using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using CargoAutomation.Properties;
using Newtonsoft.Json;

namespace CargoAutomation {
    public partial class girisEkrani : Form {

        public bool hatirlanmaAcikMi = true;
        private bool tutus;
        private int fareX, fareY;

        public girisEkrani() {
            InitializeComponent();
        }

        private void cikis_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void parolaGoster_Click(object sender, EventArgs e) {
            if (parolaTextBox.UseSystemPasswordChar) {
                parolaTextBox.UseSystemPasswordChar = false;
                parolaGoster.Image = Resources.parolaAcik;
            }else {
                parolaTextBox.UseSystemPasswordChar = true;
                parolaGoster.Image = Resources.parolaKapali;
            }
        }

        private void beniHatirla_CheckedChanged(object sender, EventArgs e) {
            if (beniHatirlaCheckBox.Checked) {
                hatirlanmaAcikMi = true;
            }else {
                hatirlanmaAcikMi = false;
            }
        }

        private void şifreYenileme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            new sifreYenilemeEkrani().Show();
            this.Hide();
        }

        private void hesapAcma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            new kayitEkrani().Show();
            this.Hide();
        }

        private async void giris_Click(object sender, EventArgs e) {
            kullaniciAdiTextBox.Text = kullaniciAdiTextBox.Text.Trim();
            parolaTextBox.Text = parolaTextBox.Text.Trim();
            if (kullaniciAdiTextBox.Text.Length <= 21 || parolaTextBox.Text.Length <= 21) {
                bool kayitVar = false;
                try {
                    Program.veritabani.response = await Program.veritabani.client.GetAsync("GirisBilgileri");
                    Dictionary<string, Kullanici> data = JsonConvert.DeserializeObject<Dictionary<string, Kullanici>>(Program.veritabani.response.Body);
                    foreach (var item in data) {
                        if (item.Value.Kullanici_Adi == kullaniciAdiTextBox.Text && item.Value.Parola == parolaTextBox.Text) {
                            Program.rol = item.Value.Rol;
                            Program.kullaniciAdi = item.Value.Kullanici_Adi;
                            Program.kullaniciAdiSoyadi = item.Value.Ad_Soyad;
                            kayitVar = true;
                        }
                    }
                }
                catch (Exception exception) {
                    MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
                }
                if (kayitVar) {
                    if (Program.rol != "") {
                        if (Program.rol.Equals("admin")) {
                            new adminAnaSayfasi().Show();
                        }else if (Program.rol.Equals("personel")) {
                            new personelAnaSayfasi().Show();
                        }else if (Program.rol.Equals("üye")) {
                            new uyeAnaSayfasi().Show();
                        }
                        this.Hide();
                    }
                    if (hatirlanmaAcikMi) {
                        FileStream fileStream = new FileStream(Application.StartupPath + "\\acikHesap.txt", FileMode.OpenOrCreate, FileAccess.Write);
                        StreamWriter streamWriter = new StreamWriter(fileStream);
                        streamWriter.WriteLine(Program.rol);
                        streamWriter.WriteLine(Program.kullaniciAdi);
                        streamWriter.WriteLine(Program.kullaniciAdiSoyadi);
                        streamWriter.Close();
                        fileStream.Close();
                    }
                }else {
                    MessageBox.Show("Yalnış Kullanıcı Adı veya Parola");
                }
            }else {
                MessageBox.Show("Geçersiz bir kullanici adı veya şifre girdiniz");
            }
        }

        private void kullaniciGirisi_Click(object sender, EventArgs e) {
            new kullaniciAnaSayfasi().Show();
            this.Hide();
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
