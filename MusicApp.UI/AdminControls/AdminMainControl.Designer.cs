
namespace MusicApp.UI.AdminControls
{
    partial class AdminMainControl
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnAlbumler = new System.Windows.Forms.Button();
            this.btnSanatcilar = new System.Windows.Forms.Button();
            this.btnSarkilar = new System.Windows.Forms.Button();
            this.btnKullanicilar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlAdminContent = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.btnCik = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnAlbumler);
            this.pnlHeader.Controls.Add(this.btnSanatcilar);
            this.pnlHeader.Controls.Add(this.btnSarkilar);
            this.pnlHeader.Controls.Add(this.btnKullanicilar);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1358, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnAlbumler
            // 
            this.btnAlbumler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnAlbumler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlbumler.FlatAppearance.BorderSize = 0;
            this.btnAlbumler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlbumler.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlbumler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.btnAlbumler.Location = new System.Drawing.Point(835, 27);
            this.btnAlbumler.Name = "btnAlbumler";
            this.btnAlbumler.Size = new System.Drawing.Size(156, 46);
            this.btnAlbumler.TabIndex = 2;
            this.btnAlbumler.Text = "Albümler";
            this.btnAlbumler.UseVisualStyleBackColor = false;
            this.btnAlbumler.Click += new System.EventHandler(this.btnAlbumler_Click);
            // 
            // btnSanatcilar
            // 
            this.btnSanatcilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnSanatcilar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanatcilar.FlatAppearance.BorderSize = 0;
            this.btnSanatcilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanatcilar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSanatcilar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.btnSanatcilar.Location = new System.Drawing.Point(673, 27);
            this.btnSanatcilar.Name = "btnSanatcilar";
            this.btnSanatcilar.Size = new System.Drawing.Size(156, 46);
            this.btnSanatcilar.TabIndex = 2;
            this.btnSanatcilar.Text = "Sanatçılar";
            this.btnSanatcilar.UseVisualStyleBackColor = false;
            this.btnSanatcilar.Click += new System.EventHandler(this.btnSanatcilar_Click);
            // 
            // btnSarkilar
            // 
            this.btnSarkilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnSarkilar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSarkilar.FlatAppearance.BorderSize = 0;
            this.btnSarkilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSarkilar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSarkilar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.btnSarkilar.Location = new System.Drawing.Point(511, 27);
            this.btnSarkilar.Name = "btnSarkilar";
            this.btnSarkilar.Size = new System.Drawing.Size(156, 46);
            this.btnSarkilar.TabIndex = 2;
            this.btnSarkilar.Text = "Şarkılar";
            this.btnSarkilar.UseVisualStyleBackColor = false;
            this.btnSarkilar.Click += new System.EventHandler(this.btnSarkilar_Click);
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnKullanicilar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKullanicilar.FlatAppearance.BorderSize = 0;
            this.btnKullanicilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullanicilar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKullanicilar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.btnKullanicilar.Location = new System.Drawing.Point(349, 27);
            this.btnKullanicilar.Name = "btnKullanicilar";
            this.btnKullanicilar.Size = new System.Drawing.Size(156, 46);
            this.btnKullanicilar.TabIndex = 2;
            this.btnKullanicilar.Text = "Kullanıcılar";
            this.btnKullanicilar.UseVisualStyleBackColor = false;
            this.btnKullanicilar.Click += new System.EventHandler(this.btnKullanicilar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(99, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Panel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicApp.UI.Properties.Resources.panel;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlAdminContent
            // 
            this.pnlAdminContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.pnlAdminContent.Location = new System.Drawing.Point(0, 101);
            this.pnlAdminContent.Name = "pnlAdminContent";
            this.pnlAdminContent.Size = new System.Drawing.Size(1358, 573);
            this.pnlAdminContent.TabIndex = 1;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblKullaniciAdi);
            this.pnlFooter.Controls.Add(this.btnCik);
            this.pnlFooter.Controls.Add(this.label2);
            this.pnlFooter.Location = new System.Drawing.Point(0, 675);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1358, 57);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(97, 16);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(95, 21);
            this.lblKullaniciAdi.TabIndex = 2;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // btnCik
            // 
            this.btnCik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCik.FlatAppearance.BorderSize = 0;
            this.btnCik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCik.Image = global::MusicApp.UI.Properties.Resources.exit;
            this.btnCik.Location = new System.Drawing.Point(1301, 7);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(44, 40);
            this.btnCik.TabIndex = 0;
            this.btnCik.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı: ";
            // 
            // AdminMainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlAdminContent);
            this.Controls.Add(this.pnlHeader);
            this.Name = "AdminMainControl";
            this.Size = new System.Drawing.Size(1358, 732);
            this.Load += new System.EventHandler(this.AdminMainControl_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion      
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlAdminContent;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKullanicilar;
        private System.Windows.Forms.Button btnCik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Button btnSarkilar;
        private System.Windows.Forms.Button btnSanatcilar;
        private System.Windows.Forms.Button btnAlbumler;
    }
}
