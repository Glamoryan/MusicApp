
namespace MusicApp.UI.AdminControls.Sections.List_Items
{
    partial class SanatciItem
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
            this.lblSanatciId = new System.Windows.Forms.Label();
            this.lblSanatciAdi = new System.Windows.Forms.Label();
            this.lblUlkeAdi = new System.Windows.Forms.Label();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSanatciId
            // 
            this.lblSanatciId.AutoSize = true;
            this.lblSanatciId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSanatciId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.lblSanatciId.Location = new System.Drawing.Point(75, 18);
            this.lblSanatciId.Name = "lblSanatciId";
            this.lblSanatciId.Size = new System.Drawing.Size(19, 21);
            this.lblSanatciId.TabIndex = 1;
            this.lblSanatciId.Text = "1";
            // 
            // lblSanatciAdi
            // 
            this.lblSanatciAdi.AutoSize = true;
            this.lblSanatciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSanatciAdi.ForeColor = System.Drawing.Color.White;
            this.lblSanatciAdi.Location = new System.Drawing.Point(255, 18);
            this.lblSanatciAdi.Name = "lblSanatciAdi";
            this.lblSanatciAdi.Size = new System.Drawing.Size(87, 21);
            this.lblSanatciAdi.TabIndex = 2;
            this.lblSanatciAdi.Text = "Sanatçı Adı";
            // 
            // lblUlkeAdi
            // 
            this.lblUlkeAdi.AutoSize = true;
            this.lblUlkeAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUlkeAdi.ForeColor = System.Drawing.Color.White;
            this.lblUlkeAdi.Location = new System.Drawing.Point(481, 18);
            this.lblUlkeAdi.Name = "lblUlkeAdi";
            this.lblUlkeAdi.Size = new System.Drawing.Size(68, 21);
            this.lblUlkeAdi.TabIndex = 2;
            this.lblUlkeAdi.Text = "Ülke Adı";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuzenle.FlatAppearance.BorderSize = 0;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.Image = global::MusicApp.UI.Properties.Resources.edit;
            this.btnDuzenle.Location = new System.Drawing.Point(626, 0);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(55, 56);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.UseVisualStyleBackColor = true;
            // 
            // SanatciItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.lblUlkeAdi);
            this.Controls.Add(this.lblSanatciAdi);
            this.Controls.Add(this.lblSanatciId);
            this.Name = "SanatciItem";
            this.Size = new System.Drawing.Size(734, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblSanatciId;
        public System.Windows.Forms.Label lblSanatciAdi;
        public System.Windows.Forms.Label lblUlkeAdi;
        public System.Windows.Forms.Button btnDuzenle;
    }
}
