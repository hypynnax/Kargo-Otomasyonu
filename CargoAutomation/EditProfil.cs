using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CargoAutomation.Properties;
using Newtonsoft.Json;

namespace CargoAutomation {
    public partial class profilDuzenlemeSayfasi : Form {

        private bool tutus, yon = true;
        private int fareX, fareY, oncekiIndex;
        private string rol;
        private string[] degerler;

        public profilDuzenlemeSayfasi(string rol, string kullanici = "") {
            InitializeComponent();
            this.rol = rol;
            hazirlik(kullanici);
        }

        public async void hazirlik(string kullanici) {
            try {
                Program.veritabani.response = await Program.veritabani.client.GetAsync("GirisBilgileri");
                Dictionary<string, Kullanici> data = JsonConvert.DeserializeObject<Dictionary<string, Kullanici>>(Program.veritabani.response.Body);
                if (kullanici != "") {
                    foreach (var item in data) {
                        if (item.Key == kullanici) {
                            degerler = new[] { item.Value.Kullanici_Adi, item.Value.Parola, item.Value.Mail, item.Value.Ad_Soyad, item.Value.Telefon, item.Value.Rol };
                        }
                    }
                }else {
                    foreach (var item in data) {
                        if (item.Key == Program.kullaniciAdi) {
                            degerler = new[] { item.Value.Kullanici_Adi, item.Value.Parola, item.Value.Mail, item.Value.Ad_Soyad, item.Value.Telefon, item.Value.Rol };
                        }
                    }
                }
                kullaniciAdiTextBox.Text = degerler[0];
                sifreTextBox.Text = degerler[1];
                sifreTekrarTextBox.Text = degerler[1];
                mailTextBox.Text = degerler[2];
                adSoyadTextBox.Text = degerler[3];
                telefonTextBox.Text = degerler[4];
            }catch (Exception e) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
            }
        }

        private void cikisButonu_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void adSoyadDuzenleButonu_Click(object sender, EventArgs e) {
            if (adSoyadTextBox.Enabled) {
                adSoyadTextBox.Enabled = false;
                adSoyadTextBox.Text = degerler[3];
                adSoyadTextBox.ForeColor = Color.Gray;
            }else {
                adSoyadTextBox.Enabled = true;
                adSoyadTextBox.Text = "";
                adSoyadTextBox.ForeColor = Color.Black;
            }
        }

        private void mailDuzenleButonu_Click(object sender, EventArgs e) {
            if (mailTextBox.Enabled) {
                mailTextBox.Enabled = false;
                mailTextBox.Text = degerler[2];
                mailTextBox.ForeColor = Color.Gray;
            }else{
                mailTextBox.Enabled = true;
                mailTextBox.Text = "";
                mailTextBox.ForeColor = Color.Black;
            }
        }

        private void telefonDuzenleButonu_Click(object sender, EventArgs e) {
            if (telefonTextBox.Enabled) {
                telefonTextBox.Enabled = false;
                telefonTextBox.Text = degerler[4];
                telefonTextBox.ForeColor = Color.Gray;
            }else {
                telefonTextBox.Enabled = true;
                telefonTextBox.Text = "";
                telefonTextBox.ForeColor = Color.Black;
            }
        }

        private void telefonTextBox_TextChanged(object sender, EventArgs e) {
            if (oncekiIndex < telefonTextBox.Text.Length) {
                yon = true;
            }else {
                yon = false;
            }
            if (yon) {
                if (telefonTextBox.Text.Length == 4 || telefonTextBox.Text.Length == 8) {
                    telefonTextBox.Text += " ";
                    telefonTextBox.Select(telefonTextBox.Text.Length, 0);
                }
                if (telefonTextBox.Text.Length == 14) {
                    telefonTextBox.Text = telefonTextBox.Text.Substring(0, 13);
                    telefonTextBox.Select(telefonTextBox.Text.Length, 0);
                }
            }
            oncekiIndex = telefonTextBox.Text.Length - 1;
        }

        private void sifreDuzenleButonu_Click(object sender, EventArgs e) {
            if (sifreTextBox.Visible) {
                sifreTextBox.Text = degerler[1];
                sifreTekrarTextBox.Text = degerler[1];
                sifreGoster.Visible = false;
                sifreTextBox.Visible = false;
                sifreTekrarGoster.Visible = false;
                sifreTekrarLabel.Visible = false;
                sifreTekrarTextBox.Visible = false;
            }else {
                sifreTextBox.Text = "";
                sifreTekrarTextBox.Text = "";
                sifreGoster.Visible = true;
                sifreTextBox.Visible = true;
                sifreTekrarGoster.Visible = true;
                sifreTekrarLabel.Visible = true;
                sifreTekrarTextBox.Visible = true;
            }
        }

        private void sifreGoster_Click(object sender, EventArgs e) {
            if (sifreTextBox.UseSystemPasswordChar) {
                sifreTextBox.UseSystemPasswordChar = false;
                sifreGoster.Image = Resources.parolaAcik;
            }else {
                sifreTextBox.UseSystemPasswordChar = true;
                sifreGoster.Image = Resources.parolaKapali;
            }
        }

        private void sifreTekrarGoster_Click(object sender, EventArgs e) {
            if (sifreTekrarTextBox.UseSystemPasswordChar) {
                sifreTekrarTextBox.UseSystemPasswordChar = false;
                sifreTekrarGoster.Image = Resources.parolaAcik;
            }else {
                sifreTekrarTextBox.UseSystemPasswordChar = true;
                sifreTekrarGoster.Image = Resources.parolaKapali;
            }
        }

        private void duzenlemeButonu_Click(object sender, EventArgs e) {
            if (Code.Process.kullaniciAdiKontrol(kullaniciAdiTextBox.Text) &&
                Code.Process.adiKontrol(adSoyadTextBox.Text) &&
                Code.Process.telefonKontrol(telefonTextBox.Text) && Code.Process.mailKontrol(mailTextBox.Text) &&
                Code.Process.sifreKontrol(sifreTextBox.Text, sifreTekrarTextBox.Text)) {
                Kullanici kullanan = new Kullanici {
                    Kullanici_Adi = kullaniciAdiTextBox.Text,
                    Parola = sifreTextBox.Text,
                    Mail = mailTextBox.Text,
                    Ad_Soyad = adSoyadTextBox.Text,
                    Telefon = telefonTextBox.Text,
                    Rol =  rol };
                UpdateUser(kullanan);
            }
        }

        public async void UpdateUser(Kullanici kullanan) {
            try {
                var response =
                    await Program.veritabani.client.UpdateAsync("GirisBilgileri/" + kullanan.Kullanici_Adi + "/",
                        kullanan);
                Kullanici result = response.ResultAs<Kullanici>();
                if (result.Kullanici_Adi != null)
                    MessageBox.Show("Profil Düzenleme İşlemi Başarılı", "Update Successful");
                else
                    MessageBox.Show("Profil Düzenleme İşlemi Başarısız", "Update Failed");
            }catch (Exception e) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
            }finally {
                this.Close();
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
