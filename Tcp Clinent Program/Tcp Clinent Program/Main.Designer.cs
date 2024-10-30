namespace Tcp_Clinent_Program
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ReceiveHexSelect = new System.Windows.Forms.RadioButton();
            this.ReceiveTextSelect = new System.Windows.Forms.RadioButton();
            this.Exit = new System.Windows.Forms.Button();
            this.ReceiveTextClear = new System.Windows.Forms.Button();
            this.ReceiveText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SendHexSelect = new System.Windows.Forms.RadioButton();
            this.SendTextSelect = new System.Windows.Forms.RadioButton();
            this.SendTextClear = new System.Windows.Forms.Button();
            this.DataSend = new System.Windows.Forms.Button();
            this.SendText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Client_Port_Text = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Server_Port_Text = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Server_IP_Text = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Client_IP_Combo = new System.Windows.Forms.ComboBox();
            this.Connect_Btn = new System.Windows.Forms.Button();
            this.Connection_Status_btn = new System.Windows.Forms.Button();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(4, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(817, 56);
            this.button2.TabIndex = 7;
            this.button2.Text = "TCP Client";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ReceiveHexSelect);
            this.groupBox3.Controls.Add(this.ReceiveTextSelect);
            this.groupBox3.Controls.Add(this.Exit);
            this.groupBox3.Controls.Add(this.ReceiveTextClear);
            this.groupBox3.Controls.Add(this.ReceiveText);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(416, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 321);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receive Data";
            // 
            // ReceiveHexSelect
            // 
            this.ReceiveHexSelect.AutoSize = true;
            this.ReceiveHexSelect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiveHexSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReceiveHexSelect.Location = new System.Drawing.Point(93, 275);
            this.ReceiveHexSelect.Name = "ReceiveHexSelect";
            this.ReceiveHexSelect.Size = new System.Drawing.Size(52, 23);
            this.ReceiveHexSelect.TabIndex = 6;
            this.ReceiveHexSelect.TabStop = true;
            this.ReceiveHexSelect.Text = "Hex";
            this.ReceiveHexSelect.UseVisualStyleBackColor = true;
            // 
            // ReceiveTextSelect
            // 
            this.ReceiveTextSelect.AutoSize = true;
            this.ReceiveTextSelect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiveTextSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReceiveTextSelect.Location = new System.Drawing.Point(21, 274);
            this.ReceiveTextSelect.Name = "ReceiveTextSelect";
            this.ReceiveTextSelect.Size = new System.Drawing.Size(53, 23);
            this.ReceiveTextSelect.TabIndex = 5;
            this.ReceiveTextSelect.TabStop = true;
            this.ReceiveTextSelect.Text = "Text";
            this.ReceiveTextSelect.UseVisualStyleBackColor = true;
            this.ReceiveTextSelect.CheckedChanged += new System.EventHandler(this.ReceiveTextSelect_CheckedChanged);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exit.Location = new System.Drawing.Point(287, 266);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(99, 42);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button6_Click);
            // 
            // ReceiveTextClear
            // 
            this.ReceiveTextClear.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ReceiveTextClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiveTextClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReceiveTextClear.Location = new System.Drawing.Point(173, 266);
            this.ReceiveTextClear.Name = "ReceiveTextClear";
            this.ReceiveTextClear.Size = new System.Drawing.Size(99, 42);
            this.ReceiveTextClear.TabIndex = 3;
            this.ReceiveTextClear.Text = "Clear";
            this.ReceiveTextClear.UseVisualStyleBackColor = false;
            this.ReceiveTextClear.Click += new System.EventHandler(this.button5_Click);
            // 
            // ReceiveText
            // 
            this.ReceiveText.BackColor = System.Drawing.SystemColors.Window;
            this.ReceiveText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReceiveText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiveText.Location = new System.Drawing.Point(6, 23);
            this.ReceiveText.Multiline = true;
            this.ReceiveText.Name = "ReceiveText";
            this.ReceiveText.ReadOnly = true;
            this.ReceiveText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ReceiveText.Size = new System.Drawing.Size(392, 232);
            this.ReceiveText.TabIndex = 1;
            this.ReceiveText.WordWrap = false;
            this.ReceiveText.TextChanged += new System.EventHandler(this.ReceiveText_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SendHexSelect);
            this.groupBox2.Controls.Add(this.SendTextSelect);
            this.groupBox2.Controls.Add(this.SendTextClear);
            this.groupBox2.Controls.Add(this.DataSend);
            this.groupBox2.Controls.Add(this.SendText);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(4, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 321);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sent Data";
            // 
            // SendHexSelect
            // 
            this.SendHexSelect.AutoSize = true;
            this.SendHexSelect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendHexSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SendHexSelect.Location = new System.Drawing.Point(87, 275);
            this.SendHexSelect.Name = "SendHexSelect";
            this.SendHexSelect.Size = new System.Drawing.Size(52, 23);
            this.SendHexSelect.TabIndex = 4;
            this.SendHexSelect.TabStop = true;
            this.SendHexSelect.Text = "Hex";
            this.SendHexSelect.UseVisualStyleBackColor = true;
            // 
            // SendTextSelect
            // 
            this.SendTextSelect.AutoSize = true;
            this.SendTextSelect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendTextSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SendTextSelect.Location = new System.Drawing.Point(20, 275);
            this.SendTextSelect.Name = "SendTextSelect";
            this.SendTextSelect.Size = new System.Drawing.Size(53, 23);
            this.SendTextSelect.TabIndex = 3;
            this.SendTextSelect.TabStop = true;
            this.SendTextSelect.Text = "Text";
            this.SendTextSelect.UseVisualStyleBackColor = true;
            // 
            // SendTextClear
            // 
            this.SendTextClear.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SendTextClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendTextClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SendTextClear.Location = new System.Drawing.Point(172, 267);
            this.SendTextClear.Name = "SendTextClear";
            this.SendTextClear.Size = new System.Drawing.Size(99, 42);
            this.SendTextClear.TabIndex = 2;
            this.SendTextClear.Text = "Clear";
            this.SendTextClear.UseVisualStyleBackColor = false;
            this.SendTextClear.Click += new System.EventHandler(this.button4_Click);
            // 
            // DataSend
            // 
            this.DataSend.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DataSend.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSend.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataSend.Location = new System.Drawing.Point(287, 267);
            this.DataSend.Name = "DataSend";
            this.DataSend.Size = new System.Drawing.Size(99, 42);
            this.DataSend.TabIndex = 1;
            this.DataSend.Text = "Sent";
            this.DataSend.UseVisualStyleBackColor = false;
            this.DataSend.Click += new System.EventHandler(this.button3_Click);
            // 
            // SendText
            // 
            this.SendText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SendText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendText.Location = new System.Drawing.Point(6, 23);
            this.SendText.Multiline = true;
            this.SendText.Name = "SendText";
            this.SendText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SendText.Size = new System.Drawing.Size(398, 232);
            this.SendText.TabIndex = 0;
            this.SendText.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.Connect_Btn);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(4, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 99);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TCP Client";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Client_Port_Text);
            this.groupBox7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(177, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(151, 67);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "ClientPort";
            // 
            // Client_Port_Text
            // 
            this.Client_Port_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_Port_Text.Location = new System.Drawing.Point(11, 26);
            this.Client_Port_Text.Name = "Client_Port_Text";
            this.Client_Port_Text.Size = new System.Drawing.Size(129, 26);
            this.Client_Port_Text.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Server_Port_Text);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(508, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(151, 67);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ServerPort";
            // 
            // Server_Port_Text
            // 
            this.Server_Port_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server_Port_Text.Location = new System.Drawing.Point(9, 25);
            this.Server_Port_Text.Name = "Server_Port_Text";
            this.Server_Port_Text.Size = new System.Drawing.Size(135, 26);
            this.Server_Port_Text.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Server_IP_Text);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(342, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(151, 67);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SeverIP";
            // 
            // Server_IP_Text
            // 
            this.Server_IP_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server_IP_Text.Location = new System.Drawing.Point(12, 26);
            this.Server_IP_Text.Name = "Server_IP_Text";
            this.Server_IP_Text.Size = new System.Drawing.Size(129, 26);
            this.Server_IP_Text.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Client_IP_Combo);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(14, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(151, 67);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ClientIP";
            // 
            // Client_IP_Combo
            // 
            this.Client_IP_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Client_IP_Combo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Client_IP_Combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_IP_Combo.FormattingEnabled = true;
            this.Client_IP_Combo.Location = new System.Drawing.Point(8, 25);
            this.Client_IP_Combo.Name = "Client_IP_Combo";
            this.Client_IP_Combo.Size = new System.Drawing.Size(132, 28);
            this.Client_IP_Combo.TabIndex = 0;
            this.Client_IP_Combo.Tag = "-1";
            this.Client_IP_Combo.SelectedIndexChanged += new System.EventHandler(this.Client_IP_Combo_SelectedIndexChanged);
            // 
            // Connect_Btn
            // 
            this.Connect_Btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Connect_Btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Connect_Btn.Location = new System.Drawing.Point(666, 25);
            this.Connect_Btn.Name = "Connect_Btn";
            this.Connect_Btn.Size = new System.Drawing.Size(145, 61);
            this.Connect_Btn.TabIndex = 4;
            this.Connect_Btn.Text = "Connect";
            this.Connect_Btn.UseVisualStyleBackColor = false;
            this.Connect_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Connection_Status_btn
            // 
            this.Connection_Status_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Connection_Status_btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connection_Status_btn.ForeColor = System.Drawing.Color.OrangeRed;
            this.Connection_Status_btn.Location = new System.Drawing.Point(4, 164);
            this.Connection_Status_btn.Name = "Connection_Status_btn";
            this.Connection_Status_btn.Size = new System.Drawing.Size(817, 65);
            this.Connection_Status_btn.TabIndex = 8;
            this.Connection_Status_btn.Text = "Disconnected";
            this.Connection_Status_btn.UseVisualStyleBackColor = false;
            // 
            // StatusText
            // 
            this.StatusText.BackColor = System.Drawing.SystemColors.Window;
            this.StatusText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusText.Location = new System.Drawing.Point(5, 20);
            this.StatusText.Multiline = true;
            this.StatusText.Name = "StatusText";
            this.StatusText.ReadOnly = true;
            this.StatusText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.StatusText.Size = new System.Drawing.Size(805, 131);
            this.StatusText.TabIndex = 5;
            this.StatusText.WordWrap = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.StatusText);
            this.groupBox8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Location = new System.Drawing.Point(4, 549);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(816, 157);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Log Message";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(823, 711);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.Connection_Status_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "<TCP Client Tool>  Developed by Twinsteps Solutions >>";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button ReceiveTextClear;
        private System.Windows.Forms.TextBox ReceiveText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SendTextClear;
        private System.Windows.Forms.Button DataSend;
        private System.Windows.Forms.TextBox SendText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Connect_Btn;
        private System.Windows.Forms.TextBox Server_Port_Text;
        private System.Windows.Forms.TextBox Server_IP_Text;
        private System.Windows.Forms.ComboBox Client_IP_Combo;
        private System.Windows.Forms.RadioButton ReceiveHexSelect;
        private System.Windows.Forms.RadioButton ReceiveTextSelect;
        private System.Windows.Forms.RadioButton SendHexSelect;
        private System.Windows.Forms.RadioButton SendTextSelect;
        private System.Windows.Forms.Button Connection_Status_btn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox Client_Port_Text;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox StatusText;
        private System.Windows.Forms.GroupBox groupBox8;
    }
}

