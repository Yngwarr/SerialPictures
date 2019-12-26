namespace realtime_lab1
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
            this.groupBox_settings = new System.Windows.Forms.GroupBox();
            this.checkBox_parity = new System.Windows.Forms.CheckBox();
            this.label_hashsum = new System.Windows.Forms.Label();
            this.label_baud = new System.Windows.Forms.Label();
            this.label_port = new System.Windows.Forms.Label();
            this.comboBox_hashsum = new System.Windows.Forms.ComboBox();
            this.comboBox_baud = new System.Windows.Forms.ComboBox();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.groupBox_log = new System.Windows.Forms.GroupBox();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.groupBox_control = new System.Windows.Forms.GroupBox();
            this.textBox_data = new System.Windows.Forms.TextBox();
            this.button_recv = new System.Windows.Forms.Button();
            this.button_send = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox_settings.SuspendLayout();
            this.groupBox_log.SuspendLayout();
            this.groupBox_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_settings
            // 
            this.groupBox_settings.Controls.Add(this.checkBox_parity);
            this.groupBox_settings.Controls.Add(this.label_hashsum);
            this.groupBox_settings.Controls.Add(this.label_baud);
            this.groupBox_settings.Controls.Add(this.label_port);
            this.groupBox_settings.Controls.Add(this.comboBox_hashsum);
            this.groupBox_settings.Controls.Add(this.comboBox_baud);
            this.groupBox_settings.Controls.Add(this.comboBox_port);
            this.groupBox_settings.Location = new System.Drawing.Point(12, 12);
            this.groupBox_settings.Name = "groupBox_settings";
            this.groupBox_settings.Size = new System.Drawing.Size(243, 125);
            this.groupBox_settings.TabIndex = 0;
            this.groupBox_settings.TabStop = false;
            this.groupBox_settings.Text = "Settings";
            // 
            // checkBox_parity
            // 
            this.checkBox_parity.AutoSize = true;
            this.checkBox_parity.Location = new System.Drawing.Point(70, 103);
            this.checkBox_parity.Name = "checkBox_parity";
            this.checkBox_parity.Size = new System.Drawing.Size(85, 17);
            this.checkBox_parity.TabIndex = 6;
            this.checkBox_parity.Text = "Parity check";
            this.checkBox_parity.UseVisualStyleBackColor = true;
            // 
            // label_hashsum
            // 
            this.label_hashsum.AutoSize = true;
            this.label_hashsum.Location = new System.Drawing.Point(7, 82);
            this.label_hashsum.Name = "label_hashsum";
            this.label_hashsum.Size = new System.Drawing.Size(51, 13);
            this.label_hashsum.TabIndex = 5;
            this.label_hashsum.Text = "Hashsum";
            // 
            // label_baud
            // 
            this.label_baud.AutoSize = true;
            this.label_baud.Location = new System.Drawing.Point(7, 54);
            this.label_baud.Name = "label_baud";
            this.label_baud.Size = new System.Drawing.Size(50, 13);
            this.label_baud.TabIndex = 4;
            this.label_baud.Text = "Baudrate";
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(6, 27);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(26, 13);
            this.label_port.TabIndex = 3;
            this.label_port.Text = "Port";
            // 
            // comboBox_hashsum
            // 
            this.comboBox_hashsum.FormattingEnabled = true;
            this.comboBox_hashsum.Items.AddRange(new object[] {
            "None",
            "XOR",
            "LRC",
            "CRC16",
            "CRC32"});
            this.comboBox_hashsum.Location = new System.Drawing.Point(70, 75);
            this.comboBox_hashsum.Name = "comboBox_hashsum";
            this.comboBox_hashsum.Size = new System.Drawing.Size(167, 21);
            this.comboBox_hashsum.TabIndex = 2;
            // 
            // comboBox_baud
            // 
            this.comboBox_baud.FormattingEnabled = true;
            this.comboBox_baud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.comboBox_baud.Location = new System.Drawing.Point(70, 47);
            this.comboBox_baud.Name = "comboBox_baud";
            this.comboBox_baud.Size = new System.Drawing.Size(167, 21);
            this.comboBox_baud.TabIndex = 1;
            // 
            // comboBox_port
            // 
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(70, 19);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(167, 21);
            this.comboBox_port.TabIndex = 0;
            this.comboBox_port.SelectionChangeCommitted += new System.EventHandler(this.comboBox_port_SelectionChangeCommitted);
            // 
            // groupBox_log
            // 
            this.groupBox_log.Controls.Add(this.textBox_log);
            this.groupBox_log.Location = new System.Drawing.Point(12, 143);
            this.groupBox_log.Name = "groupBox_log";
            this.groupBox_log.Size = new System.Drawing.Size(481, 176);
            this.groupBox_log.TabIndex = 1;
            this.groupBox_log.TabStop = false;
            this.groupBox_log.Text = "Log";
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(7, 20);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_log.Size = new System.Drawing.Size(468, 150);
            this.textBox_log.TabIndex = 0;
            // 
            // groupBox_control
            // 
            this.groupBox_control.Controls.Add(this.openBtn);
            this.groupBox_control.Controls.Add(this.textBox_data);
            this.groupBox_control.Controls.Add(this.button_recv);
            this.groupBox_control.Controls.Add(this.button_send);
            this.groupBox_control.Location = new System.Drawing.Point(261, 12);
            this.groupBox_control.Name = "groupBox_control";
            this.groupBox_control.Size = new System.Drawing.Size(232, 125);
            this.groupBox_control.TabIndex = 2;
            this.groupBox_control.TabStop = false;
            this.groupBox_control.Text = "Control";
            // 
            // textBox_data
            // 
            this.textBox_data.Location = new System.Drawing.Point(6, 99);
            this.textBox_data.Name = "textBox_data";
            this.textBox_data.Size = new System.Drawing.Size(211, 20);
            this.textBox_data.TabIndex = 2;
            // 
            // button_recv
            // 
            this.button_recv.Enabled = false;
            this.button_recv.Location = new System.Drawing.Point(109, 17);
            this.button_recv.Name = "button_recv";
            this.button_recv.Size = new System.Drawing.Size(108, 50);
            this.button_recv.TabIndex = 1;
            this.button_recv.Text = "Recv";
            this.button_recv.UseVisualStyleBackColor = true;
            this.button_recv.Click += new System.EventHandler(this.button_recv_Click);
            // 
            // button_send
            // 
            this.button_send.Enabled = false;
            this.button_send.Location = new System.Drawing.Point(6, 17);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(97, 50);
            this.button_send.TabIndex = 0;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(6, 70);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(211, 23);
            this.openBtn.TabIndex = 3;
            this.openBtn.Text = "Open...";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.gif;*.png|All files|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 331);
            this.Controls.Add(this.groupBox_control);
            this.Controls.Add(this.groupBox_log);
            this.Controls.Add(this.groupBox_settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Serial Port";
            this.groupBox_settings.ResumeLayout(false);
            this.groupBox_settings.PerformLayout();
            this.groupBox_log.ResumeLayout(false);
            this.groupBox_log.PerformLayout();
            this.groupBox_control.ResumeLayout(false);
            this.groupBox_control.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_settings;
        private System.Windows.Forms.GroupBox groupBox_log;
        private System.Windows.Forms.GroupBox groupBox_control;
        private System.Windows.Forms.Label label_hashsum;
        private System.Windows.Forms.Label label_baud;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.ComboBox comboBox_hashsum;
        private System.Windows.Forms.ComboBox comboBox_baud;
        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.TextBox textBox_data;
        private System.Windows.Forms.Button button_recv;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.CheckBox checkBox_parity;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

