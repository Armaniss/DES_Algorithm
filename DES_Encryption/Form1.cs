﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DES_Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)      // Užšifruoti
        {
            try
            {
                DES des = new DES();
                tBoxEncData.Text = des.EncryptData(textBox1.Text, tBoxKeyEncrypt.Text, cbCBCMode.Checked);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)     // Dešifruoti
        {
            try 
            {
                DES des = new DES();
                tBoxDcpData.Text = des.DecryptData(textBox2.Text, tBoxKeyDecrypt.Text,cbCBCMode.Checked);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Parinktas neteisingas šifravimo režimas");
            }
        }

        private void cbCBCMode_CheckedChanged(object sender, EventArgs e)
        {
            if(cbCBCMode.Checked) { cbECBMode.Checked = false; };
        }

        private void cbECBMode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbECBMode.Checked) { cbCBCMode.Checked = false; };
        }
    }
}
