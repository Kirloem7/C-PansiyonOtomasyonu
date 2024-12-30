using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotusPansiyonVeDinlenmeTesisleri
{
    public partial class frmAnaForm : Form
    {
        public frmAnaForm()
        {
            InitializeComponent();
        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            frmAdminGiris fr = new frmAdminGiris();
            fr.Show();
        }

        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            frmYeniMusteri fr = new frmYeniMusteri();
            fr.Show();
        }

        private void RoomsButton_Click(object sender, EventArgs e)
        {
            frmOdalar fr = new frmOdalar();
            fr.Show();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            frmMusteriler fr = new frmMusteriler();
            fr.Show();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lotus Pansiyon Ve Dinlenme Tesisleri /2024 Marmara Adası");
        }

        private void frmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToLongDateString();
            WatchLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IncomeExpenseButton_Click(object sender, EventArgs e)
        {
            frmGelirGider fr = new frmGelirGider();
            fr.Show();
        }

        private void StocksButton_Click(object sender, EventArgs e)
        {
            frmStoklar fr = new frmStoklar();
            fr.Show();
        }

        private void UseTheRadioButton_Click(object sender, EventArgs e)
        {
            frmRadyoDinle fr = new frmRadyoDinle();
            fr.Show();
        }

        private void NewspaperButton_Click(object sender, EventArgs e)
        {
            frmGazeteler fr = new frmGazeteler();
            fr.Show();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            frmSifreGuncelle fr = new frmSifreGuncelle();
            fr.Show();
        }

        private void CustomerMessagesButton_Click(object sender, EventArgs e)
        {
            frmMesajlar fr = new frmMesajlar();
            fr.Show();
        }
    }
}
