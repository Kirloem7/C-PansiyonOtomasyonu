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
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LotusPansiyonVeDinlenmeTesisleri
{
    public partial class frmYeniMusteri : Form
    {
        public frmYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-TGJGI9KG\SQLEXPRESS;Initial Catalog=LotusPansiyon;Integrated Security=True;TrustServerCertificate=True;");

        private void RoomButton1_Click(object sender, EventArgs e)
        {
            RoomNumberTextBox.Text = "101";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert  into Oda101 (Adi,Soyadi) values ('" + NameTextBox.Text + "','" + SurnameTextBox.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void RoomButton2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            RoomNumberTextBox.Text = "102";
            SqlCommand komut = new SqlCommand("insert  into Oda102 (Adi,Soyadi) values ('" + NameTextBox.Text + "','" + SurnameTextBox.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void RoomButton3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            RoomNumberTextBox.Text = "103";
            SqlCommand komut = new SqlCommand("insert  into Oda103 (Adi,Soyadi) values ('" + NameTextBox.Text + "','" + SurnameTextBox.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void RoomButton4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            RoomNumberTextBox.Text = "104";
            SqlCommand komut = new SqlCommand("insert  into Oda104 (Adi,Soyadi) values ('" + NameTextBox.Text + "','" + SurnameTextBox.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void RoomButton5_Click(object sender, EventArgs e)
        {
            baglanti.Open();   
            RoomNumberTextBox.Text = "105";
            SqlCommand komut = new SqlCommand("insert  into Oda105 (Adi,Soyadi) values ('" + NameTextBox.Text + "','" + SurnameTextBox.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void RoomButton6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            RoomNumberTextBox.Text = "106";
            SqlCommand komut = new SqlCommand("insert  into Oda106 (Adi,Soyadi) values ('" + NameTextBox.Text + "','" + SurnameTextBox.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void RoomNumber7_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            RoomNumberTextBox.Text = "107";
            SqlCommand komut = new SqlCommand("insert  into Oda107 (Adi,Soyadi) values ('" + NameTextBox.Text + "','" + SurnameTextBox.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void RoomNumber8_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            RoomNumberTextBox.Text = "108";
            SqlCommand komut = new SqlCommand("insert  into Oda108 (Adi,Soyadi) values ('" + NameTextBox.Text + "','" + SurnameTextBox.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void RoomButton9_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            RoomNumberTextBox.Text = "109";
            SqlCommand komut = new SqlCommand("insert  into Oda109 (Adi,Soyadi) values ('" + NameTextBox.Text + "','" + SurnameTextBox.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void AvailableRoomButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar boş odaları gösterir");
        }

        private void NotAvailableRoomButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösterir");
        }


        private void ExitDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Giriş ve çıkış tarihlerini al
            DateTime kucukTarih = EntryDateDateTimePicker.Value;
            DateTime buyukTarih = ExitDateDateTimePicker.Value;

            // Tarihler doğruysa
            if (kucukTarih <= buyukTarih)
            {
                // Tarihler arasındaki farkı hesapla
                TimeSpan sonuc = buyukTarih - kucukTarih;

                // Toplam gün sayısını tam sayıya dönüştür
                int gunSayisi = (int)sonuc.TotalDays;

                // Toplam ücreti hesapla (küsüratsız)
                int ucret = gunSayisi * 50;

                // Ücreti ilgili TextBox'a yazdır
                FeeTextBox.Text = ucret.ToString();

                // Toplam ücreti Label'a yazdır
                TotalFee.Text = "Toplam Ücret: " + ucret.ToString() + " TL";
            }
            else
            {
                // Hatalı tarih girişinde uyarı ver
                MessageBox.Show("Çıkış tarihi, giriş tarihinden önce olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void SaveButton_Click(object sender, EventArgs e)
        {

            baglanti.Open();


            string query = "INSERT INTO MusteriEkle (Adi, Soyadi, Cinsiyet, Telefon, Mail, TC, OdaNo, Ucret, GirisTarihi, CikisTarihi) " +
                           "VALUES (@Adi, @Soyadi, @Cinsiyet, @Telefon, @Mail, @TC, @OdaNo, @Ucret, @GirisTarihi, @CikisTarihi)";

            using (SqlCommand komut = new SqlCommand(query, baglanti))
            {

                komut.Parameters.AddWithValue("@Adi", NameTextBox.Text);
                komut.Parameters.AddWithValue("@Soyadi", SurnameTextBox.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", GenderComboBox.Text);
                komut.Parameters.AddWithValue("@Telefon", PhoneMaskedTextBox.Text);
                komut.Parameters.AddWithValue("@Mail", MailTextBox.Text);
                komut.Parameters.AddWithValue("@TC", IdentityTextBox.Text);
                komut.Parameters.AddWithValue("@OdaNo", RoomNumberTextBox.Text);
                komut.Parameters.AddWithValue("@Ucret", FeeTextBox.Text);
                komut.Parameters.AddWithValue("@GirisTarihi", DateTime.Parse(EntryDateDateTimePicker.Text));
                komut.Parameters.AddWithValue("@CikisTarihi", DateTime.Parse(ExitDateDateTimePicker.Text));

                komut.ExecuteNonQuery();
            }

            // Bağlantıyı kapat
            baglanti.Close();

            // Kullanıcıya bilgi mesajı göster
            MessageBox.Show("Kayıt başarıyla gerçekleşti");
        }

        private void frmYeniMusteri_Load(object sender, EventArgs e)
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
                RoomButton2.Enabled = false;
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
                RoomButton2.Enabled = false;
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
                RoomButton3.Enabled=false;
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
                RoomButton4.Enabled = false;
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
                RoomButton5.Enabled = false;
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
                RoomButton6.Enabled = false;
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
                RoomNumber7.Enabled = false;
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
                RoomNumber8.Enabled = false;
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
                RoomButton9.Enabled=false;
            }
        }

    }
}
        