using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace realtime_lab1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        Dictionary<string, Func<string, string>> hashes;
        Image theImage;

        private void log(string msg) {
            textBox_log.Text = $"{msg}{Environment.NewLine}{textBox_log.Text}";
        }

        private string xorSum(string msg) {
            byte hashsum = 0;
            byte[] bytes = Encoding.Unicode.GetBytes(msg);
            for (int i = 0; i < bytes.Length; i++)
            {
                hashsum ^= bytes[i];
            }
            return hashsum.ToString("X4");
        }

        private string lrcSum(string msg)
        {
            byte hashsum = 0;
            byte[] bytes = Encoding.Unicode.GetBytes(msg);
            for (int i = 0; i < bytes.Length; i++)
            {
                hashsum -= bytes[i];
            }
            return hashsum.ToString("X4");
        }

        private string crc16(string msg) {
            ushort polynomial = 0xA001;
            ushort[] table = new ushort[256];
            ushort value;
            ushort temp;
            for (ushort i = 0; i<table.Length; ++i)
            {
                value = 0;
                temp = i;
                for (byte j = 0; j< 8; ++j)
                {
                    if (((value ^ temp) & 0x0001) != 0)
                    {
                        value = (ushort) ((value >> 1) ^ polynomial);
                    }
                    else
                    {
                        value >>= 1;
                    }
                    temp >>= 1;
                }
                table[i] = value;
            }
            byte[] bytes = Encoding.Unicode.GetBytes(msg);
            ushort crc = 0;
            for (int i = 0; i < bytes.Length; ++i)
            {
                byte index = (byte)(crc ^ bytes[i]);
                crc = (ushort)((crc >> 8) ^ table[index]);
            }
            return crc.ToString("X4");
        }

        private string crc32(string msg) {
            uint poly = 0xedb88320;
            uint[] table = new uint[256];
            uint temp = 0;
            for (uint i = 0; i < table.Length; ++i)
            {
                temp = i;
                for (int j = 8; j > 0; --j)
                {
                    if ((temp & 1) == 1)
                    {
                        temp = (uint)((temp >> 1) ^ poly);
                    }
                    else
                    {
                        temp >>= 1;
                    }
                }
                table[i] = temp;
            }
            uint crc = 0xffffffff;
            byte[] bytes = Encoding.Unicode.GetBytes(msg);
            for (int i = 0; i < bytes.Length; ++i)
            {
                byte index = (byte)(((crc) & 0xff) ^ bytes[i]);
                crc = (uint)((crc >> 8) ^ table[index]);
            }
            return (~crc).ToString("X8");
        }

        public static byte[] imgToBytes(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        public Form1()
        {
            InitializeComponent();
            comboBox_port.Items.AddRange(SerialPort.GetPortNames());
            comboBox_baud.SelectedIndex = 3;
            comboBox_hashsum.SelectedIndex = 0;

            hashes = new Dictionary<string, Func<string, string>>();
            hashes["XOR"] = xorSum;
            hashes["LRC"] = lrcSum;
            hashes["CRC16"] = crc16;
            hashes["CRC32"] = crc32;
        }

        private void comboBox_port_SelectionChangeCommitted(object sender, EventArgs e)
        {
            button_recv.Enabled = true;
            button_send.Enabled = true;
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            button_recv.Enabled = false;

            string portname = comboBox_port.SelectedItem.ToString();
            int baudrate = Convert.ToInt32(comboBox_baud.SelectedItem);
            byte[] data = imgToBytes(theImage);

            // MessageBox.Show(portname);
            // MessageBox.Show(baudrate.ToString());

            using (SerialPort COMport = new SerialPort(portname, baudrate))
            {
                try {
                    COMport.Parity = checkBox_parity.Checked ? Parity.Even : Parity.None;
                    COMport.Open();
                } catch (Exception SerialException) {
                    log($"{textBox_log.Text}{Environment.NewLine}{SerialException.ToString()}");
                    log("Error openning serial port.");
                }

                if (COMport.IsOpen) {                    

                    string sumname = (string) comboBox_hashsum.SelectedItem;
                    //string hashed = sumname == "None" ? data : $"{hashes[sumname](data)}:{data}";

                    //COMport.WriteLine($"{(COMport.Parity == Parity.None ? 0 : 1)}:{hashed}");
                    COMport.WriteLine("INCOMING");
                    COMport.WriteLine($"{data.Length}");
                    COMport.Write(data, 0, data.Length);
                    log($"{data} sent");
                } else {
                    button_recv.Enabled = true;
                    log("Can't send. :(");
                }
                COMport.Close();
                button_recv.Enabled = true;
            }
        }

        private void button_recv_Click(object sender, EventArgs e)
        {
            button_send.Enabled = false;
            string portname = comboBox_port.SelectedItem.ToString();
            int baudrate = Convert.ToInt32(comboBox_baud.SelectedItem);
            string msg = "";

            using (SerialPort COMport = new SerialPort(portname, baudrate))
            {
                COMport.ReadTimeout = 3500;

                try {
                    COMport.Parity = checkBox_parity.Checked ? Parity.Even : Parity.None;
                    COMport.Open();
                } catch (Exception SerialException) {
                    log($"{textBox_log.Text}{Environment.NewLine}{SerialException.ToString()}");
                    log("Error openning serial port.");
                }

                try {
                    if (COMport.IsOpen) {
                        msg = COMport.ReadLine();
                        log("Waiting...");

                        string sumname = (string) comboBox_hashsum.SelectedItem;
                        if (sumname == "None") {
                            string[] data = msg.Split(":".ToCharArray(), 2);
                            if (data[0] == (COMport.Parity == Parity.None ? "0" : "1")) {
                                textBox_data.Text = data[1];
                                log($"{data[1]} recieved.");
                            } else {
                                log("Eh?");
                            }
                        } else {
                            string[] data = msg.Split(":".ToCharArray(), 3);
                            string hash = "";
                            if (data.Length < 2 || data[0] != (hash = hashes[sumname](data[1]))) {
                                log($"Checksums don't match: '{data[0]}' != '{hash}'");
                                log("Aborting.");
                            } else {
                                log("Checksums match.");
                                textBox_data.Text = data[1];
                                log($"{data[1]} recieved.");
                            }
                        }
                    } else {
                        log("Can't recv. :(");
                    }
                    button_send.Enabled = true;
                    COMport.Close();
                } catch (TimeoutException) {
                    log($"{COMport.ReadTimeout.ToString()}ms passed{Environment.NewLine}operation timed out");
                    COMport.Close();
                    button_send.Enabled = true;
                }
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog.ShowDialog();
            if (res != DialogResult.OK) return;
            string fname = openFileDialog.FileName;
            try
            {
                theImage = Image.FromFile(fname);
            }
            catch (Exception Ex)
            {
                log($"{textBox_log.Text}{Environment.NewLine}{Ex.ToString()}");
                Console.WriteLine("Aww, shit!");
            }
        }
    }
}
