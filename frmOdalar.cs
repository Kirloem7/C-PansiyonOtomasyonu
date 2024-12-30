using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace LotusPansiyonVeDinlenmeTesisleri
{
    public partial class frmOdalar : Form
    {
        public frmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-TGJGI9KG\SQLEXPRESS;Initial Catalog=LotusPansiyon;Integrated Security=True;TrustServerCertificate=True;");


        private void frmOdalar_Load(object sender, EventArgs e)
        {
            // Oda101 için işlemler
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select * from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                RoomButton1.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (RoomButton1.Text != "101")
            {
                RoomButton1.BackColor = Color.Red;
            }

            // Oda102 için işlemler
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select* from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                RoomButton2.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();
            if (RoomButton2.Text != "102")
            {
                RoomButton2.BackColor = Color.Red;
            }

            // Oda103 için işlemler
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select* from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                RoomButton3.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();
            if (RoomButton3.Text != "103")
            {
                RoomButton3.BackColor = Color.Red;
            }

            // Oda104 için işlemler
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select* from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                RoomButton4.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();
            if (RoomButton4.Text != "104")
            {
                RoomButton4.BackColor = Color.Red;
            }

            // Oda105 için işlemler
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select* from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                RoomButton5.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();
            if (RoomButton5.Text != "105")
            {
                RoomButton5.BackColor = Color.Red;
            }

            // Oda106 için işlemler
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select* from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                RoomButton6.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();
            if (RoomButton6.Text != "106")
            {
                RoomButton6.BackColor = Color.Red;
            }

            // Oda107 için işlemler
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select* from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                RoomNumber7.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();
            if (RoomNumber7.Text != "107")
            {
                RoomNumber7.BackColor = Color.Red;
            }

            // Oda108 için işlemler
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("Select* from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                RoomNumber8.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();
            if (RoomNumber8.Text != "108")
            {
                RoomNumber8.BackColor = Color.Red;
            }

            // Oda109 için işlemler
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("Select* from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                RoomButton9.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglanti.Close();
            if (RoomButton9.Text != "109")
            {
                RoomButton9.BackColor = Color.Red;
            }
        }

    }
}