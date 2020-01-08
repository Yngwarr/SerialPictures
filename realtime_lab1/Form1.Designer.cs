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
            this.label_baud = new System.Windows.Forms.Label();
            this.label_port = new System.Windows.Forms.Label();
            this.comboBox_baud = new System.Windows.Forms.ComboBox();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.groupBox_log = new System.Windows.Forms.GroupBox();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.groupBox_control = new System.Windows.Forms.GroupBox();
            this.openBtn = new System.Windows.Forms.Button();
            this.button_send = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox_settings.SuspendLayout();
            this.groupBox_log.SuspendLayout();
            this.groupBox_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_settings
            // 
            this.groupBox_settings.Controls.Add(this.label_baud);
            this.groupBox_settings.Controls.Add(this.label_port);
            this.groupBox_settings.Controls.Add(this.comboBox_baud);
            this.groupBox_settings.Controls.Add(this.comboBox_port);
            this.groupBox_settings.Location = new System.Drawing.Point(12, 12);
            this.groupBox_settings.Name = "groupBox_settings";
            this.groupBox_settings.Size = new System.Drawing.Size(160, 78);
            this.groupBox_settings.TabIndex = 0;
            this.groupBox_settings.TabStop = false;
            this.groupBox_settings.Text = "Settings";
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
            this.comboBox_baud.Size = new System.Drawing.Size(81, 21);
            this.comboBox_baud.TabIndex = 1;
            // 
            // comboBox_port
            // 
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(70, 19);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(81, 21);
            this.comboBox_port.TabIndex = 0;
            this.comboBox_port.SelectionChangeCommitted += new System.EventHandler(this.comboBox_port_SelectionChangeCommitted);
            // 
            // groupBox_log
            // 
            this.groupBox_log.Controls.Add(this.textBox_log);
            this.groupBox_log.Location = new System.Drawing.Point(12, 96);
            this.groupBox_log.Name = "groupBox_log";
            this.groupBox_log.Size = new System.Drawing.Size(291, 154);
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
            this.textBox_log.Size = new System.Drawing.Size(276, 124);
            this.textBox_log.TabIndex = 0;
            // 
            // groupBox_control
            // 
            this.groupBox_control.Controls.Add(this.openBtn);
            this.groupBox_control.Controls.Add(this.button_send);
            this.groupBox_control.Location = new System.Drawing.Point(178, 12);
            this.groupBox_control.Name = "groupBox_control";
            this.groupBox_control.Size = new System.Drawing.Size(125, 78);
            this.groupBox_control.TabIndex = 2;
            this.groupBox_control.TabStop = false;
            this.groupBox_control.Text = "Control";
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(6, 47);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(111, 21);
            this.openBtn.TabIndex = 3;
            this.openBtn.Text = "Open...";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // button_send
            // 
            this.button_send.Enabled = false;
            this.button_send.Location = new System.Drawing.Point(6, 17);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(111, 23);
            this.button_send.TabIndex = 0;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
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
            this.ClientSize = new System.Drawing.Size(312, 255);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_settings;
        private System.Windows.Forms.GroupBox groupBox_log;
        private System.Windows.Forms.GroupBox groupBox_control;
        private System.Windows.Forms.Label label_baud;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.ComboBox comboBox_baud;
        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

