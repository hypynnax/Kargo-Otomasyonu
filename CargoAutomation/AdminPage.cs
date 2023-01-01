using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CargoAutomation {
    public partial class adminAnaSayfasi : Form {

        private kullaniciEklemeSayfasi kullaniciEklemeSayfasi;
        private kullaniciSilmeSayfasi kullaniciSilmeSayfasi;
        private kullaniciYetkilendirSayfasi kullaniciYetkilendirSayfasi;
        private kullaniciListelemeSayfasi kullaniciListelemeSayfasi;
        private subeEkleSayfasi subeEkleSayfasi;
        private subeSilmeEkrani subeSilmeSayfasi;
        private int notSayisi = 1;

        public adminAnaSayfasi() {
            InitializeComponent();
            timer.Start();
            notDefteriAl();
        }

        private void timer_Tick(object sender, EventArgs e) { 
            tarih.Text = DateTime.Now.ToShortDateString();
            saat.Text = DateTime.Now.ToShortTimeString();
            konumBelirle(adminSayisiGosterge, Program.admSys.ToString());
            konumBelirle(personelSayisiGosterge, Program.prsSys.ToString());
            konumBelirle(uyeSayisiGosterge, Program.ueSys.ToString());
            konumBelirle(subeSayisiGosterge, Program.sbSys.ToString());
            konumBelirle(teslimKargoSayisiGosterge, Program.tmmlnkrgSys.ToString());
            konumBelirle(aktifKargoSayisiGosterge, Program.aktfKrgSys.ToString());
        }

        private void konumBelirle(Label gosterge, string sayi) {
            int uzunluk = 111 - (sayi.Length * 14);
            gosterge.Location = new Point(uzunluk / 2, 90);
            gosterge.Text = uzunluk <= 99 ? sayi : sayi.Substring(0, sayi.Length - 1) + "+";
        }

        private async void cikis_Click(object sender, EventArgs e) {
            Not not = new Not() {
                sahibi = Program.kullaniciAdi,
                not1 = not1.Text,
                not2 = not2.Text,
                not3 = not3.Text,
                not4 = not4.Text,
                notSayisi = notSayisi
            };
            try {
                Program.veritabani.response = await Program.veritabani.client.UpdateAsync("Notlar/" + not.sahibi + "/", not);
                Application.Exit();
            }catch (Exception exception) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
            }
        }

        private void altaAl_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ekleButonu_Click(object sender, EventArgs e) {
            kullaniciEklemeSayfasi = new kullaniciEklemeSayfasi();
            kullaniciEklemeSayfasi.Show();
            kullaniciEklemeSayfasi.Location = new Point(100, 51);
            if (kullaniciSilmeSayfasi != null) kullaniciSilmeSayfasi.Close();
            if (kullaniciYetkilendirSayfasi != null) kullaniciYetkilendirSayfasi.Close();
            if (kullaniciListelemeSayfasi != null) kullaniciListelemeSayfasi.Close();
            if (subeEkleSayfasi != null) subeEkleSayfasi.Close();
        }

        private void cikarButonu_Click(object sender, EventArgs e) {
            kullaniciSilmeSayfasi = new kullaniciSilmeSayfasi();
            kullaniciSilmeSayfasi.Show();
            kullaniciSilmeSayfasi.Location = new Point(100, 51);
            if (kullaniciEklemeSayfasi != null) kullaniciEklemeSayfasi.Close();
            if (kullaniciYetkilendirSayfasi != null) kullaniciYetkilendirSayfasi.Close();
            if (kullaniciListelemeSayfasi != null) kullaniciListelemeSayfasi.Close();
            if (subeEkleSayfasi != null) subeEkleSayfasi.Close();
        }

        private void duzenleButonu_Click(object sender, EventArgs e) {
            if (kullaniciEklemeSayfasi != null) kullaniciEklemeSayfasi.Close();
            if (kullaniciSilmeSayfasi != null) kullaniciSilmeSayfasi.Close();
            if (kullaniciYetkilendirSayfasi != null) kullaniciYetkilendirSayfasi.Close();
            if (kullaniciListelemeSayfasi != null) kullaniciListelemeSayfasi.Close();
            if (subeEkleSayfasi != null) subeEkleSayfasi.Close();
            kullaniciListelemeSayfasi = new kullaniciListelemeSayfasi(true);
            kullaniciListelemeSayfasi.Show();
            kullaniciListelemeSayfasi.Location = new Point(100, 51);
        }

        private void yetkilendirButonu_Click(object sender, EventArgs e) {
            kullaniciYetkilendirSayfasi = new kullaniciYetkilendirSayfasi();
            kullaniciYetkilendirSayfasi.Show();
            kullaniciYetkilendirSayfasi.Location = new Point(100, 51);
            if (kullaniciEklemeSayfasi != null) kullaniciEklemeSayfasi.Close();
            if (kullaniciSilmeSayfasi != null) kullaniciSilmeSayfasi.Close();
            if (kullaniciListelemeSayfasi != null) kullaniciListelemeSayfasi.Close();
            if (subeEkleSayfasi != null) subeEkleSayfasi.Close();
        }

        private void personelListelemeButonu_Click(object sender, EventArgs e) {
            if (kullaniciEklemeSayfasi != null) kullaniciEklemeSayfasi.Close();
            if (kullaniciSilmeSayfasi != null) kullaniciSilmeSayfasi.Close();
            if (kullaniciYetkilendirSayfasi != null) kullaniciYetkilendirSayfasi.Close();
            if (kullaniciListelemeSayfasi != null) kullaniciListelemeSayfasi.Close();
            if (subeEkleSayfasi != null) subeEkleSayfasi.Close();
            kullaniciListelemeSayfasi = new kullaniciListelemeSayfasi(false);
            kullaniciListelemeSayfasi.Show();
            kullaniciListelemeSayfasi.Location = new Point(100, 51);
        }

        private void subeEklemeButonu_Click(object sender, EventArgs e) {
            subeEkleSayfasi = new subeEkleSayfasi();
            subeEkleSayfasi.Show();
            subeEkleSayfasi.Location = new Point(100, 51);
            if (kullaniciEklemeSayfasi != null) kullaniciEklemeSayfasi.Close();
            if (kullaniciSilmeSayfasi != null) kullaniciSilmeSayfasi.Close();
            if (kullaniciYetkilendirSayfasi != null) kullaniciYetkilendirSayfasi.Close();
            if (kullaniciListelemeSayfasi != null) kullaniciListelemeSayfasi.Close();
        }

        private void subeKaldirButonu_Click(object sender, EventArgs e) {
            subeSilmeSayfasi = new subeSilmeEkrani();
            subeSilmeSayfasi.Show();
            subeSilmeSayfasi.Location = new Point(100, 51);
            if (kullaniciEklemeSayfasi != null) kullaniciEklemeSayfasi.Close();
            if (kullaniciSilmeSayfasi != null) kullaniciSilmeSayfasi.Close();
            if (kullaniciYetkilendirSayfasi != null) kullaniciYetkilendirSayfasi.Close();
            if (kullaniciListelemeSayfasi != null) kullaniciListelemeSayfasi.Close();
            if (subeEkleSayfasi != null) subeEkleSayfasi.Close();
        }

        private async void oturumKapatmaButonu_Click(object sender, EventArgs e) {
            DialogResult sonuc = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?\nÇıkış yaparsanız tekrar şifre ile giriş yapmanız gerekecek", "UYARI!", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes) {
                Not not = new Not() {
                    sahibi = Program.kullaniciAdi,
                    not1 = not1.Text,
                    not2 = not2.Text,
                    not3 = not3.Text,
                    not4 = not4.Text,
                    notSayisi = notSayisi
                };
                try {
                    Program.veritabani.response = await Program.veritabani.client.UpdateAsync("Notlar/" + not.sahibi + "/", not);
                    this.Close();
                    File.Delete(Application.StartupPath + "\\acikHesap.txt");
                }catch (Exception exception) {
                    MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
                }finally {
                    new girisEkrani().Show();
                }
            }
        }

        private async void kampanyaEkleButonu_Click(object sender, EventArgs e) {
            Kampanya kampanya = new Kampanya() {
                kampanyaYazisi = notTextBox.Text.Trim()
            };
            try {
                Program.veritabani.response = await Program.veritabani.client.UpdateAsync("KampanyaYazisi/", kampanya);
                notTextBox.Text = "";
                MessageBox.Show("Kampanya Yayın İşlemi Başarılı", "Kampanya Yayında");
            }catch (Exception exception) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
            }
        }

        private void notEkleButonu_Click(object sender, EventArgs e) {
            if (notSayisi == 1) {
                not1.Text = notTextBox.Text.Trim();
            }else if(notSayisi == 2) {
                not2.Text = notTextBox.Text.Trim();
            }else if (notSayisi == 3) {
                not3.Text = notTextBox.Text.Trim();
            }else if (notSayisi == 4) {
                not4.Text = notTextBox.Text.Trim();
            }
            notSayisi++;
            notTextBox.Text = "";
        }

        private void yapilanlariSilButonu_Click(object sender, EventArgs e) {
            if (not4.Checked) {
                not4.Text = "";
                notSayisi--;
                not4.Checked = false;
            }
            if (not3.Checked) {
                not3.Text = "";
                notSayisi--;
                not3.Text = not4.Text;
                not4.Text = "";
                not3.Checked = false;
            }
            if (not2.Checked) {
                not2.Text = "";
                notSayisi--;
                not2.Text = not3.Text;
                not3.Text = "";
                not3.Text = not4.Text;
                not4.Text = "";
                not2.Checked = false;
            }
            if (not1.Checked) {
                not1.Text = "";
                notSayisi--;
                not1.Text = not2.Text;
                not2.Text = "";
                not2.Text = not3.Text;
                not3.Text = "";
                not3.Text = not4.Text;
                not4.Text = "";
                not1.Checked = false;
            }
        }

        private void listeyiSilButonu_Click(object sender, EventArgs e) {
            not1.Text = "";
            not2.Text = "";
            not3.Text = "";
            not4.Text = "";
            notSayisi = 1;
        }

        public async void notDefteriAl() {
            try {
                Program.veritabani.response = await Program.veritabani.client.GetAsync("Notlar");
                Dictionary<string, Not> data = JsonConvert.DeserializeObject<Dictionary<string, Not>>(Program.veritabani.response.Body);
                foreach (var item in data) {
                    if (item.Key == Program.kullaniciAdi) {
                        not1.Text = item.Value.not1;
                        not2.Text = item.Value.not2;
                        not3.Text = item.Value.not3;
                        not4.Text = item.Value.not4;
                        notSayisi = item.Value.notSayisi;
                    }
                }
            }catch (Exception e) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
            }
        }
    }

    internal class Kampanya {
        public string kampanyaYazisi { get; set; }
    }

    public class Not {
        public string sahibi { get; set; }
        public string not1 { get; set; }
        public string not2 { get; set; }
        public string not3 { get; set; }
        public string not4 { get; set; }
        public int notSayisi { get; set; }
    }
}
