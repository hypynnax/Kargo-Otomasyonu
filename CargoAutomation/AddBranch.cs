using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CargoAutomation {
    public partial class subeEkleSayfasi : Form {

        private bool tutus;
        private int fareX, fareY;

        public subeEkleSayfasi() {
            InitializeComponent();
            ComboBoxFill(ilComboBox);
        }

        public async void ComboBoxFill(ComboBox ilComboBox) {
            try {
                Program.veritabani.response = await Program.veritabani.client.GetAsync("TumTurkiye");
                Dictionary<string, Sehirler> data = JsonConvert.DeserializeObject<Dictionary<string, Sehirler>>(Program.veritabani.response.Body);
                foreach (var item in data) {
                    if (!ilComboBox.Items.Contains(item.Value.il_ad)) {
                        ilComboBox.Items.Add(item.Value.il_ad);
                    }
                }
            }
            catch (Exception e) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
            }
        }

        private void cikisButonu_Click(object sender, EventArgs e) {
            this.Close();
        }

        private async void ilComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            ilceComboBox.Items.Clear();
            ilceComboBox.Text = "";
            try {
                Program.veritabani.response = await Program.veritabani.client.GetAsync("TumTurkiye");
                Dictionary<string, Sehirler> data = JsonConvert.DeserializeObject<Dictionary<string, Sehirler>>(Program.veritabani.response.Body);
                foreach (var item in data) {
                    if (item.Value.il_ad == ilComboBox.SelectedText && !ilceComboBox.Items.Contains(item.Value.ilce_ad)) {
                        ilceComboBox.Items.Add(item.Value.ilce_ad);
                        plakaTextBox.Text = item.Value.il_id;
                    }
                }
            }catch (Exception exception) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
            }
        }

        private void ilceComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            subeEklemeButonu.Enabled = true;
        }

        private async void subeEklemeButonu_Click(object sender, EventArgs e) {
            var sube = new Sube() {
                il_id = Convert.ToInt32(plakaTextBox.Text),
                il_ad = ilComboBox.Text.ToUpper(),
                ilce_ad = ilceComboBox.Text.ToUpper() };
            try {
                Program.veritabani.response = await Program.veritabani.client.SetAsync("Subelerimiz/" + sube.ilce_ad + "/", sube);
                Sube result = Program.veritabani.response.ResultAs<Sube>();
                if (result.ilce_ad != null) MessageBox.Show("Şube Ekleme İşlemi Başarılı", "Adding is Complete");
                Program.sbSys++;
                Program.veritabani.veriKayitEt();
            }catch (Exception exception) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
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
