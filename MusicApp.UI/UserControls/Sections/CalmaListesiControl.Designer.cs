
namespace MusicApp.UI.UserControls.Sections
{
    partial class CalmaListesiControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPop = new System.Windows.Forms.Panel();
            this.pnlJazz = new System.Windows.Forms.Panel();
            this.pnlKlasik = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çalma Listelerin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pop";
            // 
            // pnlPop
            // 
            this.pnlPop.Location = new System.Drawing.Point(25, 113);
            this.pnlPop.Name = "pnlPop";
            this.pnlPop.Size = new System.Drawing.Size(348, 505);
            this.pnlPop.TabIndex = 1;
            // 
            // pnlJazz
            // 
            this.pnlJazz.Location = new System.Drawing.Point(389, 113);
            this.pnlJazz.Name = "pnlJazz";
            this.pnlJazz.Size = new System.Drawing.Size(348, 505);
            this.pnlJazz.TabIndex = 1;
            // 
            // pnlKlasik
            // 
            this.pnlKlasik.Location = new System.Drawing.Point(753, 113);
            this.pnlKlasik.Name = "pnlKlasik";
            this.pnlKlasik.Size = new System.Drawing.Size(348, 505);
            this.pnlKlasik.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(389, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Jazz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(753, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Klasik";
            // 
            // CalmaListesiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.pnlKlasik);
            this.Controls.Add(this.pnlJazz);
            this.Controls.Add(this.pnlPop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalmaListesiControl";
            this.Size = new System.Drawing.Size(1112, 648);
            this.Load += new System.EventHandler(this.CalmaListesiControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlPop;
        private System.Windows.Forms.Panel pnlJazz;
        private System.Windows.Forms.Panel pnlKlasik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
