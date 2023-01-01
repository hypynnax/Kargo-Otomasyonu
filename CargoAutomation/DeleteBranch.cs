using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CargoAutomation {
    public partial class subeSilmeEkrani : Form {

        private bool tutus, kayitVar = false;
        private int fareX, fareY;

        public subeSilmeEkrani() {
            InitializeComponent();
        }

        private void cikisButonu_Click(object sender, EventArgs e) {
            this.Close();
        }

        private async void aramaButonu_Click(object sender, EventArgs e) {
            subeAramaSonucuDataGridView.Rows.Clear();
            subeAramaSonucuDataGridView.Columns.Clear();
            subeAramaSonucuDataGridView.Columns.Add("il_id", "Plaka");
            subeAramaSonucuDataGridView.Columns.Add("il_ad", "İl Adı");
            subeAramaSonucuDataGridView.Columns.Add("ilce_ad", "İlçe Adı");
            aramaTextBox.Text = aramaTextBox.Text.ToUpper();
            try {
                if (Code.Process.adiKontrol(aramaTextBox.Text)) {
                    yildiz.Visible = false;
                    kayitVar = false;
                    Program.veritabani.response = await Program.veritabani.client.GetAsync("Subelerimiz");
                    Dictionary<string, Sube> data = JsonConvert.DeserializeObject<Dictionary<string, Sube>>(Program.veritabani.response.Body);
                    foreach (var item in data) {
                        if (item.Value.il_ad.ToUpper() == aramaTextBox.Text.ToUpper() || item.Value.ilce_ad.ToUpper() == aramaTextBox.Text.ToUpper() || (item.Value.il_ad + " " + item.Value.ilce_ad).ToUpper() == aramaTextBox.Text.ToUpper()) {
                            subeAramaSonucuDataGridView.Rows.Add(item.Value.il_id, item.Value.il_ad, item.Value.ilce_ad);
                            kayitVar = true;
                        }
                    }
                    if (kayitVar) {
                        subeAramaSonucuDataGridView.Visible = true;
                    }else {
                        MessageBox.Show("Uygun Formatta Bir Şehir Girin", "Bilinmeyen Şehir");
                    }
                }else {
                    yildiz.Visible = true;
                }
                if (subeAramaSonucuDataGridView.Visible) {
                    AcceptButton = silmeButonu;
                    silmeButonu.Visible = true;
                }
            }catch (Exception exception) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
            }
        }

        private void silmeButonu_Click(object sender, EventArgs e) {
            if (subeAramaSonucuDataGridView.SelectedRows.Count != 0) {
                DeleteBranch(subeAramaSonucuDataGridView.SelectedRows[0].Cells[2].Value.ToString());
                subeAramaSonucuDataGridView.Rows.RemoveAt(subeAramaSonucuDataGridView.SelectedRows[0].Index);
                Program.sbSys--;
                MessageBox.Show("Şube Silme İşlemi Başarılı", "Deletion is Complete");
                Program.veritabani.veriKayitEt();
            }
        }

        public async void DeleteBranch(string sube) {
            try {
                var response = await Program.veritabani.client.DeleteAsync("Subelerimiz/" + sube);
                if (response.StatusCode != HttpStatusCode.OK)
                    MessageBox.Show("Şube Silme İşlemi Başarısız", "Deletion is Failed");
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
