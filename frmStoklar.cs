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
using System.Data.Sql;
using Microsoft.Data.SqlClient;

namespace LotusPansiyonVeDinlenmeTesisleri
{
    public partial class frmStoklar : Form
    {
        public frmStoklar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-TGJGI9KG\SQLEXPRESS;Initial Catalog=LotusPansiyon;Integrated Security=True;TrustServerCertificate=True;");

        private void Information()
        {
            StocsListView.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gıda"].ToString();
                ekle.SubItems.Add(oku["Icecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());

                StocsListView.Items.Add(ekle);
            }
            baglanti.Close();

        }

        private void Information2()
        {
            BillListView.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Faturalar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["Internet"].ToString());

                BillListView.Items.Add(ekle);
            }
            baglanti.Close();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into (Gıda,Icecek,Cerezler) values('" + FoodAmountTextBox.Text + "','" + DrinksAmountTextBox.Text + "', '" + SnacksTextBox.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Information();

        }

        private void frmStoklar_Load(object sender, EventArgs e)
        {
            Information();
            Information2();
        }

        private void SaveButton2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into (Elektrik,Su,Internet) values('" + ElectricBillTextBox.Text + "','" +WaterBillTextBox.Text + "', '" + InternetBillTextBox.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Information2();

        }
    }
}
