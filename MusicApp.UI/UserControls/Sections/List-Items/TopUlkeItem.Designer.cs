
namespace MusicApp.UI.UserControls.Sections.List_Items
{
    partial class TopUlkeItem
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
            this.lblSarkiAdi = new System.Windows.Forms.Label();
            this.lblDinlenme = new System.Windows.Forms.Label();
            this.lblUlke = new System.Windows.Forms.Label();
            this.btnOynat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSarkiAdi
            // 
            this.lblSarkiAdi.AutoSize = true;
            this.lblSarkiAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSarkiAdi.ForeColor = System.Drawing.Color.White;
            this.lblSarkiAdi.Location = new System.Drawing.Point(11, 18);
            this.lblSarkiAdi.Name = "lblSarkiAdi";
            this.lblSarkiAdi.Size = new System.Drawing.Size(72, 21);
            this.lblSarkiAdi.TabIndex = 1;
            this.lblSarkiAdi.Text = "Sarki Adı";
            // 
            // lblDinlenme
            // 
            this.lblDinlenme.AutoSize = true;
            this.lblDinlenme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDinlenme.ForeColor = System.Drawing.Color.White;
            this.lblDinlenme.Location = new System.Drawing.Point(124, 18);
            this.lblDinlenme.Name = "lblDinlenme";
            this.lblDinlenme.Size = new System.Drawing.Size(19, 21);
            this.lblDinlenme.TabIndex = 1;
            this.lblDinlenme.Text = "0";
            // 
            // lblUlke
            // 
            this.lblUlke.AutoSize = true;
            this.lblUlke.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUlke.ForeColor = System.Drawing.Color.White;
            this.lblUlke.Location = new System.Drawing.Point(191, 18);
            this.lblUlke.Name = "lblUlke";
            this.lblUlke.Size = new System.Drawing.Size(68, 21);
            this.lblUlke.TabIndex = 1;
            this.lblUlke.Text = "Ülke Adı";
            // 
            // btnOynat
            // 
            this.btnOynat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOynat.FlatAppearance.BorderSize = 0;
            this.btnOynat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOynat.Image = global::MusicApp.UI.Properties.Resources.play;
            this.btnOynat.Location = new System.Drawing.Point(269, 0);
            this.btnOynat.Name = "btnOynat";
            this.btnOynat.Size = new System.Drawing.Size(56, 57);
            this.btnOynat.TabIndex = 4;
            this.btnOynat.UseVisualStyleBackColor = true;
            // 
            // TopUlkeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.btnOynat);
            this.Controls.Add(this.lblUlke);
            this.Controls.Add(this.lblDinlenme);
            this.Controls.Add(this.lblSarkiAdi);
            this.Name = "TopUlkeItem";
            this.Size = new System.Drawing.Size(340, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblSarkiAdi;
        public System.Windows.Forms.Label lblDinlenme;
        public System.Windows.Forms.Label lblUlke;
        public System.Windows.Forms.Button btnOynat;
    }
}
