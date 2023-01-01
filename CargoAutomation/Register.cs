using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using CargoAutomation.Properties;
using Newtonsoft.Json;

namespace CargoAutomation {
    public partial class kayitEkrani : Form {

        private girisEkrani girisEkrani = new girisEkrani();
        private uyeAnaSayfasi uyeAnaSayfasi = new uyeAnaSayfasi();
        private static bool sifreUygunMu;
        private bool tutus, kullaniciIsimiUygunMu, isimUygunMu, mailUygunMu, telefonUygunMu, yon = true;
        private int fareX, fareY, oncekiIndex;

        public kayitEkrani() {
            InitializeComponent();
        }

        private void cikis_Click(object sender, EventArgs e) {
            this.Close();
            girisEkrani.Show();
        }

        private void altaAl_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void telefon_TextChanged(object sender, EventArgs e) {
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
            if (sifreDogrulamaTextBox.UseSystemPasswordChar) {
                sifreDogrulamaTextBox.UseSystemPasswordChar = false;
                dogrulamaParolaGoster.Image = Resources.parolaAcik;
            }else {
                sifreDogrulamaTextBox.UseSystemPasswordChar = true;
                dogrulamaParolaGoster.Image = Resources.parolaKapali;
            }
        }

        private async void kayit_Click(object sender, EventArgs e) {
            kullaniciIsimiUygunMu = Code.Process.kullaniciAdiKontrol(kullaniciAdiTextBox.Text);
            isimUygunMu = Code.Process.adiKontrol(adiSoyadiTextBox.Text);
            mailUygunMu = Code.Process.mailKontrol(mailTextBox.Text);
            telefonUygunMu = Code.Process.telefonKontrol(telefonTextBox.Text);
            sifreUygunMu = Code.Process.sifreKontrol(sifreTextBox.Text, sifreDogrulamaTextBox.Text);
            if (kullaniciIsimiUygunMu & isimUygunMu & mailUygunMu & telefonUygunMu & sifreUygunMu) {
                bool kullaniciVarMi = false;
                try {
                    Program.veritabani.response = await Program.veritabani.client.GetAsync("GirisBilgileri");
                    Dictionary<string, Kullanici> data = JsonConvert.DeserializeObject<Dictionary<string, Kullanici>>(Program.veritabani.response.Body);
                    foreach (var item in data) {
                        if (item.Key == kullaniciAdiTextBox.Text.Trim()) {
                            kullaniciVarMi = true;
                        }
                    }
                }
                catch (Exception exception) {
                    MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
                }
                if (kullaniciVarMi) {
                    MessageBox.Show("Kullanıcı mevcut");
                }else if (!Code.Process.sifreKontrol(sifreTextBox.Text, sifreDogrulamaTextBox.Text)) {
                }else {
                    sifreTextBox.Text = sifreTextBox.Text.Trim();
                    var kullanan = new Kullanici() {
                        Kullanici_Adi = kullaniciAdiTextBox.Text.Trim(),
                        Parola = sifreTextBox.Text,
                        Mail = mailTextBox.Text.Trim(),
                        Ad_Soyad = adiSoyadiTextBox.Text.Trim(),
                        Telefon = telefonTextBox.Text.Trim(),
                        Rol = "üye" };
                    try {
                        Program.veritabani.response = await Program.veritabani.client.SetAsync("GirisBilgileri/" + kullanan.Kullanici_Adi + "/", kullanan);
                        Kullanici result = Program.veritabani.response.ResultAs<Kullanici>();
                        if (result.Kullanici_Adi != null) MessageBox.Show("Kullanıcı Ekleme İşlemi Başarılı", "Adding is Complete");
                        Program.ueSys++;
                        Program.veritabani.veriKayitEt();
                        FileStream fileStream = new FileStream(Application.StartupPath + "\\acikHesap.txt", FileMode.OpenOrCreate, FileAccess.Write);
                        StreamWriter streamWriter = new StreamWriter(fileStream);
                        streamWriter.WriteLine("üye");
                        streamWriter.WriteLine(kullaniciAdiTextBox.Text.Trim());
                        streamWriter.WriteLine(adiSoyadiTextBox.Text.Trim());
                        streamWriter.Close();
                        fileStream.Close();
                    }catch (Exception exception) {
                        MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
                    }
                    this.Close();
                    uyeAnaSayfasi.Show();
                }
            }else {
                if (!kullaniciIsimiUygunMu) kullaniciYildiz.Visible = true;
                else kullaniciYildiz.Visible = false;
                if (!isimUygunMu) adYildiz.Visible = true;
                else adYildiz.Visible = false;
                if (!mailUygunMu) mailYildiz.Visible = true;
                else mailYildiz.Visible = false;
                if (!telefonUygunMu) telefonYildiz.Visible = true;
                else telefonYildiz.Visible = false;
                if (!sifreUygunMu) {
                    sifreYildiz.Visible = true;
                    sifreDogrulamaYildiz.Visible = true;
                }else {
                    sifreYildiz.Visible = false;
                    sifreDogrulamaYildiz.Visible = false;
                }
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
