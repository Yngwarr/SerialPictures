using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;

namespace realtime_lab1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        Image theImage;

        private void log(string msg) {
            textBox_log.Text = $"{msg}{Environment.NewLine}{textBox_log.Text}";
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
        }

        private void comboBox_port_SelectionChangeCommitted(object sender, EventArgs e)
        {
            button_send.Enabled = true;
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            button_send.Enabled = false;

            string portname = comboBox_port.SelectedItem.ToString();
            int baudrate = Convert.ToInt32(comboBox_baud.SelectedItem);
            byte[] data = imgToBytes(theImage);

            // MessageBox.Show(portname);
            // MessageBox.Show(baudrate.ToString());

            using (SerialPort COMport = new SerialPort(portname, baudrate))
            {
                try {
                    COMport.Open();
                } catch (Exception SerialException) {
                    log($"{textBox_log.Text}{Environment.NewLine}{SerialException.ToString()}");
                    log("Error openning serial port.");
                }

                if (COMport.IsOpen) {
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    COMport.WriteLine("INCOMING");
                    COMport.WriteLine($"{data.Length}");
                    COMport.Write(data, 0, data.Length);
                    sw.Stop();
                    log($"{data.Length} bytes sent in {sw.ElapsedMilliseconds} ms");
                } else {
                    button_send.Enabled = true;
                    log("Can't send. :(");
                }
                COMport.Close();
                button_send.Enabled = true;
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog.ShowDialog();
            if (res != DialogResult.OK) {
                log("Nothing selected.");
                return;
            }
            string fname = openFileDialog.FileName;
            try
            {
                theImage = Image.FromFile(fname);
                log($"{fname} is ready to be sent.");
            }
            catch (Exception Ex)
            {
                log($"{textBox_log.Text}{Environment.NewLine}{Ex.ToString()}");
                Console.WriteLine("Aww!");
            }
        }
    }
}
