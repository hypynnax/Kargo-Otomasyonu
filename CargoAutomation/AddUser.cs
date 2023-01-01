using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CargoAutomation {
    public partial class kullaniciEklemeSayfasi : Form {

        private int fareX, fareY, oncekiIndex;
        private bool tutus, kullaniciAdiUygun = false, mailUygun = false, adSoyadUygun = false, telefonUygun = true, rolUygun = false, yon = true;
        private string sifre, rol;

        public kullaniciEklemeSayfasi() {
            InitializeComponent();
        }

        private void cikisButonu_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void statuGrubuEkle_Leave(object sender, EventArgs e) {
            rol = "";
            if (adminRadioButton.Checked) {
                rol = "admin";
                rolUygun = true;
            }else if (personelRadioButton.Checked) {
                rol = "personel";
                rolUygun = true;
            }else if (uyeRadioButton.Checked) {
                rol = "üye";
                rolUygun = true;
            }else {
                rolUygun = false;
            }
            if (kullaniciAdiUygun && mailUygun && adSoyadUygun && rolUygun) ekleButonu.Enabled = true;
        }

        private async void kullaniciAdiTextBox_Leave(object sender, EventArgs e) {
            kullaniciAdiTextBox.Text = kullaniciAdiTextBox.Text.Trim();
            bool kullaniciVarMi = false;
            try {
                Program.veritabani.response = await Program.veritabani.client.GetAsync("GirisBilgileri");
                Dictionary<string, Kullanici> data = JsonConvert.DeserializeObject<Dictionary<string, Kullanici>>(Program.veritabani.response.Body);
                foreach (var item in data) {
                    if (item.Value.Kullanici_Adi == kullaniciAdiTextBox.Text) {
                        kullaniciVarMi = true;
                    }
                }
            }catch (Exception exception) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
            }
            if (kullaniciVarMi) MessageBox.Show("Kullanıcı mevcut");
            kullaniciAdiUygun = Code.Process.kullaniciAdiKontrol(kullaniciAdiTextBox.Text);
            if (!kullaniciAdiUygun) kullaniciAdiArkaPlanSerit.BackColor = Color.FromArgb(((int)((byte)(0))), ((int)((byte)(255))), ((int)((byte)(255))));
            else kullaniciAdiArkaPlanSerit.BackColor = Color.FromArgb(((int)((byte)(33))), ((int)((byte)(35))), ((int)((byte)(40))));
            if (kullaniciAdiUygun && mailUygun && adSoyadUygun && rolUygun) ekleButonu.Enabled = true;
        }

        private void sifreHazirlamaButonu_Click(object sender, EventArgs e) {
            Random random = new Random();
            string sifre;
            while (true) {
                int numberOfNumbers = 0, numberOfUpperLetters = 0, numberOfLowerLetters = 0;
                sifre = "";
                while (sifre.Length <= 7) {
                    Thread.Sleep(10);
                    int number = random.Next(48, 123);
                    if (!((number >= 58 && number <= 64) || (number >= 91 && number <= 96))) {
                        sifre += (char)number;
                    }
                }
                for (int i = 0; i < sifre.Length; i++) {
                    if (char.IsDigit(sifre[i])) {
                        numberOfNumbers += 1;
                    }
                    if (char.IsLower(sifre[i])) {
                        numberOfLowerLetters += 1;
                    }
                    if (char.IsLetter(sifre[i])) {
                        numberOfUpperLetters += 1;
                    }
                }
                if (sifre.Length == 8 && numberOfNumbers >= 2 && numberOfUpperLetters >= 1 && numberOfLowerLetters >= 1) {
                    break;
                }
            }
            this.sifre = sifre;
            sifreTextBox.Text = sifre;
        }

        private void mailTextBox_Leave(object sender, EventArgs e) {
            mailTextBox.Text = mailTextBox.Text.Trim();
            mailUygun = false;
            try {
                MailAddress mailAddress = new MailAddress(mailTextBox.Text);
                mailArkaPlanSerit.BackColor = Color.FromArgb(((int)((byte)(33))), ((int)((byte)(35))), ((int)((byte)(40))));
                mailUygun = true;
            }catch {
                mailArkaPlanSerit.BackColor = Color.FromArgb(((int)((byte)(0))), ((int)((byte)(255))), ((int)((byte)(255))));
            }
            if (kullaniciAdiUygun && mailUygun && adSoyadUygun && rolUygun) ekleButonu.Enabled = true;
        }

        private void adiSoyadiTextBox_Leave(object sender, EventArgs e) {
            adSoyadUygun = Code.Process.adiKontrol(adiSoyadiTextBox.Text);
            if (!adSoyadUygun) adiSoyadiArkaPlanSerit.BackColor = Color.FromArgb(((int)((byte)(0))), ((int)((byte)(255))), ((int)((byte)(255))));
            else adiSoyadiArkaPlanSerit.BackColor = Color.FromArgb(((int)((byte)(33))), ((int)((byte)(35))), ((int)((byte)(40))));
            if (kullaniciAdiUygun && mailUygun && adSoyadUygun && rolUygun) ekleButonu.Enabled = true;
        }

        private void telefonTextBox_Leave(object sender, EventArgs e) {
            telefonUygun = Code.Process.telefonKontrol(telefonTextBox.Text);
            if (!Code.Process.telefonKontrol(telefonTextBox.Text)) {
                telefonArkaPlanSerit.BackColor = Color.FromArgb(((int)((byte)(0))), ((int)((byte)(255))), ((int)((byte)(255))));
            }else telefonArkaPlanSerit.BackColor = Color.FromArgb(((int)((byte)(33))), ((int)((byte)(35))), ((int)((byte)(40))));
            if (kullaniciAdiUygun && mailUygun && adSoyadUygun && rolUygun) ekleButonu.Enabled = true;
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

        private void ekleButonu_Click(object sender, EventArgs e) {
            if (kullaniciAdiUygun && mailUygun && adSoyadUygun && rolUygun && telefonUygun) {
                if (rol == "admin") Program.admSys++;
                else if (rol == "personel") Program.prsSys++;
                else if (rol == "üye") Program.ueSys++;
                kayitEt();
            }
        }

        public async void kayitEt() {
            Kullanici kullanan = new Kullanici() {
                Kullanici_Adi = kullaniciAdiTextBox.Text.Trim(),
                Parola = sifre,
                Mail = mailTextBox.Text.Trim(),
                Ad_Soyad = adiSoyadiTextBox.Text.Trim(),
                Telefon = telefonTextBox.Text.Trim(),
                Rol = rol
            };
            try {
                Program.veritabani.response = await Program.veritabani.client.SetAsync("GirisBilgileri/" + kullanan.Kullanici_Adi + "/", kullanan);
                Kullanici result = Program.veritabani.response.ResultAs<Kullanici>();
                if (result.Kullanici_Adi != null) MessageBox.Show("Kullanıcı Ekleme İşlemi Başarılı", "Adding is Complete");
                Program.veritabani.veriKayitEt();
                if (rol == "admin") {
                    Not not = new Not() {
                        sahibi = kullanan.Kullanici_Adi,
                        not1 = "",
                        not2 = "",
                        not3 = "",
                        not4 = "",
                        notSayisi = 1
                    };
                    Program.veritabani.response = await Program.veritabani.client.SetAsync("Notlar/" + not.sahibi + "/", not);
                }
            }catch (Exception e) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
            }
            try {
                string konu = "Yeni Açılan Hesap Şifresi";
                string icerik = "Şifreniz " + sifre;
                Program.mail.SendingMail("nktkargo@gmail.com", "jahriwyfjpaxluiz", "NKT Kargo", mailTextBox.Text.Trim(), konu, icerik);
                MessageBox.Show("Şifre Kullanıcıya Mail Olarak Atıldı", "Bilgilendirme");
            }catch (Exception e) {
            }finally{
                kullaniciAdiTextBox.Text = "";
                sifreTextBox.Text = "";
                mailTextBox.Text = "";
                adiSoyadiTextBox.Text = "";
                telefonTextBox.Text = "";
                ekleButonu.Enabled = false;
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