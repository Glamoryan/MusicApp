
namespace MusicApp.UI.AdminControls.Sections.List_Items
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
            this.lblAlbumId = new System.Windows.Forms.Label();
            this.lblAlbumAdi = new System.Windows.Forms.Label();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.lblSanatciAdi = new System.Windows.Forms.Label();
            this.lblAlbumTarih = new System.Windows.Forms.Label();
            this.lblAlbumTuru = new System.Windows.Forms.Label();
            this.lblSarkiSayisi = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAlbumId
            // 
            this.lblAlbumId.AutoSize = true;
            this.lblAlbumId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlbumId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.lblAlbumId.Location = new System.Drawing.Point(37, 17);
            this.lblAlbumId.Name = "lblAlbumId";
            this.lblAlbumId.Size = new System.Drawing.Size(19, 21);
            this.lblAlbumId.TabIndex = 1;
            this.lblAlbumId.Text = "1";
            // 
            // lblAlbumAdi
            // 
            this.lblAlbumAdi.AutoSize = true;
            this.lblAlbumAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlbumAdi.ForeColor = System.Drawing.Color.White;
            this.lblAlbumAdi.Location = new System.Drawing.Point(172, 17);
            this.lblAlbumAdi.Name = "lblAlbumAdi";
            this.lblAlbumAdi.Size = new System.Drawing.Size(83, 21);
            this.lblAlbumAdi.TabIndex = 2;
            this.lblAlbumAdi.Text = "Albüm Adı";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuzenle.FlatAppearance.BorderSize = 0;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.Image = global::MusicApp.UI.Properties.Resources.edit;
            this.btnDuzenle.Location = new System.Drawing.Point(1008, 0);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(55, 58);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.UseVisualStyleBackColor = true;
            // 
            // lblSanatciAdi
            // 
            this.lblSanatciAdi.AutoSize = true;
            this.lblSanatciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSanatciAdi.ForeColor = System.Drawing.Color.White;
            this.lblSanatciAdi.Location = new System.Drawing.Point(389, 17);
            this.lblSanatciAdi.Name = "lblSanatciAdi";
            this.lblSanatciAdi.Size = new System.Drawing.Size(87, 21);
            this.lblSanatciAdi.TabIndex = 2;
            this.lblSanatciAdi.Text = "Sanatçı Adı";
            // 
            // lblAlbumTarih
            // 
            this.lblAlbumTarih.AutoSize = true;
            this.lblAlbumTarih.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlbumTarih.ForeColor = System.Drawing.Color.White;
            this.lblAlbumTarih.Location = new System.Drawing.Point(584, 17);
            this.lblAlbumTarih.Name = "lblAlbumTarih";
            this.lblAlbumTarih.Size = new System.Drawing.Size(43, 21);
            this.lblAlbumTarih.TabIndex = 2;
            this.lblAlbumTarih.Text = "Tarih";
            // 
            // lblAlbumTuru
            // 
            this.lblAlbumTuru.AutoSize = true;
            this.lblAlbumTuru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlbumTuru.ForeColor = System.Drawing.Color.White;
            this.lblAlbumTuru.Location = new System.Drawing.Point(782, 17);
            this.lblAlbumTuru.Name = "lblAlbumTuru";
            this.lblAlbumTuru.Size = new System.Drawing.Size(33, 21);
            this.lblAlbumTuru.TabIndex = 2;
            this.lblAlbumTuru.Text = "Tür";
            // 
            // lblSarkiSayisi
            // 
            this.lblSarkiSayisi.AutoSize = true;
            this.lblSarkiSayisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSarkiSayisi.ForeColor = System.Drawing.Color.White;
            this.lblSarkiSayisi.Location = new System.Drawing.Point(935, 17);
            this.lblSarkiSayisi.Name = "lblSarkiSayisi";
            this.lblSarkiSayisi.Size = new System.Drawing.Size(19, 21);
            this.lblSarkiSayisi.TabIndex = 2;
            this.lblSarkiSayisi.Text = "0";
            // 
            // btnSil
            // 
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Image = global::MusicApp.UI.Properties.Resources.admin_delete;
            this.btnSil.Location = new System.Drawing.Point(1069, 1);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(55, 57);
            this.btnSil.TabIndex = 4;
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // AlbumItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.lblSarkiSayisi);
            this.Controls.Add(this.lblAlbumTuru);
            this.Controls.Add(this.lblAlbumTarih);
            this.Controls.Add(this.lblSanatciAdi);
            this.Controls.Add(this.lblAlbumAdi);
            this.Controls.Add(this.lblAlbumId);
            this.Name = "AlbumItem";
            this.Size = new System.Drawing.Size(1143, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblAlbumId;
        public System.Windows.Forms.Label lblAlbumAdi;
        public System.Windows.Forms.Button btnDuzenle;
        public System.Windows.Forms.Label lblSanatciAdi;
        public System.Windows.Forms.Label lblAlbumTarih;
        public System.Windows.Forms.Label lblAlbumTuru;
        public System.Windows.Forms.Label lblSarkiSayisi;
        public System.Windows.Forms.Button btnSil;
    }
}
