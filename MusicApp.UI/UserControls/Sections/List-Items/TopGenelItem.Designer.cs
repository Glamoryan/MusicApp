
namespace MusicApp.UI.UserControls.Sections.List_Items
{
    partial class TopGenelItem
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
            this.lblDinlenme = new System.Windows.Forms.Label();
            this.btnOynat = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicApp.UI.Properties.Resources.music;
            this.pictureBox1.Location = new System.Drawing.Point(17, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblMuzikAdi
            // 
            this.lblMuzikAdi.AutoSize = true;
            this.lblMuzikAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMuzikAdi.ForeColor = System.Drawing.Color.White;
            this.lblMuzikAdi.Location = new System.Drawing.Point(107, 22);
            this.lblMuzikAdi.Name = "lblMuzikAdi";
            this.lblMuzikAdi.Size = new System.Drawing.Size(79, 21);
            this.lblMuzikAdi.TabIndex = 1;
            this.lblMuzikAdi.Text = "Müzik Adı";
            // 
            // lblSanatciAdi
            // 
            this.lblSanatciAdi.AutoSize = true;
            this.lblSanatciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSanatciAdi.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSanatciAdi.Location = new System.Drawing.Point(299, 22);
            this.lblSanatciAdi.Name = "lblSanatciAdi";
            this.lblSanatciAdi.Size = new System.Drawing.Size(87, 21);
            this.lblSanatciAdi.TabIndex = 1;
            this.lblSanatciAdi.Text = "Sanatçı Adı";
            // 
            // lblDinlenme
            // 
            this.lblDinlenme.AutoSize = true;
            this.lblDinlenme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDinlenme.ForeColor = System.Drawing.Color.White;
            this.lblDinlenme.Location = new System.Drawing.Point(470, 22);
            this.lblDinlenme.Name = "lblDinlenme";
            this.lblDinlenme.Size = new System.Drawing.Size(19, 21);
            this.lblDinlenme.TabIndex = 1;
            this.lblDinlenme.Text = "0";
            // 
            // btnOynat
            // 
            this.btnOynat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOynat.FlatAppearance.BorderSize = 0;
            this.btnOynat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOynat.Image = global::MusicApp.UI.Properties.Resources.play;
            this.btnOynat.Location = new System.Drawing.Point(610, 0);
            this.btnOynat.Name = "btnOynat";
            this.btnOynat.Size = new System.Drawing.Size(56, 62);
            this.btnOynat.TabIndex = 2;
            this.btnOynat.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Image = global::MusicApp.UI.Properties.Resources.add;
            this.btnEkle.Location = new System.Drawing.Point(548, 0);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(56, 62);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // TopGenelItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnOynat);
            this.Controls.Add(this.lblDinlenme);
            this.Controls.Add(this.lblSanatciAdi);
            this.Controls.Add(this.lblMuzikAdi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TopGenelItem";
            this.Size = new System.Drawing.Size(685, 63);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblMuzikAdi;
        public System.Windows.Forms.Label lblSanatciAdi;
        public System.Windows.Forms.Label lblDinlenme;
        public System.Windows.Forms.Button btnOynat;
        public System.Windows.Forms.Button btnEkle;
    }
}
