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
    public partial class frmAdminGiris : Form
    {
        public frmAdminGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-TGJGI9KG\SQLEXPRESS;Initial Catalog=LotusPansiyon;Integrated Security=True;TrustServerCertificate=True;");
        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Veritabanı bağlantısını açıyoruz
                baglanti.Open();

                // SQL sorgusunu oluşturuyoruz
                string sql = "select * from AdminGiris where Kullanici=@Kullanici AND Sifre=@Sifresi";

                // Parametreleri tanımlıyoruz
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@Kullanici", UserNameTextBox.Text);
                komut.Parameters.AddWithValue("@Sifre", PasswordTextBox.Text);

                // Veri çekme işlemi
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                // Sonuç kontrolü
                if (dt.Rows.Count > 0)
                {
                    // Başarılı giriş, ana formu açıyoruz
                    frmAnaForm fr = new frmAnaForm();
                    fr.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                }
            }
            catch (Exception ex)
            {
                // Hata mesajını gösteriyoruz
                MessageBox.Show("Hatalı giriş!" );
            }
            finally
            {
                // Bağlantıyı kapatıyoruz (opsiyonel, ancak iyi bir uygulamadır)
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }
    }
}
