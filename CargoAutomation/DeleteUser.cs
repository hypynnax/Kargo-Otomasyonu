using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CargoAutomation {
    public partial class kullaniciSilmeSayfasi : Form {

        private bool tutus, kayitVar = false;
        private int fareX, fareY;

        private bool rolKontrol() {
            string rol = aramaTextBox.Text.Trim();
            if (rol == "admin" || rol == "personel" || rol == "üye") return true;
            return false;
        }

        public kullaniciSilmeSayfasi() {
            InitializeComponent();
        }

        private void cikisButonu_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void aramaComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            aramaTextBox.Visible = true;
            aramaButonu.Visible = true;
        }

        private async void aramaButonu_Click(object sender, EventArgs e) {
            silmeAramaSonucuDataGridView.Rows.Clear();
            silmeAramaSonucuDataGridView.Columns.Clear();
            silmeAramaSonucuDataGridView.Columns.Add("Kullanici_Adi", "Kullanıcı Adı");
            silmeAramaSonucuDataGridView.Columns.Add("Mail", "Mail");
            silmeAramaSonucuDataGridView.Columns.Add("Ad_Soyad", "Adı Soyadı");
            silmeAramaSonucuDataGridView.Columns.Add("Telefon", "Telefon");
            silmeAramaSonucuDataGridView.Columns.Add("Rol", "Rol");
            aramaTextBox.Text = aramaTextBox.Text.ToLower();
            kayitVar = false;
            try {
                Program.veritabani.response = await Program.veritabani.client.GetAsync("GirisBilgileri");
                Dictionary<string, Kullanici> data = JsonConvert.DeserializeObject<Dictionary<string, Kullanici>>(Program.veritabani.response.Body);
                if (aramaComboBox.SelectedIndex == 0) {
                    if (Code.Process.kullaniciAdiKontrol(aramaTextBox.Text)) {
                        yildiz.Visible = false;
                        foreach (var item in data) {
                            if (item.Value.Kullanici_Adi == aramaTextBox.Text) {
                                silmeAramaSonucuDataGridView.Rows.Add(item.Value.Kullanici_Adi, item.Value.Mail, item.Value.Ad_Soyad, item.Value.Telefon, item.Value.Rol);
                                kayitVar = true;
                            }
                        }
                        if (kayitVar) {
                            silmeAramaSonucuDataGridView.Visible = true;
                        }else {
                            MessageBox.Show("Kullanici Bulunamadı");
                        }
                    }else {
                        yildiz.Visible = true;
                    }
                }else if (aramaComboBox.SelectedIndex == 1) {
                    if (Code.Process.adiKontrol(aramaTextBox.Text)) {
                        yildiz.Visible = false;
                        foreach (var item in data) {
                            if (item.Value.Ad_Soyad.ToUpper() == aramaTextBox.Text.ToUpper()) {
                                silmeAramaSonucuDataGridView.Rows.Add(item.Value.Kullanici_Adi, item.Value.Mail, item.Value.Ad_Soyad, item.Value.Telefon, item.Value.Rol);
                                kayitVar = true;
                            }
                        }
                        if (kayitVar)
                        {
                            silmeAramaSonucuDataGridView.Visible = true;
                        }else {
                            MessageBox.Show("Kullanici Bulunamadı");
                        }
                    }else {
                        yildiz.Visible = true;
                    }
                }else if (aramaComboBox.SelectedIndex == 2) {
                    if (Code.Process.telefonKontrol(aramaTextBox.Text)) {
                        yildiz.Visible = false;
                        foreach (var item in data) {
                            if (item.Value.Telefon == aramaTextBox.Text) {
                                silmeAramaSonucuDataGridView.Rows.Add(item.Value.Kullanici_Adi, item.Value.Mail, item.Value.Ad_Soyad, item.Value.Telefon, item.Value.Rol);
                                kayitVar = true;
                            }
                        }
                        if (kayitVar) {
                            silmeAramaSonucuDataGridView.Visible = true;
                        }else {
                            MessageBox.Show("Kullanici Bulunamadı");
                        }
                    }else {
                        yildiz.Visible = true;
                    }
                }else if (aramaComboBox.SelectedIndex == 3) {
                    if (rolKontrol()) {
                        yildiz.Visible = false;
                        foreach (var item in data) {
                            if (item.Value.Rol.ToLower() == aramaTextBox.Text.ToLower()) {
                                silmeAramaSonucuDataGridView.Rows.Add(item.Value.Kullanici_Adi, item.Value.Mail, item.Value.Ad_Soyad, item.Value.Telefon, item.Value.Rol);
                                kayitVar = true;
                            }
                        }
                        if (kayitVar) {
                            silmeAramaSonucuDataGridView.Visible = true;
                        }else {
                            MessageBox.Show("Hiç " + aramaTextBox.Text + " Kaydı Yok");
                        }
                    }else {
                        yildiz.Visible = true;
                    }
                }
                if (silmeAramaSonucuDataGridView.Visible) {
                    AcceptButton = silmeButonu;
                    silmeButonu.Enabled = true;
                    silmeButonu.Visible = true;
                }
            }catch (Exception exception) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
            }
        }

        private void silmeButonu_Click(object sender, EventArgs e) {
            if (silmeAramaSonucuDataGridView.SelectedRows.Count != 0) {
                string rol = silmeAramaSonucuDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                string kullaniciAd = silmeAramaSonucuDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                if (rol == "admin" && Program.admSys > 1 && silmeAramaSonucuDataGridView.SelectedRows[0].Cells[0].Value.ToString() != Program.kullaniciAdi) {
                    Program.admSys--;
                    DeleteUser(kullaniciAd, true);
                }else if (rol == "personel") {
                    Program.prsSys--;
                    DeleteUser(kullaniciAd, false);
                }else if (rol == "üye") {
                    Program.ueSys--;
                    DeleteUser(kullaniciAd, false);
                }
                silmeAramaSonucuDataGridView.Rows.RemoveAt(silmeAramaSonucuDataGridView.SelectedRows[0].Index);
            }
        }

        public async void DeleteUser(string kullaniciAdi, bool rol) {
            try {
                if (rol) Program.veritabani.response = await Program.veritabani.client.DeleteAsync("Notlar/" + kullaniciAdi);
                var response = await Program.veritabani.client.DeleteAsync("GirisBilgileri/" + kullaniciAdi);
                if (response.StatusCode == HttpStatusCode.OK)
                    MessageBox.Show("Kullanıcı Silme İşlemi Başarılı", "Deletion is Complete");
                else
                    MessageBox.Show("Kullanıcı Silme İşlemi Başarısız", "Deletion is Failed");
                Program.veritabani.veriKayitEt();
            }catch (Exception e) {
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
