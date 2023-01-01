using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CargoAutomation {
    public partial class kullaniciAnaSayfasi : Form {

        private string kod = "";
        private bool kargoVar = false;

        public kullaniciAnaSayfasi() {
            InitializeComponent();
            timer.Start();
            kodOlusturma();
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

        private void kodOlusturma() {
            kod = Code.Process.dogrulamaKoduOlustur();
            dogrulamaKoduLabel.Text = Code.Process.boslukEkle(kod);
        }

        private void ucretHesapla_Click(object sender, EventArgs e) {
            this.Hide();
            kargoSorgulamaArkaPlan.Visible = false;
            ucretHesaplaSayfasi ucretHesaplaSayfasi = new ucretHesaplaSayfasi();
            ucretHesaplaSayfasi.Location = new Point(this.Location.X + 12, this.Location.Y + 44);
            ucretHesaplaSayfasi.Show();
            ucretHesaplaSayfasi.cagiranForm = this;
        }

        private void subelerimiz_Click(object sender, EventArgs e) {
            this.Hide();
            kargoSorgulamaArkaPlan.Visible = false;
            subelerimizSayfasi subelerimizSayfasi = new subelerimizSayfasi();
            subelerimizSayfasi.Location = new Point(this.Location.X + 12, this.Location.Y + 44);
            subelerimizSayfasi.Show();
            subelerimizSayfasi.cagiranForm = this;
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

        private void yenileme_Click(object sender, EventArgs e) {
            kargoSorgulamaArkaPlan.Visible = false;
            kodOlusturma();
            if (dogrulamaKoduTextBox.Text != "Doğrulama Kodunu Giriniz") {
                dogrulamaKoduTextBox.Text = "";
            }
        }

        private async void sorgula_Click(object sender, EventArgs e) {
            dogrulamaKoduTextBox.Text = dogrulamaKoduTextBox.Text.Trim();
            gonderiNumarasiTextBox.Text = gonderiNumarasiTextBox.Text.Trim();
            if (dogrulamaKoduTextBox.Text.Length == 4) {
                if (dogrulamaKoduTextBox.Text == kod) {
                    if (gonderiNumarasiTextBox.Text.Length == 7) {
                        string[] degiskenler = new string[8];
                        kargoVar = false;
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
                        if (kargoVar) {
                            kargoSorgulamaArkaPlan.Visible = true;
                            this.gonderen.Text = degiskenler[0];
                            this.gonderenAdresi.Text = degiskenler[1];
                            this.alici.Text = degiskenler[2];
                            this.aliciAdresi.Text = degiskenler[3];
                            this.gonderilisTarihi.Text = degiskenler[4];
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
