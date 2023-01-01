namespace CargoAutomation
{
    partial class girisEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisEkrani));
            this.arkaPlan = new System.Windows.Forms.PictureBox();
            this.kontrolPaneli = new System.Windows.Forms.Panel();
            this.cikisButonu = new System.Windows.Forms.Label();
            this.kullaniciAdiLabel = new System.Windows.Forms.Label();
            this.kullaniciArkaPlan = new System.Windows.Forms.PictureBox();
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.parolaLabel = new System.Windows.Forms.Label();
            this.parolaArkaPlan = new System.Windows.Forms.PictureBox();
            this.parolaTextBox = new System.Windows.Forms.TextBox();
            this.beniHatirlaCheckBox = new System.Windows.Forms.CheckBox();
            this.girisButonu = new System.Windows.Forms.Button();
            this.şifreYenilemeButonu = new System.Windows.Forms.LinkLabel();
            this.hesapAcmaLabel = new System.Windows.Forms.Label();
            this.hesapAcmaButonu = new System.Windows.Forms.LinkLabel();
            this.kullaniciGirisiButonu = new System.Windows.Forms.Label();
            this.logoYazisi = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.parolaGoster = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciArkaPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parolaArkaPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parolaGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // arkaPlan
            // 
            this.arkaPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.arkaPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.arkaPlan, "arkaPlan");
            this.arkaPlan.Name = "arkaPlan";
            this.arkaPlan.TabStop = false;
            // 
            // kontrolPaneli
            // 
            this.kontrolPaneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.kontrolPaneli.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.kontrolPaneli, "kontrolPaneli");
            this.kontrolPaneli.Name = "kontrolPaneli";
            this.kontrolPaneli.TabStop = true;
            this.kontrolPaneli.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kontrolPaneli_MouseDown);
            this.kontrolPaneli.MouseMove += new System.Windows.Forms.MouseEventHandler(this.kontrolPaneli_MouseMove);
            this.kontrolPaneli.MouseUp += new System.Windows.Forms.MouseEventHandler(this.kontrolPaneli_MouseUp);
            // 
            // cikisButonu
            // 
            resources.ApplyResources(this.cikisButonu, "cikisButonu");
            this.cikisButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.cikisButonu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisButonu.ForeColor = System.Drawing.Color.White;
            this.cikisButonu.Name = "cikisButonu";
            this.cikisButonu.Click += new System.EventHandler(this.cikis_Click);
            // 
            // kullaniciAdiLabel
            // 
            resources.ApplyResources(this.kullaniciAdiLabel, "kullaniciAdiLabel");
            this.kullaniciAdiLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.kullaniciAdiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(145)))), ((int)(((byte)(241)))));
            this.kullaniciAdiLabel.Name = "kullaniciAdiLabel";
            // 
            // kullaniciArkaPlan
            // 
            this.kullaniciArkaPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.kullaniciArkaPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.kullaniciArkaPlan, "kullaniciArkaPlan");
            this.kullaniciArkaPlan.Name = "kullaniciArkaPlan";
            this.kullaniciArkaPlan.TabStop = false;
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.kullaniciAdiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.kullaniciAdiTextBox, "kullaniciAdiTextBox");
            this.kullaniciAdiTextBox.ForeColor = System.Drawing.Color.White;
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            // 
            // parolaLabel
            // 
            resources.ApplyResources(this.parolaLabel, "parolaLabel");
            this.parolaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.parolaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(155)))));
            this.parolaLabel.Name = "parolaLabel";
            // 
            // parolaArkaPlan
            // 
            this.parolaArkaPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.parolaArkaPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.parolaArkaPlan, "parolaArkaPlan");
            this.parolaArkaPlan.Name = "parolaArkaPlan";
            this.parolaArkaPlan.TabStop = false;
            // 
            // parolaTextBox
            // 
            resources.ApplyResources(this.parolaTextBox, "parolaTextBox");
            this.parolaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.parolaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.parolaTextBox.ForeColor = System.Drawing.Color.White;
            this.parolaTextBox.Name = "parolaTextBox";
            this.parolaTextBox.UseSystemPasswordChar = true;
            // 
            // beniHatirlaCheckBox
            // 
            resources.ApplyResources(this.beniHatirlaCheckBox, "beniHatirlaCheckBox");
            this.beniHatirlaCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.beniHatirlaCheckBox.Checked = true;
            this.beniHatirlaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.beniHatirlaCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(155)))));
            this.beniHatirlaCheckBox.Name = "beniHatirlaCheckBox";
            this.beniHatirlaCheckBox.UseVisualStyleBackColor = false;
            this.beniHatirlaCheckBox.CheckedChanged += new System.EventHandler(this.beniHatirla_CheckedChanged);
            // 
            // girisButonu
            // 
            this.girisButonu.BackColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.girisButonu, "girisButonu");
            this.girisButonu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.girisButonu.Name = "girisButonu";
            this.girisButonu.UseVisualStyleBackColor = false;
            this.girisButonu.Click += new System.EventHandler(this.giris_Click);
            // 
            // şifreYenilemeButonu
            // 
            this.şifreYenilemeButonu.ActiveLinkColor = System.Drawing.Color.Purple;
            resources.ApplyResources(this.şifreYenilemeButonu, "şifreYenilemeButonu");
            this.şifreYenilemeButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.şifreYenilemeButonu.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(152)))));
            this.şifreYenilemeButonu.Name = "şifreYenilemeButonu";
            this.şifreYenilemeButonu.TabStop = true;
            this.şifreYenilemeButonu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.şifreYenileme_LinkClicked);
            // 
            // hesapAcmaLabel
            // 
            resources.ApplyResources(this.hesapAcmaLabel, "hesapAcmaLabel");
            this.hesapAcmaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.hesapAcmaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(155)))));
            this.hesapAcmaLabel.Name = "hesapAcmaLabel";
            // 
            // hesapAcmaButonu
            // 
            this.hesapAcmaButonu.ActiveLinkColor = System.Drawing.Color.Purple;
            resources.ApplyResources(this.hesapAcmaButonu, "hesapAcmaButonu");
            this.hesapAcmaButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.hesapAcmaButonu.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(152)))));
            this.hesapAcmaButonu.Name = "hesapAcmaButonu";
            this.hesapAcmaButonu.TabStop = true;
            this.hesapAcmaButonu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hesapAcma_LinkClicked);
            // 
            // kullaniciGirisiButonu
            // 
            resources.ApplyResources(this.kullaniciGirisiButonu, "kullaniciGirisiButonu");
            this.kullaniciGirisiButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.kullaniciGirisiButonu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(155)))));
            this.kullaniciGirisiButonu.Name = "kullaniciGirisiButonu";
            this.kullaniciGirisiButonu.Click += new System.EventHandler(this.kullaniciGirisi_Click);
            // 
            // logoYazisi
            // 
            resources.ApplyResources(this.logoYazisi, "logoYazisi");
            this.logoYazisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.logoYazisi.ForeColor = System.Drawing.Color.DodgerBlue;
            this.logoYazisi.Name = "logoYazisi";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            resources.ApplyResources(this.logo, "logo");
            this.logo.Name = "logo";
            this.logo.TabStop = false;
            // 
            // parolaGoster
            // 
            this.parolaGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            resources.ApplyResources(this.parolaGoster, "parolaGoster");
            this.parolaGoster.Image = global::CargoAutomation.Properties.Resources.parolaKapali;
            this.parolaGoster.Name = "parolaGoster";
            this.parolaGoster.TabStop = false;
            this.parolaGoster.Click += new System.EventHandler(this.parolaGoster_Click);
            // 
            // girisEkrani
            // 
            this.AcceptButton = this.girisButonu;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.logoYazisi);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.kullaniciGirisiButonu);
            this.Controls.Add(this.hesapAcmaButonu);
            this.Controls.Add(this.hesapAcmaLabel);
            this.Controls.Add(this.şifreYenilemeButonu);
            this.Controls.Add(this.girisButonu);
            this.Controls.Add(this.beniHatirlaCheckBox);
            this.Controls.Add(this.parolaGoster);
            this.Controls.Add(this.parolaTextBox);
            this.Controls.Add(this.parolaArkaPlan);
            this.Controls.Add(this.parolaLabel);
            this.Controls.Add(this.kullaniciAdiTextBox);
            this.Controls.Add(this.kullaniciArkaPlan);
            this.Controls.Add(this.kullaniciAdiLabel);
            this.Controls.Add(this.cikisButonu);
            this.Controls.Add(this.kontrolPaneli);
            this.Controls.Add(this.arkaPlan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "girisEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciArkaPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parolaArkaPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parolaGoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox arkaPlan;
        private System.Windows.Forms.Panel kontrolPaneli;
        private System.Windows.Forms.Label cikisButonu;
        private System.Windows.Forms.Label kullaniciAdiLabel;
        private System.Windows.Forms.PictureBox kullaniciArkaPlan;
        private System.Windows.Forms.TextBox kullaniciAdiTextBox;
        private System.Windows.Forms.Label parolaLabel;
        private System.Windows.Forms.PictureBox parolaArkaPlan;
        private System.Windows.Forms.TextBox parolaTextBox;
        private System.Windows.Forms.PictureBox parolaGoster;
        private System.Windows.Forms.CheckBox beniHatirlaCheckBox;
        private System.Windows.Forms.Button girisButonu;
        private System.Windows.Forms.LinkLabel şifreYenilemeButonu;
        private System.Windows.Forms.Label hesapAcmaLabel;
        private System.Windows.Forms.LinkLabel hesapAcmaButonu;
        private System.Windows.Forms.Label kullaniciGirisiButonu;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label logoYazisi;
    }
}

