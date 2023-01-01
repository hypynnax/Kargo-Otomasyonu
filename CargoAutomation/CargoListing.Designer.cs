namespace CargoAutomation
{
    partial class kargolariListelemeSayfasi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kargolariListelemeSayfasi));
            this.arkaPlan = new System.Windows.Forms.PictureBox();
            this.tarih = new System.Windows.Forms.Label();
            this.tarihSaatImleci = new System.Windows.Forms.Label();
            this.saat = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cikisButonu = new System.Windows.Forms.Label();
            this.altaAlButonu = new System.Windows.Forms.Label();
            this.geriAlButonu = new System.Windows.Forms.Label();
            this.kargolar = new System.Windows.Forms.PictureBox();
            this.kargolarLabel = new System.Windows.Forms.Label();
            this.kargolarListeDataGridView = new System.Windows.Forms.DataGridView();
            this.kargolarDetayDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargolarListeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargolarDetayDataGridView)).BeginInit();
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
            // kargolar
            // 
            this.kargolar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kargolar.BackColor = System.Drawing.Color.Gainsboro;
            this.kargolar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kargolar.ErrorImage = null;
            this.kargolar.InitialImage = null;
            this.kargolar.Location = new System.Drawing.Point(12, 45);
            this.kargolar.Name = "kargolar";
            this.kargolar.Size = new System.Drawing.Size(1342, 700);
            this.kargolar.TabIndex = 7;
            this.kargolar.TabStop = false;
            // 
            // kargolarLabel
            // 
            this.kargolarLabel.AutoSize = true;
            this.kargolarLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.kargolarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kargolarLabel.Location = new System.Drawing.Point(50, 80);
            this.kargolarLabel.Name = "kargolarLabel";
            this.kargolarLabel.Size = new System.Drawing.Size(368, 55);
            this.kargolarLabel.TabIndex = 0;
            this.kargolarLabel.Text = " KARGOLARIM";
            // 
            // kargolarListeDataGridView
            // 
            this.kargolarListeDataGridView.AllowUserToAddRows = false;
            this.kargolarListeDataGridView.AllowUserToDeleteRows = false;
            this.kargolarListeDataGridView.AllowUserToResizeColumns = false;
            this.kargolarListeDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            this.kargolarListeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.kargolarListeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.kargolarListeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kargolarListeDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.kargolarListeDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.kargolarListeDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.kargolarListeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kargolarListeDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.kargolarListeDataGridView.Location = new System.Drawing.Point(30, 160);
            this.kargolarListeDataGridView.MultiSelect = false;
            this.kargolarListeDataGridView.Name = "kargolarListeDataGridView";
            this.kargolarListeDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.kargolarListeDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.kargolarListeDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.kargolarListeDataGridView.Size = new System.Drawing.Size(350, 534);
            this.kargolarListeDataGridView.TabIndex = 0;
            this.kargolarListeDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.kargolarListeDataGridView_RowHeaderMouseClick);
            // 
            // kargolarDetayDataGridView
            // 
            this.kargolarDetayDataGridView.AllowUserToAddRows = false;
            this.kargolarDetayDataGridView.AllowUserToDeleteRows = false;
            this.kargolarDetayDataGridView.AllowUserToResizeColumns = false;
            this.kargolarDetayDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            this.kargolarDetayDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.kargolarDetayDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.kargolarDetayDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kargolarDetayDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.kargolarDetayDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.kargolarDetayDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.kargolarDetayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kargolarDetayDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.kargolarDetayDataGridView.Location = new System.Drawing.Point(378, 160);
            this.kargolarDetayDataGridView.MultiSelect = false;
            this.kargolarDetayDataGridView.Name = "kargolarDetayDataGridView";
            this.kargolarDetayDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.kargolarDetayDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.kargolarDetayDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.kargolarDetayDataGridView.Size = new System.Drawing.Size(953, 534);
            this.kargolarDetayDataGridView.TabIndex = 0;
            this.kargolarDetayDataGridView.Visible = false;
            // 
            // kargolariListelemeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.kargolarDetayDataGridView);
            this.Controls.Add(this.kargolarListeDataGridView);
            this.Controls.Add(this.kargolarLabel);
            this.Controls.Add(this.kargolar);
            this.Controls.Add(this.geriAlButonu);
            this.Controls.Add(this.altaAlButonu);
            this.Controls.Add(this.cikisButonu);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.tarihSaatImleci);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.arkaPlan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kargolariListelemeSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargolarListeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kargolarDetayDataGridView)).EndInit();
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
        private System.Windows.Forms.PictureBox kargolar;
        private System.Windows.Forms.Label kargolarLabel;
        private System.Windows.Forms.DataGridView kargolarListeDataGridView;
        private System.Windows.Forms.DataGridView kargolarDetayDataGridView;
    }
}