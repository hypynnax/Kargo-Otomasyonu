using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CargoAutomation {
    public partial class kullaniciYetkilendirSayfasi : Form {

        private bool tutus;
        private int fareX, fareY;

        public kullaniciYetkilendirSayfasi() {
            InitializeComponent();
        }

        private void adminRadioButonu_CheckedChanged(object sender, EventArgs e) {
            if (adminRadioButonu.Checked) {
                adminRadioButonu.ForeColor = Color.Red;
                personelRadioButonu.ForeColor = Color.Silver;
                ListUser("admin");
                yetkilendirButonu.Enabled = false;
                yetkiKaldirmaButonu.Enabled = true;
            }
        }

        private void personelRadioButonu_CheckedChanged(object sender, EventArgs e) {
            if (personelRadioButonu.Checked) {
                personelRadioButonu.ForeColor = Color.Red;
                adminRadioButonu.ForeColor = Color.Silver;
                ListUser("personel");
                yetkilendirButonu.Enabled = true;
                yetkiKaldirmaButonu.Enabled = false;
            }
        }

        public async void ListUser(string rol) {
            yetkilendirAramaSonucuPaneli.Rows.Clear();
            yetkilendirAramaSonucuPaneli.Columns.Clear();
            yetkilendirAramaSonucuPaneli.Columns.Add("Kullanic_Adi", "Kullanıcı Adı");
            yetkilendirAramaSonucuPaneli.Columns.Add("Parola", "Parola");
            yetkilendirAramaSonucuPaneli.Columns.Add("Mail", "Mail");
            yetkilendirAramaSonucuPaneli.Columns.Add("Ad_Soyad", "Adı Soyadı");
            yetkilendirAramaSonucuPaneli.Columns.Add("Telefon", "Telefon");
            yetkilendirAramaSonucuPaneli.Columns.Add("Rol", "Rol");
            try {
                Program.veritabani.response = await Program.veritabani.client.GetAsync("GirisBilgileri");
                Dictionary<string, Kullanici> data = JsonConvert.DeserializeObject<Dictionary<string, Kullanici>>(Program.veritabani.response.Body);
                foreach (var item in data) {
                    if (item.Value.Rol == rol) {
                        yetkilendirAramaSonucuPaneli.Rows.Add(item.Value.Kullanici_Adi, item.Value.Parola, item.Value.Mail, item.Value.Ad_Soyad, item.Value.Telefon, item.Value.Rol);
                    }
                }
            }catch (Exception e) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
            }
        }

        public async void UpdateUser(string kullaniciAdi, string sifre, string mail, string adiSoyadi, string telefon, string rol) {
            Kullanici kullanan = new Kullanici() {
                Kullanici_Adi = kullaniciAdi.Trim(),
                Parola = sifre.Trim(),
                Mail = mail.Trim(),
                Ad_Soyad = adiSoyadi.Trim(),
                Telefon = telefon.Trim(),
                Rol = rol.Trim()
            };
            try {
                var response = await Program.veritabani.client.UpdateAsync("GirisBilgileri/" + kullanan.Kullanici_Adi, kullanan);
                Kullanici result = response.ResultAs<Kullanici>();
                if (result.Kullanici_Adi == null)
                    MessageBox.Show("Profil Düzenleme İşlemi Başarısız", "Update Failed");
            }catch (Exception e) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
            }
        }

        private void yetkilendirButonu_Click(object sender, EventArgs e) {
            if (yetkilendirAramaSonucuPaneli.SelectedRows.Count != 0) {
                UpdateUser(yetkilendirAramaSonucuPaneli.SelectedRows[0].Cells[0].Value.ToString(),
                    yetkilendirAramaSonucuPaneli.SelectedRows[0].Cells[1].Value.ToString(),
                    yetkilendirAramaSonucuPaneli.SelectedRows[0].Cells[2].Value.ToString(),
                    yetkilendirAramaSonucuPaneli.SelectedRows[0].Cells[3].Value.ToString(),
                    yetkilendirAramaSonucuPaneli.SelectedRows[0].Cells[4].Value.ToString(), "admin");
                Program.admSys++;
                Program.prsSys--;
                try {
                    Program.veritabani.veriKayitEt();
                    MessageBox.Show("Yetkilendirme İşlemi Başarılı", "Authorization Process Successful");
                    yetkilendirAramaSonucuPaneli.Rows.RemoveAt(yetkilendirAramaSonucuPaneli.SelectedRows[0].Index);
                }catch (Exception exception) {
                    MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
                }
            }
        }

        private void yetkiKaldirmaButonu_Click(object sender, EventArgs e) {
            if (yetkilendirAramaSonucuPaneli.SelectedRows.Count != 0) {
                if (yetkilendirAramaSonucuPaneli.SelectedRows[0].Cells[0].Value.ToString() != Program.kullaniciAdi && Program.admSys > 1) {
                    UpdateUser(yetkilendirAramaSonucuPaneli.SelectedRows[0].Cells[0].Value.ToString(),
                        yetkilendirAramaSonucuPaneli.SelectedRows[0].Cells[1].Value.ToString(),
                        yetkilendirAramaSonucuPaneli.SelectedRows[0].Cells[2].Value.ToString(),
                        yetkilendirAramaSonucuPaneli.SelectedRows[0].Cells[3].Value.ToString(),
                        yetkilendirAramaSonucuPaneli.SelectedRows[0].Cells[4].Value.ToString(), "personel");
                    Program.admSys--;
                    Program.prsSys++;
                    try {
                        Program.veritabani.veriKayitEt();
                        MessageBox.Show("Yetki Kaldırma İşlemi Başarılı", "Deauthorization Successful");
                        yetkilendirAramaSonucuPaneli.Rows.RemoveAt(yetkilendirAramaSonucuPaneli.SelectedRows[0].Index);
                    }catch (Exception exception) {
                        MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
                    }
                }
            }
        }

        private void cikisButonu_Click(object sender, EventArgs e) {
            this.Close();
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
