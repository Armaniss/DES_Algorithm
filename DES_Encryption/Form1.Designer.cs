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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxKeyEncrypt = new System.Windows.Forms.TextBox();
            this.tBoxKeyDecrypt = new System.Windows.Forms.TextBox();
            this.cbCBCMode = new System.Windows.Forms.CheckBox();
            this.cbECBMode = new System.Windows.Forms.CheckBox();
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
            this.tBoxEncData.Location = new System.Drawing.Point(523, 70);
            this.tBoxEncData.Name = "tBoxEncData";
            this.tBoxEncData.Size = new System.Drawing.Size(197, 20);
            this.tBoxEncData.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 262);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 20);
            this.textBox2.TabIndex = 2;
            // 
            // tBoxDcpData
            // 
            this.tBoxDcpData.Location = new System.Drawing.Point(523, 262);
            this.tBoxDcpData.Name = "tBoxDcpData";
            this.tBoxDcpData.Size = new System.Drawing.Size(197, 20);
            this.tBoxDcpData.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Užšifruoti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Dešifruoti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.label2.Location = new System.Drawing.Point(520, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Užšifruotas tekstas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tekstas dešifravimui";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dešifruotas tekstas";
            // 
            // tBoxKeyEncrypt
            // 
            this.tBoxKeyEncrypt.Location = new System.Drawing.Point(82, 96);
            this.tBoxKeyEncrypt.MaxLength = 8;
            this.tBoxKeyEncrypt.Name = "tBoxKeyEncrypt";
            this.tBoxKeyEncrypt.Size = new System.Drawing.Size(100, 20);
            this.tBoxKeyEncrypt.TabIndex = 10;
            // 
            // tBoxKeyDecrypt
            // 
            this.tBoxKeyDecrypt.Location = new System.Drawing.Point(82, 288);
            this.tBoxKeyDecrypt.MaxLength = 8;
            this.tBoxKeyDecrypt.Name = "tBoxKeyDecrypt";
            this.tBoxKeyDecrypt.Size = new System.Drawing.Size(100, 20);
            this.tBoxKeyDecrypt.TabIndex = 11;
            // 
            // cbCBCMode
            // 
            this.cbCBCMode.AutoSize = true;
            this.cbCBCMode.Location = new System.Drawing.Point(82, 122);
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
            this.cbECBMode.Location = new System.Drawing.Point(82, 140);
            this.cbECBMode.Name = "cbECBMode";
            this.cbECBMode.Size = new System.Drawing.Size(77, 17);
            this.cbECBMode.TabIndex = 13;
            this.cbECBMode.Text = "ECB Mode";
            this.cbECBMode.UseVisualStyleBackColor = true;
            this.cbECBMode.CheckedChanged += new System.EventHandler(this.cbECBMode_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbECBMode);
            this.Controls.Add(this.cbCBCMode);
            this.Controls.Add(this.tBoxKeyDecrypt);
            this.Controls.Add(this.tBoxKeyEncrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBoxDcpData);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tBoxEncData);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tBoxEncData;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tBoxDcpData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxKeyEncrypt;
        private System.Windows.Forms.TextBox tBoxKeyDecrypt;
        private System.Windows.Forms.CheckBox cbCBCMode;
        private System.Windows.Forms.CheckBox cbECBMode;
    }
}

