
namespace MusicApp.UI.UserControls.Sections.List_Items
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMuzikAdi = new System.Windows.Forms.Label();
            this.lblIzlenmeSayisi = new System.Windows.Forms.Label();
            this.btnOynat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicApp.UI.Properties.Resources.music;
            this.pictureBox1.Location = new System.Drawing.Point(18, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblMuzikAdi
            // 
            this.lblMuzikAdi.AutoSize = true;
            this.lblMuzikAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMuzikAdi.ForeColor = System.Drawing.Color.White;
            this.lblMuzikAdi.Location = new System.Drawing.Point(85, 17);
            this.lblMuzikAdi.Name = "lblMuzikAdi";
            this.lblMuzikAdi.Size = new System.Drawing.Size(166, 21);
            this.lblMuzikAdi.TabIndex = 1;
            this.lblMuzikAdi.Text = "Müzik adı - Sanatcı adı";
            // 
            // lblIzlenmeSayisi
            // 
            this.lblIzlenmeSayisi.AutoSize = true;
            this.lblIzlenmeSayisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIzlenmeSayisi.ForeColor = System.Drawing.Color.White;
            this.lblIzlenmeSayisi.Location = new System.Drawing.Point(293, 17);
            this.lblIzlenmeSayisi.Name = "lblIzlenmeSayisi";
            this.lblIzlenmeSayisi.Size = new System.Drawing.Size(106, 21);
            this.lblIzlenmeSayisi.TabIndex = 1;
            this.lblIzlenmeSayisi.Text = "İzlenme sayısı";
            // 
            // btnOynat
            // 
            this.btnOynat.FlatAppearance.BorderSize = 0;
            this.btnOynat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOynat.Image = global::MusicApp.UI.Properties.Resources.play;
            this.btnOynat.Location = new System.Drawing.Point(888, 0);
            this.btnOynat.Name = "btnOynat";
            this.btnOynat.Size = new System.Drawing.Size(91, 52);
            this.btnOynat.TabIndex = 2;
            this.btnOynat.UseVisualStyleBackColor = true;
            // 
            // SarkiItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.btnOynat);
            this.Controls.Add(this.lblIzlenmeSayisi);
            this.Controls.Add(this.lblMuzikAdi);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "SarkiItem";
            this.Size = new System.Drawing.Size(1050, 52);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblMuzikAdi;
        public System.Windows.Forms.Label lblIzlenmeSayisi;
        public System.Windows.Forms.Button btnOynat;
    }
}
