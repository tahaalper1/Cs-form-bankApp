using System;
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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tutar;
            double kalan;
           

            tutar = Convert.ToInt32(textBox1.Text);
            kalan = 12700 - tutar;
            label3.Text = kalan.ToString();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 geri = new Form5();
            geri.Show();
            this.Hide();
        }
    }
}
