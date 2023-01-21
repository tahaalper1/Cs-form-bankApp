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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 bilgi = new Form6();
            bilgi.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 çekme = new Form7();
            çekme.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 yatırma = new Form8();
            yatırma.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 havale = new Form9();
            havale.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 ödeme = new Form10();
            ödeme.Show();
            this.Hide();

        }
    }
}
