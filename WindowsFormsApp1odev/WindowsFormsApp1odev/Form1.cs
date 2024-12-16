using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(txtKulAd.Text == "oto" && txtParola.Text == "123")
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Hatalı!");
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
