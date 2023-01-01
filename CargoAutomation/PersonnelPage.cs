using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CargoAutomation {
    public partial class personelAnaSayfasi : Form {

        private kullaniciSilmeSayfasi uyeSil;
        private bool tutus, buyukboy = false, gonderenYon = true, aliciYon = true, gonderilenSube = false, kategori = false, gonderimTuru = false;
        private int fareX, fareY, gonderenOncekiIndex, aliciOncekiIndex;
        private double ucret;

        public personelAnaSayfasi() {
            InitializeComponent();
            this.Width = SystemInformation.PrimaryMonitorSize.Width - 52;
            this.Height = SystemInformation.PrimaryMonitorSize.Height - 57;
            timer.Start();
            ComboBoxFill();
        }

        public async void ComboBoxFill() {
            try {
                Program.veritabani.response = await Program.veritabani.client.GetAsync("Subelerimiz");
                Dictionary<string, Sehirler> data = JsonConvert.DeserializeObject<Dictionary<string, Sehirler>>(Program.veritabani.response.Body);
                foreach (var item in data) {
                    if (!gonderilenSubeComboBox.Items.Contains((item.Value.il_ad + " " + item.Value.ilce_ad).ToUpper())) {
                        gonderilenSubeComboBox.Items.Add((item.Value.il_ad + " " + item.Value.ilce_ad).ToUpper());
                    }
                }
            }catch (Exception e) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
            }
        }

        private void timer_Tick(object sender, EventArgs e) {
            tarih.Text = DateTime.Now.ToShortDateString();
            saat.Text = DateTime.Now.ToShortTimeString();
        }

        private void cikis_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void altaAl_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool adresKontrol(string adres) {
            adres = adres.Trim();
            if (adres.Length == 0 || adres.Length > 150) return false;
            return true;
        }

        private void gonderenTelefonTextBox_TextChanged(object sender, EventArgs e) {
            if (gonderenOncekiIndex < gonderenTelefonTextBox.Text.Length) {
                gonderenYon = true;
            }else {
                gonderenYon = false;
            }
            if (gonderenYon) {
                if (gonderenTelefonTextBox.Text.Length == 4 || gonderenTelefonTextBox.Text.Length == 8) {
                    gonderenTelefonTextBox.Text += " ";
                    gonderenTelefonTextBox.Select(gonderenTelefonTextBox.Text.Length, 0);
                }
                if (gonderenTelefonTextBox.Text.Length == 14) {
                    gonderenTelefonTextBox.Text = gonderenTelefonTextBox.Text.Substring(0, 13);
                    gonderenTelefonTextBox.Select(gonderenTelefonTextBox.Text.Length, 0);
                }
            }
            gonderenOncekiIndex = gonderenTelefonTextBox.Text.Length - 1;
        }

        private void aliciTelefonTextBox_TextChanged(object sender, EventArgs e) {
            if (aliciOncekiIndex < aliciTelefonTextBox.Text.Length) {
                aliciYon = true;
            }else {
                aliciYon = false;
            }
            if (aliciYon) {
                if (aliciTelefonTextBox.Text.Length == 4 || aliciTelefonTextBox.Text.Length == 8) {
                    aliciTelefonTextBox.Text += " ";
                    aliciTelefonTextBox.Select(aliciTelefonTextBox.Text.Length, 0);
                }
                if (aliciTelefonTextBox.Text.Length == 14) {
                    aliciTelefonTextBox.Text = aliciTelefonTextBox.Text.Substring(0, 13);
                    aliciTelefonTextBox.Select(aliciTelefonTextBox.Text.Length, 0);
                }
            }
            aliciOncekiIndex = aliciTelefonTextBox.Text.Length - 1;
        }

        private void gonderilenSubeComboBox_Leave(object sender, EventArgs e) {
            if (gonderilenSubeComboBox.Text == "Gonderilecek Şubeyi Seçin") {
                gonderilenSube = false;
                gonderilenSubeComboBox.ForeColor = Color.DimGray;
            }else {
                gonderilenSube = true;
                gonderilenSubeComboBox.ForeColor = Color.Black;
            }
        }

        private void kategoriComboBox_Leave(object sender, EventArgs e) {
            if (kategoriComboBox.Text == "Kategori Seçin") {
                kategori = false;
                kategoriComboBox.ForeColor = Color.DimGray;
            }else {
                kategori = true;
                kategoriComboBox.ForeColor = Color.Black;
            }
        }

        private bool agirlikKontrol() {
            if (agirlikTextBox.Text.Length != 0) {
                for (int i = 0; i < agirlikTextBox.Text.Length; i++) {
                    if (!char.IsDigit(agirlikTextBox.Text[i])) return false;
                }
                return true;
            }
            return false;
        }

        private bool enBoyyukseklik(string deger) {
            if (deger.Length != 0) {
                for (int i = 0; i < deger.Length; i++) {
                    if (!char.IsDigit(deger[i])) return false;
                }
                return true;
            }
            return false;
        }

        private void ucretHesapla() {
            int agirlik = Convert.ToInt32(agirlikTextBox.Text);
            if (paketKoliCheckBox.Checked) {
                double desi = Convert.ToDouble(enTextBox.Text) * Convert.ToDouble(boyTextBox.Text) * Convert.ToDouble(yukseklikTextBox.Text) / 1000;
                double ekUcret;
                if (desi > agirlik) ekUcret = desi * 35;
                else ekUcret = agirlik * 10;
                double kdvMiktari = ekUcret / 10 * 2;
                ucret += kdvMiktari + ekUcret;
            }else ucret = agirlik;
        }

        private void zarfDosyaCheckBox_CheckedChanged(object sender, EventArgs e) {
            enLabel.Visible = false;
            enTextBox.Visible = false;
            enCinsi.Visible = false;
            enYildiz.Visible = false;
            boyLabel.Visible = false;
            boyTextBox.Visible = false;
            boyCinsi.Visible = false;
            boyYildiz.Visible = false;
            yukseklikLabel.Visible = false;
            yukseklikTextBox.Visible = false;
            yukseklikCinsi.Visible = false;
            yukseklikYildiz.Visible = false;
            gonderimTuru = true;
        }

        private void paketKoliCheckBox_CheckedChanged(object sender, EventArgs e) {
            enLabel.Visible = true;
            enTextBox.Visible = true;
            enCinsi.Visible = true;
            boyLabel.Visible = true;
            boyTextBox.Visible = true;
            boyCinsi.Visible = true;
            yukseklikLabel.Visible = true;
            yukseklikTextBox.Visible = true;
            yukseklikCinsi.Visible = true;
            gonderimTuru = true;
        }

        private async void gonderButonu_Click(object sender, EventArgs e) {
            if (!Code.Process.kullaniciAdiKontrol(gonderenAdiTextBox.Text)) gonderenAdYildiz.Visible = true;
            else gonderenAdYildiz.Visible = false;

            if (!adresKontrol(gonderenAdresiTextBox.Text)) gonderenAdresYildiz.Visible = true;
            else gonderenAdresYildiz.Visible = false;

            if (!Code.Process.telefonKontrol(gonderenTelefonTextBox.Text)) gonderenTelefonYildiz.Visible = true;
            else gonderenTelefonYildiz.Visible = false;

            if (!Code.Process.mailKontrol(gonderenMailTextBox.Text)) gonderenMailYildiz.Visible = true;
            else gonderenMailYildiz.Visible = false;

            if (!Code.Process.kullaniciAdiKontrol(aliciAdiTextBox.Text)) aliciAdYildiz.Visible = true;
            else aliciAdYildiz.Visible = false;

            if (!adresKontrol(aliciAdresiTextBox.Text)) aliciAdresYildiz.Visible = true;
            else aliciAdresYildiz.Visible = false;

            if (!Code.Process.telefonKontrol(aliciTelefonTextBox.Text)) aliciTelefonYildiz.Visible = true;
            else aliciTelefonYildiz.Visible = false;

            if (!Code.Process.mailKontrol(aliciMailTextBox.Text)) aliciMailYildiz.Visible = true;
            else aliciMailYildiz.Visible = false;

            if (!gonderilenSube) gonderilenSubeYildiz.Visible = true;
            else gonderilenSubeYildiz.Visible = false;

            if (!kategori) kategoriYildiz.Visible = true;
            else kategoriYildiz.Visible = false;

            if (!agirlikKontrol()) agirlikYildiz.Visible = true;
            else agirlikYildiz.Visible = false;

            if (!gonderimTuru) gonderimTuruYildiz.Visible = true;
            else gonderimTuruYildiz.Visible = false;

            if (enTextBox.Visible) {
                if (!enBoyyukseklik(enTextBox.Text)) enYildiz.Visible = true;
                else enYildiz.Visible = false;

                if (!enBoyyukseklik(boyTextBox.Text)) boyYildiz.Visible = true;
                else boyYildiz.Visible = false;

                if (!enBoyyukseklik(yukseklikTextBox.Text)) yukseklikYildiz.Visible = true;
                else yukseklikYildiz.Visible = false;
            }

            string kod = Code.Process.kodOlustur();
            bool uygun = Code.Process.kullaniciAdiKontrol(gonderenAdiTextBox.Text) && adresKontrol(gonderenAdresiTextBox.Text) &&
                         Code.Process.mailKontrol(gonderenMailTextBox.Text) && Code.Process.telefonKontrol(gonderenTelefonTextBox.Text) &&
                         Code.Process.kullaniciAdiKontrol(aliciAdiTextBox.Text) && adresKontrol(aliciAdresiTextBox.Text) &&
                         Code.Process.mailKontrol(aliciMailTextBox.Text) && Code.Process.telefonKontrol(aliciTelefonTextBox.Text) && gonderilenSube &&
                         kategori && gonderimTuru && agirlikKontrol();
            if (uygun) {
                ucretHesapla();
                var kargo = new Kargo() {
                    Gonderen_Adi = gonderenAdiTextBox.Text.ToUpper(),
                    Gonderen_Adresi = gonderenAdresiTextBox.Text.ToUpper(),
                    Gonderen_Maili = gonderenMailTextBox.Text.ToUpper(),
                    Gonderen_Telefon = gonderenTelefonTextBox.Text.ToUpper(),
                    Alici_Adi = aliciAdiTextBox.Text.ToUpper(),
                    Alici_Adresi = aliciAdresiTextBox.Text.ToUpper(),
                    Alici_Maili = aliciMailTextBox.Text.ToUpper(),
                    Alici_Telefon = aliciTelefonTextBox.Text.ToUpper(),
                    Gonderim_Tarihi = gonderimTarihiDateTimePicker.Value.ToShortDateString(),
                    Teslimat_Tarihi = "",
                    Durumu = "TESLİM ALINDI",
                    Yeri = gonderilenSubeComboBox.Text.ToUpper(),
                    Ucreti = ucret.ToString().ToUpper(),
                    Agırlıgı = agirlikTextBox.Text.ToUpper(),
                    Kategorisi = kategoriComboBox.Text.ToUpper(),
                    Gonderi_Numarasi = kod };
                Program.veritabani.response = await Program.veritabani.client.SetAsync("TumKargolar/" + kargo.Gonderi_Numarasi + "/", kargo);
                MessageBox.Show("Kargo gönderme işlemi başarılı");
                Program.aktfKrgSys++;
                Program.veritabani.veriKayitEt();
                sifirla();
                try {
                    string konu = "Gönderi Bilgilendirme";
                    string icerik = "Gönderi Numaranız " + kod;
                    Program.mail.SendingMail("nktkargo@gmail.com", "jahriwyfjpaxluiz", "NKT Kargo", gonderenMailTextBox.Text.Trim(), konu, icerik);
                    Program.mail.SendingMail("nktkargo@gmail.com", "jahriwyfjpaxluiz", "NKT Kargo", aliciMailTextBox.Text.Trim(), konu, icerik);
                }catch (Exception exception) { }
                MessageBox.Show(ucret + "TL", "ÜCRET");
            }else {
                MessageBox.Show("Tüm bilgileri doğru girdiğinizden emin olun!!!");
            }
        }

        private void postaGonderButonu_Click(object sender, EventArgs e) {
            if (!(uyeSil == null || uyeSil.IsDisposed)) {
                uyeSil.Close();
            }
            sifirla();
            kargoGondermeSayfasi.Visible = true;
            postaGonderArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            postaGonderButonu.BackColor = Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            uyeSilArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            uyeSilButonu.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
        }

        private void uyeSilButonu_Click(object sender, EventArgs e) {
            if (kargoGondermeSayfasi.Visible) {
                kargoGondermeSayfasi.Visible = false;
            }
            uyeSil = new kullaniciSilmeSayfasi();
            uyeSil.Show();
            uyeSil.Location = new Point(100, 51);
            postaGonderArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            postaGonderButonu.BackColor = Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            uyeSilArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            uyeSilButonu.BackColor = Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
        }

        public void sifirla() {
            gonderenAdiTextBox.Text = "";
            gonderenMailTextBox.Text = "";
            gonderenTelefonTextBox.Text = "";
            gonderenAdresiTextBox.Text = "";
            aliciAdiTextBox.Text = "";
            aliciMailTextBox.Text = "";
            aliciTelefonTextBox.Text = "";
            aliciAdresiTextBox.Text = "";
            gonderilenSubeComboBox.Text = "";
            gonderilenSube = false;
            kategoriComboBox.Text = "";
            kategori = false;
            agirlikTextBox.Text = "";
            gonderimTarihiDateTimePicker.Text = "";
            zarfDosyaCheckBox.Checked = false;
            paketKoliCheckBox.Checked = false;
            gonderimTuru = false;
            enTextBox.Text = "";
            boyTextBox.Text = "";
            yukseklikTextBox.Text = "";
        }

        private void oturumKapatmaButonu_Click(object sender, EventArgs e) {
            DialogResult sonuc = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?\nÇıkış yaparsanız tekrar şifre ile giriş yapmanız gerekecek", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes) {
                this.Close();
                File.Delete(Application.StartupPath + "\\acikHesap.txt");
                new girisEkrani().Show();
            }
        }
    }
}
