using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CargoAutomation {
    public partial class subelerimizSayfasi : Form {

        public Form cagiranForm;

        public subelerimizSayfasi() {
            InitializeComponent();
            timer.Start();
        }

        private void cikis_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void altaAl_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void geriAl_Click(object sender, EventArgs e) {
            this.Close();
            cagiranForm.Show();
        }

        private void timer_Tick(object sender, EventArgs e) {
            tarih.Text = DateTime.Now.ToShortDateString();
            saat.Text = DateTime.Now.ToShortTimeString();
        }

        private void konum_Enter(object sender, EventArgs e) {
            if (konumTextBox.Text == "Lokasyon Giriniz") {
                konumTextBox.Text = "";
                konumTextBox.ForeColor = Color.Black;
            }
        }

        private void konum_Leave(object sender, EventArgs e) {
            if (konumTextBox.Text == "") {
                konumTextBox.Text = "Lokasyon Giriniz";
                konumTextBox.ForeColor = Color.DimGray;
            }
        }

        private async void arama_Click(object sender, EventArgs e) {
            string sehir = "", semt = "";
            bool subeVar = false;
            konumTextBox.Text = konumTextBox.Text.ToUpper();
            try {
                Program.veritabani.response = await Program.veritabani.client.GetAsync("Subelerimiz");
                Dictionary<string, Sube> data = JsonConvert.DeserializeObject<Dictionary<string, Sube>>(Program.veritabani.response.Body);
                foreach (var item in data) {
                    if (item.Value.il_ad == konumTextBox.Text || item.Value.ilce_ad == konumTextBox.Text || item.Value.il_ad + " " + item.Value.ilce_ad == konumTextBox.Text) {
                        sehir = item.Value.il_ad;
                        semt = item.Value.ilce_ad;
                        subeVar = true;
                    }
                }
            }
            catch (Exception exception) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
            }
            if (subeVar) {
                hata.Visible = false;
                hataMesaji.Visible = false;
                map.Visible = true;
                try {
                    Program.harita.Map("Türkiye", sehir, semt, map);
                }catch (Exception exception) { }
            }else {
                hata.Visible = true;
                hataMesaji.Visible = true;
                map.Visible = false;
            }
        }
    }
}
