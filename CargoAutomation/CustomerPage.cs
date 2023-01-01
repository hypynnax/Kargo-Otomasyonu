using BagliListe = LinkList.LinkList;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CargoAutomation {
    public partial class uyeAnaSayfasi : Form {

        private BagliListe bl = new BagliListe();
        private bool kargoVar = false;
        public string kod = "", gorunenYazi, kampanyaYazisi = "";
        private int ekranBoyutu;

        public uyeAnaSayfasi() {
            InitializeComponent();
            kampanyaYazisiCekme();
            timer.Start();
            kampanyaYazisiTimer.Start();
            kodOlusturma();
            bl.MakeList(new[] { ucretHesaplaButonu, subelerimizButonu, kampanyalarButonu, kargolarimButonu, gecmisButonu }, SystemInformation.PrimaryMonitorSize.Height - 688);
            ekranBoyutu = SystemInformation.PrimaryMonitorSize.Width - 8;
        }

        public async void kampanyaYazisiCekme() {
            try {
                Program.veritabani.response = await Program.veritabani.client.GetAsync("KampanyaYazisi");
                kampanyaYazisi = JsonConvert.DeserializeObject<Kampanya>(Program.veritabani.response.Body).kampanyaYazisi;
                kampanyaYazisiLabel.Text = kampanyaYazisi.Length > 146
                    ? kampanyaYazisi.ToUpper() + (" | ")
                    : kampanyaYazisi.ToUpper();
            }catch (Exception e) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
            }
        }

        private void timer_Tick(object sender, EventArgs e) {
            tarih.Text = DateTime.Now.ToShortDateString();
            saat.Text = DateTime.Now.ToShortTimeString();
        }

        private void kampanyaYazisiTimer_Tick(object sender, EventArgs e) {
            int uzunluk = kampanyaYazisiLabel.Text.Length;
            if (kampanyaYazisiLabel.Size.Width >= ekranBoyutu) {
                gorunenYazi = kampanyaYazisiLabel.Text[uzunluk - 1] + kampanyaYazisiLabel.Text.Substring(0, uzunluk - 1);
                kampanyaYazisiLabel.Text = gorunenYazi.Substring(0, uzunluk);
            }else {
                kampanyaYazisiLabel.Text = "  " + kampanyaYazisiLabel.Text;
            }
        }

        private void kodOlusturma() {
            kod = Code.Process.dogrulamaKoduOlustur();
            dogrulamaKoduLabel.Text = Code.Process.boslukEkle(kod);
        }

        private void cikis_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void altaAl_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void oturumKapatmaButonu_Click(object sender, EventArgs e) {
            DialogResult sonuc = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?\nÇıkış yaparsanız tekrar şifre ile giriş yapmanız gerekecek", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes) {
                this.Close();
                File.Delete(Application.StartupPath + "\\acikHesap.txt");
                new girisEkrani().Show();
            }
        }

        private void sagaKaydir_Click(object sender, EventArgs e) {
            bl.Side(true, 2);
        }

        private void solaKaydir_Click(object sender, EventArgs e) {
            bl.Side(false, 2);
        }

        private void ucretHesapla_Click(object sender, EventArgs e) {
            this.Hide();
            ucretHesaplaSayfasi ucretHesaplaSayfasi = new ucretHesaplaSayfasi();
            ucretHesaplaSayfasi.Location = new Point(this.Location.X + 12, this.Location.Y + 44);
            ucretHesaplaSayfasi.Show();
            ucretHesaplaSayfasi.cagiranForm = this;
        }

        private void subelerimiz_Click(object sender, EventArgs e) {
            this.Hide();
            subelerimizSayfasi subelerimizSayfasi = new subelerimizSayfasi();
            subelerimizSayfasi.Location = new Point(this.Location.X + 12, this.Location.Y + 44);
            subelerimizSayfasi.Show();
            subelerimizSayfasi.cagiranForm = this;
        }

        private void kampanyalar_Click(object sender, EventArgs e) {
            this.Hide();
            kampanyalarSayfasi kampanyalarSayfasi = new kampanyalarSayfasi();
            kampanyalarSayfasi.Location = new Point(this.Location.X + 12, this.Location.Y + 44);
            kampanyalarSayfasi.Show();
            kampanyalarSayfasi.cagiranForm = this;
        }

        private void kargolarim_Click(object sender, EventArgs e) {
            this.Hide();
            kargolariListelemeSayfasi kargolarimSayfasi = new kargolariListelemeSayfasi("TESLİMAT SÜRECİNDEKİ", "Teslimat_Tarihi", "");
            kargolarimSayfasi.Location = new Point(this.Location.X + 12, this.Location.Y + 44);
            kargolarimSayfasi.Show();
            kargolarimSayfasi.cagiranForm = this;
        }

        private void gecmis_Click(object sender, EventArgs e) {
            this.Hide();
            kargolariListelemeSayfasi gecmisimSayfasi = new kargolariListelemeSayfasi("GEÇMİŞ", "Durumu", "Teslim Edildi");
            gecmisimSayfasi.Location = new Point(this.Location.X + 12, this.Location.Y + 44);
            gecmisimSayfasi.Show();
            gecmisimSayfasi.cagiranForm = this;
        }

        private void gonderiNumarasi_Enter(object sender, EventArgs e) {
            if (gonderiNumarasiTextBox.Text == "Gönderi Numarası") {
                gonderiNumarasiTextBox.Text = "";
                gonderiNumarasiTextBox.ForeColor = Color.Black;
            }
        }

        private void gonderiNumarasi_Leave(object sender, EventArgs e) {
            if (gonderiNumarasiTextBox.Text == "") {
                gonderiNumarasiTextBox.Text = "Gönderi Numarası";
                gonderiNumarasiTextBox.ForeColor = Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(184)))), ((int)(((byte)(193)))));
                gonderiNumarasiArkaPlanSerit.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            }
            else gonderiNumarasiArkaPlanSerit.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
        }

        private void dogrulamaKodu_Enter(object sender, EventArgs e) {
            if (dogrulamaKoduTextBox.Text == "Doğrulama Kodunu Giriniz") {
                dogrulamaKoduTextBox.Text = "";
                dogrulamaKoduTextBox.ForeColor = Color.Black;
            }
        }

        private void dogrulamaKodu_Leave(object sender, EventArgs e) {
            if (dogrulamaKoduTextBox.Text == "") {
                dogrulamaKoduTextBox.Text = "Doğrulama Kodunu Giriniz";
                dogrulamaKoduTextBox.ForeColor = Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(184)))), ((int)(((byte)(193)))));
            }
        }

        private void duzenleButonu_Click(object sender, EventArgs e) {
            profilDuzenlemeSayfasi profilDuzenlemeSayfasi = new profilDuzenlemeSayfasi("üye");
            profilDuzenlemeSayfasi.Show();
            profilDuzenlemeSayfasi.Location = new Point(90, 51);
        }

        private void yenileme_Click(object sender, EventArgs e) {
            kargoSorgulamaArkaPlan.Visible = false;
            kodOlusturma();
            if (dogrulamaKoduTextBox.Text != "Doğrulama Kodunu Giriniz") {
                dogrulamaKoduTextBox.Text = "";
            }
        }

        private async void sorgula_Click(object sender, EventArgs e) {
            if (dogrulamaKoduTextBox.Text.Length == 4) {
                if (dogrulamaKoduTextBox.Text == kod) {
                    if (gonderiNumarasiTextBox.Text.Length == 7) {
                        string[] degiskenler = new string[8];
                        kargoVar = false;
                        try {
                            Program.veritabani.response = await Program.veritabani.client.GetAsync("TumKargolar");
                            Dictionary<string, Kargo> data = JsonConvert.DeserializeObject<Dictionary<string, Kargo>>(Program.veritabani.response.Body);
                            foreach (var item in data) {
                                if (item.Value.Gonderi_Numarasi == gonderiNumarasiTextBox.Text) {
                                    kargoVar = true;
                                    degiskenler = new[] {
                                        item.Value.Gonderen_Adi, item.Value.Gonderen_Adresi, item.Value.Alici_Adi,
                                        item.Value.Alici_Adresi, Convert.ToString(item.Value.Gonderim_Tarihi),
                                        Convert.ToString(item.Value.Teslimat_Tarihi), item.Value.Durumu, item.Value.Yeri
                                    };
                                }
                            }
                        }catch (Exception exception) {
                            MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
                        }
                        if (kargoVar) {
                            kargoSorgulamaArkaPlan.Visible = true;
                            this.gonderen.Text = degiskenler[0];
                            this.gonderenAdresi.Text = Code.Process.adresiFormatla(degiskenler[1]);
                            this.alici.Text = degiskenler[2];
                            this.aliciAdresi.Text = Code.Process.adresiFormatla(degiskenler[3]);
                            this.gonderilisTarihi.Text = degiskenler[4].Substring(0, 10);
                            this.teslimatTarihi.Text = degiskenler[5] == "" ? "XX . XX . XXXX" : degiskenler[5];
                            this.kargoDurumu.Text = degiskenler[6];
                            this.kargoYeri.Text = degiskenler[7];
                            gonderiNumarasiTextBox.Text = "Gönderi Numarası";
                            gonderiNumarasiTextBox.ForeColor = Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(184)))), ((int)(((byte)(193)))));
                            dogrulamaKoduTextBox.Text = "Doğrulama Kodunu Giriniz";
                            dogrulamaKoduTextBox.ForeColor = Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(184)))), ((int)(((byte)(193)))));
                            kodOlusturma();
                        }else {
                            MessageBox.Show("Bu gönderi numarası ile uyuşan kargo bulunmamaktadır");
                        }
                    }else {
                        MessageBox.Show("Gönderi numarasını 7 karekter olacak şekilde giriniz");
                    }
                }else {
                    MessageBox.Show("Doğrulama kodunu doğru girdiğinizden emin olun!");
                }
            }else {
                MessageBox.Show("Doğrulama kodunu 4 karekter olacak şekilde giriniz");
            }
        }
    }
}
