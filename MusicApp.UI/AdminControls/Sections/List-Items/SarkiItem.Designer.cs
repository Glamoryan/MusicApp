
namespace MusicApp.UI.AdminControls.Sections.List_Items
{
    partial class SarkiItem
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
            this.lblSarkiId = new System.Windows.Forms.Label();
            this.lblSanatciAdi = new System.Windows.Forms.Label();
            this.lblSarkiAdi = new System.Windows.Forms.Label();
            this.lblDinlenme = new System.Windows.Forms.Label();
            this.lblUlkeAdi = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSarkiSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSarkiId
            // 
            this.lblSarkiId.AutoSize = true;
            this.lblSarkiId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSarkiId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.lblSarkiId.Location = new System.Drawing.Point(40, 14);
            this.lblSarkiId.Name = "lblSarkiId";
            this.lblSarkiId.Size = new System.Drawing.Size(19, 21);
            this.lblSarkiId.TabIndex = 1;
            this.lblSarkiId.Text = "1";
            // 
            // lblSanatciAdi
            // 
            this.lblSanatciAdi.AutoSize = true;
            this.lblSanatciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSanatciAdi.ForeColor = System.Drawing.Color.White;
            this.lblSanatciAdi.Location = new System.Drawing.Point(195, 14);
            this.lblSanatciAdi.Name = "lblSanatciAdi";
            this.lblSanatciAdi.Size = new System.Drawing.Size(87, 21);
            this.lblSanatciAdi.TabIndex = 2;
            this.lblSanatciAdi.Text = "Sanatçı Adı";
            // 
            // lblSarkiAdi
            // 
            this.lblSarkiAdi.AutoSize = true;
            this.lblSarkiAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSarkiAdi.ForeColor = System.Drawing.Color.White;
            this.lblSarkiAdi.Location = new System.Drawing.Point(392, 14);
            this.lblSarkiAdi.Name = "lblSarkiAdi";
            this.lblSarkiAdi.Size = new System.Drawing.Size(72, 21);
            this.lblSarkiAdi.TabIndex = 2;
            this.lblSarkiAdi.Text = "Şarkı Adı";
            // 
            // lblDinlenme
            // 
            this.lblDinlenme.AutoSize = true;
            this.lblDinlenme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDinlenme.ForeColor = System.Drawing.Color.White;
            this.lblDinlenme.Location = new System.Drawing.Point(634, 14);
            this.lblDinlenme.Name = "lblDinlenme";
            this.lblDinlenme.Size = new System.Drawing.Size(19, 21);
            this.lblDinlenme.TabIndex = 2;
            this.lblDinlenme.Text = "0";
            // 
            // lblUlkeAdi
            // 
            this.lblUlkeAdi.AutoSize = true;
            this.lblUlkeAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUlkeAdi.ForeColor = System.Drawing.Color.White;
            this.lblUlkeAdi.Location = new System.Drawing.Point(789, 14);
            this.lblUlkeAdi.Name = "lblUlkeAdi";
            this.lblUlkeAdi.Size = new System.Drawing.Size(68, 21);
            this.lblUlkeAdi.TabIndex = 2;
            this.lblUlkeAdi.Text = "Ülke Adı";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTarih.ForeColor = System.Drawing.Color.White;
            this.lblTarih.Location = new System.Drawing.Point(923, 14);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(82, 21);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "Şarkı Tarih";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuzenle.FlatAppearance.BorderSize = 0;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.Image = global::MusicApp.UI.Properties.Resources.edit;
            this.btnDuzenle.Location = new System.Drawing.Point(1027, 0);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(55, 53);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnSarkiSil
            // 
            this.btnSarkiSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSarkiSil.FlatAppearance.BorderSize = 0;
            this.btnSarkiSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSarkiSil.Image = global::MusicApp.UI.Properties.Resources.admin_delete;
            this.btnSarkiSil.Location = new System.Drawing.Point(1088, 0);
            this.btnSarkiSil.Name = "btnSarkiSil";
            this.btnSarkiSil.Size = new System.Drawing.Size(55, 53);
            this.btnSarkiSil.TabIndex = 3;
            this.btnSarkiSil.UseVisualStyleBackColor = true;
            // 
            // SarkiItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.btnSarkiSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblUlkeAdi);
            this.Controls.Add(this.lblDinlenme);
            this.Controls.Add(this.lblSarkiAdi);
            this.Controls.Add(this.lblSanatciAdi);
            this.Controls.Add(this.lblSarkiId);
            this.Name = "SarkiItem";
            this.Size = new System.Drawing.Size(1178, 53);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblSarkiId;
        public System.Windows.Forms.Label lblSanatciAdi;
        public System.Windows.Forms.Label lblSarkiAdi;
        public System.Windows.Forms.Label lblDinlenme;
        public System.Windows.Forms.Label lblUlkeAdi;
        public System.Windows.Forms.Label lblTarih;
        public System.Windows.Forms.Button btnDuzenle;
        public System.Windows.Forms.Button btnSarkiSil;
    }
}
