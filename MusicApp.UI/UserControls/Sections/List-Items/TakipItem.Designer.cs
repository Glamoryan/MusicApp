
namespace MusicApp.UI.UserControls.Sections.List_Items
{
    partial class TakipItem
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblTakipciSayisi = new System.Windows.Forms.Label();
            this.lblTakipEdilen = new System.Windows.Forms.Label();
            this.btnTumunuEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicApp.UI.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(9, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(78, 22);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(95, 21);
            this.lblKullaniciAdi.TabIndex = 1;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblTakipciSayisi
            // 
            this.lblTakipciSayisi.AutoSize = true;
            this.lblTakipciSayisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTakipciSayisi.ForeColor = System.Drawing.Color.White;
            this.lblTakipciSayisi.Location = new System.Drawing.Point(208, 22);
            this.lblTakipciSayisi.Name = "lblTakipciSayisi";
            this.lblTakipciSayisi.Size = new System.Drawing.Size(100, 21);
            this.lblTakipciSayisi.TabIndex = 1;
            this.lblTakipciSayisi.Text = "Takipçi Sayısı";
            // 
            // lblTakipEdilen
            // 
            this.lblTakipEdilen.AutoSize = true;
            this.lblTakipEdilen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTakipEdilen.ForeColor = System.Drawing.Color.White;
            this.lblTakipEdilen.Location = new System.Drawing.Point(338, 22);
            this.lblTakipEdilen.Name = "lblTakipEdilen";
            this.lblTakipEdilen.Size = new System.Drawing.Size(91, 21);
            this.lblTakipEdilen.TabIndex = 1;
            this.lblTakipEdilen.Text = "Takip Edilen";
            // 
            // btnTumunuEkle
            // 
            this.btnTumunuEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(81)))), ((int)(((byte)(251)))));
            this.btnTumunuEkle.FlatAppearance.BorderSize = 0;
            this.btnTumunuEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumunuEkle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTumunuEkle.ForeColor = System.Drawing.Color.White;
            this.btnTumunuEkle.Location = new System.Drawing.Point(449, 10);
            this.btnTumunuEkle.Name = "btnTumunuEkle";
            this.btnTumunuEkle.Size = new System.Drawing.Size(141, 44);
            this.btnTumunuEkle.TabIndex = 2;
            this.btnTumunuEkle.Text = "Tüm Listeyi Ekle";
            this.btnTumunuEkle.UseVisualStyleBackColor = false;
            // 
            // TakipItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.btnTumunuEkle);
            this.Controls.Add(this.lblTakipEdilen);
            this.Controls.Add(this.lblTakipciSayisi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TakipItem";
            this.Size = new System.Drawing.Size(605, 67);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblKullaniciAdi;
        public System.Windows.Forms.Label lblTakipciSayisi;
        public System.Windows.Forms.Label lblTakipEdilen;
        public System.Windows.Forms.Button btnTumunuEkle;
    }
}
