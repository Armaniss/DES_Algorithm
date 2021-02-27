namespace DES_Encryption
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tBoxEncData = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tBoxDcpData = new System.Windows.Forms.TextBox();
            this.bEncrypt = new System.Windows.Forms.Button();
            this.bDecrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxKeyEncrypt = new System.Windows.Forms.TextBox();
            this.tBoxKeyDecrypt = new System.Windows.Forms.TextBox();
            this.cbCBCMode = new System.Windows.Forms.CheckBox();
            this.cbECBMode = new System.Windows.Forms.CheckBox();
            this.pbFile = new System.Windows.Forms.Panel();
            this.bDialogBox = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tFileKey = new System.Windows.Forms.TextBox();
            this.tbFileText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bFileEncrypt = new System.Windows.Forms.Button();
            this.bFileDecrypt = new System.Windows.Forms.Button();
            this.pbFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tBoxEncData
            // 
            this.tBoxEncData.Location = new System.Drawing.Point(285, 70);
            this.tBoxEncData.Name = "tBoxEncData";
            this.tBoxEncData.Size = new System.Drawing.Size(197, 20);
            this.tBoxEncData.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 246);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 20);
            this.textBox2.TabIndex = 2;
            // 
            // tBoxDcpData
            // 
            this.tBoxDcpData.Location = new System.Drawing.Point(287, 246);
            this.tBoxDcpData.Name = "tBoxDcpData";
            this.tBoxDcpData.Size = new System.Drawing.Size(197, 20);
            this.tBoxDcpData.TabIndex = 3;
            // 
            // bEncrypt
            // 
            this.bEncrypt.Location = new System.Drawing.Point(84, 179);
            this.bEncrypt.Name = "bEncrypt";
            this.bEncrypt.Size = new System.Drawing.Size(75, 23);
            this.bEncrypt.TabIndex = 4;
            this.bEncrypt.Text = "Užšifruoti";
            this.bEncrypt.UseVisualStyleBackColor = true;
            this.bEncrypt.Click += new System.EventHandler(this.button1_Click);
            // 
            // bDecrypt
            // 
            this.bDecrypt.Location = new System.Drawing.Point(83, 314);
            this.bDecrypt.Name = "bDecrypt";
            this.bDecrypt.Size = new System.Drawing.Size(75, 23);
            this.bDecrypt.TabIndex = 5;
            this.bDecrypt.Text = "Dešifruoti";
            this.bDecrypt.UseVisualStyleBackColor = true;
            this.bDecrypt.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tekstas užšifravimui";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Užšifruotas tekstas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tekstas dešifravimui";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dešifruotas tekstas";
            // 
            // tBoxKeyEncrypt
            // 
            this.tBoxKeyEncrypt.Location = new System.Drawing.Point(84, 112);
            this.tBoxKeyEncrypt.MaxLength = 8;
            this.tBoxKeyEncrypt.Name = "tBoxKeyEncrypt";
            this.tBoxKeyEncrypt.Size = new System.Drawing.Size(100, 20);
            this.tBoxKeyEncrypt.TabIndex = 10;
            // 
            // tBoxKeyDecrypt
            // 
            this.tBoxKeyDecrypt.Location = new System.Drawing.Point(83, 285);
            this.tBoxKeyDecrypt.MaxLength = 8;
            this.tBoxKeyDecrypt.Name = "tBoxKeyDecrypt";
            this.tBoxKeyDecrypt.Size = new System.Drawing.Size(100, 20);
            this.tBoxKeyDecrypt.TabIndex = 11;
            // 
            // cbCBCMode
            // 
            this.cbCBCMode.AutoSize = true;
            this.cbCBCMode.Location = new System.Drawing.Point(84, 138);
            this.cbCBCMode.Name = "cbCBCMode";
            this.cbCBCMode.Size = new System.Drawing.Size(77, 17);
            this.cbCBCMode.TabIndex = 12;
            this.cbCBCMode.Text = "CBC Mode";
            this.cbCBCMode.UseVisualStyleBackColor = true;
            this.cbCBCMode.CheckedChanged += new System.EventHandler(this.cbCBCMode_CheckedChanged);
            // 
            // cbECBMode
            // 
            this.cbECBMode.AutoSize = true;
            this.cbECBMode.Location = new System.Drawing.Point(84, 156);
            this.cbECBMode.Name = "cbECBMode";
            this.cbECBMode.Size = new System.Drawing.Size(77, 17);
            this.cbECBMode.TabIndex = 13;
            this.cbECBMode.Text = "ECB Mode";
            this.cbECBMode.UseVisualStyleBackColor = true;
            this.cbECBMode.CheckedChanged += new System.EventHandler(this.cbECBMode_CheckedChanged);
            // 
            // pbFile
            // 
            this.pbFile.Controls.Add(this.bFileDecrypt);
            this.pbFile.Controls.Add(this.bFileEncrypt);
            this.pbFile.Controls.Add(this.label9);
            this.pbFile.Controls.Add(this.label8);
            this.pbFile.Controls.Add(this.tbFileText);
            this.pbFile.Controls.Add(this.tFileKey);
            this.pbFile.Controls.Add(this.label5);
            this.pbFile.Controls.Add(this.tbPath);
            this.pbFile.Location = new System.Drawing.Point(493, 96);
            this.pbFile.Name = "pbFile";
            this.pbFile.Size = new System.Drawing.Size(295, 291);
            this.pbFile.TabIndex = 14;
            this.pbFile.Visible = false;
            // 
            // bDialogBox
            // 
            this.bDialogBox.Location = new System.Drawing.Point(493, 70);
            this.bDialogBox.Name = "bDialogBox";
            this.bDialogBox.Size = new System.Drawing.Size(25, 23);
            this.bDialogBox.TabIndex = 15;
            this.bDialogBox.Text = "...";
            this.bDialogBox.UseVisualStyleBackColor = true;
            this.bDialogBox.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(3, 23);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(289, 20);
            this.tbPath.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dokumento vieta";
            // 
            // tFileKey
            // 
            this.tFileKey.Location = new System.Drawing.Point(6, 67);
            this.tFileKey.MaxLength = 8;
            this.tFileKey.Name = "tFileKey";
            this.tFileKey.Size = new System.Drawing.Size(100, 20);
            this.tFileKey.TabIndex = 16;
            // 
            // tbFileText
            // 
            this.tbFileText.Location = new System.Drawing.Point(7, 108);
            this.tbFileText.Multiline = true;
            this.tbFileText.Name = "tbFileText";
            this.tbFileText.Size = new System.Drawing.Size(288, 44);
            this.tbFileText.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Raktas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Raktas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Raktas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Dokumento tekstas";
            // 
            // bFileEncrypt
            // 
            this.bFileEncrypt.Location = new System.Drawing.Point(7, 163);
            this.bFileEncrypt.Name = "bFileEncrypt";
            this.bFileEncrypt.Size = new System.Drawing.Size(75, 23);
            this.bFileEncrypt.TabIndex = 18;
            this.bFileEncrypt.Text = "Užšifruoti";
            this.bFileEncrypt.UseVisualStyleBackColor = true;
            this.bFileEncrypt.Click += new System.EventHandler(this.bFileEncrypt_Click);
            // 
            // bFileDecrypt
            // 
            this.bFileDecrypt.Location = new System.Drawing.Point(88, 163);
            this.bFileDecrypt.Name = "bFileDecrypt";
            this.bFileDecrypt.Size = new System.Drawing.Size(75, 23);
            this.bFileDecrypt.TabIndex = 18;
            this.bFileDecrypt.Text = "Dešifruoti";
            this.bFileDecrypt.UseVisualStyleBackColor = true;
            this.bFileDecrypt.Click += new System.EventHandler(this.bFileDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bDialogBox);
            this.Controls.Add(this.pbFile);
            this.Controls.Add(this.cbECBMode);
            this.Controls.Add(this.cbCBCMode);
            this.Controls.Add(this.tBoxKeyDecrypt);
            this.Controls.Add(this.tBoxKeyEncrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bDecrypt);
            this.Controls.Add(this.bEncrypt);
            this.Controls.Add(this.tBoxDcpData);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tBoxEncData);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pbFile.ResumeLayout(false);
            this.pbFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tBoxEncData;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tBoxDcpData;
        private System.Windows.Forms.Button bEncrypt;
        private System.Windows.Forms.Button bDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxKeyEncrypt;
        private System.Windows.Forms.TextBox tBoxKeyDecrypt;
        private System.Windows.Forms.CheckBox cbCBCMode;
        private System.Windows.Forms.CheckBox cbECBMode;
        private System.Windows.Forms.Panel pbFile;
        private System.Windows.Forms.Button bDialogBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.TextBox tbFileText;
        private System.Windows.Forms.TextBox tFileKey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bFileDecrypt;
        private System.Windows.Forms.Button bFileEncrypt;
    }
}

