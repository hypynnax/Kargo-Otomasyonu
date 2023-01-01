namespace CargoAutomation
{
    partial class kodDogrulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kodDogrulama));
            this.arka_plan = new System.Windows.Forms.PictureBox();
            this.kontrolPaneli = new System.Windows.Forms.Panel();
            this.dogrulamaKoduLabel = new System.Windows.Forms.Label();
            this.altaAlButonu = new System.Windows.Forms.Label();
            this.cikisButonu = new System.Windows.Forms.Label();
            this.dogrulamaKoduArkaPlan = new System.Windows.Forms.PictureBox();
            this.dogrulamaKoduTextBox = new System.Windows.Forms.TextBox();
            this.dogrulaButonu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.arka_plan)).BeginInit();
            this.kontrolPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogrulamaKoduArkaPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // arka_plan
            // 
            this.arka_plan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.arka_plan.ErrorImage = null;
            this.arka_plan.InitialImage = null;
            this.arka_plan.Location = new System.Drawing.Point(1, 1);
            this.arka_plan.Name = "arka_plan";
            this.arka_plan.Size = new System.Drawing.Size(398, 248);
            this.arka_plan.TabIndex = 1;
            this.arka_plan.TabStop = false;
            // 
            // kontrolPaneli
            // 
            this.kontrolPaneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.kontrolPaneli.Controls.Add(this.dogrulamaKoduLabel);
            this.kontrolPaneli.Location = new System.Drawing.Point(2, 2);
            this.kontrolPaneli.Name = "kontrolPaneli";
            this.kontrolPaneli.Size = new System.Drawing.Size(333, 36);
            this.kontrolPaneli.TabIndex = 0;
            this.kontrolPaneli.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kontrolPaneli_MouseDown);
            this.kontrolPaneli.MouseMove += new System.Windows.Forms.MouseEventHandler(this.kontrolPaneli_MouseMove);
            this.kontrolPaneli.MouseUp += new System.Windows.Forms.MouseEventHandler(this.kontrolPaneli_MouseUp);
            // 
            // dogrulamaKoduLabel
            // 
            this.dogrulamaKoduLabel.AutoSize = true;
            this.dogrulamaKoduLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.dogrulamaKoduLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogrulamaKoduLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(145)))), ((int)(((byte)(241)))));
            this.dogrulamaKoduLabel.Location = new System.Drawing.Point(10, 10);
            this.dogrulamaKoduLabel.Name = "dogrulamaKoduLabel";
            this.dogrulamaKoduLabel.Size = new System.Drawing.Size(100, 13);
            this.dogrulamaKoduLabel.TabIndex = 0;
            this.dogrulamaKoduLabel.Text = "Doğrulama Kodu";
            // 
            // altaAlButonu
            // 
            this.altaAlButonu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.altaAlButonu.AutoSize = true;
            this.altaAlButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.altaAlButonu.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.altaAlButonu.ForeColor = System.Drawing.Color.White;
            this.altaAlButonu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.altaAlButonu.Location = new System.Drawing.Point(341, 3);
            this.altaAlButonu.Name = "altaAlButonu";
            this.altaAlButonu.Size = new System.Drawing.Size(27, 34);
            this.altaAlButonu.TabIndex = 0;
            this.altaAlButonu.Text = "━";
            this.altaAlButonu.Click += new System.EventHandler(this.altaAl_Click);
            // 
            // cikisButonu
            // 
            this.cikisButonu.AutoSize = true;
            this.cikisButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.cikisButonu.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButonu.ForeColor = System.Drawing.Color.White;
            this.cikisButonu.Location = new System.Drawing.Point(369, 3);
            this.cikisButonu.Name = "cikisButonu";
            this.cikisButonu.Size = new System.Drawing.Size(29, 34);
            this.cikisButonu.TabIndex = 0;
            this.cikisButonu.Text = "×";
            this.cikisButonu.Click += new System.EventHandler(this.cikis_Click);
            // 
            // dogrulamaKoduArkaPlan
            // 
            this.dogrulamaKoduArkaPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.dogrulamaKoduArkaPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dogrulamaKoduArkaPlan.ErrorImage = null;
            this.dogrulamaKoduArkaPlan.InitialImage = null;
            this.dogrulamaKoduArkaPlan.Location = new System.Drawing.Point(75, 100);
            this.dogrulamaKoduArkaPlan.Name = "dogrulamaKoduArkaPlan";
            this.dogrulamaKoduArkaPlan.Size = new System.Drawing.Size(250, 40);
            this.dogrulamaKoduArkaPlan.TabIndex = 17;
            this.dogrulamaKoduArkaPlan.TabStop = false;
            // 
            // dogrulamaKoduTextBox
            // 
            this.dogrulamaKoduTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.dogrulamaKoduTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dogrulamaKoduTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dogrulamaKoduTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogrulamaKoduTextBox.ForeColor = System.Drawing.Color.White;
            this.dogrulamaKoduTextBox.Location = new System.Drawing.Point(87, 109);
            this.dogrulamaKoduTextBox.Name = "dogrulamaKoduTextBox";
            this.dogrulamaKoduTextBox.Size = new System.Drawing.Size(222, 22);
            this.dogrulamaKoduTextBox.TabIndex = 1;
            // 
            // dogrulaButonu
            // 
            this.dogrulaButonu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.dogrulaButonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dogrulaButonu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogrulaButonu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.dogrulaButonu.Location = new System.Drawing.Point(155, 170);
            this.dogrulaButonu.Name = "dogrulaButonu";
            this.dogrulaButonu.Size = new System.Drawing.Size(90, 40);
            this.dogrulaButonu.TabIndex = 2;
            this.dogrulaButonu.Text = "Doğrula";
            this.dogrulaButonu.UseVisualStyleBackColor = false;
            this.dogrulaButonu.Click += new System.EventHandler(this.dogrula_Click);
            // 
            // kodDogrulama
            // 
            this.AcceptButton = this.dogrulaButonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.dogrulaButonu);
            this.Controls.Add(this.dogrulamaKoduTextBox);
            this.Controls.Add(this.dogrulamaKoduArkaPlan);
            this.Controls.Add(this.cikisButonu);
            this.Controls.Add(this.altaAlButonu);
            this.Controls.Add(this.kontrolPaneli);
            this.Controls.Add(this.arka_plan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kodDogrulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.arka_plan)).EndInit();
            this.kontrolPaneli.ResumeLayout(false);
            this.kontrolPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogrulamaKoduArkaPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox arka_plan;
        private System.Windows.Forms.Panel kontrolPaneli;
        private System.Windows.Forms.Label dogrulamaKoduLabel;
        private System.Windows.Forms.Label altaAlButonu;
        private System.Windows.Forms.Label cikisButonu;
        private System.Windows.Forms.PictureBox dogrulamaKoduArkaPlan;
        private System.Windows.Forms.TextBox dogrulamaKoduTextBox;
        private System.Windows.Forms.Button dogrulaButonu;
    }
}