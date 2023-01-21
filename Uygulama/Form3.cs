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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            if (textBox2.Text == "1283")
            {
                MessageBox.Show("Giriş Başarılı");
                Form5 banka = new Form5();
                banka.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI ŞİFRE !!!");
            }
        }
    }
}
