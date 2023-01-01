using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CargoAutomation {
    public partial class kargolariListelemeSayfasi : Form {

        public Form cagiranForm;
        private string alan, veri;

        public kargolariListelemeSayfasi(string baslikLabel, string area, string data) {
            InitializeComponent();
            timer.Start();
            alan = area;
            veri = data;
            kargolarLabel.Text = baslikLabel + kargolarLabel.Text;
            kargolarListeDataGridView.Columns.Add("Gonderen_Adi","Gönderen Adı");
            kargolarListeDataGridView.Columns.Add("Gonderen_Adresi", "Gönderen Adresi");
            kargolarListeDataGridView.Columns.Add("Gonderim_Tarihi", "Gönderim Tarihi");
            ListCargo(Program.kullaniciAdiSoyadi, kargolarListeDataGridView);
        }

        public async void ListCargo(string kargosahibi, DataGridView tableList, DataGridView tableDetay = null) {
            try {
                Program.veritabani.response = await Program.veritabani.client.GetAsync("TumKargolar");
                Dictionary<string, Kargo> data = JsonConvert.DeserializeObject<Dictionary<string, Kargo>>(Program.veritabani.response.Body);
                foreach (var item in data) {
                    if (item.Value.Gonderen_Adi.ToUpper() == kargosahibi.ToUpper() || item.Value.Alici_Adi.ToUpper() == kargosahibi.ToUpper()) {
                        if (alan == "Teslimat_Tarihi") {
                            if (item.Value.Teslimat_Tarihi == veri) {
                                if (tableDetay != null) {
                                    tableDetay.Rows.Add(item.Value.Gonderen_Adi, item.Value.Gonderen_Adresi,
                                        item.Value.Gonderen_Telefon, item.Value.Alici_Adi, item.Value.Alici_Adresi,
                                        item.Value.Alici_Telefon, item.Value.Durumu, item.Value.Yeri, item.Value.Agırlıgı,
                                        item.Value.Kategorisi, item.Value.Gonderim_Tarihi, item.Value.Teslimat_Tarihi);
                                }else {
                                    tableList.Rows.Add(item.Value.Gonderen_Adi, item.Value.Gonderen_Adresi, item.Value.Gonderim_Tarihi);
                                }
                            }
                        }else if (alan == "Durumu") {
                            if (item.Value.Durumu.ToUpper() == veri.ToUpper()) {
                                if (tableDetay != null) {
                                    tableDetay.Rows.Add(item.Value.Gonderen_Adi, item.Value.Gonderen_Adresi,
                                        item.Value.Gonderen_Telefon, item.Value.Alici_Adi, item.Value.Alici_Adresi,
                                        item.Value.Alici_Telefon, item.Value.Durumu, item.Value.Yeri, item.Value.Agırlıgı,
                                        item.Value.Kategorisi, item.Value.Gonderim_Tarihi, item.Value.Teslimat_Tarihi);
                                }else {
                                    tableList.Rows.Add(item.Value.Gonderen_Adi, item.Value.Gonderen_Adresi, item.Value.Gonderim_Tarihi);
                                }
                            }
                        }
                    }
                }
            }catch (Exception e) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
            }
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

        private void kargolarListeDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            kargolarDetayDataGridView.Visible = true;
            kargolarDetayDataGridView.Columns.Add("Gonderen_Adi", "Gönderen Adı");
            kargolarDetayDataGridView.Columns.Add("Gonderen_Adresi", "Gönderen Adresi");
            kargolarDetayDataGridView.Columns.Add("Gonderen_Telefon", "Gonderen_Telefon");
            kargolarDetayDataGridView.Columns.Add("Alici_Adi","Alıcı Adı");
            kargolarDetayDataGridView.Columns.Add("Alici_Adresi","Alıcı Adresi");
            kargolarDetayDataGridView.Columns.Add("Alici_Telefon","Alıcı Telefon");
            kargolarDetayDataGridView.Columns.Add("Durumu","Durumu");
            kargolarDetayDataGridView.Columns.Add("Yeri","Yeri");
            kargolarDetayDataGridView.Columns.Add("Agirligi","Ağırlığı");
            kargolarDetayDataGridView.Columns.Add("Kategorisi", "Kategorisi");
            kargolarDetayDataGridView.Columns.Add("Gonderim_Tarihi", "Gönderim Tarihi");
            kargolarDetayDataGridView.Columns.Add("Teslimat_Tarihi", "Teslimat Tarihi");
            ListCargo(Program.kullaniciAdiSoyadi, kargolarListeDataGridView, kargolarDetayDataGridView);
        }
    }
}
