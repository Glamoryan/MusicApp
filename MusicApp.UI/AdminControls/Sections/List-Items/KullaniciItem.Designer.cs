
namespace MusicApp.UI.AdminControls.Sections.List_Items
{
    partial class KullaniciItem
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
            this.lblKullaniciId = new System.Windows.Forms.Label();
            this.lblKullaniciRol = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblKullaniciMail = new System.Windows.Forms.Label();
            this.lblKullaniciUlke = new System.Windows.Forms.Label();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKullaniciId
            // 
            this.lblKullaniciId.AutoSize = true;
            this.lblKullaniciId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.lblKullaniciId.Location = new System.Drawing.Point(33, 18);
            this.lblKullaniciId.Name = "lblKullaniciId";
            this.lblKullaniciId.Size = new System.Drawing.Size(19, 21);
            this.lblKullaniciId.TabIndex = 0;
            this.lblKullaniciId.Text = "1";
            // 
            // lblKullaniciRol
            // 
            this.lblKullaniciRol.AutoSize = true;
            this.lblKullaniciRol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciRol.ForeColor = System.Drawing.Color.White;
            this.lblKullaniciRol.Location = new System.Drawing.Point(186, 18);
            this.lblKullaniciRol.Name = "lblKullaniciRol";
            this.lblKullaniciRol.Size = new System.Drawing.Size(33, 21);
            this.lblKullaniciRol.TabIndex = 0;
            this.lblKullaniciRol.Text = "Rol";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(376, 18);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(95, 21);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblKullaniciMail
            // 
            this.lblKullaniciMail.AutoSize = true;
            this.lblKullaniciMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciMail.ForeColor = System.Drawing.Color.White;
            this.lblKullaniciMail.Location = new System.Drawing.Point(598, 18);
            this.lblKullaniciMail.Name = "lblKullaniciMail";
            this.lblKullaniciMail.Size = new System.Drawing.Size(102, 21);
            this.lblKullaniciMail.TabIndex = 0;
            this.lblKullaniciMail.Text = "Kullanıcı Mail";
            // 
            // lblKullaniciUlke
            // 
            this.lblKullaniciUlke.AutoSize = true;
            this.lblKullaniciUlke.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciUlke.ForeColor = System.Drawing.Color.White;
            this.lblKullaniciUlke.Location = new System.Drawing.Point(856, 18);
            this.lblKullaniciUlke.Name = "lblKullaniciUlke";
            this.lblKullaniciUlke.Size = new System.Drawing.Size(102, 21);
            this.lblKullaniciUlke.TabIndex = 0;
            this.lblKullaniciUlke.Text = "Kullanıcı Mail";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuzenle.FlatAppearance.BorderSize = 0;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.Image = global::MusicApp.UI.Properties.Resources.edit;
            this.btnDuzenle.Location = new System.Drawing.Point(1065, 0);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(55, 57);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.UseVisualStyleBackColor = true;
            // 
            // KullaniciItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.lblKullaniciUlke);
            this.Controls.Add(this.lblKullaniciMail);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblKullaniciRol);
            this.Controls.Add(this.lblKullaniciId);
            this.Name = "KullaniciItem";
            this.Size = new System.Drawing.Size(1153, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblKullaniciId;
        public System.Windows.Forms.Label lblKullaniciRol;
        public System.Windows.Forms.Label lblKullaniciAdi;
        public System.Windows.Forms.Label lblKullaniciMail;
        public System.Windows.Forms.Label lblKullaniciUlke;
        public System.Windows.Forms.Button btnDuzenle;
    }
}
