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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Katlar ",con);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    switch (dr[1].ToString())
                    {
                        case "A1":
                            {
                                btnA1.Text = dr[1].ToString();
                                btnA1.BackColor = System.Drawing.Color.Red;
                                btnA1.Enabled = false;
                                break;
                            }
                        case "A2":
                            {
                                btnA2.Text = dr[1].ToString();
                                btnA2.BackColor = System.Drawing.Color.Red;
                                btnA2.Enabled = false;
                                break;
                            }
                        case "A3":
                            {
                                btnA3.Text = dr[1].ToString();
                                btnA3.BackColor = System.Drawing.Color.Red;
                                btnA3.Enabled = false;
                                break;
                            }

                        case "A4":
                            {
                                btnA4.Text = dr[1].ToString();
                                btnA4.BackColor = System.Drawing.Color.Red;
                                btnA4.Enabled = false;
                                break;
                            }
                        case "A5":
                            {
                                btnA5.Text = dr[1].ToString();
                                btnA5.BackColor = System.Drawing.Color.Red;
                                btnA5.Enabled = false;
                                break;
                            }
                        case "A6":
                            {
                                btnA6.Text = dr[1].ToString();
                                btnA6.BackColor = System.Drawing.Color.Red;
                                btnA6.Enabled = false;
                                break;
                            }
                        case "A7":
                            {
                                btnA7.Text = dr[1].ToString();
                                btnA7.BackColor = System.Drawing.Color.Red;
                                btnA7.Enabled = false;
                                break;
                            }
                        case "A8":
                            {
                                btnA8.Text = dr[1].ToString();
                                btnA8.BackColor = System.Drawing.Color.Red;
                                btnA8.Enabled = false;
                                break;
                            }
                        case "A9":
                            {
                                btnA9.Text = dr[1].ToString();
                                btnA9.BackColor = System.Drawing.Color.Red;
                                btnA9.Enabled = false;
                                break;
                            }
                        case "A10":
                            {
                                btnA10.Text = dr[1].ToString();
                                btnA10.BackColor = System.Drawing.Color.Red;
                                btnA10.Enabled = false;
                                break;
                            }
                        case "B1":
                            {
                                btnB1.Text = dr[1].ToString();
                                btnB1.BackColor = System.Drawing.Color.Red;
                                btnB1.Enabled = false;
                                break;
                            }
                        case "B2":
                            {
                                btnB2.Text = dr[1].ToString();
                                btnB2.BackColor = System.Drawing.Color.Red;
                                btnB2.Enabled = false;
                                break;
                            }
                        case "B3":
                            {
                                btnB3.Text = dr[1].ToString();
                                btnB3.BackColor = System.Drawing.Color.Red;
                                btnB3.Enabled = false;
                                break;
                            }

                        case "B4":
                            {
                                btnB4.Text = dr[1].ToString();
                                btnB4.BackColor = System.Drawing.Color.Red;
                                btnB4.Enabled = false;
                                break;
                            }
                        case "B5":
                            {
                                btnB5.Text = dr[1].ToString();
                                btnB5.BackColor = System.Drawing.Color.Red;
                                btnB5.Enabled = false;
                                break;
                            }
                        case "B6":
                            {
                                btnB6.Text = dr[1].ToString();
                                btnB6.BackColor = System.Drawing.Color.Red;
                                btnB6.Enabled = false;
                                break;
                            }
                        case "B7":
                            {
                                btnB7.Text = dr[1].ToString();
                                btnB7.BackColor = System.Drawing.Color.Red;
                                btnB7.Enabled = false;
                                break;
                            }
                        case "B8":
                            {
                                btnB8.Text = dr[1].ToString();
                                btnB8.BackColor = System.Drawing.Color.Red;
                                btnB8.Enabled = false;
                                break;
                            }
                        case "B9":
                            {
                                btnB9.Text = dr[1].ToString();
                                btnB9.BackColor = System.Drawing.Color.Red;
                                btnB9.Enabled = false;
                                break;
                            }
                        case "B10":
                            {
                                btnB10.Text = dr[1].ToString();
                                btnB10.BackColor = System.Drawing.Color.Red;
                                btnB10.Enabled = false;
                                break;
                            }
                        case "C1":
                            {
                                btnC1.Text = dr[1].ToString();
                                btnC1.BackColor = System.Drawing.Color.Red;
                                btnC1.Enabled = false;
                                break;
                            }
                        case "C2":
                            {
                                btnC2.Text = dr[1].ToString();
                                btnC2.BackColor = System.Drawing.Color.Red;
                                btnC2.Enabled = false;
                                break;
                            }
                        case "C3":
                            {
                                btnC3.Text = dr[1].ToString();
                                btnC3.BackColor = System.Drawing.Color.Red;
                                btnC3.Enabled = false;
                                break;
                            }

                        case "C4":
                            {
                                btnC4.Text = dr[1].ToString();
                                btnC4.BackColor = System.Drawing.Color.Red;
                                btnC4.Enabled = false;
                                break;
                            }
                        case "C5":
                            {
                                btnC5.Text = dr[1].ToString();
                                btnC5.BackColor = System.Drawing.Color.Red;
                                btnC5.Enabled = false;
                                break;
                            }
                        case "C6":
                            {
                                btnC6.Text = dr[1].ToString();
                                btnC6.BackColor = System.Drawing.Color.Red;
                                btnC6.Enabled = false;
                                break;
                            }
                        case "C7":
                            {
                                btnC7.Text = dr[1].ToString();
                                btnC7.BackColor = System.Drawing.Color.Red;
                                btnC7.Enabled = false;
                                break;
                            }
                        case "C8":
                            {
                                btnC8.Text = dr[1].ToString();
                                btnC8.BackColor = System.Drawing.Color.Red;
                                btnC8.Enabled = false;
                                break;
                            }
                        case "C9":
                            {
                                btnC9.Text = dr[1].ToString();
                                btnC9.BackColor = System.Drawing.Color.Red;
                                btnC9.Enabled = false;
                                break;
                            }
                        case "C10":
                            {
                                btnC10.Text = dr[1].ToString();
                                btnC10.BackColor = System.Drawing.Color.Red;
                                btnC10.Enabled = false;
                                break;
                            }
                        case "D1":
                            {
                                btnD1.Text = dr[1].ToString();
                                btnD1.BackColor = System.Drawing.Color.Red;
                                btnD1.Enabled = false;
                                break;
                            }
                        case "D2":
                            {
                                btnD2.Text = dr[1].ToString();
                                btnD2.BackColor = System.Drawing.Color.Red;
                                btnD2.Enabled = false;
                                break;
                            }
                        case "D3":
                            {
                                btnD3.Text = dr[1].ToString();
                                btnD3.BackColor = System.Drawing.Color.Red;
                                btnD3.Enabled = false;
                                break;
                            }

                        case "D4":
                            {
                                btnD4.Text = dr[1].ToString();
                                btnD4.BackColor = System.Drawing.Color.Red;
                                btnD4.Enabled = false;
                                break;
                            }
                        case "D5":
                            {
                                btnD5.Text = dr[1].ToString();
                                btnD5.BackColor = System.Drawing.Color.Red;
                                btnD5.Enabled = false;
                                break;
                            }
                        case "D6":
                            {
                                btnD6.Text = dr[1].ToString();
                                btnD6.BackColor = System.Drawing.Color.Red;
                                btnD6.Enabled = false;
                                break;
                            }
                        case "D7":
                            {
                                btnD7.Text = dr[1].ToString();
                                btnD7.BackColor = System.Drawing.Color.Red;
                                btnD7.Enabled = false;
                                break;
                            }
                        case "D8":
                            {
                                btnD8.Text = dr[1].ToString();
                                btnD8.BackColor = System.Drawing.Color.Red;
                                btnD8.Enabled = false;
                                break;
                            }
                        case "D9":
                            {
                                btnD9.Text = dr[1].ToString();
                                btnD9.BackColor = System.Drawing.Color.Red;
                                btnD9.Enabled = false;
                                break;
                            }
                        case "D10":
                            {
                                btnD10.Text = dr[1].ToString();
                                btnD10.BackColor = System.Drawing.Color.Red;
                                btnD10.Enabled = false;
                                break;
                            }
                        case "E1":
                            {
                                btnE1.Text = dr[1].ToString();
                                btnE1.BackColor = System.Drawing.Color.Red;
                                btnE1.Enabled = false;
                                break;
                            }
                        case "E2":
                            {
                                btnE2.Text = dr[1].ToString();
                                btnE2.BackColor = System.Drawing.Color.Red;
                                btnE2.Enabled = false;
                                break;
                            }
                        case "E3":
                            {
                                btnE3.Text = dr[1].ToString();
                                btnE3.BackColor = System.Drawing.Color.Red;
                                btnE3.Enabled = false;
                                break;
                            }

                        case "E4":
                            {
                                btnE4.Text = dr[1].ToString();
                                btnE4.BackColor = System.Drawing.Color.Red;
                                btnE4.Enabled = false;
                                break;
                            }
                        case "E5":
                            {
                                btnE5.Text = dr[1].ToString();
                                btnE5.BackColor = System.Drawing.Color.Red;
                                btnE5.Enabled = false;
                                break;
                            }
                        case "E6":
                            {
                                btnE6.Text = dr[1].ToString();
                                btnE6.BackColor = System.Drawing.Color.Red;
                                btnE6.Enabled = false;
                                break;
                            }
                        case "E7":
                            {
                                btnE7.Text = dr[1].ToString();
                                btnE7.BackColor = System.Drawing.Color.Red;
                                btnE7.Enabled = false;
                                break;
                            }
                        case "E8":
                            {
                                btnE8.Text = dr[1].ToString();
                                btnE8.BackColor = System.Drawing.Color.Red;
                                btnE8.Enabled = false;
                                break;
                            }
                        case "E9":
                            {
                                btnE9.Text = dr[1].ToString();
                                btnE9.BackColor = System.Drawing.Color.Red;
                                btnE9.Enabled = false;
                                break;
                            }
                        case "E10":
                            {
                                btnE10.Text = dr[1].ToString();
                                btnE10.BackColor = System.Drawing.Color.Red;
                                btnE10.Enabled = false;
                                break;
                            }

                    }
                }
            

            }

            con.Close();
            dr.Dispose();
        }
       

        private void btnEkle_Click(object sender, EventArgs e)
        {

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Musteri( Plaka, Model, Giris_vakti,Kalacagi_Tarife) values( @Plaka, @Model, @Giris_vakti,@Kalaca" +
                "gi_Tarife) ";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            //cmd.Parameters.AddWithValue("@ArabaId", txtId.Text);
            cmd.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
            cmd.Parameters.AddWithValue("@Model", txtModel.Text);
            cmd.Parameters.AddWithValue("@Giris_vakti", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@Kalacagi_Tarife", cmbTarife.Text);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();

        }

      

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "update Musteri set   Kalacagi_Tarife=@Kalacagi_Tarife where ArabaId=@ArabaId ";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@ArabaId", txtId.Text);
            cmd.Parameters.AddWithValue("@Kalacagi_Tarife", cmbTarife.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close(); ;

        }


    


        private void button1_Click(object sender, EventArgs e)
        {
            lbA1.Text = txtPlaka.Text;

            btnA1.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnA1.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            lbA2.Text = txtPlaka.Text ; 
            btnA2.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnA2.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();





        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbA3.Text = txtPlaka.Text; 
            btnA3.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnA3.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbA4.Text = txtPlaka.Text ; 
            btnA4.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar4 (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnA4.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lbA5.Text = txtPlaka.Text  ; 
            btnA5.BackColor = Color.Red;
            
            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnA5.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }



        private void button12_Click(object sender, EventArgs e)
        {
            lbA6.Text = txtPlaka.Text   ; 
            btnA6.BackColor = Color.Red;
            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnA6.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lbA7.Text = txtPlaka.Text   ; 
            btnA7.BackColor = Color.Red;
            
            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnA7.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }



        private void button16_Click(object sender, EventArgs e)
        {
            lbA8.Text = txtPlaka.Text   ; 
            btnA8.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnA8.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();

        }



        private void button18_Click(object sender, EventArgs e)
        {
            lbA9.Text = txtPlaka.Text   ; 
            btnA9.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnA9.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }



        private void button20_Click(object sender, EventArgs e)
        {
            lbA10.Text = txtPlaka.Text   ; 
            btnA10.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnA10.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            lbB1.Text = txtPlaka.Text   ; 
            btnB1.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnB1.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void button36_Click(object sender, EventArgs e)
        {
            lbB2.Text = txtPlaka.Text   ; 
            btnB2.BackColor = Color.Red;
            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnB2.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();


        }

        private void button32_Click(object sender, EventArgs e)
        {
            lbB3.Text = txtPlaka.Text   ; 
            btnB3.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnB3.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            lbB4.Text = txtPlaka.Text   ; 
            btnB4.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnB4.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            lbB5.Text = txtPlaka.Text   ; 
            btnB5.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnB5.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
        private void button21_Click(object sender, EventArgs e)
        {
            lbB10.Text = txtPlaka.Text   ; 
            btnB10.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnB10.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            lbB9.Text = txtPlaka.Text   ; 
            btnB9.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnB9.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }
       
        private void button29_Click(object sender, EventArgs e)
        {
            lbB8.Text = txtPlaka.Text   ; 
            btnB8.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnB8.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            lbB7.Text = txtPlaka.Text   ; 
            btnB7.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnB7.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            lbB6.Text = txtPlaka.Text   ; 
            btnB6.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnB6.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            lbC1.Text = txtPlaka.Text   ; ;
            btnC1.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnC1.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            lbC2.Text = txtPlaka.Text   ; 
            btnC2.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnC2.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            lbC3.Text = txtPlaka.Text   ; 
            btnC3.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnC3.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            lbC4.Text = txtPlaka.Text   ; 
            btnC4.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnC4.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            lbC5.Text = txtPlaka.Text   ; 
            btnC5.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnC5.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

   
        private void button41_Click(object sender, EventArgs e)
        {
            lbC10.Text = txtPlaka.Text   ;
            btnC10.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnC10.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();


        }

        private void button45_Click(object sender, EventArgs e)
        {
            lbC9.Text = txtPlaka.Text   ;
            btnC9.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnC9.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void button49_Click(object sender, EventArgs e)
        {
            lbC8.Text = txtPlaka.Text   ;
            btnC8.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnC8.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void button53_Click(object sender, EventArgs e)
        {
            lbC7.Text = txtPlaka.Text   ;
            btnC7.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnC7.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void button57_Click(object sender, EventArgs e)
        {
            lbC6.Text = txtPlaka.Text   ;
            btnC6.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnC6.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button80_Click(object sender, EventArgs e)
        {
            lbD1.Text = txtPlaka.Text   ;
            btnD1.BackColor = Color.Red;


            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnD1.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void button76_Click(object sender, EventArgs e)
        {
            lbD2.Text = txtPlaka.Text   ;
            btnD2.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnD2.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            lbD3.Text = txtPlaka.Text   ;
            btnD3.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnD3.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button68_Click(object sender, EventArgs e)
        {
            lbD4.Text = txtPlaka.Text;
            btnD4.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnD4.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            lbD5.Text = txtPlaka.Text   ;
            btnD5.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnD5.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

      
       
        private void button61_Click(object sender, EventArgs e)
        {
            lbD10.Text = txtPlaka.Text   ;
            btnD10.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnD10.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button65_Click(object sender, EventArgs e)
        {
            lbD9.Text = txtPlaka.Text   ;
            btnD9.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnD9.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button69_Click(object sender, EventArgs e)
        {
            lbD8.Text = txtPlaka.Text   ;
            btnD8.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnD8.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button73_Click(object sender, EventArgs e)
        {
            lbD7.Text = txtPlaka.Text   ;
            btnD7.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnD7.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button77_Click(object sender, EventArgs e)
        {
            lbD6.Text = txtPlaka.Text   ;
            btnD6.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnD6.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button100_Click(object sender, EventArgs e)
        {
            lbE1.Text = txtPlaka.Text   ;
            btnE1.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnE1.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();


        }

        private void button96_Click(object sender, EventArgs e)
        {
            lbD2.Text = txtPlaka.Text   ;
            btnE2.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnE2.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button92_Click(object sender, EventArgs e)
        {
            lbE3.Text = txtPlaka.Text   ;
            btnE3.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnE3.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button88_Click(object sender, EventArgs e)
        {
            lbE4.Text = txtPlaka.Text   ;
            btnE4.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnE4.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button84_Click(object sender, EventArgs e)
        {
            lbE5.Text = txtPlaka.Text   ;
            btnE5.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnE5.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }


        private void button81_Click(object sender, EventArgs e)
        {
            lbE10.Text = txtPlaka.Text   ;
            btnE10.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnE10.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button85_Click(object sender, EventArgs e)
        {
            lbE9.Text = txtPlaka.Text   ;
            btnE9.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnE9.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button89_Click(object sender, EventArgs e)
        {
            lbE8.Text = txtPlaka.Text   ;
            btnE8.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnE8.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button93_Click(object sender, EventArgs e)
        {
            lbE7.Text = txtPlaka.Text   ;
            btnE7.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnE7.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button97_Click(object sender, EventArgs e)
        {
            lbE6.Text = txtPlaka.Text   ; 
            btnE6.BackColor = Color.Red;

            con = new SqlConnection("server = DESKTOP-I9H03GM; database = FinalÖdevi; user id = sa; password = 1785");
            string cmdText = "insert into Katlar (KatAdi) values (@KatAdi)";
            cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@KatAdi", btnE6.Text);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            
        }

        private void cmbTarife_MouseClick(object sender, MouseEventArgs e)
        {
            cmbTarife.Items.Clear();
            for (int i = 1; i <= 24; i++)
            {
                cmbTarife.Items.Add(i + " Saat");
            }
        }
    }
}
