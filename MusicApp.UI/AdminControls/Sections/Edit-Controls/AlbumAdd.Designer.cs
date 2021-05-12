
namespace MusicApp.UI.AdminControls.Sections.Edit_Controls
{
    partial class AlbumAdd
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBaslik = new System.Windows.Forms.Label();
            this.tbxAlbumAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSanatcilar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTurler = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblYol = new System.Windows.Forms.Label();
            this.btnSarkiSec = new System.Windows.Forms.Button();
            this.tbxSarkiAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSarkiAdi = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.sarkiSecici = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.lblBaslik.Location = new System.Drawing.Point(133, 35);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(143, 32);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Albüm Ekle";
            // 
            // tbxAlbumAdi
            // 
            this.tbxAlbumAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAlbumAdi.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxAlbumAdi.Location = new System.Drawing.Point(155, 125);
            this.tbxAlbumAdi.Name = "tbxAlbumAdi";
            this.tbxAlbumAdi.Size = new System.Drawing.Size(216, 35);
            this.tbxAlbumAdi.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(155, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Albüm Adı";
            // 
            // cbxSanatcilar
            // 
            this.cbxSanatcilar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSanatcilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSanatcilar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxSanatcilar.FormattingEnabled = true;
            this.cbxSanatcilar.Location = new System.Drawing.Point(467, 125);
            this.cbxSanatcilar.Name = "cbxSanatcilar";
            this.cbxSanatcilar.Size = new System.Drawing.Size(216, 38);
            this.cbxSanatcilar.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(467, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Albüm Sanatçısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(767, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Albüm Türü";
            // 
            // cbxTurler
            // 
            this.cbxTurler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTurler.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxTurler.FormattingEnabled = true;
            this.cbxTurler.Location = new System.Drawing.Point(767, 125);
            this.cbxTurler.Name = "cbxTurler";
            this.cbxTurler.Size = new System.Drawing.Size(216, 38);
            this.cbxTurler.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(133, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Albümün ilk Şarkısını Ekle";
            // 
            // lblYol
            // 
            this.lblYol.AutoSize = true;
            this.lblYol.ForeColor = System.Drawing.Color.White;
            this.lblYol.Location = new System.Drawing.Point(779, 346);
            this.lblYol.Name = "lblYol";
            this.lblYol.Size = new System.Drawing.Size(18, 15);
            this.lblYol.TabIndex = 17;
            this.lblYol.Text = "../";
            // 
            // btnSarkiSec
            // 
            this.btnSarkiSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.btnSarkiSec.FlatAppearance.BorderSize = 0;
            this.btnSarkiSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSarkiSec.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSarkiSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnSarkiSec.Location = new System.Drawing.Point(484, 327);
            this.btnSarkiSec.Name = "btnSarkiSec";
            this.btnSarkiSec.Size = new System.Drawing.Size(276, 44);
            this.btnSarkiSec.TabIndex = 16;
            this.btnSarkiSec.Text = "Şarkı Dosyası Seç (.mp3)";
            this.btnSarkiSec.UseVisualStyleBackColor = false;
            this.btnSarkiSec.Click += new System.EventHandler(this.btnSarkiSec_Click);
            // 
            // tbxSarkiAdi
            // 
            this.tbxSarkiAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSarkiAdi.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxSarkiAdi.Location = new System.Drawing.Point(155, 332);
            this.tbxSarkiAdi.Name = "tbxSarkiAdi";
            this.tbxSarkiAdi.Size = new System.Drawing.Size(216, 35);
            this.tbxSarkiAdi.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(181, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Dosya ismi ile şarkı adı aynı olmalıdır.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.label6.Location = new System.Drawing.Point(155, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Not:";
            // 
            // lblSarkiAdi
            // 
            this.lblSarkiAdi.AutoSize = true;
            this.lblSarkiAdi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSarkiAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.lblSarkiAdi.Location = new System.Drawing.Point(155, 301);
            this.lblSarkiAdi.Name = "lblSarkiAdi";
            this.lblSarkiAdi.Size = new System.Drawing.Size(86, 25);
            this.lblSarkiAdi.TabIndex = 20;
            this.lblSarkiAdi.Text = "Şarkı Adı";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnEkle.Location = new System.Drawing.Point(1149, 484);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(113, 42);
            this.btnEkle.TabIndex = 22;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Red;
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(1030, 484);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(113, 42);
            this.btnIptal.TabIndex = 23;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // AlbumAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.tbxSarkiAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSarkiAdi);
            this.Controls.Add(this.lblYol);
            this.Controls.Add(this.btnSarkiSec);
            this.Controls.Add(this.cbxTurler);
            this.Controls.Add(this.cbxSanatcilar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxAlbumAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBaslik);
            this.Name = "AlbumAdd";
            this.Size = new System.Drawing.Size(1358, 573);
            this.Load += new System.EventHandler(this.AlbumAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        public System.Windows.Forms.TextBox tbxAlbumAdi;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbxSanatcilar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbxTurler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblYol;
        private System.Windows.Forms.Button btnSarkiSec;
        public System.Windows.Forms.TextBox tbxSarkiAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSarkiAdi;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.OpenFileDialog sarkiSecici;
    }
}
