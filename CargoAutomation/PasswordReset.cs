using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CargoAutomation {
    public partial class sifreYenilemeEkrani : Form {

        girisEkrani girisEkrani = new girisEkrani();
        public static string kod, aliciAdi;
        private string aliciEpostasi;
        private bool tutus;
        private int fareX, fareY;

        public sifreYenilemeEkrani() {
            InitializeComponent();
            kod = Code.Process.kodOlustur();
        }

        private void cikis_Click(object sender, EventArgs e) {
            this.Close();
            girisEkrani.Show();
        }

        private void altaAl_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void ara_Click(object sender, EventArgs e) {
            kullaniciAdiVeyaMailTextBox.Text = kullaniciAdiVeyaMailTextBox.Text.Trim();
            bool kayitVarMi = false;
            Kullanici kullanan = new Kullanici();
            try {
                Program.veritabani.response = await Program.veritabani.client.GetAsync("GirisBilgileri");
                Dictionary<string, Kullanici> data = JsonConvert.DeserializeObject<Dictionary<string, Kullanici>>(Program.veritabani.response.Body);
                foreach (var item in data) {
                    if (item.Key == kullaniciAdiVeyaMailTextBox.Text || item.Value.Mail == kullaniciAdiVeyaMailTextBox.Text) {
                        aliciAdi = item.Value.Ad_Soyad;
                        aliciEpostasi = item.Value.Mail;
                        kayitVarMi = true;
                        kullanan = new Kullanici() {
                            Kullanici_Adi = item.Value.Kullanici_Adi,
                            Parola = item.Value.Parola,
                            Mail = item.Value.Mail,
                            Ad_Soyad = item.Value.Ad_Soyad,
                            Telefon = item.Value.Telefon,
                            Rol = item.Value.Rol
                        };
                    }
                }
            }
            catch (Exception exception) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
            }
            if (kayitVarMi) {
                try {
                    string konu = "Şifre Yenileme Talebi";
                    string icerik = "Şifre Yenileme Kodunuz " + kod;
                    Program.mail.SendingMail("nktkargo@gmail.com", "jahriwyfjpaxluiz", "NKT Kargo", aliciEpostasi, konu, icerik);
                    kodDogrulama kodDogrulamaEkrani = new kodDogrulama(kullanan);
                    kodDogrulamaEkrani.Show();
                    this.Close();
                }catch (Exception exception) {}
            }else {
                MessageBox.Show("Kullanıcı bulunamadı");
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
