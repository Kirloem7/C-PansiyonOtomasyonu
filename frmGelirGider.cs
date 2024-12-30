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
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace LotusPansiyonVeDinlenmeTesisleri
{
    public partial class frmGelirGider : Form
    {
        public frmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-TGJGI9KG\SQLEXPRESS;Initial Catalog=LotusPansiyon;Integrated Security=True;TrustServerCertificate=True;");

        private void CalculateButton_Click(object sender, EventArgs e)
        {

            int personel = Convert.ToInt16(StaffNumberTextBox.Text);
            StaffWagesCost.Text = (personel * 1500).ToString();




            // Helper method to handle possible commas (for non-US cultures)
            decimal ConvertToDecimal(string value)
            {
                value = value.Replace(",", ".");  // Virgülü noktaya dönüştür
                decimal result;
                // Sayıyı Decimal türüne dönüştürmeye çalışıyoruz
                if (decimal.TryParse(value, out result))
                {
                    return result;
                }
                else
                {
                    // Eğer geçerli bir sayı değilse, 0 döndürüyoruz
                    return 0;
                }
            }

            // Hesaplamalar için güncellenmiş kod
            decimal sonuc;
            sonuc = ConvertToDecimal(TotalCostLabel.Text) -
                    ConvertToDecimal(StaffNumberLabel.Text) +
                    ConvertToDecimal(FoodCostsLabel.Text) +
                    ConvertToDecimal(DrinksCostsLabel.Text) +
                    ConvertToDecimal(TotalSnacksCostsLabel.Text) +
                    ConvertToDecimal(InternetBillsCostsLabel.Text) +
                    ConvertToDecimal(WaterBillsCostsLabel.Text) +
                    ConvertToDecimal(ElectricBillsCostsLabel.Text);

            // Sonucu string'e çevirip ResultLabel'a atıyoruz
            ResultCostLabel.Text = sonuc.ToString("N2"); // İki ondalıklı formatla göster




















        }

        private void frmGelirGider_Load(object sender, EventArgs e)
        {

            // Veritabanı bağlantısını aç
            baglanti.Open();

            // SQL komutunu düzelt
            SqlCommand komut = new SqlCommand("SELECT SUM(Ucret) AS Toplam FROM MusteriEkle", baglanti);

            // Komutu çalıştır ve sonucu oku
            SqlDataReader oku = komut.ExecuteReader();

            // Sonuçları işle
            if (oku.Read())  // Veritabanında veri varsa
            {
                TotalCostLabel.Text = oku["Toplam"].ToString();
            }
            else
            {
                TotalCostLabel.Text = "0";  // Eğer sonuç yoksa
            }

            // Bağlantıyı kapat
            baglanti.Close();


            // Veritabanı bağlantısını aç
            baglanti.Open();

            // SQL komutunu düzelt
            SqlCommand komut2 = new SqlCommand("SELECT SUM(Gıda) AS Toplam1 FROM Stoklar", baglanti);

            // Komutu çalıştır ve sonucu oku
            SqlDataReader oku2 = komut2.ExecuteReader();

            // Sonuçları işle
            if (oku2.Read())  // Veritabanında veri varsa
            {
                FoodCostsLabel.Text = oku2["Toplam1"].ToString();
            }
            else
            {
                FoodCostsLabel.Text = "0";  // Eğer sonuç yoksa
            }

            // Bağlantıyı kapat
            baglanti.Close();




            // Veritabanı bağlantısını aç
            baglanti.Open();

            // SQL komutunu düzelt
            SqlCommand komut3 = new SqlCommand("SELECT SUM(Icecek) AS Toplam2 FROM Stoklar", baglanti);

            // Komutu çalıştır ve sonucu oku
            SqlDataReader oku3 = komut3.ExecuteReader();

            // Sonuçları işle
            if (oku3.Read())  // Veritabanında veri varsa
            {
                DrinksCostsLabel.Text = oku3["Toplam2"].ToString();
            }
            else
            {
                DrinksCostsLabel.Text = "0";  // Eğer sonuç yoksa
            }

            // Bağlantıyı kapat
            baglanti.Close();



            // Veritabanı bağlantısını aç
            baglanti.Open();

            // SQL komutunu düzelt
            SqlCommand komut4 = new SqlCommand("SELECT SUM(Cerezler) AS Toplam3 FROM Stoklar", baglanti);

            // Komutu çalıştır ve sonucu oku
            SqlDataReader oku4 = komut4.ExecuteReader();

            // Sonuçları işle
            if (oku4.Read())  // Veritabanında veri varsa
            {
                TotalSnacksCostsLabel.Text = oku4["Toplam3"].ToString();
            }
            else
            {
                TotalSnacksCostsLabel.Text = "0";  // Eğer sonuç yoksa
            }

            // Bağlantıyı kapat
            baglanti.Close();







            // Veritabanı bağlantısını aç
            baglanti.Open();

            // SQL komutunu düzelt
            SqlCommand komut5 = new SqlCommand("SELECT SUM(Elektrik) AS Toplam4 FROM Faturalar", baglanti);

            // Komutu çalıştır ve sonucu oku
            SqlDataReader oku5 = komut5.ExecuteReader();

            // Sonuçları işle
            if (oku5.Read())  // Veritabanında veri varsa
            { 
                ElectricBillsCostsLabel.Text = oku5["Toplam4"].ToString();
            } 
            else
            {
               ElectricBillsCostsLabel.Text = "0";  // Eğer sonuç yoksa
            }

            // Bağlantıyı kapat
            baglanti.Close();




            // Veritabanı bağlantısını aç
            baglanti.Open();

            // SQL komutunu düzelt
            SqlCommand komut6 = new SqlCommand("SELECT SUM(Elektrik) AS Toplam5 FROM Faturalar", baglanti);

            // Komutu çalıştır ve sonucu oku
            SqlDataReader oku6 = komut6.ExecuteReader();

            // Sonuçları işle
            if (oku6.Read())  // Veritabanında veri varsa
            {
               WaterBillsCostsLabel.Text = oku6["Toplam5"].ToString();
            }
            else
            {
                WaterBillsCostsLabel.Text = "0";  // Eğer sonuç yoksa
            }

            // Bağlantıyı kapat
            baglanti.Close();



            // Veritabanı bağlantısını aç
            baglanti.Open();

            // SQL komutunu düzelt
            SqlCommand komut7 = new SqlCommand("SELECT SUM(Elektrik) AS Toplam6 FROM Faturalar", baglanti);

            // Komutu çalıştır ve sonucu oku
            SqlDataReader oku7 = komut7.ExecuteReader();

            // Sonuçları işle
            if (oku7.Read())  // Veritabanında veri varsa
            {
                InternetBillsCostsLabel.Text = oku7["Toplam6"].ToString();
            }
            else
            {
                InternetBillsCostsLabel.Text = "0";  // Eğer sonuç yoksa
            }

            // Bağlantıyı kapat
            baglanti.Close();
            
            
                int personel;
                // Eğer kutu boş değilse, değeri int'e dönüştürmeye çalışalım
                if (int.TryParse(StaffNumberTextBox.Text, out personel))
                {
                    // Başarılı bir dönüşüm yaptıysak, maaşı hesaplayalım
                    StaffWagesCost.Text = (personel * 1500).ToString();
                }
             

        }

    }
}