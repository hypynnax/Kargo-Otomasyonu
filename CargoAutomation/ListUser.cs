using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CargoAutomation {
    public partial class kullaniciListelemeSayfasi : Form {

        private bool tutus, duzenleme;
        private int fareX, fareY;
        private profilDuzenlemeSayfasi profilDuzenle;

        public kullaniciListelemeSayfasi(bool duzenleme) {
            InitializeComponent();
            this.duzenleme = duzenleme;
        }

        private void cikisButonu_Click(object sender, EventArgs e) {
            this.Close();
        }

        private async void listelemeButonu_Click(object sender, EventArgs e) {
            listeleAramaSonucuDataGridView.Visible = true;
            string rol = "";
            if (adminRadioButton.Checked == true) rol = "admin";
            else if (personelRadioButton.Checked == true) rol = "personel";
            else if (uyeRadioButton.Checked == true) rol = "üye";
            listeleAramaSonucuDataGridView.Rows.Clear();
            listeleAramaSonucuDataGridView.Columns.Clear();
            listeleAramaSonucuDataGridView.Columns.Add("Kullanic_Adi", "Kullanıcı Adı");
            listeleAramaSonucuDataGridView.Columns.Add("Parola", "Parola");
            listeleAramaSonucuDataGridView.Columns.Add("Mail", "Mail");
            listeleAramaSonucuDataGridView.Columns.Add("Ad_Soyad", "Adı Soyadı");
            listeleAramaSonucuDataGridView.Columns.Add("Telefon", "Telefon");
            listeleAramaSonucuDataGridView.Columns.Add("Rol", "Rol");
            try {
                Program.veritabani.response = await Program.veritabani.client.GetAsync("GirisBilgileri");
                Dictionary<string, Kullanici> data = JsonConvert.DeserializeObject<Dictionary<string, Kullanici>>(Program.veritabani.response.Body);
                foreach (var item in data) {
                    if (item.Value.Rol == rol) {
                        listeleAramaSonucuDataGridView.Rows.Add(item.Value.Kullanici_Adi, item.Value.Parola, item.Value.Mail, item.Value.Ad_Soyad, item.Value.Telefon, item.Value.Rol);
                    }
                }
            }catch (Exception exception) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
            }
        }

        private void listeleAramaSonucuDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (duzenleme) {
                if (profilDuzenle != null) profilDuzenle.Close();
                profilDuzenle = new profilDuzenlemeSayfasi(listeleAramaSonucuDataGridView.CurrentRow.Cells[5].Value.ToString(), listeleAramaSonucuDataGridView.CurrentRow.Cells[0].Value.ToString()); 
                profilDuzenle.Show();
                profilDuzenle.Location = new Point(517, 51);
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
