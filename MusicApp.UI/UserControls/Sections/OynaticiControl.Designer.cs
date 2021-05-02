
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMuzikAdi = new System.Windows.Forms.Label();
            this.lblSanatciAdi = new System.Windows.Forms.Label();
            this.pcbxCikis = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSesYukselt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSesDuzey = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxCikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Enabled = false;
            this.btnPlay.FlatAppearance.BorderSize = 0;
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
            this.btnOnceki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnceki.Enabled = false;
            this.btnOnceki.FlatAppearance.BorderSize = 0;
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
            this.btnSonraki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSonraki.Enabled = false;
            this.btnSonraki.FlatAppearance.BorderSize = 0;
            this.btnSonraki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSonraki.Image = global::MusicApp.UI.Properties.Resources.next;
            this.btnSonraki.Location = new System.Drawing.Point(174, 22);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(75, 40);
            this.btnSonraki.TabIndex = 2;
            this.btnSonraki.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicApp.UI.Properties.Resources.music;
            this.pictureBox1.Location = new System.Drawing.Point(470, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblMuzikAdi
            // 
            this.lblMuzikAdi.AutoSize = true;
            this.lblMuzikAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMuzikAdi.ForeColor = System.Drawing.Color.White;
            this.lblMuzikAdi.Location = new System.Drawing.Point(540, 22);
            this.lblMuzikAdi.Name = "lblMuzikAdi";
            this.lblMuzikAdi.Size = new System.Drawing.Size(87, 21);
            this.lblMuzikAdi.TabIndex = 4;
            this.lblMuzikAdi.Text = "Müzik Adı";
            // 
            // lblSanatciAdi
            // 
            this.lblSanatciAdi.AutoSize = true;
            this.lblSanatciAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSanatciAdi.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSanatciAdi.Location = new System.Drawing.Point(540, 47);
            this.lblSanatciAdi.Name = "lblSanatciAdi";
            this.lblSanatciAdi.Size = new System.Drawing.Size(66, 15);
            this.lblSanatciAdi.TabIndex = 5;
            this.lblSanatciAdi.Text = "Sanatcı Adı";
            // 
            // pcbxCikis
            // 
            this.pcbxCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbxCikis.Image = global::MusicApp.UI.Properties.Resources.signout;
            this.pcbxCikis.Location = new System.Drawing.Point(1292, 12);
            this.pcbxCikis.Name = "pcbxCikis";
            this.pcbxCikis.Size = new System.Drawing.Size(53, 61);
            this.pcbxCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbxCikis.TabIndex = 6;
            this.pcbxCikis.TabStop = false;
            this.pcbxCikis.Click += new System.EventHandler(this.pcbxCikis_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MusicApp.UI.Properties.Resources.volume;
            this.pictureBox2.Location = new System.Drawing.Point(335, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnSesYukselt
            // 
            this.btnSesYukselt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSesYukselt.FlatAppearance.BorderSize = 0;
            this.btnSesYukselt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSesYukselt.Image = global::MusicApp.UI.Properties.Resources.up;
            this.btnSesYukselt.Location = new System.Drawing.Point(301, 11);
            this.btnSesYukselt.Name = "btnSesYukselt";
            this.btnSesYukselt.Size = new System.Drawing.Size(51, 31);
            this.btnSesYukselt.TabIndex = 8;
            this.btnSesYukselt.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::MusicApp.UI.Properties.Resources.down;
            this.button1.Location = new System.Drawing.Point(301, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 31);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblSesDuzey
            // 
            this.lblSesDuzey.AutoSize = true;
            this.lblSesDuzey.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSesDuzey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(81)))), ((int)(((byte)(251)))));
            this.lblSesDuzey.Location = new System.Drawing.Point(400, 21);
            this.lblSesDuzey.Name = "lblSesDuzey";
            this.lblSesDuzey.Size = new System.Drawing.Size(49, 37);
            this.lblSesDuzey.TabIndex = 9;
            this.lblSesDuzey.Text = "20";
            // 
            // OynaticiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.Controls.Add(this.lblSesDuzey);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSesYukselt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pcbxCikis);
            this.Controls.Add(this.lblSanatciAdi);
            this.Controls.Add(this.lblMuzikAdi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.btnOnceki);
            this.Controls.Add(this.btnPlay);
            this.Name = "OynaticiControl";
            this.Size = new System.Drawing.Size(1358, 84);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxCikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lblMuzikAdi;
        public System.Windows.Forms.Label lblSanatciAdi;
        public System.Windows.Forms.Button btnPlay;
        public System.Windows.Forms.Button btnOnceki;
        public System.Windows.Forms.Button btnSonraki;
        public System.Windows.Forms.Button btnSesYukselt;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lblSesDuzey;
        public System.Windows.Forms.PictureBox pcbxCikis;
    }
}
