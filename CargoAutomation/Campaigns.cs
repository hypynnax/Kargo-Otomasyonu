using System;
using System.Windows.Forms;

namespace CargoAutomation {
    public partial class kampanyalarSayfasi : Form {

        public Form cagiranForm;

        public kampanyalarSayfasi() {
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
    }
}
