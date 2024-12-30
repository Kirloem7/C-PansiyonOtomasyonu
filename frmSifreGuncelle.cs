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
    public partial class frmSifreGuncelle : Form
    {
        public frmSifreGuncelle()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-TGJGI9KG\SQLEXPRESS;Initial Catalog=LotusPansiyon;Integrated Security=True;TrustServerCertificate=True;");

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update AdminGiris set Kullanici='" + UserNameTextBox.Text + "',Sifre='" + PasswordTextBox.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme tamamlandı.");


        }
    }
}
