
namespace MusicApp.UI.UserControls.Sections.List_Items
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblUlkeAdi = new System.Windows.Forms.Label();
            this.lblRolAdi = new System.Windows.Forms.Label();
            this.lblAbonelikAdi = new System.Windows.Forms.Label();
            this.btnTakip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicApp.UI.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(18, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(92, 16);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(95, 21);
            this.lblKullaniciAdi.TabIndex = 2;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblUlkeAdi
            // 
            this.lblUlkeAdi.AutoSize = true;
            this.lblUlkeAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUlkeAdi.ForeColor = System.Drawing.Color.White;
            this.lblUlkeAdi.Location = new System.Drawing.Point(703, 16);
            this.lblUlkeAdi.Name = "lblUlkeAdi";
            this.lblUlkeAdi.Size = new System.Drawing.Size(41, 21);
            this.lblUlkeAdi.TabIndex = 2;
            this.lblUlkeAdi.Text = "Ülke";
            // 
            // lblRolAdi
            // 
            this.lblRolAdi.AutoSize = true;
            this.lblRolAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRolAdi.ForeColor = System.Drawing.Color.White;
            this.lblRolAdi.Location = new System.Drawing.Point(295, 16);
            this.lblRolAdi.Name = "lblRolAdi";
            this.lblRolAdi.Size = new System.Drawing.Size(60, 21);
            this.lblRolAdi.TabIndex = 2;
            this.lblRolAdi.Text = "Rol Adı";
            // 
            // lblAbonelikAdi
            // 
            this.lblAbonelikAdi.AutoSize = true;
            this.lblAbonelikAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAbonelikAdi.ForeColor = System.Drawing.Color.White;
            this.lblAbonelikAdi.Location = new System.Drawing.Point(496, 16);
            this.lblAbonelikAdi.Name = "lblAbonelikAdi";
            this.lblAbonelikAdi.Size = new System.Drawing.Size(107, 21);
            this.lblAbonelikAdi.TabIndex = 2;
            this.lblAbonelikAdi.Text = "Abonelik Türü";
            // 
            // btnTakip
            // 
            this.btnTakip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(81)))), ((int)(((byte)(251)))));
            this.btnTakip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTakip.FlatAppearance.BorderSize = 0;
            this.btnTakip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTakip.ForeColor = System.Drawing.Color.White;
            this.btnTakip.Location = new System.Drawing.Point(849, 6);
            this.btnTakip.Name = "btnTakip";
            this.btnTakip.Size = new System.Drawing.Size(153, 39);
            this.btnTakip.TabIndex = 3;
            this.btnTakip.Text = "Takip Et";
            this.btnTakip.UseVisualStyleBackColor = false;
            // 
            // KullaniciItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.btnTakip);
            this.Controls.Add(this.lblUlkeAdi);
            this.Controls.Add(this.lblAbonelikAdi);
            this.Controls.Add(this.lblRolAdi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KullaniciItem";
            this.Size = new System.Drawing.Size(1050, 52);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblKullaniciAdi;
        public System.Windows.Forms.Label lblUlkeAdi;
        public System.Windows.Forms.Label lblRolAdi;
        public System.Windows.Forms.Label lblAbonelikAdi;
        public System.Windows.Forms.Button btnTakip;
    }
}
