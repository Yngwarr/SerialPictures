namespace photo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openBtn = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.comboBox_baud = new System.Windows.Forms.ComboBox();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(228, 177);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.gif;*.png|All files|*.*";
            // 
            // openBtn
            // 
            this.openBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.openBtn.Location = new System.Drawing.Point(0, 223);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(227, 23);
            this.openBtn.TabIndex = 1;
            this.openBtn.Text = "Open...";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 38400;
            this.serialPort.PortName = "COM6";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBox_baud
            // 
            this.comboBox_baud.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comboBox_baud.FormattingEnabled = true;
            this.comboBox_baud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.comboBox_baud.Location = new System.Drawing.Point(0, 202);
            this.comboBox_baud.Name = "comboBox_baud";
            this.comboBox_baud.Size = new System.Drawing.Size(227, 21);
            this.comboBox_baud.TabIndex = 2;
            // 
            // comboBox_port
            // 
            this.comboBox_port.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(0, 181);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(227, 21);
            this.comboBox_port.TabIndex = 3;
            this.comboBox_port.SelectedIndexChanged += new System.EventHandler(this.comboBox_port_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 246);
            this.Controls.Add(this.comboBox_port);
            this.Controls.Add(this.comboBox_baud);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openBtn;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox comboBox_baud;
        private System.Windows.Forms.ComboBox comboBox_port;
    }
}

