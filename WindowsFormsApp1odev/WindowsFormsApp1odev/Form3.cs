using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1odev
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            for (int i = 1; i <= 24; i++)
            {
                comboBox2.Items.Add(i + " Saat");
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into KalinanZaman (MusteriPlaka,KullanılanTarife,AlınanPara) values (@MusteriPlaka,@KullanılanTarife,@AlınanPara)";
            SqlCommand cmd = new SqlCommand(cmdText,con);
            cmd.Parameters.AddWithValue("@MusteriPlaka", textBox1.Text);
            cmd.Parameters.AddWithValue("@KullanılanTarife", comboBox2.Text);
            cmd.Parameters.AddWithValue("@AlınanPara", textBox2.Text );

            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            int saat = 0, ucret = 0;
            string[] dizi = new string[30];
            string[] dizi1 = new string[30];
            dizi1 = comboBox2.Text.Split(' ');
            dizi = textBox1.Text.Split(' ');
            saat = Int16.Parse(dizi1[0]);


            ucret = saat * 15;

            textBox2.Text = ucret.ToString();

            cmd.ExecuteNonQuery();
            con.Close();

            con = new SqlConnection(@"server=DESKTOP-I9H03GM; database=FinalÖdevi;user id=sa; password=1785");
            string cmdText2 = "delete from Musteri where Plaka=@Plaka";
            cmd = new SqlCommand(cmdText2, con);
            cmd.Parameters.AddWithValue("@Plaka", textBox1.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
            con = new SqlConnection(@"server=DESKTOP-I9H03GM; database=FinalÖdevi;user id=sa; password=1785");
            string cmdText3 = "update KalinanZaman set AlınanPara=@AlınanPara where MusteriPlaka= @MusteriPlaka";
            cmd = new SqlCommand(cmdText3, con);
            cmd.Parameters.AddWithValue("@MusteriPlaka", textBox1.Text);
            cmd.Parameters.AddWithValue("@AlınanPara", textBox2.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();

            Form4 frm4 = new Form4();
            frm4.GridiDoldur();
            MessageBox.Show("Muhasebe işlemi Tamamlanmıştır");




        }

        private void lbGun_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
