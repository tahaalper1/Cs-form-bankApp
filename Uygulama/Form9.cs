﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 geri = new Form5();
            geri.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tutar;
            int kalan;

            tutar = Convert.ToInt32(textBox2.Text);
            kalan = 12700 - tutar;
            label3.Text = kalan.ToString();



            if (textBox1.Text=="50247896")
            {
                MessageBox.Show(" İŞLEM BAŞARILI ");
            }
            else
            {
                MessageBox.Show(" İŞLEM BAŞARISIZ !!!");
            }

            
        }
    }
}
