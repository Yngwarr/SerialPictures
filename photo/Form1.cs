using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace photo
{
    enum State {
        Idle,
        Incoming,
        RecvData
    };
    public partial class Form1 : Form
    {
        const int INBUF_SIZE = 24;

        State state = State.Idle;
        int bytesToRead = 0;
        int imgSize = 0;
        byte[] imgBuffer = new byte[16 * 1024 * 1024];

        public Form1()
        {
            InitializeComponent();
        }
        
        public Image bytesToImg(byte[] byteArrayIn, int count)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn, 0, count))
            {
                return Image.FromStream(ms);
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog.ShowDialog();
            if (res != DialogResult.OK) return;
            string fname = openFileDialog.FileName;
            try {
                //Image img = Image.FromFile(fname);
                //pictureBox.Image = img;
                pictureBox.ImageLocation = fname;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            } catch (Exception) {
                Console.WriteLine("Aww, shit!");
            }
        }

        private void recvBtn_Click(object sender, EventArgs e)
        {
            // TODO read name and baudrate from the form
            using (SerialPort COMport = new SerialPort("COM6", 38400))
            {
                COMport.ReadTimeout = 3500;

                try
                {
                    //COMport.Parity = checkBox_parity.Checked ? Parity.Even : Parity.None;
                    COMport.Open();
                }
                catch (Exception SerialException)
                {
                    Console.WriteLine($"{SerialException.ToString()}");
                    Console.WriteLine("Error openning serial port.");
                }

                try
                {
                    if (COMport.IsOpen)
                    {
                        string l = COMport.ReadLine();
                        int len = Convert.ToInt32(l);
                        Console.WriteLine("Waiting...");
                        byte[] data = new byte[len];
                        int read = 0;
                        while (read < len)
                        {
                            read += COMport.Read(data, read, len-read);
                        }
                        pictureBox.Image = bytesToImg(data, len);
                    }
                    else
                    {
                        Console.WriteLine("Can't recv. :(");
                    }
                    COMport.Close();
                }
                catch (TimeoutException)
                {
                    Console.WriteLine($"{COMport.ReadTimeout.ToString()}ms passed{Environment.NewLine}operation timed out");
                    COMport.Close();
                }
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort) sender;
            //string indata = sp.ReadExisting();
            //Console.WriteLine("Data Received:");
            //Console.Write(indata);
            char[] inBuf = new char[INBUF_SIZE];
            int bytesRead = 0;
            int i;
            switch (state) {
                case State.Idle:
                    sp.Read(inBuf, 0, 9);
                    string inb = new string(inBuf, 0, 9);
                    if (inb != "INCOMING\n") {
                        sp.ReadExisting();
                        break;
                    }
                    state = State.Incoming;
                break;
                case State.Incoming:
                    for (i = 0; i < INBUF_SIZE; ++i) {
                        inBuf[i] = (char) sp.ReadChar();
                        if (inBuf[i] == '\n') {
                            inBuf[i] = '\0';
                            break;
                        }
                    }
                    bytesToRead = Convert.ToInt32(new string(inBuf, 0, i));
                    imgSize = bytesToRead;
                    state = State.RecvData;
                break;
                case State.RecvData:
                    bytesRead = sp.Read(imgBuffer, imgSize - bytesToRead, bytesToRead);
                    bytesToRead -= bytesRead;
                    if (bytesToRead <= 0) {
                        pictureBox.Image = bytesToImg(imgBuffer, imgSize);
                        bytesToRead = 0;
                        imgSize = 0;
                        state = State.Idle;
                    }
                break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort.Open();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort.Close();
        }
    }
}
