namespace CargoAutomation
{
    partial class kullaniciYetkilendirSayfasi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullaniciYetkilendirSayfasi));
            this.arkaPlan = new System.Windows.Forms.PictureBox();
            this.kontrolPaneli = new System.Windows.Forms.Panel();
            this.cikisButonu = new System.Windows.Forms.Label();
            this.kullaniciYetkilendirmePaneli = new System.Windows.Forms.Panel();
            this.yetkiKaldirmaButonu = new System.Windows.Forms.Button();
            this.yetkilendirAramaSonucuPaneli = new System.Windows.Forms.DataGridView();
            this.yetkilendirButonu = new System.Windows.Forms.Button();
            this.adminRadioButonu = new System.Windows.Forms.RadioButton();
            this.personelRadioButonu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan)).BeginInit();
            this.kontrolPaneli.SuspendLayout();
            this.kullaniciYetkilendirmePaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yetkilendirAramaSonucuPaneli)).BeginInit();
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
            this.arkaPlan.Size = new System.Drawing.Size(415, 605);
            this.arkaPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.arkaPlan.TabIndex = 3;
            this.arkaPlan.TabStop = false;
            // 
            // kontrolPaneli
            // 
            this.kontrolPaneli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kontrolPaneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.kontrolPaneli.Controls.Add(this.personelRadioButonu);
            this.kontrolPaneli.Controls.Add(this.adminRadioButonu);
            this.kontrolPaneli.Location = new System.Drawing.Point(3, 3);
            this.kontrolPaneli.Name = "kontrolPaneli";
            this.kontrolPaneli.Size = new System.Drawing.Size(378, 36);
            this.kontrolPaneli.TabIndex = 0;
            this.kontrolPaneli.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kontrolPaneli_MouseDown);
            this.kontrolPaneli.MouseMove += new System.Windows.Forms.MouseEventHandler(this.kontrolPaneli_MouseMove);
            this.kontrolPaneli.MouseUp += new System.Windows.Forms.MouseEventHandler(this.kontrolPaneli_MouseUp);
            // 
            // cikisButonu
            // 
            this.cikisButonu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cikisButonu.AutoSize = true;
            this.cikisButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.cikisButonu.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButonu.ForeColor = System.Drawing.Color.White;
            this.cikisButonu.Location = new System.Drawing.Point(386, 3);
            this.cikisButonu.Name = "cikisButonu";
            this.cikisButonu.Size = new System.Drawing.Size(29, 34);
            this.cikisButonu.TabIndex = 0;
            this.cikisButonu.Text = "×";
            this.cikisButonu.Click += new System.EventHandler(this.cikisButonu_Click);
            // 
            // kullaniciYetkilendirmePaneli
            // 
            this.kullaniciYetkilendirmePaneli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kullaniciYetkilendirmePaneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.kullaniciYetkilendirmePaneli.Controls.Add(this.yetkiKaldirmaButonu);
            this.kullaniciYetkilendirmePaneli.Controls.Add(this.yetkilendirAramaSonucuPaneli);
            this.kullaniciYetkilendirmePaneli.Controls.Add(this.yetkilendirButonu);
            this.kullaniciYetkilendirmePaneli.Location = new System.Drawing.Point(1, 16);
            this.kullaniciYetkilendirmePaneli.Name = "kullaniciYetkilendirmePaneli";
            this.kullaniciYetkilendirmePaneli.Size = new System.Drawing.Size(415, 590);
            this.kullaniciYetkilendirmePaneli.TabIndex = 0;
            // 
            // yetkiKaldirmaButonu
            // 
            this.yetkiKaldirmaButonu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.yetkiKaldirmaButonu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.yetkiKaldirmaButonu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.yetkiKaldirmaButonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yetkiKaldirmaButonu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yetkiKaldirmaButonu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.yetkiKaldirmaButonu.Location = new System.Drawing.Point(234, 510);
            this.yetkiKaldirmaButonu.Name = "yetkiKaldirmaButonu";
            this.yetkiKaldirmaButonu.Size = new System.Drawing.Size(128, 46);
            this.yetkiKaldirmaButonu.TabIndex = 0;
            this.yetkiKaldirmaButonu.Text = "KALDIR";
            this.yetkiKaldirmaButonu.UseVisualStyleBackColor = false;
            this.yetkiKaldirmaButonu.Click += new System.EventHandler(this.yetkiKaldirmaButonu_Click);
            // 
            // yetkilendirAramaSonucuPaneli
            // 
            this.yetkilendirAramaSonucuPaneli.AllowUserToAddRows = false;
            this.yetkilendirAramaSonucuPaneli.AllowUserToDeleteRows = false;
            this.yetkilendirAramaSonucuPaneli.AllowUserToResizeColumns = false;
            this.yetkilendirAramaSonucuPaneli.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.yetkilendirAramaSonucuPaneli.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.yetkilendirAramaSonucuPaneli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.yetkilendirAramaSonucuPaneli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.yetkilendirAramaSonucuPaneli.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.yetkilendirAramaSonucuPaneli.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.yetkilendirAramaSonucuPaneli.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.yetkilendirAramaSonucuPaneli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yetkilendirAramaSonucuPaneli.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.yetkilendirAramaSonucuPaneli.Location = new System.Drawing.Point(10, 30);
            this.yetkilendirAramaSonucuPaneli.MultiSelect = false;
            this.yetkilendirAramaSonucuPaneli.Name = "yetkilendirAramaSonucuPaneli";
            this.yetkilendirAramaSonucuPaneli.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.yetkilendirAramaSonucuPaneli.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.yetkilendirAramaSonucuPaneli.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.yetkilendirAramaSonucuPaneli.Size = new System.Drawing.Size(395, 463);
            this.yetkilendirAramaSonucuPaneli.TabIndex = 0;
            // 
            // yetkilendirButonu
            // 
            this.yetkilendirButonu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yetkilendirButonu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.yetkilendirButonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yetkilendirButonu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yetkilendirButonu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.yetkilendirButonu.Location = new System.Drawing.Point(55, 510);
            this.yetkilendirButonu.Name = "yetkilendirButonu";
            this.yetkilendirButonu.Size = new System.Drawing.Size(128, 46);
            this.yetkilendirButonu.TabIndex = 0;
            this.yetkilendirButonu.Text = "YETKİLENDİR";
            this.yetkilendirButonu.UseVisualStyleBackColor = false;
            this.yetkilendirButonu.Click += new System.EventHandler(this.yetkilendirButonu_Click);
            // 
            // adminRadioButonu
            // 
            this.adminRadioButonu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adminRadioButonu.AutoSize = true;
            this.adminRadioButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminRadioButonu.ForeColor = System.Drawing.Color.Red;
            this.adminRadioButonu.Location = new System.Drawing.Point(60, 9);
            this.adminRadioButonu.Name = "adminRadioButonu";
            this.adminRadioButonu.Size = new System.Drawing.Size(74, 20);
            this.adminRadioButonu.TabIndex = 0;
            this.adminRadioButonu.TabStop = true;
            this.adminRadioButonu.Text = "ADMİN";
            this.adminRadioButonu.UseVisualStyleBackColor = true;
            this.adminRadioButonu.CheckedChanged += new System.EventHandler(this.adminRadioButonu_CheckedChanged);
            // 
            // personelRadioButonu
            // 
            this.personelRadioButonu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.personelRadioButonu.AutoSize = true;
            this.personelRadioButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelRadioButonu.ForeColor = System.Drawing.Color.Silver;
            this.personelRadioButonu.Location = new System.Drawing.Point(160, 9);
            this.personelRadioButonu.Name = "personelRadioButonu";
            this.personelRadioButonu.Size = new System.Drawing.Size(107, 20);
            this.personelRadioButonu.TabIndex = 0;
            this.personelRadioButonu.TabStop = true;
            this.personelRadioButonu.Text = "PERSONEL";
            this.personelRadioButonu.UseVisualStyleBackColor = true;
            this.personelRadioButonu.CheckedChanged += new System.EventHandler(this.personelRadioButonu_CheckedChanged);
            // 
            // kullaniciYetkilendirSayfasi
            // 
            this.AcceptButton = this.yetkilendirButonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.CancelButton = this.yetkiKaldirmaButonu;
            this.ClientSize = new System.Drawing.Size(417, 607);
            this.Controls.Add(this.cikisButonu);
            this.Controls.Add(this.kontrolPaneli);
            this.Controls.Add(this.kullaniciYetkilendirmePaneli);
            this.Controls.Add(this.arkaPlan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kullaniciYetkilendirSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan)).EndInit();
            this.kontrolPaneli.ResumeLayout(false);
            this.kontrolPaneli.PerformLayout();
            this.kullaniciYetkilendirmePaneli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yetkilendirAramaSonucuPaneli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox arkaPlan;
        private System.Windows.Forms.Panel kontrolPaneli;
        private System.Windows.Forms.Label cikisButonu;
        private System.Windows.Forms.Panel kullaniciYetkilendirmePaneli;
        private System.Windows.Forms.Button yetkilendirButonu;
        private System.Windows.Forms.DataGridView yetkilendirAramaSonucuPaneli;
        private System.Windows.Forms.Button yetkiKaldirmaButonu;
        private System.Windows.Forms.RadioButton personelRadioButonu;
        private System.Windows.Forms.RadioButton adminRadioButonu;
    }
}