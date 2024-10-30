namespace Tcp_sever_program
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ServerPortText = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ServerIPCombo = new System.Windows.Forms.ComboBox();
            this.Listern_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SentHex = new System.Windows.Forms.RadioButton();
            this.SentText = new System.Windows.Forms.RadioButton();
            this.SentClear_btn = new System.Windows.Forms.Button();
            this.Sent_btn = new System.Windows.Forms.Button();
            this.SentTexBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ReceiveHex = new System.Windows.Forms.RadioButton();
            this.ReceiveText = new System.Windows.Forms.RadioButton();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.ReceiveClear_btn = new System.Windows.Forms.Button();
            this.ReceiveTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.Listern_btn);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TCP Server";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ServerPortText);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(339, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(160, 67);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ServerPort";
            // 
            // ServerPortText
            // 
            this.ServerPortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerPortText.Location = new System.Drawing.Point(18, 25);
            this.ServerPortText.Name = "ServerPortText";
            this.ServerPortText.Size = new System.Drawing.Size(126, 26);
            this.ServerPortText.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ServerIPCombo);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(78, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 67);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ServerIP";
            // 
            // ServerIPCombo
            // 
            this.ServerIPCombo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerIPCombo.FormattingEnabled = true;
            this.ServerIPCombo.Location = new System.Drawing.Point(15, 23);
            this.ServerIPCombo.Name = "ServerIPCombo";
            this.ServerIPCombo.Size = new System.Drawing.Size(128, 27);
            this.ServerIPCombo.TabIndex = 0;
            // 
            // Listern_btn
            // 
            this.Listern_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Listern_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listern_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Listern_btn.Location = new System.Drawing.Point(636, 32);
            this.Listern_btn.Name = "Listern_btn";
            this.Listern_btn.Size = new System.Drawing.Size(126, 53);
            this.Listern_btn.TabIndex = 4;
            this.Listern_btn.Text = "Listern";
            this.Listern_btn.UseVisualStyleBackColor = false;
            this.Listern_btn.Click += new System.EventHandler(this.Listern_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SentHex);
            this.groupBox2.Controls.Add(this.SentText);
            this.groupBox2.Controls.Add(this.SentClear_btn);
            this.groupBox2.Controls.Add(this.Sent_btn);
            this.groupBox2.Controls.Add(this.SentTexBox);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 328);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sent Data";
            // 
            // SentHex
            // 
            this.SentHex.AutoSize = true;
            this.SentHex.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentHex.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SentHex.Location = new System.Drawing.Point(85, 278);
            this.SentHex.Name = "SentHex";
            this.SentHex.Size = new System.Drawing.Size(51, 21);
            this.SentHex.TabIndex = 5;
            this.SentHex.TabStop = true;
            this.SentHex.Text = "Hex";
            this.SentHex.UseVisualStyleBackColor = true;
            // 
            // SentText
            // 
            this.SentText.AutoSize = true;
            this.SentText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SentText.Location = new System.Drawing.Point(12, 278);
            this.SentText.Name = "SentText";
            this.SentText.Size = new System.Drawing.Size(52, 21);
            this.SentText.TabIndex = 4;
            this.SentText.TabStop = true;
            this.SentText.Text = "Text";
            this.SentText.UseVisualStyleBackColor = true;
            // 
            // SentClear_btn
            // 
            this.SentClear_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SentClear_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentClear_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SentClear_btn.Location = new System.Drawing.Point(154, 270);
            this.SentClear_btn.Name = "SentClear_btn";
            this.SentClear_btn.Size = new System.Drawing.Size(110, 39);
            this.SentClear_btn.TabIndex = 2;
            this.SentClear_btn.Text = "Clear";
            this.SentClear_btn.UseVisualStyleBackColor = false;
            this.SentClear_btn.Click += new System.EventHandler(this.SentClear_btn_Click);
            // 
            // Sent_btn
            // 
            this.Sent_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Sent_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sent_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Sent_btn.Location = new System.Drawing.Point(283, 270);
            this.Sent_btn.Name = "Sent_btn";
            this.Sent_btn.Size = new System.Drawing.Size(110, 39);
            this.Sent_btn.TabIndex = 1;
            this.Sent_btn.Text = "Sent";
            this.Sent_btn.UseVisualStyleBackColor = false;
            this.Sent_btn.Click += new System.EventHandler(this.Sent_btn_Click);
            // 
            // SentTexBox
            // 
            this.SentTexBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SentTexBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentTexBox.Location = new System.Drawing.Point(8, 20);
            this.SentTexBox.Multiline = true;
            this.SentTexBox.Name = "SentTexBox";
            this.SentTexBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SentTexBox.Size = new System.Drawing.Size(393, 234);
            this.SentTexBox.TabIndex = 0;
            this.SentTexBox.WordWrap = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ReceiveHex);
            this.groupBox3.Controls.Add(this.ReceiveText);
            this.groupBox3.Controls.Add(this.Exit_btn);
            this.groupBox3.Controls.Add(this.ReceiveClear_btn);
            this.groupBox3.Controls.Add(this.ReceiveTextBox);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(427, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 328);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receive Data";
            // 
            // ReceiveHex
            // 
            this.ReceiveHex.AutoSize = true;
            this.ReceiveHex.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiveHex.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReceiveHex.Location = new System.Drawing.Point(100, 278);
            this.ReceiveHex.Name = "ReceiveHex";
            this.ReceiveHex.Size = new System.Drawing.Size(51, 21);
            this.ReceiveHex.TabIndex = 7;
            this.ReceiveHex.TabStop = true;
            this.ReceiveHex.Text = "Hex";
            this.ReceiveHex.UseVisualStyleBackColor = true;
            // 
            // ReceiveText
            // 
            this.ReceiveText.AutoSize = true;
            this.ReceiveText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiveText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReceiveText.Location = new System.Drawing.Point(31, 278);
            this.ReceiveText.Name = "ReceiveText";
            this.ReceiveText.Size = new System.Drawing.Size(52, 21);
            this.ReceiveText.TabIndex = 6;
            this.ReceiveText.TabStop = true;
            this.ReceiveText.Text = "Text";
            this.ReceiveText.UseVisualStyleBackColor = true;
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Exit_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exit_btn.Location = new System.Drawing.Point(290, 269);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(110, 39);
            this.Exit_btn.TabIndex = 4;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // ReceiveClear_btn
            // 
            this.ReceiveClear_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ReceiveClear_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiveClear_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReceiveClear_btn.Location = new System.Drawing.Point(163, 269);
            this.ReceiveClear_btn.Name = "ReceiveClear_btn";
            this.ReceiveClear_btn.Size = new System.Drawing.Size(110, 39);
            this.ReceiveClear_btn.TabIndex = 3;
            this.ReceiveClear_btn.Text = "Clear";
            this.ReceiveClear_btn.UseVisualStyleBackColor = false;
            this.ReceiveClear_btn.Click += new System.EventHandler(this.ReceiveClear_btn_Click);
            // 
            // ReceiveTextBox
            // 
            this.ReceiveTextBox.BackColor = System.Drawing.Color.White;
            this.ReceiveTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReceiveTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiveTextBox.Location = new System.Drawing.Point(8, 20);
            this.ReceiveTextBox.Multiline = true;
            this.ReceiveTextBox.Name = "ReceiveTextBox";
            this.ReceiveTextBox.ReadOnly = true;
            this.ReceiveTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ReceiveTextBox.Size = new System.Drawing.Size(393, 234);
            this.ReceiveTextBox.TabIndex = 1;
            this.ReceiveTextBox.Text = "`";
            this.ReceiveTextBox.WordWrap = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(12, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(826, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "TCP SERVER TOOL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StatusText
            // 
            this.StatusText.BackColor = System.Drawing.Color.White;
            this.StatusText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusText.Location = new System.Drawing.Point(8, 23);
            this.StatusText.Multiline = true;
            this.StatusText.Name = "StatusText";
            this.StatusText.ReadOnly = true;
            this.StatusText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.StatusText.Size = new System.Drawing.Size(807, 135);
            this.StatusText.TabIndex = 8;
            this.StatusText.WordWrap = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.StatusText);
            this.groupBox8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Location = new System.Drawing.Point(12, 505);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(824, 166);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "LogStatus";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(845, 676);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "<TCP Server Tool> Developed by Twinsteps Solutions >>";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ServerPortText;
        private System.Windows.Forms.ComboBox ServerIPCombo;
        private System.Windows.Forms.Button Listern_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SentTexBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ReceiveTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SentClear_btn;
        private System.Windows.Forms.Button Sent_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button ReceiveClear_btn;
        private System.Windows.Forms.RadioButton SentHex;
        private System.Windows.Forms.RadioButton SentText;
        private System.Windows.Forms.RadioButton ReceiveHex;
        private System.Windows.Forms.RadioButton ReceiveText;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox StatusText;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Timer timer1;
    }
}

