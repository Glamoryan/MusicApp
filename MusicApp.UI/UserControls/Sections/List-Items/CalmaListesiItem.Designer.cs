
namespace MusicApp.UI.UserControls.Sections.List_Items
{
    partial class CalmaListesiItem
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
            this.lblMuzikAdi = new System.Windows.Forms.Label();
            this.lblSanatciAdi = new System.Windows.Forms.Label();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnOynat = new System.Windows.Forms.Button();
            this.lblSayac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicApp.UI.Properties.Resources.music;
            this.pictureBox1.Location = new System.Drawing.Point(43, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblMuzikAdi
            // 
            this.lblMuzikAdi.AutoSize = true;
            this.lblMuzikAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMuzikAdi.ForeColor = System.Drawing.Color.White;
            this.lblMuzikAdi.Location = new System.Drawing.Point(117, 27);
            this.lblMuzikAdi.Name = "lblMuzikAdi";
            this.lblMuzikAdi.Size = new System.Drawing.Size(79, 21);
            this.lblMuzikAdi.TabIndex = 1;
            this.lblMuzikAdi.Text = "Müzik Adı";
            // 
            // lblSanatciAdi
            // 
            this.lblSanatciAdi.AutoSize = true;
            this.lblSanatciAdi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSanatciAdi.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSanatciAdi.Location = new System.Drawing.Point(117, 48);
            this.lblSanatciAdi.Name = "lblSanatciAdi";
            this.lblSanatciAdi.Size = new System.Drawing.Size(72, 17);
            this.lblSanatciAdi.TabIndex = 1;
            this.lblSanatciAdi.Text = "Sanatçı Adı";
            // 
            // btnCikar
            // 
            this.btnCikar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikar.FlatAppearance.BorderSize = 0;
            this.btnCikar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikar.Image = global::MusicApp.UI.Properties.Resources.delete;
            this.btnCikar.Location = new System.Drawing.Point(271, 13);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(48, 64);
            this.btnCikar.TabIndex = 2;
            this.btnCikar.UseVisualStyleBackColor = true;
            // 
            // btnOynat
            // 
            this.btnOynat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOynat.FlatAppearance.BorderSize = 0;
            this.btnOynat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOynat.Image = global::MusicApp.UI.Properties.Resources.play;
            this.btnOynat.Location = new System.Drawing.Point(217, 13);
            this.btnOynat.Name = "btnOynat";
            this.btnOynat.Size = new System.Drawing.Size(48, 64);
            this.btnOynat.TabIndex = 2;
            this.btnOynat.UseVisualStyleBackColor = true;
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSayac.ForeColor = System.Drawing.Color.White;
            this.lblSayac.Location = new System.Drawing.Point(12, 33);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(19, 21);
            this.lblSayac.TabIndex = 3;
            this.lblSayac.Text = "1";
            // 
            // CalmaListesiItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.btnOynat);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.lblSanatciAdi);
            this.Controls.Add(this.lblMuzikAdi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CalmaListesiItem";
            this.Size = new System.Drawing.Size(331, 93);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblMuzikAdi;
        public System.Windows.Forms.Label lblSanatciAdi;
        public System.Windows.Forms.Button btnCikar;
        public System.Windows.Forms.Button btnOynat;
        public System.Windows.Forms.Label lblSayac;
    }
}
