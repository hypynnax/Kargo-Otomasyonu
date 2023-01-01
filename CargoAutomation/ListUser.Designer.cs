namespace CargoAutomation
{
    partial class kullaniciListelemeSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullaniciListelemeSayfasi));
            this.arkaPlan = new System.Windows.Forms.PictureBox();
            this.kontrolPaneli = new System.Windows.Forms.Panel();
            this.cikisButonu = new System.Windows.Forms.Label();
            this.kullaniciListelemePaneli = new System.Windows.Forms.Panel();
            this.uyeRadioButton = new System.Windows.Forms.RadioButton();
            this.personelRadioButton = new System.Windows.Forms.RadioButton();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.listeleAramaSonucuDataGridView = new System.Windows.Forms.DataGridView();
            this.listelemeButonu = new System.Windows.Forms.Button();
            this.Baslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan)).BeginInit();
            this.kontrolPaneli.SuspendLayout();
            this.kullaniciListelemePaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeleAramaSonucuDataGridView)).BeginInit();
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
            this.kontrolPaneli.Controls.Add(this.Baslik);
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
            // kullaniciListelemePaneli
            // 
            this.kullaniciListelemePaneli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kullaniciListelemePaneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.kullaniciListelemePaneli.Controls.Add(this.uyeRadioButton);
            this.kullaniciListelemePaneli.Controls.Add(this.personelRadioButton);
            this.kullaniciListelemePaneli.Controls.Add(this.adminRadioButton);
            this.kullaniciListelemePaneli.Controls.Add(this.listeleAramaSonucuDataGridView);
            this.kullaniciListelemePaneli.Controls.Add(this.listelemeButonu);
            this.kullaniciListelemePaneli.Location = new System.Drawing.Point(1, 16);
            this.kullaniciListelemePaneli.Name = "kullaniciListelemePaneli";
            this.kullaniciListelemePaneli.Size = new System.Drawing.Size(415, 590);
            this.kullaniciListelemePaneli.TabIndex = 0;
            // 
            // uyeRadioButton
            // 
            this.uyeRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uyeRadioButton.AutoSize = true;
            this.uyeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeRadioButton.ForeColor = System.Drawing.Color.White;
            this.uyeRadioButton.Location = new System.Drawing.Point(284, 30);
            this.uyeRadioButton.Name = "uyeRadioButton";
            this.uyeRadioButton.Size = new System.Drawing.Size(51, 20);
            this.uyeRadioButton.TabIndex = 3;
            this.uyeRadioButton.TabStop = true;
            this.uyeRadioButton.Text = "Üye";
            this.uyeRadioButton.UseVisualStyleBackColor = true;
            // 
            // personelRadioButton
            // 
            this.personelRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.personelRadioButton.AutoSize = true;
            this.personelRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelRadioButton.ForeColor = System.Drawing.Color.White;
            this.personelRadioButton.Location = new System.Drawing.Point(174, 30);
            this.personelRadioButton.Name = "personelRadioButton";
            this.personelRadioButton.Size = new System.Drawing.Size(80, 20);
            this.personelRadioButton.TabIndex = 2;
            this.personelRadioButton.TabStop = true;
            this.personelRadioButton.Text = "Personel";
            this.personelRadioButton.UseVisualStyleBackColor = true;
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminRadioButton.ForeColor = System.Drawing.Color.White;
            this.adminRadioButton.Location = new System.Drawing.Point(80, 30);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Size = new System.Drawing.Size(64, 20);
            this.adminRadioButton.TabIndex = 1;
            this.adminRadioButton.TabStop = true;
            this.adminRadioButton.Text = "Admin";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            // 
            // listeleAramaSonucuDataGridView
            // 
            this.listeleAramaSonucuDataGridView.AllowUserToAddRows = false;
            this.listeleAramaSonucuDataGridView.AllowUserToDeleteRows = false;
            this.listeleAramaSonucuDataGridView.AllowUserToResizeColumns = false;
            this.listeleAramaSonucuDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.listeleAramaSonucuDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listeleAramaSonucuDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listeleAramaSonucuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeleAramaSonucuDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.listeleAramaSonucuDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.listeleAramaSonucuDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.listeleAramaSonucuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeleAramaSonucuDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.listeleAramaSonucuDataGridView.Location = new System.Drawing.Point(10, 68);
            this.listeleAramaSonucuDataGridView.MultiSelect = false;
            this.listeleAramaSonucuDataGridView.Name = "listeleAramaSonucuDataGridView";
            this.listeleAramaSonucuDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.listeleAramaSonucuDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.listeleAramaSonucuDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listeleAramaSonucuDataGridView.Size = new System.Drawing.Size(395, 425);
            this.listeleAramaSonucuDataGridView.TabIndex = 0;
            this.listeleAramaSonucuDataGridView.Visible = false;
            this.listeleAramaSonucuDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.listeleAramaSonucuDataGridView_RowHeaderMouseClick);
            // 
            // listelemeButonu
            // 
            this.listelemeButonu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listelemeButonu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.listelemeButonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listelemeButonu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listelemeButonu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.listelemeButonu.Location = new System.Drawing.Point(118, 510);
            this.listelemeButonu.Name = "listelemeButonu";
            this.listelemeButonu.Size = new System.Drawing.Size(180, 46);
            this.listelemeButonu.TabIndex = 4;
            this.listelemeButonu.Text = "LİSTELE";
            this.listelemeButonu.UseVisualStyleBackColor = false;
            this.listelemeButonu.Click += new System.EventHandler(this.listelemeButonu_Click);
            // 
            // Baslik
            // 
            this.Baslik.AutoSize = true;
            this.Baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Baslik.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Baslik.Location = new System.Drawing.Point(96, 6);
            this.Baslik.Name = "Baslik";
            this.Baslik.Size = new System.Drawing.Size(210, 25);
            this.Baslik.TabIndex = 0;
            this.Baslik.Text = "Kullanıcı Listeleme";
            // 
            // kullaniciListelemeSayfasi
            // 
            this.AcceptButton = this.listelemeButonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(417, 607);
            this.Controls.Add(this.cikisButonu);
            this.Controls.Add(this.kontrolPaneli);
            this.Controls.Add(this.kullaniciListelemePaneli);
            this.Controls.Add(this.arkaPlan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kullaniciListelemeSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan)).EndInit();
            this.kontrolPaneli.ResumeLayout(false);
            this.kontrolPaneli.PerformLayout();
            this.kullaniciListelemePaneli.ResumeLayout(false);
            this.kullaniciListelemePaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeleAramaSonucuDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox arkaPlan;
        private System.Windows.Forms.Panel kontrolPaneli;
        private System.Windows.Forms.Label cikisButonu;
        private System.Windows.Forms.Panel kullaniciListelemePaneli;
        private System.Windows.Forms.Button listelemeButonu;
        private System.Windows.Forms.DataGridView listeleAramaSonucuDataGridView;
        private System.Windows.Forms.RadioButton uyeRadioButton;
        private System.Windows.Forms.RadioButton personelRadioButton;
        private System.Windows.Forms.RadioButton adminRadioButton;
        private System.Windows.Forms.Label Baslik;
    }
}