using System;
using System.Windows.Forms;

namespace CargoAutomation {
    public partial class kodDogrulama : Form {

        private girisEkrani girisEkrani = new girisEkrani();
        private bool tutus;
        private int fareX, fareY;
        private Kullanici kullanan;

        public kodDogrulama(Kullanici kullanan) {
            InitializeComponent();
            this.kullanan = kullanan;
        }

        private void cikis_Click(object sender, EventArgs e) {
            this.Close();
            girisEkrani.Show();
        }

        private void altaAl_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dogrula_Click(object sender, EventArgs e) {
            if (dogrulamaKoduTextBox.Text.Trim() == sifreYenilemeEkrani.kod) {
                new sifreDegistirmeEkrani(kullanan).Show();
                this.Close();
            }else {
                MessageBox.Show("Yanlış Kod Girdiniz");
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
