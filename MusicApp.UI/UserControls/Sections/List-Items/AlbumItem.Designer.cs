
namespace MusicApp.UI.UserControls.Sections.List_Items
{
    partial class AlbumItem
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
            this.lblAlbumAdi = new System.Windows.Forms.Label();
            this.lblSanatciAdi = new System.Windows.Forms.Label();
            this.lblAlbumTarihi = new System.Windows.Forms.Label();
            this.lblAlbumTuru = new System.Windows.Forms.Label();
            this.btnSec = new System.Windows.Forms.Button();
            this.lblSayac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicApp.UI.Properties.Resources.album;
            this.pictureBox1.Location = new System.Drawing.Point(51, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblAlbumAdi
            // 
            this.lblAlbumAdi.AutoSize = true;
            this.lblAlbumAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlbumAdi.ForeColor = System.Drawing.Color.White;
            this.lblAlbumAdi.Location = new System.Drawing.Point(120, 19);
            this.lblAlbumAdi.Name = "lblAlbumAdi";
            this.lblAlbumAdi.Size = new System.Drawing.Size(83, 21);
            this.lblAlbumAdi.TabIndex = 1;
            this.lblAlbumAdi.Text = "Album Adı";
            // 
            // lblSanatciAdi
            // 
            this.lblSanatciAdi.AutoSize = true;
            this.lblSanatciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSanatciAdi.ForeColor = System.Drawing.Color.White;
            this.lblSanatciAdi.Location = new System.Drawing.Point(362, 19);
            this.lblSanatciAdi.Name = "lblSanatciAdi";
            this.lblSanatciAdi.Size = new System.Drawing.Size(87, 21);
            this.lblSanatciAdi.TabIndex = 1;
            this.lblSanatciAdi.Text = "Sanatçı Adı";
            // 
            // lblAlbumTarihi
            // 
            this.lblAlbumTarihi.AutoSize = true;
            this.lblAlbumTarihi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlbumTarihi.ForeColor = System.Drawing.Color.White;
            this.lblAlbumTarihi.Location = new System.Drawing.Point(739, 19);
            this.lblAlbumTarihi.Name = "lblAlbumTarihi";
            this.lblAlbumTarihi.Size = new System.Drawing.Size(97, 21);
            this.lblAlbumTarihi.TabIndex = 1;
            this.lblAlbumTarihi.Text = "Album Tarihi";
            // 
            // lblAlbumTuru
            // 
            this.lblAlbumTuru.AutoSize = true;
            this.lblAlbumTuru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlbumTuru.ForeColor = System.Drawing.Color.White;
            this.lblAlbumTuru.Location = new System.Drawing.Point(567, 19);
            this.lblAlbumTuru.Name = "lblAlbumTuru";
            this.lblAlbumTuru.Size = new System.Drawing.Size(92, 21);
            this.lblAlbumTuru.TabIndex = 1;
            this.lblAlbumTuru.Text = "Album Türü";
            // 
            // btnSec
            // 
            this.btnSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(81)))), ((int)(((byte)(251)))));
            this.btnSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSec.FlatAppearance.BorderSize = 0;
            this.btnSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSec.ForeColor = System.Drawing.Color.White;
            this.btnSec.Location = new System.Drawing.Point(923, 10);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(77, 39);
            this.btnSec.TabIndex = 2;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = false;
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSayac.ForeColor = System.Drawing.Color.White;
            this.lblSayac.Location = new System.Drawing.Point(22, 19);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(19, 21);
            this.lblSayac.TabIndex = 1;
            this.lblSayac.Text = "1";
            // 
            // AlbumItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.lblAlbumTuru);
            this.Controls.Add(this.lblAlbumTarihi);
            this.Controls.Add(this.lblSanatciAdi);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.lblAlbumAdi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AlbumItem";
            this.Size = new System.Drawing.Size(1029, 55);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblAlbumAdi;
        public System.Windows.Forms.Label lblSanatciAdi;
        public System.Windows.Forms.Label lblAlbumTarihi;
        public System.Windows.Forms.Label lblAlbumTuru;
        public System.Windows.Forms.Button btnSec;
        public System.Windows.Forms.Label lblSayac;
    }
}
