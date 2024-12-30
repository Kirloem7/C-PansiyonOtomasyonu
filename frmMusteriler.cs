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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-TGJGI9KG\SQLEXPRESS;Initial Catalog=LotusPansiyon;Integrated Security=True;TrustServerCertificate=True;");

        private void ShowCustomerInfo()
        {
            try
            {
                // Veritabanı bağlantısını açıyoruz
                baglanti.Open();

                // CustomerInfoListView içeriğini temizliyoruz (Başlıklar korunur, öğeler temizlenir)
                CustomerInfoListView.Items.Clear();

                // SQL komutunu oluşturuyoruz
                SqlCommand komut = new SqlCommand("SELECT * FROM MusteriEkle", baglanti);

                // Komutu çalıştırıyoruz ve verileri alıyoruz
                SqlDataReader oku = komut.ExecuteReader();

                // Okuma işlemi başlatıyoruz
                while (oku.Read())
                {
                    // Yeni bir ListViewItem oluşturuyoruz
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["Musteriid"].ToString();  // Musteriid ilk sütun olarak

                    // Diğer sütunları ekliyoruz
                    ekle.SubItems.Add(oku["Adi"].ToString());
                    ekle.SubItems.Add(oku["Soyadi"].ToString());
                    ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                    ekle.SubItems.Add(oku["Telefon"].ToString());
                    ekle.SubItems.Add(oku["Mail"].ToString());
                    ekle.SubItems.Add(oku["TC"].ToString());
                    ekle.SubItems.Add(oku["OdaNo"].ToString());
                    ekle.SubItems.Add(oku["Ucret"].ToString());
                    ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                    ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                    // Veriyi ListView'e ekliyoruz
                    CustomerInfoListView.Items.Add(ekle);
                }

                // Okuma işlemini sonlandırıyoruz
                oku.Close();
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj gösteriyoruz
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Veritabanı bağlantısını her durumda kapatıyoruz
                baglanti.Close();
            }
        }

        private void ShowInfoButton_Click(object sender, EventArgs e)
        {
            ShowCustomerInfo();  // Verileri göster butonuna tıklanınca verileri göster
        }

        int id = 0;
        private void CustomerInfoListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerInfoListView.SelectedItems.Count > 0)  // Seçili bir öğe varsa işlem yap
            {
                id = int.Parse(CustomerInfoListView.SelectedItems[0].SubItems[0].Text);  // Seçilen id'yi al
                NameTextBox.Text = CustomerInfoListView.SelectedItems[0].SubItems[1].Text;
                SurnameTextBox.Text = CustomerInfoListView.SelectedItems[0].SubItems[2].Text;
                GenderComboBox.Text = CustomerInfoListView.SelectedItems[0].SubItems[3].Text;
                PhoneMaskedTextBox.Text = CustomerInfoListView.SelectedItems[0].SubItems[4].Text;
                MailTextBox.Text = CustomerInfoListView.SelectedItems[0].SubItems[5].Text;
                IdentityTextBox.Text = CustomerInfoListView.SelectedItems[0].SubItems[6].Text;
                RoomNumberTextBox.Text = CustomerInfoListView.SelectedItems[0].SubItems[7].Text;
                FeeTextBox.Text = CustomerInfoListView.SelectedItems[0].SubItems[8].Text;
                EntryDateDateTimePicker.Text = CustomerInfoListView.SelectedItems[0].SubItems[9].Text;
                ExitDateDateTimePicker.Text = CustomerInfoListView.SelectedItems[0].SubItems[10].Text;
            }
        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (id != 0)  // Seçilen bir müşteri olup olmadığını kontrol et
            {
                try
                {
                    // Sayısal verileri doğrulama
                    if (!int.TryParse(RoomNumberTextBox.Text, out int odaNo))
                    {
                        MessageBox.Show("Oda numarası geçerli bir sayı olmalıdır.");
                        return;
                    }

                    if (!decimal.TryParse(FeeTextBox.Text, out decimal ucret))
                    {
                        MessageBox.Show("Ücret geçerli bir sayı olmalıdır.");
                        return;
                    }

                    baglanti.Open();

                    // Update sorgusunu parametreli olarak yazıyoruz
                    SqlCommand komut = new SqlCommand("UPDATE MusteriEkle SET Adi = @Adi, Soyadi = @Soyadi, Cinsiyet = @Cinsiyet, Telefon = @Telefon, Mail = @Mail, TC = @TC, OdaNo = @OdaNo, Ucret = @Ucret, GirisTarihi = @GirisTarihi, CikisTarihi = @CikisTarihi WHERE Musteriid = @Musteriid", baglanti);

                    // Parametreleri ekliyoruz
                    komut.Parameters.AddWithValue("@Adi", NameTextBox.Text);
                    komut.Parameters.AddWithValue("@Soyadi", SurnameTextBox.Text);
                    komut.Parameters.AddWithValue("@Cinsiyet", GenderComboBox.Text);
                    komut.Parameters.AddWithValue("@Telefon", PhoneMaskedTextBox.Text);
                    komut.Parameters.AddWithValue("@Mail", MailTextBox.Text);
                    komut.Parameters.AddWithValue("@TC", IdentityTextBox.Text);
                    komut.Parameters.AddWithValue("@OdaNo", odaNo);  // OdaNo'yu sayısal olarak gönderiyoruz
                    komut.Parameters.AddWithValue("@Ucret", ucret);  // Ucreti sayısal olarak gönderiyoruz
                    komut.Parameters.AddWithValue("@GirisTarihi", EntryDateDateTimePicker.Value);
                    komut.Parameters.AddWithValue("@CikisTarihi", ExitDateDateTimePicker.Value);
                    komut.Parameters.AddWithValue("@Musteriid", id);  // Güncellenmesi gereken müşteri id'si

                    // Sorguyu çalıştırıyoruz
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Müşteri başarıyla güncellendi.");

                    baglanti.Close();

                    // Güncel veriyi tekrar gösteriyoruz
                    ShowCustomerInfo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir müşteri seçin.");
            }
        }



        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string roomNumber = RoomNumberTextBox.Text;

            // Oda numarasını 101'den 109'a kadar kontrol ediyoruz
            if (int.TryParse(roomNumber, out int roomNum) && roomNum >= 101 && roomNum <= 109)
            {
                try
                {
                    // Veritabanı bağlantısını açıyoruz
                    baglanti.Open();

                    // Oda adını dinamik olarak değiştiriyoruz
                    SqlCommand komut = new SqlCommand($"DELETE FROM Oda{roomNum}", baglanti);
                    komut.ExecuteNonQuery();

                    MessageBox.Show($"Oda{roomNum} başarıyla silindi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                    ShowCustomerInfo();  // Güncel bilgileri göster
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir oda numarası girin (101-109).");
            }

            // Müşteri ID'sine göre silme işlemi
            if (id != 0)
            {
                try
                {
                    baglanti.Open();

                    SqlCommand komut = new SqlCommand("DELETE FROM MusteriEkle WHERE Musteriid = @Musteriid", baglanti);
                    komut.Parameters.AddWithValue("@Musteriid", id);  // Parametre ekliyoruz
                    komut.ExecuteNonQuery();  // Sorguyu çalıştırıyoruz

                    MessageBox.Show("Müşteri başarıyla silindi.");

                    baglanti.Close();

                    ShowCustomerInfo();  // Verileri tekrar gösteriyoruz
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir müşteri seçin.");
            }
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Tüm metin kutularını temizliyoruz
            NameTextBox.Clear();
            SurnameTextBox.Clear();
            GenderComboBox.Text = "";
            PhoneMaskedTextBox.Clear();
            MailTextBox.Clear();
            IdentityTextBox.Clear();
            RoomNumberTextBox.Clear();
            FeeTextBox.Clear();
            EntryDateDateTimePicker.Value = DateTime.Now;
            ExitDateDateTimePicker.Value = DateTime.Now;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Veritabanı bağlantısını açıyoruz
                baglanti.Open();

                // CustomerInfoListView içeriğini temizliyoruz (Başlıklar korunur, öğeler temizlenir)
                CustomerInfoListView.Items.Clear();

                // SQL komutunu parametreli olarak oluşturuyoruz
                string sqlQuery = "SELECT * FROM MusteriEkle WHERE Adi LIKE @Adi";

                // Komutu oluşturuyoruz ve parametreyi ekliyoruz
                SqlCommand komut = new SqlCommand(sqlQuery, baglanti);
                komut.Parameters.AddWithValue("@Adi", "%" + SearchTextBox.Text + "%");

                // Komutu çalıştırıyoruz ve verileri alıyoruz
                SqlDataReader oku = komut.ExecuteReader();

                // Okuma işlemi başlatıyoruz
                while (oku.Read())
                {
                    // Yeni bir ListViewItem oluşturuyoruz
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["Musteriid"].ToString();  // Musteriid ilk sütun olarak

                    // Diğer sütunları ekliyoruz
                    ekle.SubItems.Add(oku["Adi"].ToString());
                    ekle.SubItems.Add(oku["Soyadi"].ToString());
                    ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                    ekle.SubItems.Add(oku["Telefon"].ToString());
                    ekle.SubItems.Add(oku["Mail"].ToString());
                    ekle.SubItems.Add(oku["TC"].ToString());
                    ekle.SubItems.Add(oku["OdaNo"].ToString());
                    ekle.SubItems.Add(oku["Ucret"].ToString());
                    ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                    ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                    // Veriyi ListView'e ekliyoruz
                    CustomerInfoListView.Items.Add(ekle);
                }

                // Okuma işlemini sonlandırıyoruz
                oku.Close();
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj gösteriyoruz
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Veritabanı bağlantısını her durumda kapatıyoruz
                baglanti.Close();
            }
        }
    }
}
