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
using Microsoft.EntityFrameworkCore.Storage.Json;

namespace LotusPansiyonVeDinlenmeTesisleri
{
    public partial class frmMesajlar : Form
    {
        public frmMesajlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-TGJGI9KG\SQLEXPRESS;Initial Catalog=LotusPansiyon;Integrated Security=True;TrustServerCertificate=True;");


        private void showCustomerMessage()
        {
           
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Mesajlar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                {
                    ekle.Text = oku["Mesajid"].ToString();
                    ekle.SubItems.Add(oku["AdSoyad"].ToString());
                    ekle.SubItems.Add(oku["Mesaj"].ToString());

                    CustomerMessageListView.Items.Add(ekle);

                }
              }
            baglanti.Close();
        }

        private void SaveMessageButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("İnsert into Mesajlar(AdSoyad,Mesaj) values('" + NameAndSurnameTextBox.Text + "','" + CustomerMessageRichTextBox.Text + "')", baglanti);
            komut.ExecuteReader();
            baglanti.Close();
            showCustomerMessage();

        }

        private void frmMesajlar_Load(object sender, EventArgs e)
        {
            showCustomerMessage();
        }
    }
}
