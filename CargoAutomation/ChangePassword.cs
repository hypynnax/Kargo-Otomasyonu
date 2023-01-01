using System;
using System.Windows.Forms;
using CargoAutomation.Properties;

namespace CargoAutomation {
    public partial class sifreDegistirmeEkrani : Form {

        private girisEkrani girisEkrani = new girisEkrani();
        private bool tutus;
        private int fareX, fareY;
        private Kullanici kullanan;

        public sifreDegistirmeEkrani(Kullanici kullanan) {
            InitializeComponent();
            this.kullanan = kullanan;
        }

        private void cikis_Click(object sender, EventArgs e) {
            this.Close();
            girisEkrani.Show();
        }

        private void altaAl_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void parolaGoster_Click(object sender, EventArgs e) {
            if (sifreTextBox.UseSystemPasswordChar) {
                sifreTextBox.UseSystemPasswordChar = false;
                parolaGoster.Image = Resources.parolaAcik;
            }else {
                sifreTextBox.UseSystemPasswordChar = true;
                parolaGoster.Image = Resources.parolaKapali;
            }
        }

        private void dogrulamaParolaGoster_Click(object sender, EventArgs e) {
            if (sifreTekrarTextBox.UseSystemPasswordChar) {
                sifreTekrarTextBox.UseSystemPasswordChar = false;
                dogrulamaParolaGoster.Image = Resources.parolaAcik;
            }else {
                sifreTekrarTextBox.UseSystemPasswordChar = true;
                dogrulamaParolaGoster.Image = Resources.parolaKapali;
            }
        }

        private void yenileme_Click(object sender, EventArgs e) {
            if (sifreTextBox.Text == sifreTekrarTextBox.Text) {
                if (Code.Process.sifreKontrol(sifreTextBox.Text, sifreTekrarTextBox.Text)) {
                    sifreTextBox.Text = sifreTextBox.Text.Trim();
                    kullanan.Parola = sifreTextBox.Text;
                    UpdateUser();
                    this.Close();
                    girisEkrani.Show();
                }else {
                    MessageBox.Show("Daha güvenlikli bir şifre tercih edin");
                }
            }else {
                MessageBox.Show("Girilen iki şifreninde aynı olması lazım");
            }
        }

        public async void UpdateUser() {
            try {
                var response = await Program.veritabani.client.UpdateAsync("GirisBilgileri/" + kullanan.Kullanici_Adi, kullanan);
                Kullanici result = response.ResultAs<Kullanici>();
                if (result.Kullanici_Adi != null)
                    MessageBox.Show("Şifre Değiştirme İşlemi Başarılı", "Update Successful");
                else
                    MessageBox.Show("Şifre Değiştirme İşlemi Başarısız", "Update Failed");
            }catch (Exception e) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
            }
        }

        private void kontrolPaneli_MouseMove(object sender, MouseEventArgs e) {
            if (tutus) {
                this.Left = Cursor.Position.X - fareX;
                this.Top = Cursor.Position.Y - fareY;
            }   
        }

        private void kontrolPaneli_MouseUp(object sender, MouseEventArgs e) {
            tutus = false;
            fareX = 0;
            fareY = 0;
        }

        private void kontrolPaneli_MouseDown(object sender, MouseEventArgs e) {
            tutus = true;
            fareX = Cursor.Position.X - this.Left;
            fareY = Cursor.Position.Y - this.Top;
        }
    }
}
