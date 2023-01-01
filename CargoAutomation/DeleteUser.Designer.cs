namespace CargoAutomation
{
    partial class kullaniciSilmeSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullaniciSilmeSayfasi));
            this.arkaPlan = new System.Windows.Forms.PictureBox();
            this.kontrolPaneli = new System.Windows.Forms.Panel();
            this.cikisButonu = new System.Windows.Forms.Label();
            this.kullaniciSilmePaneli = new System.Windows.Forms.Panel();
            this.silmeAramaSonucuDataGridView = new System.Windows.Forms.DataGridView();
            this.yildiz = new System.Windows.Forms.Label();
            this.aramaButonu = new System.Windows.Forms.Button();
            this.aramaTextBox = new System.Windows.Forms.TextBox();
            this.aramaComboBox = new System.Windows.Forms.ComboBox();
            this.aramaLabel = new System.Windows.Forms.Label();
            this.silmeButonu = new System.Windows.Forms.Button();
            this.Baslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan)).BeginInit();
            this.kontrolPaneli.SuspendLayout();
            this.kullaniciSilmePaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.silmeAramaSonucuDataGridView)).BeginInit();
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
            // kullaniciSilmePaneli
            // 
            this.kullaniciSilmePaneli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kullaniciSilmePaneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.kullaniciSilmePaneli.Controls.Add(this.silmeAramaSonucuDataGridView);
            this.kullaniciSilmePaneli.Controls.Add(this.yildiz);
            this.kullaniciSilmePaneli.Controls.Add(this.aramaButonu);
            this.kullaniciSilmePaneli.Controls.Add(this.aramaTextBox);
            this.kullaniciSilmePaneli.Controls.Add(this.aramaComboBox);
            this.kullaniciSilmePaneli.Controls.Add(this.aramaLabel);
            this.kullaniciSilmePaneli.Controls.Add(this.silmeButonu);
            this.kullaniciSilmePaneli.Location = new System.Drawing.Point(1, 16);
            this.kullaniciSilmePaneli.Name = "kullaniciSilmePaneli";
            this.kullaniciSilmePaneli.Size = new System.Drawing.Size(415, 590);
            this.kullaniciSilmePaneli.TabIndex = 0;
            // 
            // silmeAramaSonucuDataGridView
            // 
            this.silmeAramaSonucuDataGridView.AllowUserToAddRows = false;
            this.silmeAramaSonucuDataGridView.AllowUserToDeleteRows = false;
            this.silmeAramaSonucuDataGridView.AllowUserToResizeColumns = false;
            this.silmeAramaSonucuDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.silmeAramaSonucuDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.silmeAramaSonucuDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.silmeAramaSonucuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.silmeAramaSonucuDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.silmeAramaSonucuDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.silmeAramaSonucuDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.silmeAramaSonucuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.silmeAramaSonucuDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.silmeAramaSonucuDataGridView.Location = new System.Drawing.Point(10, 200);
            this.silmeAramaSonucuDataGridView.MultiSelect = false;
            this.silmeAramaSonucuDataGridView.Name = "silmeAramaSonucuDataGridView";
            this.silmeAramaSonucuDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.silmeAramaSonucuDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.silmeAramaSonucuDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.silmeAramaSonucuDataGridView.Size = new System.Drawing.Size(395, 294);
            this.silmeAramaSonucuDataGridView.TabIndex = 0;
            this.silmeAramaSonucuDataGridView.Visible = false;
            // 
            // yildiz
            // 
            this.yildiz.AutoSize = true;
            this.yildiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.yildiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildiz.ForeColor = System.Drawing.Color.Red;
            this.yildiz.Location = new System.Drawing.Point(30, 139);
            this.yildiz.Name = "yildiz";
            this.yildiz.Size = new System.Drawing.Size(25, 31);
            this.yildiz.TabIndex = 0;
            this.yildiz.Text = "*";
            this.yildiz.Visible = false;
            // 
            // aramaButonu
            // 
            this.aramaButonu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aramaButonu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.aramaButonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aramaButonu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramaButonu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.aramaButonu.Location = new System.Drawing.Point(313, 130);
            this.aramaButonu.Name = "aramaButonu";
            this.aramaButonu.Size = new System.Drawing.Size(79, 39);
            this.aramaButonu.TabIndex = 0;
            this.aramaButonu.Text = "ARA";
            this.aramaButonu.UseVisualStyleBackColor = false;
            this.aramaButonu.Visible = false;
            this.aramaButonu.Click += new System.EventHandler(this.aramaButonu_Click);
            // 
            // aramaTextBox
            // 
            this.aramaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aramaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramaTextBox.ForeColor = System.Drawing.Color.Black;
            this.aramaTextBox.Location = new System.Drawing.Point(61, 139);
            this.aramaTextBox.Name = "aramaTextBox";
            this.aramaTextBox.Size = new System.Drawing.Size(246, 22);
            this.aramaTextBox.TabIndex = 0;
            this.aramaTextBox.Visible = false;
            // 
            // aramaComboBox
            // 
            this.aramaComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aramaComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.aramaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aramaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramaComboBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.aramaComboBox.FormattingEnabled = true;
            this.aramaComboBox.Items.AddRange(new object[] {
            "Kullanıcı Adı",
            "Adı Soyadı",
            "Telefon",
            "Rol"});
            this.aramaComboBox.Location = new System.Drawing.Point(98, 67);
            this.aramaComboBox.Name = "aramaComboBox";
            this.aramaComboBox.Size = new System.Drawing.Size(256, 24);
            this.aramaComboBox.TabIndex = 0;
            this.aramaComboBox.SelectedIndexChanged += new System.EventHandler(this.aramaComboBox_SelectedIndexChanged);
            // 
            // aramaLabel
            // 
            this.aramaLabel.AutoSize = true;
            this.aramaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramaLabel.ForeColor = System.Drawing.Color.White;
            this.aramaLabel.Location = new System.Drawing.Point(30, 70);
            this.aramaLabel.Name = "aramaLabel";
            this.aramaLabel.Size = new System.Drawing.Size(39, 16);
            this.aramaLabel.TabIndex = 0;
            this.aramaLabel.Text = "ARA";
            // 
            // silmeButonu
            // 
            this.silmeButonu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.silmeButonu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.silmeButonu.Enabled = false;
            this.silmeButonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.silmeButonu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silmeButonu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.silmeButonu.Location = new System.Drawing.Point(118, 510);
            this.silmeButonu.Name = "silmeButonu";
            this.silmeButonu.Size = new System.Drawing.Size(180, 46);
            this.silmeButonu.TabIndex = 0;
            this.silmeButonu.Text = "SİL";
            this.silmeButonu.UseVisualStyleBackColor = false;
            this.silmeButonu.Visible = false;
            this.silmeButonu.Click += new System.EventHandler(this.silmeButonu_Click);
            // 
            // Baslik
            // 
            this.Baslik.AutoSize = true;
            this.Baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Baslik.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Baslik.Location = new System.Drawing.Point(124, 6);
            this.Baslik.Name = "Baslik";
            this.Baslik.Size = new System.Drawing.Size(167, 25);
            this.Baslik.TabIndex = 0;
            this.Baslik.Text = "Kullanıcı Silme";
            // 
            // kullaniciSilmeSayfasi
            // 
            this.AcceptButton = this.aramaButonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(417, 607);
            this.Controls.Add(this.cikisButonu);
            this.Controls.Add(this.kontrolPaneli);
            this.Controls.Add(this.kullaniciSilmePaneli);
            this.Controls.Add(this.arkaPlan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kullaniciSilmeSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan)).EndInit();
            this.kontrolPaneli.ResumeLayout(false);
            this.kontrolPaneli.PerformLayout();
            this.kullaniciSilmePaneli.ResumeLayout(false);
            this.kullaniciSilmePaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.silmeAramaSonucuDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox arkaPlan;
        private System.Windows.Forms.Panel kontrolPaneli;
        private System.Windows.Forms.Label cikisButonu;
        private System.Windows.Forms.Panel kullaniciSilmePaneli;
        private System.Windows.Forms.Label yildiz;
        private System.Windows.Forms.Button aramaButonu;
        private System.Windows.Forms.TextBox aramaTextBox;
        private System.Windows.Forms.ComboBox aramaComboBox;
        private System.Windows.Forms.Label aramaLabel;
        private System.Windows.Forms.Button silmeButonu;
        private System.Windows.Forms.DataGridView silmeAramaSonucuDataGridView;
        private System.Windows.Forms.Label Baslik;
    }
}