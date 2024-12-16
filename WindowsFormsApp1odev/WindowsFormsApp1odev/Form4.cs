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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        private void dgvListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        { 
            GridiDoldur();
        }
         public  void GridiDoldur()
        {
            con = new SqlConnection(@"server=DESKTOP-I9H03GM; database=FinalÖdevi;user id=sa; password=1785");
            da = new SqlDataAdapter("select * from Musteri ", con);//datatable tek tablo dataset tabloların tümü
            ds = new DataSet();
            da.Fill(ds, "Musteri");
            dgvListele.DataSource = ds.Tables["Musteri"];

        }




        private void btnAra_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"server=DESKTOP-I9H03GM; database=FinalÖdevi;user id=sa; password=1785");
            SqlDataAdapter da = new SqlDataAdapter("select * from Musteri where Plaka like '" + txtAra.Text+"%'",con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "Musteri");
            dgvListele.DataSource = ds.Tables["Musteri"];
            con.Close();

        }

        

        private void btnMuhasebe_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
        }
      
    }
}
