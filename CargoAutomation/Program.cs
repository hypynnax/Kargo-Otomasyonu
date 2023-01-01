using VeriTabani = CargoAutomation.Database;
using Harita = MapTransactions.MapBrowser;
using Mail = MailTransactions.SendMail;
using System;
using System.IO;
using System.Windows.Forms;

namespace CargoAutomation {

    static class Program {

        public static VeriTabani veritabani = new VeriTabani();
        public static Harita harita = new Harita();
        public static Mail mail = new Mail();
        public static string rol = "", kullaniciAdi = "", kullaniciAdiSoyadi = "";
        public static int admSys = 0, prsSys = 0, ueSys = 0, sbSys = 0, tmmlnkrgSys = 0, aktfKrgSys = 0;

        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            veritabani.veriAl();
            if (!File.Exists(Application.StartupPath + "\\acikHesap.txt")) {
                new FileStream(Application.StartupPath + "\\acikHesap.txt", FileMode.Create).Close();
            }else {
                FileStream fileStream = new FileStream(Application.StartupPath + "\\acikHesap.txt", FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream);
                rol = streamReader.ReadLine();
                kullaniciAdi = streamReader.ReadLine();
                kullaniciAdiSoyadi = streamReader.ReadLine();
                streamReader.Close();
            }
            if (veritabani.client != null) {
                if (rol != "" && rol != null) {
                    if (rol.Equals("admin")) {
                        Application.Run(new adminAnaSayfasi());
                    }else if (rol.Equals("personel")) {
                        Application.Run(new personelAnaSayfasi());
                    }else if (rol.Equals("üye")) {
                        Application.Run(new uyeAnaSayfasi());
                    }
                }else {
                    Application.Run(new girisEkrani());
                }
            }else {
                MessageBox.Show("Lütfen programı tekrar başlatmayı deneyin", "Oops!");
            }
        }
    }
}
