using System.Windows.Forms;

namespace CargoAutomation
{
    partial class kullaniciAnaSayfasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullaniciAnaSayfasi));
            this.arkaPlan = new System.Windows.Forms.PictureBox();
            this.altaAlButonu = new System.Windows.Forms.Label();
            this.cikisButonu = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.Label();
            this.tarihSaatImleci = new System.Windows.Forms.Label();
            this.saat = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.arkaPlan1 = new System.Windows.Forms.PictureBox();
            this.arkaPlan2 = new System.Windows.Forms.PictureBox();
            this.gonderiNumarasiTextBox = new System.Windows.Forms.TextBox();
            this.dogrulamaKoduLabelArkaPlan = new System.Windows.Forms.PictureBox();
            this.dogrulamaKoduTextBox = new System.Windows.Forms.TextBox();
            this.sorgulaButonu = new System.Windows.Forms.Button();
            this.dogrulamaKoduArkaPlan = new System.Windows.Forms.PictureBox();
            this.dogrulamaKoduLabel = new System.Windows.Forms.Label();
            this.gonderiNumarasiArkaPlan = new System.Windows.Forms.PictureBox();
            this.gonderiNumarasiArkaPlanSerit = new System.Windows.Forms.PictureBox();
            this.subelerimizButonu = new System.Windows.Forms.Button();
            this.ucretHesaplaButonu = new System.Windows.Forms.Button();
            this.yenilemeButonu = new System.Windows.Forms.PictureBox();
            this.kargoSorgulamaArkaPlan = new System.Windows.Forms.Panel();
            this.kargoYeri = new System.Windows.Forms.Label();
            this.kargoDurumu = new System.Windows.Forms.Label();
            this.teslimatTarihi = new System.Windows.Forms.Label();
            this.gonderilisTarihi = new System.Windows.Forms.Label();
            this.aliciAdresi = new System.Windows.Forms.Label();
            this.alici = new System.Windows.Forms.Label();
            this.gonderenAdresi = new System.Windows.Forms.Label();
            this.gonderen = new System.Windows.Forms.Label();
            this.kargoYeriLabel = new System.Windows.Forms.Label();
            this.kargoDurumuLabel = new System.Windows.Forms.Label();
            this.teslimatTarihiLabel = new System.Windows.Forms.Label();
            this.gonderilisTarihiLabel = new System.Windows.Forms.Label();
            this.AliciAdresiLabel = new System.Windows.Forms.Label();
            this.AliciLabel = new System.Windows.Forms.Label();
            this.gonderenAdresiLabel = new System.Windows.Forms.Label();
            this.gonderenLabel = new System.Windows.Forms.Label();
            this.gonderiTakipLabel = new System.Windows.Forms.Label();
            this.resim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogrulamaKoduLabelArkaPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogrulamaKoduArkaPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gonderiNumarasiArkaPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gonderiNumarasiArkaPlanSerit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yenilemeButonu)).BeginInit();
            this.kargoSorgulamaArkaPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).BeginInit();
            this.SuspendLayout();
            // 
            // arkaPlan
            // 
            this.arkaPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arkaPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.arkaPlan.ErrorImage = null;
            this.arkaPlan.InitialImage = null;
            this.arkaPlan.Location = new System.Drawing.Point(1, 1);
            this.arkaPlan.Name = "arkaPlan";
            this.arkaPlan.Size = new System.Drawing.Size(1364, 766);
            this.arkaPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.arkaPlan.TabIndex = 2;
            this.arkaPlan.TabStop = false;
            // 
            // altaAlButonu
            // 
            this.altaAlButonu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.altaAlButonu.AutoSize = true;
            this.altaAlButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.altaAlButonu.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.altaAlButonu.ForeColor = System.Drawing.Color.White;
            this.altaAlButonu.Location = new System.Drawing.Point(1304, 3);
            this.altaAlButonu.Name = "altaAlButonu";
            this.altaAlButonu.Size = new System.Drawing.Size(27, 34);
            this.altaAlButonu.TabIndex = 0;
            this.altaAlButonu.Text = "━";
            this.altaAlButonu.Click += new System.EventHandler(this.altaAl_Click);
            // 
            // cikisButonu
            // 
            this.cikisButonu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cikisButonu.AutoSize = true;
            this.cikisButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.cikisButonu.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButonu.ForeColor = System.Drawing.Color.White;
            this.cikisButonu.Location = new System.Drawing.Point(1333, 3);
            this.cikisButonu.Name = "cikisButonu";
            this.cikisButonu.Size = new System.Drawing.Size(29, 34);
            this.cikisButonu.TabIndex = 0;
            this.cikisButonu.Text = "×";
            this.cikisButonu.Click += new System.EventHandler(this.cikis_Click);
            // 
            // tarih
            // 
            this.tarih.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.tarih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tarih.AutoSize = true;
            this.tarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih.ForeColor = System.Drawing.Color.White;
            this.tarih.Location = new System.Drawing.Point(1292, 748);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(70, 16);
            this.tarih.TabIndex = 0;
            this.tarih.Text = "00.00.0000";
            // 
            // tarihSaatImleci
            // 
            this.tarihSaatImleci.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tarihSaatImleci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tarihSaatImleci.AutoSize = true;
            this.tarihSaatImleci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.tarihSaatImleci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarihSaatImleci.ForeColor = System.Drawing.Color.White;
            this.tarihSaatImleci.Location = new System.Drawing.Point(1280, 748);
            this.tarihSaatImleci.Name = "tarihSaatImleci";
            this.tarihSaatImleci.Size = new System.Drawing.Size(12, 16);
            this.tarihSaatImleci.TabIndex = 0;
            this.tarihSaatImleci.Text = "/";
            // 
            // saat
            // 
            this.saat.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.saat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saat.AutoSize = true;
            this.saat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saat.ForeColor = System.Drawing.Color.White;
            this.saat.Location = new System.Drawing.Point(1241, 748);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(39, 16);
            this.saat.TabIndex = 0;
            this.saat.Text = "00:00";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // arkaPlan1
            // 
            this.arkaPlan1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.arkaPlan1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.arkaPlan1.ErrorImage = null;
            this.arkaPlan1.InitialImage = null;
            this.arkaPlan1.Location = new System.Drawing.Point(100, 250);
            this.arkaPlan1.Name = "arkaPlan1";
            this.arkaPlan1.Size = new System.Drawing.Size(500, 300);
            this.arkaPlan1.TabIndex = 4;
            this.arkaPlan1.TabStop = false;
            // 
            // arkaPlan2
            // 
            this.arkaPlan2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.arkaPlan2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(207)))));
            this.arkaPlan2.ErrorImage = null;
            this.arkaPlan2.InitialImage = null;
            this.arkaPlan2.Location = new System.Drawing.Point(105, 255);
            this.arkaPlan2.Name = "arkaPlan2";
            this.arkaPlan2.Size = new System.Drawing.Size(490, 290);
            this.arkaPlan2.TabIndex = 5;
            this.arkaPlan2.TabStop = false;
            // 
            // gonderiNumarasiTextBox
            // 
            this.gonderiNumarasiTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gonderiNumarasiTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gonderiNumarasiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gonderiNumarasiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gonderiNumarasiTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(184)))), ((int)(((byte)(193)))));
            this.gonderiNumarasiTextBox.Location = new System.Drawing.Point(159, 346);
            this.gonderiNumarasiTextBox.Name = "gonderiNumarasiTextBox";
            this.gonderiNumarasiTextBox.Size = new System.Drawing.Size(255, 15);
            this.gonderiNumarasiTextBox.TabIndex = 2;
            this.gonderiNumarasiTextBox.Text = "Gönderi Numarası";
            this.gonderiNumarasiTextBox.Enter += new System.EventHandler(this.gonderiNumarasi_Enter);
            this.gonderiNumarasiTextBox.Leave += new System.EventHandler(this.gonderiNumarasi_Leave);
            // 
            // dogrulamaKoduLabelArkaPlan
            // 
            this.dogrulamaKoduLabelArkaPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dogrulamaKoduLabelArkaPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.dogrulamaKoduLabelArkaPlan.ErrorImage = null;
            this.dogrulamaKoduLabelArkaPlan.InitialImage = null;
            this.dogrulamaKoduLabelArkaPlan.Location = new System.Drawing.Point(144, 425);
            this.dogrulamaKoduLabelArkaPlan.Name = "dogrulamaKoduLabelArkaPlan";
            this.dogrulamaKoduLabelArkaPlan.Size = new System.Drawing.Size(115, 55);
            this.dogrulamaKoduLabelArkaPlan.TabIndex = 7;
            this.dogrulamaKoduLabelArkaPlan.TabStop = false;
            // 
            // dogrulamaKoduTextBox
            // 
            this.dogrulamaKoduTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dogrulamaKoduTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dogrulamaKoduTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogrulamaKoduTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.dogrulamaKoduTextBox.Location = new System.Drawing.Point(294, 445);
            this.dogrulamaKoduTextBox.Name = "dogrulamaKoduTextBox";
            this.dogrulamaKoduTextBox.Size = new System.Drawing.Size(190, 15);
            this.dogrulamaKoduTextBox.TabIndex = 3;
            this.dogrulamaKoduTextBox.Text = "Doğrulama Kodunu Giriniz";
            this.dogrulamaKoduTextBox.Enter += new System.EventHandler(this.dogrulamaKodu_Enter);
            this.dogrulamaKoduTextBox.Leave += new System.EventHandler(this.dogrulamaKodu_Leave);
            // 
            // sorgulaButonu
            // 
            this.sorgulaButonu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sorgulaButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.sorgulaButonu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.sorgulaButonu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(180)))));
            this.sorgulaButonu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(180)))));
            this.sorgulaButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sorgulaButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorgulaButonu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.sorgulaButonu.Location = new System.Drawing.Point(435, 334);
            this.sorgulaButonu.Name = "sorgulaButonu";
            this.sorgulaButonu.Size = new System.Drawing.Size(125, 40);
            this.sorgulaButonu.TabIndex = 4;
            this.sorgulaButonu.Text = "Sorgula";
            this.sorgulaButonu.UseVisualStyleBackColor = false;
            this.sorgulaButonu.Click += new System.EventHandler(this.sorgula_Click);
            // 
            // dogrulamaKoduArkaPlan
            // 
            this.dogrulamaKoduArkaPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dogrulamaKoduArkaPlan.BackColor = System.Drawing.Color.White;
            this.dogrulamaKoduArkaPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dogrulamaKoduArkaPlan.ErrorImage = null;
            this.dogrulamaKoduArkaPlan.InitialImage = null;
            this.dogrulamaKoduArkaPlan.Location = new System.Drawing.Point(274, 425);
            this.dogrulamaKoduArkaPlan.Name = "dogrulamaKoduArkaPlan";
            this.dogrulamaKoduArkaPlan.Size = new System.Drawing.Size(230, 55);
            this.dogrulamaKoduArkaPlan.TabIndex = 12;
            this.dogrulamaKoduArkaPlan.TabStop = false;
            // 
            // dogrulamaKoduLabel
            // 
            this.dogrulamaKoduLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dogrulamaKoduLabel.AutoSize = true;
            this.dogrulamaKoduLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.dogrulamaKoduLabel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogrulamaKoduLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.dogrulamaKoduLabel.Location = new System.Drawing.Point(165, 445);
            this.dogrulamaKoduLabel.Name = "dogrulamaKoduLabel";
            this.dogrulamaKoduLabel.Size = new System.Drawing.Size(71, 18);
            this.dogrulamaKoduLabel.TabIndex = 0;
            this.dogrulamaKoduLabel.Text = "A A A A";
            // 
            // gonderiNumarasiArkaPlan
            // 
            this.gonderiNumarasiArkaPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gonderiNumarasiArkaPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gonderiNumarasiArkaPlan.ErrorImage = null;
            this.gonderiNumarasiArkaPlan.InitialImage = null;
            this.gonderiNumarasiArkaPlan.Location = new System.Drawing.Point(147, 337);
            this.gonderiNumarasiArkaPlan.Name = "gonderiNumarasiArkaPlan";
            this.gonderiNumarasiArkaPlan.Size = new System.Drawing.Size(279, 34);
            this.gonderiNumarasiArkaPlan.TabIndex = 14;
            this.gonderiNumarasiArkaPlan.TabStop = false;
            // 
            // gonderiNumarasiArkaPlanSerit
            // 
            this.gonderiNumarasiArkaPlanSerit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gonderiNumarasiArkaPlanSerit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gonderiNumarasiArkaPlanSerit.ErrorImage = null;
            this.gonderiNumarasiArkaPlanSerit.InitialImage = null;
            this.gonderiNumarasiArkaPlanSerit.Location = new System.Drawing.Point(144, 334);
            this.gonderiNumarasiArkaPlanSerit.Name = "gonderiNumarasiArkaPlanSerit";
            this.gonderiNumarasiArkaPlanSerit.Size = new System.Drawing.Size(285, 40);
            this.gonderiNumarasiArkaPlanSerit.TabIndex = 15;
            this.gonderiNumarasiArkaPlanSerit.TabStop = false;
            // 
            // subelerimizButonu
            // 
            this.subelerimizButonu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.subelerimizButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.subelerimizButonu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.subelerimizButonu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(180)))));
            this.subelerimizButonu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(180)))));
            this.subelerimizButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subelerimizButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subelerimizButonu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.subelerimizButonu.Image = ((System.Drawing.Image)(resources.GetObject("subelerimizButonu.Image")));
            this.subelerimizButonu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subelerimizButonu.Location = new System.Drawing.Point(375, 80);
            this.subelerimizButonu.Name = "subelerimizButonu";
            this.subelerimizButonu.Size = new System.Drawing.Size(200, 100);
            this.subelerimizButonu.TabIndex = 0;
            this.subelerimizButonu.Text = "Şubelerimiz";
            this.subelerimizButonu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.subelerimizButonu.UseVisualStyleBackColor = false;
            this.subelerimizButonu.Click += new System.EventHandler(this.subelerimiz_Click);
            // 
            // ucretHesaplaButonu
            // 
            this.ucretHesaplaButonu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ucretHesaplaButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.ucretHesaplaButonu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.ucretHesaplaButonu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(180)))));
            this.ucretHesaplaButonu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(180)))));
            this.ucretHesaplaButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ucretHesaplaButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucretHesaplaButonu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ucretHesaplaButonu.Image = global::CargoAutomation.Properties.Resources.hesapla;
            this.ucretHesaplaButonu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucretHesaplaButonu.Location = new System.Drawing.Point(125, 80);
            this.ucretHesaplaButonu.Name = "ucretHesaplaButonu";
            this.ucretHesaplaButonu.Size = new System.Drawing.Size(200, 100);
            this.ucretHesaplaButonu.TabIndex = 0;
            this.ucretHesaplaButonu.Text = "Ücret\r\nHesapla";
            this.ucretHesaplaButonu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucretHesaplaButonu.UseVisualStyleBackColor = false;
            this.ucretHesaplaButonu.Click += new System.EventHandler(this.ucretHesapla_Click);
            // 
            // yenilemeButonu
            // 
            this.yenilemeButonu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yenilemeButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(207)))));
            this.yenilemeButonu.ErrorImage = null;
            this.yenilemeButonu.Image = global::CargoAutomation.Properties.Resources.yenileme;
            this.yenilemeButonu.InitialImage = null;
            this.yenilemeButonu.Location = new System.Drawing.Point(519, 435);
            this.yenilemeButonu.Name = "yenilemeButonu";
            this.yenilemeButonu.Size = new System.Drawing.Size(30, 30);
            this.yenilemeButonu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yenilemeButonu.TabIndex = 11;
            this.yenilemeButonu.TabStop = false;
            this.yenilemeButonu.Click += new System.EventHandler(this.yenileme_Click);
            // 
            // kargoSorgulamaArkaPlan
            // 
            this.kargoSorgulamaArkaPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kargoSorgulamaArkaPlan.BackColor = System.Drawing.Color.White;
            this.kargoSorgulamaArkaPlan.Controls.Add(this.kargoYeri);
            this.kargoSorgulamaArkaPlan.Controls.Add(this.kargoDurumu);
            this.kargoSorgulamaArkaPlan.Controls.Add(this.teslimatTarihi);
            this.kargoSorgulamaArkaPlan.Controls.Add(this.gonderilisTarihi);
            this.kargoSorgulamaArkaPlan.Controls.Add(this.aliciAdresi);
            this.kargoSorgulamaArkaPlan.Controls.Add(this.alici);
            this.kargoSorgulamaArkaPlan.Controls.Add(this.gonderenAdresi);
            this.kargoSorgulamaArkaPlan.Controls.Add(this.gonderen);
            this.kargoSorgulamaArkaPlan.Controls.Add(this.kargoYeriLabel);
            this.kargoSorgulamaArkaPlan.Controls.Add(this.kargoDurumuLabel);
            this.kargoSorgulamaArkaPlan.Controls.Add(this.teslimatTarihiLabel);
            this.kargoSorgulamaArkaPlan.Controls.Add(this.gonderilisTarihiLabel);
            this.kargoSorgulamaArkaPlan.Controls.Add(this.AliciAdresiLabel);
            this.kargoSorgulamaArkaPlan.Controls.Add(this.AliciLabel);
            this.kargoSorgulamaArkaPlan.Controls.Add(this.gonderenAdresiLabel);
            this.kargoSorgulamaArkaPlan.Controls.Add(this.gonderenLabel);
            this.kargoSorgulamaArkaPlan.Controls.Add(this.gonderiTakipLabel);
            this.kargoSorgulamaArkaPlan.Location = new System.Drawing.Point(700, 70);
            this.kargoSorgulamaArkaPlan.Name = "kargoSorgulamaArkaPlan";
            this.kargoSorgulamaArkaPlan.Size = new System.Drawing.Size(555, 550);
            this.kargoSorgulamaArkaPlan.TabIndex = 1;
            this.kargoSorgulamaArkaPlan.Visible = false;
            // 
            // kargoYeri
            // 
            this.kargoYeri.AutoSize = true;
            this.kargoYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kargoYeri.Location = new System.Drawing.Point(335, 470);
            this.kargoYeri.Name = "kargoYeri";
            this.kargoYeri.Size = new System.Drawing.Size(48, 16);
            this.kargoYeri.TabIndex = 0;
            this.kargoYeri.Text = "XXXXX";
            // 
            // kargoDurumu
            // 
            this.kargoDurumu.AutoSize = true;
            this.kargoDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kargoDurumu.Location = new System.Drawing.Point(60, 470);
            this.kargoDurumu.Name = "kargoDurumu";
            this.kargoDurumu.Size = new System.Drawing.Size(48, 16);
            this.kargoDurumu.TabIndex = 0;
            this.kargoDurumu.Text = "XXXXX";
            // 
            // teslimatTarihi
            // 
            this.teslimatTarihi.AutoSize = true;
            this.teslimatTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslimatTarihi.Location = new System.Drawing.Point(335, 360);
            this.teslimatTarihi.Name = "teslimatTarihi";
            this.teslimatTarihi.Size = new System.Drawing.Size(78, 16);
            this.teslimatTarihi.TabIndex = 0;
            this.teslimatTarihi.Text = "XX.XX.XXXX";
            // 
            // gonderilisTarihi
            // 
            this.gonderilisTarihi.AutoSize = true;
            this.gonderilisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gonderilisTarihi.Location = new System.Drawing.Point(60, 360);
            this.gonderilisTarihi.Name = "gonderilisTarihi";
            this.gonderilisTarihi.Size = new System.Drawing.Size(78, 16);
            this.gonderilisTarihi.TabIndex = 0;
            this.gonderilisTarihi.Text = "XX.XX.XXXX";
            // 
            // aliciAdresi
            // 
            this.aliciAdresi.AutoSize = true;
            this.aliciAdresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aliciAdresi.Location = new System.Drawing.Point(335, 250);
            this.aliciAdresi.Name = "aliciAdresi";
            this.aliciAdresi.Size = new System.Drawing.Size(48, 16);
            this.aliciAdresi.TabIndex = 0;
            this.aliciAdresi.Text = "XXXXX";
            // 
            // alici
            // 
            this.alici.AutoSize = true;
            this.alici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alici.Location = new System.Drawing.Point(60, 250);
            this.alici.Name = "alici";
            this.alici.Size = new System.Drawing.Size(48, 16);
            this.alici.TabIndex = 0;
            this.alici.Text = "XXXXX";
            // 
            // gonderenAdresi
            // 
            this.gonderenAdresi.AutoSize = true;
            this.gonderenAdresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gonderenAdresi.Location = new System.Drawing.Point(335, 140);
            this.gonderenAdresi.Name = "gonderenAdresi";
            this.gonderenAdresi.Size = new System.Drawing.Size(48, 16);
            this.gonderenAdresi.TabIndex = 0;
            this.gonderenAdresi.Text = "XXXXX";
            // 
            // gonderen
            // 
            this.gonderen.AutoSize = true;
            this.gonderen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gonderen.Location = new System.Drawing.Point(60, 140);
            this.gonderen.Name = "gonderen";
            this.gonderen.Size = new System.Drawing.Size(48, 16);
            this.gonderen.TabIndex = 0;
            this.gonderen.Text = "XXXXX";
            // 
            // kargoYeriLabel
            // 
            this.kargoYeriLabel.AutoSize = true;
            this.kargoYeriLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kargoYeriLabel.Location = new System.Drawing.Point(335, 430);
            this.kargoYeriLabel.Name = "kargoYeriLabel";
            this.kargoYeriLabel.Size = new System.Drawing.Size(81, 16);
            this.kargoYeriLabel.TabIndex = 0;
            this.kargoYeriLabel.Text = "Kargo Yeri";
            // 
            // kargoDurumuLabel
            // 
            this.kargoDurumuLabel.AutoSize = true;
            this.kargoDurumuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kargoDurumuLabel.Location = new System.Drawing.Point(60, 430);
            this.kargoDurumuLabel.Name = "kargoDurumuLabel";
            this.kargoDurumuLabel.Size = new System.Drawing.Size(105, 16);
            this.kargoDurumuLabel.TabIndex = 0;
            this.kargoDurumuLabel.Text = "Kargo Durumu";
            // 
            // teslimatTarihiLabel
            // 
            this.teslimatTarihiLabel.AutoSize = true;
            this.teslimatTarihiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslimatTarihiLabel.Location = new System.Drawing.Point(335, 320);
            this.teslimatTarihiLabel.Name = "teslimatTarihiLabel";
            this.teslimatTarihiLabel.Size = new System.Drawing.Size(112, 16);
            this.teslimatTarihiLabel.TabIndex = 0;
            this.teslimatTarihiLabel.Text = "Teslimat Tarihi";
            // 
            // gonderilisTarihiLabel
            // 
            this.gonderilisTarihiLabel.AutoSize = true;
            this.gonderilisTarihiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gonderilisTarihiLabel.Location = new System.Drawing.Point(60, 320);
            this.gonderilisTarihiLabel.Name = "gonderilisTarihiLabel";
            this.gonderilisTarihiLabel.Size = new System.Drawing.Size(123, 16);
            this.gonderilisTarihiLabel.TabIndex = 0;
            this.gonderilisTarihiLabel.Text = "Gönderiliş Tarihi";
            // 
            // AliciAdresiLabel
            // 
            this.AliciAdresiLabel.AutoSize = true;
            this.AliciAdresiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AliciAdresiLabel.Location = new System.Drawing.Point(335, 210);
            this.AliciAdresiLabel.Name = "AliciAdresiLabel";
            this.AliciAdresiLabel.Size = new System.Drawing.Size(87, 16);
            this.AliciAdresiLabel.TabIndex = 0;
            this.AliciAdresiLabel.Text = "Alıcı Adresi";
            // 
            // AliciLabel
            // 
            this.AliciLabel.AutoSize = true;
            this.AliciLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AliciLabel.Location = new System.Drawing.Point(60, 210);
            this.AliciLabel.Name = "AliciLabel";
            this.AliciLabel.Size = new System.Drawing.Size(38, 16);
            this.AliciLabel.TabIndex = 0;
            this.AliciLabel.Text = "Alıcı";
            // 
            // gonderenAdresiLabel
            // 
            this.gonderenAdresiLabel.AutoSize = true;
            this.gonderenAdresiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gonderenAdresiLabel.Location = new System.Drawing.Point(335, 100);
            this.gonderenAdresiLabel.Name = "gonderenAdresiLabel";
            this.gonderenAdresiLabel.Size = new System.Drawing.Size(125, 16);
            this.gonderenAdresiLabel.TabIndex = 0;
            this.gonderenAdresiLabel.Text = "Gönderen Adresi";
            // 
            // gonderenLabel
            // 
            this.gonderenLabel.AutoSize = true;
            this.gonderenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gonderenLabel.Location = new System.Drawing.Point(60, 100);
            this.gonderenLabel.Name = "gonderenLabel";
            this.gonderenLabel.Size = new System.Drawing.Size(76, 16);
            this.gonderenLabel.TabIndex = 0;
            this.gonderenLabel.Text = "Gönderen";
            // 
            // gonderiTakipLabel
            // 
            this.gonderiTakipLabel.AutoSize = true;
            this.gonderiTakipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gonderiTakipLabel.Location = new System.Drawing.Point(157, 30);
            this.gonderiTakipLabel.Name = "gonderiTakipLabel";
            this.gonderiTakipLabel.Size = new System.Drawing.Size(241, 31);
            this.gonderiTakipLabel.TabIndex = 0;
            this.gonderiTakipLabel.Text = "GÖNDERİ TAKİP";
            // 
            // resim
            // 
            this.resim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.resim.ErrorImage = null;
            this.resim.InitialImage = null;
            this.resim.Location = new System.Drawing.Point(12, 44);
            this.resim.Name = "resim";
            this.resim.Size = new System.Drawing.Size(1342, 701);
            this.resim.TabIndex = 16;
            this.resim.TabStop = false;
            // 
            // kullaniciAnaSayfasi
            // 
            this.AcceptButton = this.sorgulaButonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.tarihSaatImleci);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.cikisButonu);
            this.Controls.Add(this.altaAlButonu);
            this.Controls.Add(this.sorgulaButonu);
            this.Controls.Add(this.gonderiNumarasiTextBox);
            this.Controls.Add(this.gonderiNumarasiArkaPlan);
            this.Controls.Add(this.gonderiNumarasiArkaPlanSerit);
            this.Controls.Add(this.dogrulamaKoduTextBox);
            this.Controls.Add(this.dogrulamaKoduArkaPlan);
            this.Controls.Add(this.dogrulamaKoduLabel);
            this.Controls.Add(this.dogrulamaKoduLabelArkaPlan);
            this.Controls.Add(this.yenilemeButonu);
            this.Controls.Add(this.arkaPlan2);
            this.Controls.Add(this.arkaPlan1);
            this.Controls.Add(this.kargoSorgulamaArkaPlan);
            this.Controls.Add(this.subelerimizButonu);
            this.Controls.Add(this.ucretHesaplaButonu);
            this.Controls.Add(this.resim);
            this.Controls.Add(this.arkaPlan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kullaniciAnaSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogrulamaKoduLabelArkaPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogrulamaKoduArkaPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gonderiNumarasiArkaPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gonderiNumarasiArkaPlanSerit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yenilemeButonu)).EndInit();
            this.kargoSorgulamaArkaPlan.ResumeLayout(false);
            this.kargoSorgulamaArkaPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox arkaPlan;
        private System.Windows.Forms.Label altaAlButonu;
        private System.Windows.Forms.Label cikisButonu;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Label tarihSaatImleci;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox arkaPlan1;
        private System.Windows.Forms.PictureBox arkaPlan2;
        private System.Windows.Forms.TextBox gonderiNumarasiTextBox;
        private System.Windows.Forms.PictureBox dogrulamaKoduLabelArkaPlan;
        private System.Windows.Forms.TextBox dogrulamaKoduTextBox;
        private System.Windows.Forms.Button sorgulaButonu;
        private System.Windows.Forms.PictureBox yenilemeButonu;
        private System.Windows.Forms.PictureBox dogrulamaKoduArkaPlan;
        private System.Windows.Forms.Label dogrulamaKoduLabel;
        private System.Windows.Forms.PictureBox gonderiNumarasiArkaPlan;
        private System.Windows.Forms.PictureBox gonderiNumarasiArkaPlanSerit;
        private System.Windows.Forms.Button ucretHesaplaButonu;
        private System.Windows.Forms.Button subelerimizButonu;
        private System.Windows.Forms.Panel kargoSorgulamaArkaPlan;
        private System.Windows.Forms.Label kargoYeri;
        private System.Windows.Forms.Label kargoDurumu;
        private System.Windows.Forms.Label teslimatTarihi;
        private System.Windows.Forms.Label gonderilisTarihi;
        private System.Windows.Forms.Label aliciAdresi;
        private System.Windows.Forms.Label alici;
        private System.Windows.Forms.Label gonderenAdresi;
        private System.Windows.Forms.Label gonderen;
        private System.Windows.Forms.Label kargoYeriLabel;
        private System.Windows.Forms.Label kargoDurumuLabel;
        private System.Windows.Forms.Label teslimatTarihiLabel;
        private System.Windows.Forms.Label gonderilisTarihiLabel;
        private System.Windows.Forms.Label AliciAdresiLabel;
        private System.Windows.Forms.Label AliciLabel;
        private System.Windows.Forms.Label gonderenAdresiLabel;
        private System.Windows.Forms.Label gonderenLabel;
        private System.Windows.Forms.Label gonderiTakipLabel;
        private System.Windows.Forms.PictureBox resim;
    }
}