
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
            this.grbxPop = new System.Windows.Forms.GroupBox();
            this.grbxJazz = new System.Windows.Forms.GroupBox();
            this.grbxKlasik = new System.Windows.Forms.GroupBox();
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
            // grbxPop
            // 
            this.grbxPop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbxPop.ForeColor = System.Drawing.Color.White;
            this.grbxPop.Location = new System.Drawing.Point(42, 75);
            this.grbxPop.Name = "grbxPop";
            this.grbxPop.Size = new System.Drawing.Size(303, 497);
            this.grbxPop.TabIndex = 1;
            this.grbxPop.TabStop = false;
            this.grbxPop.Text = "Pop";
            // 
            // grbxJazz
            // 
            this.grbxJazz.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbxJazz.ForeColor = System.Drawing.Color.White;
            this.grbxJazz.Location = new System.Drawing.Point(413, 75);
            this.grbxJazz.Name = "grbxJazz";
            this.grbxJazz.Size = new System.Drawing.Size(303, 497);
            this.grbxJazz.TabIndex = 1;
            this.grbxJazz.TabStop = false;
            this.grbxJazz.Text = "Jazz";
            // 
            // grbxKlasik
            // 
            this.grbxKlasik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbxKlasik.ForeColor = System.Drawing.Color.White;
            this.grbxKlasik.Location = new System.Drawing.Point(782, 75);
            this.grbxKlasik.Name = "grbxKlasik";
            this.grbxKlasik.Size = new System.Drawing.Size(303, 497);
            this.grbxKlasik.TabIndex = 1;
            this.grbxKlasik.TabStop = false;
            this.grbxKlasik.Text = "Klasik";
            // 
            // CalmaListesiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.grbxKlasik);
            this.Controls.Add(this.grbxJazz);
            this.Controls.Add(this.grbxPop);
            this.Controls.Add(this.label1);
            this.Name = "CalmaListesiControl";
            this.Size = new System.Drawing.Size(1112, 648);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbxPop;
        private System.Windows.Forms.GroupBox grbxJazz;
        private System.Windows.Forms.GroupBox grbxKlasik;
    }
}
