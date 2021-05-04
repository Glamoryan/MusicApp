
namespace MusicApp.UI.UserControls.Sections.List_Items
{
    partial class KullaniciCalmaListesiItem
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
            this.lblMuzikAdi = new System.Windows.Forms.Label();
            this.lblSanatciAdi = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMuzikAdi
            // 
            this.lblMuzikAdi.AutoSize = true;
            this.lblMuzikAdi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMuzikAdi.ForeColor = System.Drawing.Color.White;
            this.lblMuzikAdi.Location = new System.Drawing.Point(13, 15);
            this.lblMuzikAdi.Name = "lblMuzikAdi";
            this.lblMuzikAdi.Size = new System.Drawing.Size(75, 20);
            this.lblMuzikAdi.TabIndex = 0;
            this.lblMuzikAdi.Text = "Müzik Adı";
            // 
            // lblSanatciAdi
            // 
            this.lblSanatciAdi.AutoSize = true;
            this.lblSanatciAdi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSanatciAdi.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSanatciAdi.Location = new System.Drawing.Point(137, 15);
            this.lblSanatciAdi.Name = "lblSanatciAdi";
            this.lblSanatciAdi.Size = new System.Drawing.Size(84, 20);
            this.lblSanatciAdi.TabIndex = 0;
            this.lblSanatciAdi.Text = "Sanatçı Adı";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Image = global::MusicApp.UI.Properties.Resources.add;
            this.btnEkle.Location = new System.Drawing.Point(275, 0);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(71, 50);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.UseVisualStyleBackColor = false;
            // 
            // KullaniciCalmaListesiItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblSanatciAdi);
            this.Controls.Add(this.lblMuzikAdi);
            this.Name = "KullaniciCalmaListesiItem";
            this.Size = new System.Drawing.Size(370, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblMuzikAdi;
        public System.Windows.Forms.Label lblSanatciAdi;
        public System.Windows.Forms.Button btnEkle;
    }
}
