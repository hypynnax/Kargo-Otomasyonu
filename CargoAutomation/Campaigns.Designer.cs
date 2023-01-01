namespace CargoAutomation
{
    partial class kampanyalarSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kampanyalarSayfasi));
            this.arkaPlan = new System.Windows.Forms.PictureBox();
            this.tarih = new System.Windows.Forms.Label();
            this.tarihSaatImleci = new System.Windows.Forms.Label();
            this.saat = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cikisButonu = new System.Windows.Forms.Label();
            this.altaAlButonu = new System.Windows.Forms.Label();
            this.geriAlButonu = new System.Windows.Forms.Label();
            this.yapimAsamasiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan)).BeginInit();
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
            this.arkaPlan.TabIndex = 6;
            this.arkaPlan.TabStop = false;
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
            // yapimAsamasiLabel
            // 
            this.yapimAsamasiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yapimAsamasiLabel.AutoSize = true;
            this.yapimAsamasiLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.yapimAsamasiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yapimAsamasiLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.yapimAsamasiLabel.Location = new System.Drawing.Point(201, 301);
            this.yapimAsamasiLabel.Name = "yapimAsamasiLabel";
            this.yapimAsamasiLabel.Size = new System.Drawing.Size(961, 165);
            this.yapimAsamasiLabel.TabIndex = 0;
            this.yapimAsamasiLabel.Text = "YAPIM AŞAMASINDADIR\r\n\r\nANLAYIŞINIZ İÇİN TEŞEKKÜR EDERİZ...";
            // 
            // kampanyalarSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.yapimAsamasiLabel);
            this.Controls.Add(this.geriAlButonu);
            this.Controls.Add(this.altaAlButonu);
            this.Controls.Add(this.cikisButonu);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.tarihSaatImleci);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.arkaPlan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kampanyalarSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox arkaPlan;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Label tarihSaatImleci;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label cikisButonu;
        private System.Windows.Forms.Label altaAlButonu;
        private System.Windows.Forms.Label geriAlButonu;
        private System.Windows.Forms.Label yapimAsamasiLabel;
    }
}