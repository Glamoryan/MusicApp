
namespace MusicApp.UI.AdminControls.Sections.Edit_Controls
{
    partial class SarkiAdd
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
            this.lblSanatciAdi = new System.Windows.Forms.Label();
            this.cbxSanatci = new System.Windows.Forms.ComboBox();
            this.lblSarkiAdi = new System.Windows.Forms.Label();
            this.tbxSarkiAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSarkiSec = new System.Windows.Forms.Button();
            this.lblYol = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.dosyaSecici = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.lblBaslik.Location = new System.Drawing.Point(134, 40);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(123, 32);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Şarkı Ekle";
            // 
            // lblSanatciAdi
            // 
            this.lblSanatciAdi.AutoSize = true;
            this.lblSanatciAdi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSanatciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.lblSanatciAdi.Location = new System.Drawing.Point(174, 202);
            this.lblSanatciAdi.Name = "lblSanatciAdi";
            this.lblSanatciAdi.Size = new System.Drawing.Size(107, 25);
            this.lblSanatciAdi.TabIndex = 3;
            this.lblSanatciAdi.Text = "Sanatci Seç";
            // 
            // cbxSanatci
            // 
            this.cbxSanatci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSanatci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSanatci.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxSanatci.FormattingEnabled = true;
            this.cbxSanatci.Location = new System.Drawing.Point(174, 230);
            this.cbxSanatci.Name = "cbxSanatci";
            this.cbxSanatci.Size = new System.Drawing.Size(216, 38);
            this.cbxSanatci.TabIndex = 6;
            // 
            // lblSarkiAdi
            // 
            this.lblSarkiAdi.AutoSize = true;
            this.lblSarkiAdi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSarkiAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.lblSarkiAdi.Location = new System.Drawing.Point(477, 202);
            this.lblSarkiAdi.Name = "lblSarkiAdi";
            this.lblSarkiAdi.Size = new System.Drawing.Size(86, 25);
            this.lblSarkiAdi.TabIndex = 3;
            this.lblSarkiAdi.Text = "Şarkı Adı";
            // 
            // tbxSarkiAdi
            // 
            this.tbxSarkiAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSarkiAdi.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxSarkiAdi.Location = new System.Drawing.Point(477, 233);
            this.tbxSarkiAdi.Name = "tbxSarkiAdi";
            this.tbxSarkiAdi.Size = new System.Drawing.Size(216, 35);
            this.tbxSarkiAdi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(477, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Not:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(503, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dosya ismi ile şarkı adı aynı olmalıdır.";
            // 
            // btnSarkiSec
            // 
            this.btnSarkiSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.btnSarkiSec.FlatAppearance.BorderSize = 0;
            this.btnSarkiSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSarkiSec.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSarkiSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnSarkiSec.Location = new System.Drawing.Point(174, 102);
            this.btnSarkiSec.Name = "btnSarkiSec";
            this.btnSarkiSec.Size = new System.Drawing.Size(276, 44);
            this.btnSarkiSec.TabIndex = 8;
            this.btnSarkiSec.Text = "Şarkı Dosyası Seç (.mp3)";
            this.btnSarkiSec.UseVisualStyleBackColor = false;
            this.btnSarkiSec.Click += new System.EventHandler(this.btnSarkiSec_Click);
            // 
            // lblYol
            // 
            this.lblYol.AutoSize = true;
            this.lblYol.ForeColor = System.Drawing.Color.White;
            this.lblYol.Location = new System.Drawing.Point(469, 121);
            this.lblYol.Name = "lblYol";
            this.lblYol.Size = new System.Drawing.Size(18, 15);
            this.lblYol.TabIndex = 9;
            this.lblYol.Text = "../";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnEkle.Location = new System.Drawing.Point(1181, 498);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(113, 42);
            this.btnEkle.TabIndex = 14;
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
            this.btnIptal.Location = new System.Drawing.Point(1062, 498);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(113, 42);
            this.btnIptal.TabIndex = 15;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // SarkiAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.lblYol);
            this.Controls.Add(this.btnSarkiSec);
            this.Controls.Add(this.tbxSarkiAdi);
            this.Controls.Add(this.cbxSanatci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSarkiAdi);
            this.Controls.Add(this.lblSanatciAdi);
            this.Controls.Add(this.lblBaslik);
            this.Name = "SarkiAdd";
            this.Size = new System.Drawing.Size(1358, 573);
            this.Load += new System.EventHandler(this.SarkiAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblSanatciAdi;
        public System.Windows.Forms.ComboBox cbxSanatci;
        private System.Windows.Forms.Label lblSarkiAdi;
        public System.Windows.Forms.TextBox tbxSarkiAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSarkiSec;
        private System.Windows.Forms.Label lblYol;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.OpenFileDialog dosyaSecici;
    }
}
