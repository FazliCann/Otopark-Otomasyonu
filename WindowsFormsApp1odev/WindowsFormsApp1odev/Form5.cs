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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;


        private void Form5_Load(object sender, EventArgs e)
        {

            RezervasyonGridiDoldur();
        }
        void RezervasyonGridiDoldur()
        {
            con = new SqlConnection(@"server=DESKTOP-I9H03GM; database=FinalÖdevi;user id=sa; password=1785");
            da = new SqlDataAdapter("select * from Rezervasyon", con);//datatable tek tablo dataset tabloların tümü
            ds = new DataSet();
            da.Fill(ds, "Rezervasyon");
            dgvRezervasyon.DataSource = ds.Tables["Rezervasyon"];

        }
    }
}
