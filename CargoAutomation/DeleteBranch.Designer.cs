namespace CargoAutomation
{
    partial class subeSilmeEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subeSilmeEkrani));
            this.subeSilmePaneli = new System.Windows.Forms.Panel();
            this.cikisButonu = new System.Windows.Forms.Label();
            this.kontrolPaneli = new System.Windows.Forms.Panel();
            this.subeAramaSonucuDataGridView = new System.Windows.Forms.DataGridView();
            this.yildiz = new System.Windows.Forms.Label();
            this.aramaButonu = new System.Windows.Forms.Button();
            this.aramaTextBox = new System.Windows.Forms.TextBox();
            this.silmeButonu = new System.Windows.Forms.Button();
            this.Baslik = new System.Windows.Forms.Label();
            this.subeSilmePaneli.SuspendLayout();
            this.kontrolPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subeAramaSonucuDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // subeSilmePaneli
            // 
            this.subeSilmePaneli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subeSilmePaneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.subeSilmePaneli.Controls.Add(this.cikisButonu);
            this.subeSilmePaneli.Controls.Add(this.kontrolPaneli);
            this.subeSilmePaneli.Controls.Add(this.subeAramaSonucuDataGridView);
            this.subeSilmePaneli.Controls.Add(this.yildiz);
            this.subeSilmePaneli.Controls.Add(this.aramaButonu);
            this.subeSilmePaneli.Controls.Add(this.aramaTextBox);
            this.subeSilmePaneli.Controls.Add(this.silmeButonu);
            this.subeSilmePaneli.Location = new System.Drawing.Point(1, 1);
            this.subeSilmePaneli.Name = "subeSilmePaneli";
            this.subeSilmePaneli.Size = new System.Drawing.Size(415, 590);
            this.subeSilmePaneli.TabIndex = 0;
            // 
            // cikisButonu
            // 
            this.cikisButonu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cikisButonu.AutoSize = true;
            this.cikisButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.cikisButonu.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButonu.ForeColor = System.Drawing.Color.White;
            this.cikisButonu.Location = new System.Drawing.Point(385, 3);
            this.cikisButonu.Name = "cikisButonu";
            this.cikisButonu.Size = new System.Drawing.Size(29, 34);
            this.cikisButonu.TabIndex = 1;
            this.cikisButonu.Text = "×";
            this.cikisButonu.Click += new System.EventHandler(this.cikisButonu_Click);
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
            this.kontrolPaneli.TabIndex = 1;
            this.kontrolPaneli.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kontrolPaneli_MouseDown);
            this.kontrolPaneli.MouseMove += new System.Windows.Forms.MouseEventHandler(this.kontrolPaneli_MouseMove);
            this.kontrolPaneli.MouseUp += new System.Windows.Forms.MouseEventHandler(this.kontrolPaneli_MouseUp);
            // 
            // subeAramaSonucuDataGridView
            // 
            this.subeAramaSonucuDataGridView.AllowUserToAddRows = false;
            this.subeAramaSonucuDataGridView.AllowUserToDeleteRows = false;
            this.subeAramaSonucuDataGridView.AllowUserToResizeColumns = false;
            this.subeAramaSonucuDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.subeAramaSonucuDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.subeAramaSonucuDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.subeAramaSonucuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.subeAramaSonucuDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.subeAramaSonucuDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.subeAramaSonucuDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.subeAramaSonucuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subeAramaSonucuDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.subeAramaSonucuDataGridView.Location = new System.Drawing.Point(10, 100);
            this.subeAramaSonucuDataGridView.MultiSelect = false;
            this.subeAramaSonucuDataGridView.Name = "subeAramaSonucuDataGridView";
            this.subeAramaSonucuDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.subeAramaSonucuDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.subeAramaSonucuDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.subeAramaSonucuDataGridView.Size = new System.Drawing.Size(395, 400);
            this.subeAramaSonucuDataGridView.TabIndex = 0;
            this.subeAramaSonucuDataGridView.Visible = false;
            // 
            // yildiz
            // 
            this.yildiz.AutoSize = true;
            this.yildiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.yildiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yildiz.ForeColor = System.Drawing.Color.Red;
            this.yildiz.Location = new System.Drawing.Point(30, 50);
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
            this.aramaButonu.Location = new System.Drawing.Point(315, 40);
            this.aramaButonu.Name = "aramaButonu";
            this.aramaButonu.Size = new System.Drawing.Size(79, 39);
            this.aramaButonu.TabIndex = 0;
            this.aramaButonu.Text = "ARA";
            this.aramaButonu.UseVisualStyleBackColor = false;
            this.aramaButonu.Click += new System.EventHandler(this.aramaButonu_Click);
            // 
            // aramaTextBox
            // 
            this.aramaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aramaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aramaTextBox.ForeColor = System.Drawing.Color.Black;
            this.aramaTextBox.Location = new System.Drawing.Point(60, 50);
            this.aramaTextBox.Name = "aramaTextBox";
            this.aramaTextBox.Size = new System.Drawing.Size(246, 22);
            this.aramaTextBox.TabIndex = 0;
            // 
            // silmeButonu
            // 
            this.silmeButonu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.silmeButonu.BackColor = System.Drawing.Color.DeepSkyBlue;
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
            this.Baslik.Location = new System.Drawing.Point(131, 8);
            this.Baslik.Name = "Baslik";
            this.Baslik.Size = new System.Drawing.Size(131, 25);
            this.Baslik.TabIndex = 0;
            this.Baslik.Text = "Şube Silme";
            // 
            // subeSilmeEkrani
            // 
            this.AcceptButton = this.aramaButonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(417, 592);
            this.Controls.Add(this.subeSilmePaneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "subeSilmeEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.subeSilmePaneli.ResumeLayout(false);
            this.subeSilmePaneli.PerformLayout();
            this.kontrolPaneli.ResumeLayout(false);
            this.kontrolPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subeAramaSonucuDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel subeSilmePaneli;
        private System.Windows.Forms.DataGridView subeAramaSonucuDataGridView;
        private System.Windows.Forms.Label yildiz;
        private System.Windows.Forms.Button aramaButonu;
        private System.Windows.Forms.TextBox aramaTextBox;
        private System.Windows.Forms.Button silmeButonu;
        private System.Windows.Forms.Panel kontrolPaneli;
        private System.Windows.Forms.Label cikisButonu;
        private System.Windows.Forms.Label Baslik;
    }
}