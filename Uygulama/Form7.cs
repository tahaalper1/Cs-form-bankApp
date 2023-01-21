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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int para;

            para = 12700 - 20;
            label4.Text = "12.680 TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int para;
            para = 12700 - 50;
            label4.Text = "12.650 TL";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int para;
            para = 12700 - 100;
            label4.Text = "12.600 TL";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int para;
            para = 12700 - 200;
            label4.Text = "12.500 TL";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int para;
            para = 12700 - 500;
            label4.Text = "12.200 TL";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 geri = new Form5();
            geri.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form11 miktar = new Form11();
            miktar.Show();
            this.Hide();
        }
    }
}
