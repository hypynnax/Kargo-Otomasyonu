namespace CargoAutomation
{
    partial class subelerimizSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subelerimizSayfasi));
            this.geriAlButonu = new System.Windows.Forms.Label();
            this.arkaPlan = new System.Windows.Forms.PictureBox();
            this.cikisButonu = new System.Windows.Forms.Label();
            this.altaAlButonu = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.Label();
            this.tarihSaatImleci = new System.Windows.Forms.Label();
            this.saat = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.konumArkaPlan = new System.Windows.Forms.PictureBox();
            this.konumTextBox = new System.Windows.Forms.TextBox();
            this.hataMesaji = new System.Windows.Forms.Label();
            this.hata = new System.Windows.Forms.Label();
            this.konumGirisiPanel = new System.Windows.Forms.Panel();
            this.aramaButonu = new System.Windows.Forms.Button();
            this.map = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konumArkaPlan)).BeginInit();
            this.konumGirisiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // geriAlButonu
            // 
            this.geriAlButonu.AutoSize = true;
            this.geriAlButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.geriAlButonu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.geriAlButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geriAlButonu.ForeColor = System.Drawing.Color.White;
            this.geriAlButonu.Location = new System.Drawing.Point(12, 6);
            this.geriAlButonu.Name = "geriAlButonu";
            this.geriAlButonu.Size = new System.Drawing.Size(33, 33);
            this.geriAlButonu.TabIndex = 0;
            this.geriAlButonu.Text = "<";
            this.geriAlButonu.Click += new System.EventHandler(this.geriAl_Click);
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
            this.arkaPlan.TabIndex = 4;
            this.arkaPlan.TabStop = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(175, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şubelerimiz Artık\r\nBir Tık Uzaklıkta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(180, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "   Şubelerimizi sorgulamak için bir\r\nlokasyon giriniz.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::CargoAutomation.Properties.Resources.subelerimiziBulunKonum;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::CargoAutomation.Properties.Resources.subelerimiziBulun;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(27, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // konumArkaPlan
            // 
            this.konumArkaPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.konumArkaPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.konumArkaPlan.ErrorImage = null;
            this.konumArkaPlan.InitialImage = null;
            this.konumArkaPlan.Location = new System.Drawing.Point(43, 207);
            this.konumArkaPlan.Name = "konumArkaPlan";
            this.konumArkaPlan.Size = new System.Drawing.Size(385, 50);
            this.konumArkaPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.konumArkaPlan.TabIndex = 7;
            this.konumArkaPlan.TabStop = false;
            // 
            // konumTextBox
            // 
            this.konumTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.konumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.konumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.konumTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.konumTextBox.Location = new System.Drawing.Point(52, 216);
            this.konumTextBox.Name = "konumTextBox";
            this.konumTextBox.Size = new System.Drawing.Size(325, 31);
            this.konumTextBox.TabIndex = 2;
            this.konumTextBox.Text = "Lokasyon Giriniz";
            this.konumTextBox.Enter += new System.EventHandler(this.konum_Enter);
            this.konumTextBox.Leave += new System.EventHandler(this.konum_Leave);
            // 
            // hataMesaji
            // 
            this.hataMesaji.AutoSize = true;
            this.hataMesaji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.hataMesaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hataMesaji.ForeColor = System.Drawing.Color.Red;
            this.hataMesaji.Location = new System.Drawing.Point(78, 263);
            this.hataMesaji.Name = "hataMesaji";
            this.hataMesaji.Size = new System.Drawing.Size(334, 16);
            this.hataMesaji.TabIndex = 0;
            this.hataMesaji.Text = "Bu konuma yakın bir şubemiz bulunmamaktadır.";
            this.hataMesaji.Visible = false;
            // 
            // hata
            // 
            this.hata.AutoSize = true;
            this.hata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.hata.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hata.ForeColor = System.Drawing.Color.Red;
            this.hata.Location = new System.Drawing.Point(46, 259);
            this.hata.Name = "hata";
            this.hata.Size = new System.Drawing.Size(26, 31);
            this.hata.TabIndex = 0;
            this.hata.Text = "*";
            this.hata.Visible = false;
            // 
            // konumGirisiPanel
            // 
            this.konumGirisiPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.konumGirisiPanel.Controls.Add(this.aramaButonu);
            this.konumGirisiPanel.Controls.Add(this.pictureBox2);
            this.konumGirisiPanel.Controls.Add(this.hataMesaji);
            this.konumGirisiPanel.Controls.Add(this.hata);
            this.konumGirisiPanel.Controls.Add(this.pictureBox1);
            this.konumGirisiPanel.Controls.Add(this.label1);
            this.konumGirisiPanel.Controls.Add(this.konumTextBox);
            this.konumGirisiPanel.Controls.Add(this.label2);
            this.konumGirisiPanel.Controls.Add(this.konumArkaPlan);
            this.konumGirisiPanel.Location = new System.Drawing.Point(24, 56);
            this.konumGirisiPanel.Name = "konumGirisiPanel";
            this.konumGirisiPanel.Size = new System.Drawing.Size(459, 302);
            this.konumGirisiPanel.TabIndex = 0;
            // 
            // aramaButonu
            // 
            this.aramaButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.aramaButonu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.aramaButonu.FlatAppearance.BorderSize = 0;
            this.aramaButonu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.aramaButonu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.aramaButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aramaButonu.Image = global::CargoAutomation.Properties.Resources.aramaIcon;
            this.aramaButonu.Location = new System.Drawing.Point(383, 216);
            this.aramaButonu.Name = "aramaButonu";
            this.aramaButonu.Size = new System.Drawing.Size(32, 32);
            this.aramaButonu.TabIndex = 1;
            this.aramaButonu.UseVisualStyleBackColor = false;
            this.aramaButonu.Click += new System.EventHandler(this.arama_Click);
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Location = new System.Drawing.Point(525, 56);
            this.map.MinimumSize = new System.Drawing.Size(20, 20);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(794, 660);
            this.map.TabIndex = 0;
            this.map.Visible = false;
            // 
            // subelerimizSayfasi
            // 
            this.AcceptButton = this.aramaButonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.map);
            this.Controls.Add(this.konumGirisiPanel);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.tarihSaatImleci);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.altaAlButonu);
            this.Controls.Add(this.cikisButonu);
            this.Controls.Add(this.geriAlButonu);
            this.Controls.Add(this.arkaPlan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "subelerimizSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konumArkaPlan)).EndInit();
            this.konumGirisiPanel.ResumeLayout(false);
            this.konumGirisiPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label geriAlButonu;
        private System.Windows.Forms.PictureBox arkaPlan;
        private System.Windows.Forms.Label cikisButonu;
        private System.Windows.Forms.Label altaAlButonu;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Label tarihSaatImleci;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox konumArkaPlan;
        private System.Windows.Forms.TextBox konumTextBox;
        private System.Windows.Forms.Label hataMesaji;
        private System.Windows.Forms.Label hata;
        private System.Windows.Forms.Panel konumGirisiPanel;
        private System.Windows.Forms.Button aramaButonu;
        private System.Windows.Forms.WebBrowser map;
    }
}