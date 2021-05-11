
namespace MusicApp.UI.AdminControls.Sections
{
    partial class SanatcilarControl
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSanatcilar = new System.Windows.Forms.Panel();
            this.btnSanatciEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.label6.Location = new System.Drawing.Point(36, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sanatçılar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(244, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sanatçı Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(460, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sanatçı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(688, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ülke Adı";
            // 
            // pnlSanatcilar
            // 
            this.pnlSanatcilar.Location = new System.Drawing.Point(208, 50);
            this.pnlSanatcilar.Name = "pnlSanatcilar";
            this.pnlSanatcilar.Size = new System.Drawing.Size(734, 506);
            this.pnlSanatcilar.TabIndex = 3;
            // 
            // btnSanatciEkle
            // 
            this.btnSanatciEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSanatciEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanatciEkle.FlatAppearance.BorderSize = 0;
            this.btnSanatciEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanatciEkle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSanatciEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(50)))));
            this.btnSanatciEkle.Location = new System.Drawing.Point(31, 311);
            this.btnSanatciEkle.Name = "btnSanatciEkle";
            this.btnSanatciEkle.Size = new System.Drawing.Size(110, 73);
            this.btnSanatciEkle.TabIndex = 5;
            this.btnSanatciEkle.Text = "Sanatçı Ekle";
            this.btnSanatciEkle.UseVisualStyleBackColor = false;
            this.btnSanatciEkle.Click += new System.EventHandler(this.btnSanatciEkle_Click);
            // 
            // SanatcilarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.btnSanatciEkle);
            this.Controls.Add(this.pnlSanatcilar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "SanatcilarControl";
            this.Size = new System.Drawing.Size(1358, 573);
            this.Load += new System.EventHandler(this.SanatcilarControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlSanatcilar;
        private System.Windows.Forms.Button btnSanatciEkle;
    }
}
