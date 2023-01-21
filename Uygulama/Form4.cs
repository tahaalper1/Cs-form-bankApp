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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "tahaalper1992@gmail.com" && textBox2.Text == "1283")
            { MessageBox.Show("Giriş Başarılı");
                Form5 banka = new Form5();
                banka.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ !!!");
            }
        }
       
        

    }
}
