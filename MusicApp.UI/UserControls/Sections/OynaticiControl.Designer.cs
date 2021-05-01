
namespace MusicApp.UI.UserControls.Sections
{
    partial class OynaticiControl
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnOnceki = new System.Windows.Forms.Button();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = global::MusicApp.UI.Properties.Resources.play;
            this.btnPlay.Location = new System.Drawing.Point(93, 22);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 40);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnOnceki
            // 
            this.btnOnceki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnceki.Image = global::MusicApp.UI.Properties.Resources.prev;
            this.btnOnceki.Location = new System.Drawing.Point(12, 22);
            this.btnOnceki.Name = "btnOnceki";
            this.btnOnceki.Size = new System.Drawing.Size(75, 40);
            this.btnOnceki.TabIndex = 1;
            this.btnOnceki.UseVisualStyleBackColor = true;
            // 
            // btnSonraki
            // 
            this.btnSonraki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSonraki.Image = global::MusicApp.UI.Properties.Resources.next;
            this.btnSonraki.Location = new System.Drawing.Point(174, 22);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(75, 40);
            this.btnSonraki.TabIndex = 2;
            this.btnSonraki.UseVisualStyleBackColor = true;
            // 
            // OynaticiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.btnOnceki);
            this.Controls.Add(this.btnPlay);
            this.Name = "OynaticiControl";
            this.Size = new System.Drawing.Size(1358, 84);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnOnceki;
        private System.Windows.Forms.Button btnSonraki;
    }
}
