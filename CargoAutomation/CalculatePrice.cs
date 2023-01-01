using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CargoAutomation.Properties;
using Newtonsoft.Json;

namespace CargoAutomation {
    public partial class ucretHesaplaSayfasi : Form {

        private int adim = 1;
        private double toplam = 0.0, kdvMiktari = 0.0, ucret = 0.0, desi = 0.0, ucreteEsasAgirlik = 0.0, yolMesafesi = 10.0, ekUcret = 0.0;
        public Form cagiranForm;

        public ucretHesaplaSayfasi() {
            InitializeComponent();
            timer.Start();
            ComboBoxFill();
            fiyatPaneli.Height = 200;
            fiyatPaneliToplamTutar.Location = new Point(0,100);
            paketKoliArkaPlanSerit.Height = 75;
            paketKoliArkaPlan.Height = 71;
        }

        public async void ComboBoxFill() {
            try {
                Program.veritabani.response = await Program.veritabani.client.GetAsync("TumTurkiye");
                Dictionary<string, Sehirler> data = JsonConvert.DeserializeObject<Dictionary<string, Sehirler>>(Program.veritabani.response.Body);
                foreach (var item in data) {
                    if (!gonderimYeriComboBox.Items.Contains((item.Value.il_ad + " " + item.Value.ilce_ad).ToUpper())) {
                        gonderimYeriComboBox.Items.Add((item.Value.il_ad + " " + item.Value.ilce_ad).ToUpper());
                        teslimatYeriComboBox.Items.Add((item.Value.il_ad + " " + item.Value.ilce_ad).ToUpper());
                    }
                }
            }catch (Exception e) {
                MessageBox.Show("Lütfen İnternet Bağlantınızı Kontrol Edin", "Bağlantı Hatası");
            }
        }

        private void timer_Tick(object sender, EventArgs e) {
            tarih.Text = DateTime.Now.ToShortDateString();
            saat.Text = DateTime.Now.ToShortTimeString();
        }

        private void cikis_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void altaAl_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void geriAl_Click(object sender, EventArgs e) {
            if (adim == 1) {
                this.Close();
                cagiranForm.Show();
            }else if (adim == 2) {
                adim2.Visible = false;
                adim1.Visible = true;
                gonderiTuruIcon.Image = Resources.gonderiTuruPasif;
                gonderiTuruYazisi.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(76)))));
                cizgi2.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(76)))));
            }else if (adim == 3) {
                adim3.Visible = false;
                adim2.Visible = true;
                digerHizmetlerIcon.Image = Resources.digerHizmetlerPasif;
                digerHizmetlerYazisi.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(76)))));
            }
            adim--;
        }

        private void gonderimYeri_Enter(object sender, EventArgs e) {
            if (gonderimYeriComboBox.Text != "Lokasyon giriniz") {
                gonderimYeriComboBox.ForeColor = Color.Black;
            }else {
                gonderimYeriComboBox.ForeColor = Color.FromArgb(((int)((byte)(170))), ((int)((byte)(170))), ((int)((byte)(170))));
            }
        }

        private void gonderimYeri_Leave(object sender, EventArgs e) {
            if (gonderimYeriComboBox.Text == "Lokasyon giriniz") {
                gonderimYeriComboBox.ForeColor = Color.FromArgb(((int)((byte)(170))), ((int)((byte)(170))), ((int)((byte)(170))));
            }else {
                gonderimYeriComboBox.ForeColor = Color.Black;
            }
        }

        private void gonderimYeriComboBox_TextUpdate(object sender, EventArgs e) {
            gonderimYeriComboBox.Text = gonderimYeriComboBox.Text.ToUpper();
            gonderimYeriComboBox.SelectionStart = gonderimYeriComboBox.Text.Length;
        }

        private void teslimatYeri_Enter(object sender, EventArgs e) {
            if (teslimatYeriComboBox.Text != "Lokasyon giriniz") {
                teslimatYeriComboBox.ForeColor = Color.Black;
            }else {
                teslimatYeriComboBox.ForeColor = Color.FromArgb(((int)((byte)(170))), ((int)((byte)(170))), ((int)((byte)(170))));
            }
        }

        private void teslimatYeri_Leave(object sender, EventArgs e) {
            if (teslimatYeriComboBox.Text == "Lokasyon giriniz") {
                teslimatYeriComboBox.ForeColor = Color.FromArgb(((int)((byte)(170))), ((int)((byte)(170))), ((int)((byte)(170))));
            }else {
                teslimatYeriComboBox.ForeColor = Color.Black;
            }
        }

        private void teslimatYeriComboBox_TextUpdate(object sender, EventArgs e) {
            teslimatYeriComboBox.Text = teslimatYeriComboBox.Text.ToUpper();
            teslimatYeriComboBox.SelectionStart = teslimatYeriComboBox.Text.Length;
        }

        private void devam_Click(object sender, EventArgs e) {
            if (gonderimYeriComboBox.Text != "Lokasyon giriniz" && teslimatYeriComboBox.Text != "Lokasyon giriniz") {
                adim1.Visible = false;
                adim2.Visible = true;
                gonderenYerLabelIl.Text = gonderimYeriComboBox.Text.Split()[0];
                gonderenYerLabelIlce.Text = gonderimYeriComboBox.Text.Split()[1];
                gonderenYerLabelIl1.Text = gonderimYeriComboBox.Text.Split()[0];
                gonderenYerLabelIlce1.Text = gonderimYeriComboBox.Text.Split()[1];
                alanYerLabelIl.Text = teslimatYeriComboBox.Text.Split()[0];
                alanYerLabelIlce.Text = teslimatYeriComboBox.Text.Split()[1];
                alanYerLabelIl1.Text = teslimatYeriComboBox.Text.Split()[0];
                alanYerLabelIlce1.Text = teslimatYeriComboBox.Text.Split()[1];
                gonderiTuruIcon.Image = Resources.gonderiTuruAktif;
                gonderiTuruYazisi.ForeColor = Color.White;
                cizgi2.ForeColor = Color.White;
                gonderimYeriComboBox.DroppedDown = false;
                teslimatYeriComboBox.DroppedDown = false;
                adim++;
            }else {
                gonderimYeriArkaPlanSerit.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                aliciYeriArkaPlanSerit.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            }
        }

        private void devam1_Click(object sender, EventArgs e) {
            if (gonderilenLabel.Text != "XXXXXXXX") {
                adim2.Visible = false;
                adim3.Visible = true;
                digerHizmetlerIcon.Image = Resources.digerHizmetlerAktif;
                digerHizmetlerYazisi.ForeColor = Color.White;
                fiyatPaneliEkUcretler.Visible = true;
                fiyatPaneli1.Height = 600;
                fiyatPaneliToplamTutar1.Location = new Point(0, 500);
                adim++;
            }else {
                zarfDosyaArkaPlanSerit.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0))))); ;
                paketKoliArkaPlanSerit.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0))))); ;
            }
        }

        private void zarfSec_Click(object sender, EventArgs e) {
            sayfaBuyutme1.Location = new Point(0, 700);
            fiyatPaneli.Height = 500;
            fiyatPaneliToplamTutar.Location = new Point(0, 400);
            zarfSecButonu.Visible = false;
            zarfDosyaTikLabel.Visible = true;
            zarfDosyaArkaPlanSerit.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            zarfDosyaArkaPlan.BackColor = Color.White;
            zarfDosyaLabel.BackColor = Color.White;
            gonderilenLabel.Text = "Zarf - Dosya";
            gonderilenLabel1.Text = "Zarf - Dosya";
            ucret = yolMesafesi / 100 * 5;
            kdvMiktari = ucret / 10 * 2 ;
            toplam = ucret + kdvMiktari;
            gonderilen.Text = ucret + " TL";
            gonderilen1.Text = ucret + " TL";
            kdv.Text = kdvMiktari + " TL";
            kdv1.Text = kdvMiktari + " TL";
            toplamTutar.Text = toplam + " TL";
            toplamTutar1.Text = toplam + " TL";
            paketSecButonu.Visible = true;
            paketKoliTikLabel.Visible = false;
            paketKoliArkaPlanSerit.BackColor = Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231))))); ;
            paketKoliArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231))))); ;
            paketKoliLabel.BackColor = Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231))))); ;
            paketKoliArkaPlanSerit.Height = 75;
            paketKoliArkaPlan.Height = 71;
            en.Value = 0;
            enGosterge.Text = "100";
            enGosterge.ForeColor = Color.Gray;
            boy.Value = 0;
            boyGosterge.Text = "100";
            boyGosterge.ForeColor = Color.Gray;
            yukseklik.Value = 0;
            yukseklikGosterge.Text = "200";
            yukseklikGosterge.ForeColor = Color.Gray;
            agirlik.Value = 0;
            agirlikGosterge.Text = "50";
            agirlikGosterge.ForeColor = Color.Gray;
        }

        private void paketSec_Click(object sender, EventArgs e) {
            sayfaBuyutme1.Location = new Point(0, 700);
            fiyatPaneli.Height = 500;
            fiyatPaneliToplamTutar.Location = new Point(0, 400);
            paketSecButonu.Visible = false;
            paketKoliTikLabel.Visible = true;
            paketKoliArkaPlanSerit.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            paketKoliArkaPlan.BackColor = Color.White;
            paketKoliLabel.BackColor = Color.White;
            paketKoliArkaPlanSerit.Height = 275;
            paketKoliArkaPlan.Height = 271;
            gonderilenLabel.Text = "Paket - Koli";
            gonderilenLabel1.Text = "Paket - Koli";
            ucret = yolMesafesi / 100 * 20;
            kdvMiktari = ucret / 10 * 2;
            toplam = ucret + kdvMiktari + ucreteEsasAgirlik;
            gonderilen.Text = ucret + " TL";
            gonderilen1.Text = ucret + " TL";
            kdv.Text = kdvMiktari + " TL";
            kdv1.Text = kdvMiktari + " TL";
            toplamTutar.Text = toplam + " TL";
            toplamTutar1.Text = toplam + " TL";
            zarfSecButonu.Visible = true;
            zarfDosyaTikLabel.Visible = false;
            zarfDosyaArkaPlanSerit.BackColor = Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            zarfDosyaArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            zarfDosyaLabel.BackColor = Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
        }

        private void ekUcretDegisikligi(bool yon, double eklenecek) {
            if (yon) {
                toplam += eklenecek;
            }else {
                toplam -= eklenecek;
            }
            ekUcretler.Text = ekUcret + " TL";
            toplamTutar1.Text = toplam + " TL";
        }

        private void paketKoliFiyatHesapla() {
            desi = en.Value * boy.Value * yukseklik.Value / 1000;
            if (desi > agirlik.Value) {
                ucreteEsasAgirlik = desi * 35;
            }else {
                ucreteEsasAgirlik = agirlik.Value * 10;
            }
            ucret = ucreteEsasAgirlik / 100 * 20;
            kdvMiktari = ucret / 10 * 2;
            toplam = ucret + kdvMiktari;
            gonderilen.Text = ucret + " TL";
            gonderilen1.Text = ucret + " TL";
            kdv.Text = kdvMiktari + " TL";
            kdv1.Text = kdvMiktari + " TL";
            toplamTutar.Text = toplam + " TL";
            toplamTutar1.Text = toplam + " TL";
        }

        private void en_Scroll(object sender, ScrollEventArgs e) {
            enGosterge.Text = en.Value.ToString();
            paketKoliFiyatHesapla();
        }

        private void boy_Scroll(object sender, ScrollEventArgs e) {
            boyGosterge.Text = boy.Value.ToString();
            paketKoliFiyatHesapla();
        }

        private void yukseklik_Scroll(object sender, ScrollEventArgs e) {
            yukseklikGosterge.Text = yukseklik.Value.ToString();
            paketKoliFiyatHesapla();
        }

        private void agirlik_Scroll(object sender, ScrollEventArgs e) {
            agirlikGosterge.Text = agirlik.Value.ToString();
            paketKoliFiyatHesapla();
        }

        private void adreseTeslimArkaPlan_MouseClick(object sender, MouseEventArgs e) {
            if (adreseTeslimArkaPlan.BackColor != Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))))) {
                adreseTeslimArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                adreseTeslimLabel.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                adreseTeslimLabel.ForeColor = Color.Black;
                adreseTeslimFiyatLabel.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                adreseTeslimFiyatLabel.ForeColor = Color.Black;
                adreseTeslimTikLabel.Visible = false;
                ekUcret -= 15;
                ekUcretDegisikligi(false, 15);
            }else {
                adreseTeslimArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                adreseTeslimLabel.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                adreseTeslimLabel.ForeColor = Color.White;
                adreseTeslimFiyatLabel.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                adreseTeslimFiyatLabel.ForeColor = Color.White;
                adreseTeslimTikLabel.Visible = true;
                ekUcret += 15;
                ekUcretDegisikligi(true, 15);
            }
        }

        private void aliciIhbarliArkaPlan_MouseClick(object sender, MouseEventArgs e) {
            if (aliciIhbarliArkaPlan.BackColor != Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))))) {
                aliciIhbarliArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                aliciIhbarlıLabel.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                aliciIhbarlıLabel.ForeColor = Color.Black;
                aliciIhbarliFiyatLabel.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                aliciIhbarliFiyatLabel.ForeColor = Color.Black;
                aliciIhbarliTikLabel.Visible = false;
            }else {
                aliciIhbarliArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                aliciIhbarlıLabel.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                aliciIhbarlıLabel.ForeColor = Color.White;
                aliciIhbarliFiyatLabel.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                aliciIhbarliFiyatLabel.ForeColor = Color.White;
                aliciIhbarliTikLabel.Visible = true;
            }
        }

        private void telefonIhbarliArkaPlan_MouseClick(object sender, MouseEventArgs e) {
            if (telefonIhbarliArkaPlan.BackColor != Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))))) {
                telefonIhbarliArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                telefonIhbarliLabel.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                telefonIhbarliLabel.ForeColor = Color.Black;
                telefonIhbarliFiyatLabel.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                telefonIhbarliFiyatLabel.ForeColor = Color.Black;
                telefonIhbarliTikLabel.Visible = false;
                ekUcret -= 3.31;
                ekUcretDegisikligi(false, 3.31);
            }else {
                telefonIhbarliArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                telefonIhbarliLabel.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                telefonIhbarliLabel.ForeColor = Color.White;
                telefonIhbarliFiyatLabel.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                telefonIhbarliFiyatLabel.ForeColor = Color.White;
                telefonIhbarliTikLabel.Visible = true;
                ekUcret += 3.31;
                ekUcretDegisikligi(true, 3.31);
            }
        }

        private void kuryeCagirButonu_Click(object sender, EventArgs e) {
            MessageBox.Show("Kurye Çağrılıyor");
        }

        private void mobilHizmetArkaPlan_MouseClick(object sender, MouseEventArgs e) {
            if (mobilHizmetArkaPlan.BackColor != Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))))) {
                mobilHizmetArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                mobilHizmetLabel.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                mobilHizmetLabel.ForeColor = Color.Black;
                mobilHizmetFiyatLabel.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                mobilHizmetFiyatLabel.ForeColor = Color.Black;
                mobilHizmetTikLabel.Visible = false;
                ekUcret -= 18;
                ekUcretDegisikligi(false, 18);
            }else {
                mobilHizmetArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                mobilHizmetLabel.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                mobilHizmetLabel.ForeColor = Color.White;
                mobilHizmetFiyatLabel.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                mobilHizmetFiyatLabel.ForeColor = Color.White;
                mobilHizmetTikLabel.Visible = true;
                ekUcret += 18;
                ekUcretDegisikligi(true, 18);
            }
        }

        private void standartUcretsizArkaPlan_MouseClick(object sender, MouseEventArgs e) {
            if (standartUcretsizArkaPlan.BackColor != Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))))) {
                standartUcretsizArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                standartUcretsizLabel1.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                standartUcretsizLabel1.ForeColor = Color.Black;
                standartUcretsizFiyatLabel.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                standartUcretsizFiyatLabel.ForeColor = Color.Black;
                standartUcretsizTikLabel.Visible = false;
            }else {
                standartUcretsizArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                standartUcretsizLabel1.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                standartUcretsizLabel1.ForeColor = Color.White;
                standartUcretsizFiyatLabel.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                standartUcretsizFiyatLabel.ForeColor = Color.White;
                standartUcretsizTikLabel.Visible = true;
            }
        }

        private void aliciyaMailArkaPlan_MouseClick(object sender, MouseEventArgs e) {
            if (aliciyaMailArkaPlan.BackColor != Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))))) {
                aliciyaMailArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                aliciyaMailLabel.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                aliciyaMailLabel.ForeColor = Color.Black;
                aliciyaMailFiyatLabel.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                aliciyaMailFiyatLabel.ForeColor = Color.Black;
                aliciyaMailTikLabel.Visible = false;
                ekUcret -= 1.24;
                ekUcretDegisikligi(false, 1.24);
            }else {
                aliciyaMailArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                aliciyaMailLabel.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                aliciyaMailLabel.ForeColor = Color.White;
                aliciyaMailFiyatLabel.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                aliciyaMailFiyatLabel.ForeColor = Color.White;
                aliciyaMailTikLabel.Visible = true;
                ekUcret += 1.24;
                ekUcretDegisikligi(true, 1.24);
            }
        }

        private void adrestenAlimArkaPlan_MouseClick(object sender, MouseEventArgs e) {
            if (adrestenAlimArkaPlan.BackColor != Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))))) {
                adrestenAlimArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                adrestenAlimLabel.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                adrestenAlimLabel.ForeColor = Color.Black;
                adrestenAlimFiyatLabel.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                adrestenAlimFiyatLabel.ForeColor = Color.Black;
                adrestenAlimTikLabel.Visible = false;
                ekUcret -= 15;
                ekUcretDegisikligi(false, 15);
            }else {
                adrestenAlimArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                adrestenAlimLabel.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                adrestenAlimLabel.ForeColor = Color.White;
                adrestenAlimFiyatLabel.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                adrestenAlimFiyatLabel.ForeColor = Color.White;
                adrestenAlimTikLabel.Visible = true;
                ekUcret += 15;
                ekUcretDegisikligi(true, 15);
            }
        }

        private void gondericiyeMailArkaPlan_MouseClick(object sender, MouseEventArgs e) {
            if (gondericiyeMailArkaPlan.BackColor != Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))))) {
                gondericiyeMailArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                gondericiyeMailLabel.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                gondericiyeMailLabel.ForeColor = Color.Black;
                gondericiyeMailFiyatLabel.BackColor = Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
                gondericiyeMailFiyatLabel.ForeColor = Color.Black;
                gondericiyeMailTikLabel.Visible = false;
                ekUcret -= 1.24;
                ekUcretDegisikligi(false, 1.24);
            }else {
                gondericiyeMailArkaPlan.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                gondericiyeMailLabel.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                gondericiyeMailLabel.ForeColor = Color.White;
                gondericiyeMailFiyatLabel.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
                gondericiyeMailFiyatLabel.ForeColor = Color.White;
                gondericiyeMailTikLabel.Visible = true;
                ekUcret += 1.24;
                ekUcretDegisikligi(true, 1.24);
            }
        }

        private void yeniHesaplamaArkaPlan_MouseClick(object sender, MouseEventArgs e) {
            ucretHesaplaSayfasi ucretHesaplaSayfasi = new ucretHesaplaSayfasi();
            ucretHesaplaSayfasi.cagiranForm = this.cagiranForm;
            ucretHesaplaSayfasi.Show();
            this.Hide();
        }
    }
}
