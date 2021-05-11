
namespace MusicApp.UI.AdminControls.Sections.Edit_Controls
{
    partial class SanatciAdd
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
            this.tbxSanatciAdi = new System.Windows.Forms.TextBox();
            this.lblSarkiAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUlkeAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.lblBaslik.Location = new System.Drawing.Point(134, 40);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(149, 32);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Sanatçı Ekle";
            // 
            // tbxSanatciAdi
            // 
            this.tbxSanatciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSanatciAdi.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxSanatciAdi.Location = new System.Drawing.Point(165, 129);
            this.tbxSanatciAdi.Name = "tbxSanatciAdi";
            this.tbxSanatciAdi.Size = new System.Drawing.Size(216, 35);
            this.tbxSanatciAdi.TabIndex = 9;
            // 
            // lblSarkiAdi
            // 
            this.lblSarkiAdi.AutoSize = true;
            this.lblSarkiAdi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSarkiAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.lblSarkiAdi.Location = new System.Drawing.Point(165, 98);
            this.lblSarkiAdi.Name = "lblSarkiAdi";
            this.lblSarkiAdi.Size = new System.Drawing.Size(106, 25);
            this.lblSarkiAdi.TabIndex = 8;
            this.lblSarkiAdi.Text = "Sanatçı Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(461, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ülkesi";
            // 
            // tbxUlkeAdi
            // 
            this.tbxUlkeAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUlkeAdi.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxUlkeAdi.Location = new System.Drawing.Point(461, 129);
            this.tbxUlkeAdi.Name = "tbxUlkeAdi";
            this.tbxUlkeAdi.Size = new System.Drawing.Size(216, 35);
            this.tbxUlkeAdi.TabIndex = 9;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.btnEkle.Location = new System.Drawing.Point(1177, 486);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(113, 42);
            this.btnEkle.TabIndex = 16;
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
            this.btnIptal.Location = new System.Drawing.Point(1058, 486);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(113, 42);
            this.btnIptal.TabIndex = 17;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // SanatciAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.tbxUlkeAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSanatciAdi);
            this.Controls.Add(this.lblSarkiAdi);
            this.Controls.Add(this.lblBaslik);
            this.Name = "SanatciAdd";
            this.Size = new System.Drawing.Size(1358, 573);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        public System.Windows.Forms.TextBox tbxSanatciAdi;
        private System.Windows.Forms.Label lblSarkiAdi;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbxUlkeAdi;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.Button btnIptal;
    }
}
