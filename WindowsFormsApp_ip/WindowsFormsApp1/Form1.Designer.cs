namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_clean = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox_status = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_browse_close = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_network_connection_toggle_interval = new System.Windows.Forms.TextBox();
            this.textBox_network_connection_toggle_name = new System.Windows.Forms.TextBox();
            this.checkBox_network_connection_toggle = new System.Windows.Forms.CheckBox();
            this.checkBox_proxy = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_interval = new System.Windows.Forms.TextBox();
            this.textBox_argument = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.label_selectedFile = new System.Windows.Forms.Label();
            this.textBox_proxy = new System.Windows.Forms.TextBox();
            this.button_browse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_closeFile = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 364);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 364);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(631, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "status";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button_clean);
            this.panel3.Controls.Add(this.label_status);
            this.panel3.Controls.Add(this.button_start);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 34);
            this.panel3.TabIndex = 1;
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(492, 4);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(119, 23);
            this.button_clean.TabIndex = 2;
            this.button_clean.Text = "clean status";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(99, 9);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 13);
            this.label_status.TabIndex = 1;
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Lime;
            this.button_start.Location = new System.Drawing.Point(18, 4);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "toggle";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.richTextBox_status);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 296);
            this.panel2.TabIndex = 0;
            // 
            // richTextBox_status
            // 
            this.richTextBox_status.BackColor = System.Drawing.Color.White;
            this.richTextBox_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_status.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_status.Name = "richTextBox_status";
            this.richTextBox_status.Size = new System.Drawing.Size(625, 296);
            this.richTextBox_status.TabIndex = 0;
            this.richTextBox_status.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(631, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "setting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txt_closeFile);
            this.groupBox1.Controls.Add(this.button_browse_close);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_network_connection_toggle_interval);
            this.groupBox1.Controls.Add(this.textBox_network_connection_toggle_name);
            this.groupBox1.Controls.Add(this.checkBox_network_connection_toggle);
            this.groupBox1.Controls.Add(this.checkBox_proxy);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_interval);
            this.groupBox1.Controls.Add(this.textBox_argument);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button_save);
            this.groupBox1.Controls.Add(this.label_selectedFile);
            this.groupBox1.Controls.Add(this.textBox_proxy);
            this.groupBox1.Controls.Add(this.button_browse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_IP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 332);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "setting";
            // 
            // button_browse_close
            // 
            this.button_browse_close.BackColor = System.Drawing.Color.Red;
            this.button_browse_close.Location = new System.Drawing.Point(67, 136);
            this.button_browse_close.Name = "button_browse_close";
            this.button_browse_close.Size = new System.Drawing.Size(60, 23);
            this.button_browse_close.TabIndex = 19;
            this.button_browse_close.Text = "browse";
            this.button_browse_close.UseVisualStyleBackColor = false;
            this.button_browse_close.Click += new System.EventHandler(this.button_browse_close_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "close file";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "network interval";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "network connection name";
            // 
            // textBox_network_connection_toggle_interval
            // 
            this.textBox_network_connection_toggle_interval.Location = new System.Drawing.Point(346, 218);
            this.textBox_network_connection_toggle_interval.Name = "textBox_network_connection_toggle_interval";
            this.textBox_network_connection_toggle_interval.Size = new System.Drawing.Size(100, 20);
            this.textBox_network_connection_toggle_interval.TabIndex = 15;
            // 
            // textBox_network_connection_toggle_name
            // 
            this.textBox_network_connection_toggle_name.Location = new System.Drawing.Point(142, 218);
            this.textBox_network_connection_toggle_name.Name = "textBox_network_connection_toggle_name";
            this.textBox_network_connection_toggle_name.Size = new System.Drawing.Size(110, 20);
            this.textBox_network_connection_toggle_name.TabIndex = 14;
            // 
            // checkBox_network_connection_toggle
            // 
            this.checkBox_network_connection_toggle.AutoSize = true;
            this.checkBox_network_connection_toggle.Location = new System.Drawing.Point(452, 221);
            this.checkBox_network_connection_toggle.Name = "checkBox_network_connection_toggle";
            this.checkBox_network_connection_toggle.Size = new System.Drawing.Size(152, 17);
            this.checkBox_network_connection_toggle.TabIndex = 13;
            this.checkBox_network_connection_toggle.Text = "network connection toggle";
            this.checkBox_network_connection_toggle.UseVisualStyleBackColor = true;
            // 
            // checkBox_proxy
            // 
            this.checkBox_proxy.AutoSize = true;
            this.checkBox_proxy.Location = new System.Drawing.Point(346, 61);
            this.checkBox_proxy.Name = "checkBox_proxy";
            this.checkBox_proxy.Size = new System.Drawing.Size(86, 17);
            this.checkBox_proxy.TabIndex = 12;
            this.checkBox_proxy.Text = "proxy enable";
            this.checkBox_proxy.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "interval";
            // 
            // textBox_interval
            // 
            this.textBox_interval.Location = new System.Drawing.Point(365, 168);
            this.textBox_interval.Name = "textBox_interval";
            this.textBox_interval.Size = new System.Drawing.Size(187, 20);
            this.textBox_interval.TabIndex = 10;
            // 
            // textBox_argument
            // 
            this.textBox_argument.Location = new System.Drawing.Point(88, 168);
            this.textBox_argument.Name = "textBox_argument";
            this.textBox_argument.Size = new System.Drawing.Size(187, 20);
            this.textBox_argument.TabIndex = 9;
            this.textBox_argument.Text = "--connect client.ovpn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "start argument";
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.BackColor = System.Drawing.Color.LimeGreen;
            this.button_save.Location = new System.Drawing.Point(289, 303);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(70, 23);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_selectedFile
            // 
            this.label_selectedFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_selectedFile.AutoSize = true;
            this.label_selectedFile.Location = new System.Drawing.Point(147, 99);
            this.label_selectedFile.Name = "label_selectedFile";
            this.label_selectedFile.Size = new System.Drawing.Size(0, 13);
            this.label_selectedFile.TabIndex = 5;
            // 
            // textBox_proxy
            // 
            this.textBox_proxy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_proxy.Location = new System.Drawing.Point(67, 59);
            this.textBox_proxy.Name = "textBox_proxy";
            this.textBox_proxy.Size = new System.Drawing.Size(263, 20);
            this.textBox_proxy.TabIndex = 7;
            // 
            // button_browse
            // 
            this.button_browse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_browse.BackColor = System.Drawing.Color.Red;
            this.button_browse.Location = new System.Drawing.Point(67, 94);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(60, 23);
            this.button_browse.TabIndex = 4;
            this.button_browse.Text = "browse";
            this.button_browse.UseVisualStyleBackColor = false;
            this.button_browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "proxy";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "exe file";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_IP
            // 
            this.textBox_IP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_IP.Location = new System.Drawing.Point(67, 19);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(552, 20);
            this.textBox_IP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ip address";
            // 
            // txt_closeFile
            // 
            this.txt_closeFile.Location = new System.Drawing.Point(133, 136);
            this.txt_closeFile.Name = "txt_closeFile";
            this.txt_closeFile.Size = new System.Drawing.Size(486, 20);
            this.txt_closeFile.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 364);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Label label_selectedFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_proxy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.RichTextBox richTextBox_status;
        private System.Windows.Forms.TextBox textBox_argument;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_interval;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.CheckBox checkBox_proxy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_network_connection_toggle_interval;
        private System.Windows.Forms.TextBox textBox_network_connection_toggle_name;
        private System.Windows.Forms.CheckBox checkBox_network_connection_toggle;
        private System.Windows.Forms.Button button_browse_close;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_closeFile;
    }
}

