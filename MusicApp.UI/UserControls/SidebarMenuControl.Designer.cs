
namespace MusicApp.UI.UserControls
{
    partial class SidebarMenuControl
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
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.btnCalmaListesi = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.btnTakipler = new System.Windows.Forms.Button();
            this.btnKullanicilar = new System.Windows.Forms.Button();
            this.btnSarkilar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(81)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(13, 599);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı :";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(109, 600);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(21, 30);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "-";
            // 
            // btnCalmaListesi
            // 
            this.btnCalmaListesi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(81)))), ((int)(((byte)(251)))));
            this.btnCalmaListesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalmaListesi.FlatAppearance.BorderSize = 0;
            this.btnCalmaListesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalmaListesi.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalmaListesi.ForeColor = System.Drawing.Color.White;
            this.btnCalmaListesi.Location = new System.Drawing.Point(16, 176);
            this.btnCalmaListesi.Name = "btnCalmaListesi";
            this.btnCalmaListesi.Size = new System.Drawing.Size(211, 45);
            this.btnCalmaListesi.TabIndex = 1;
            this.btnCalmaListesi.Text = "Çalma Listeleri";
            this.btnCalmaListesi.UseVisualStyleBackColor = false;
            this.btnCalmaListesi.Click += new System.EventHandler(this.btnCalmaListesi_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(81)))), ((int)(((byte)(251)))));
            this.btnAnasayfa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnasayfa.FlatAppearance.BorderSize = 0;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnasayfa.ForeColor = System.Drawing.Color.White;
            this.btnAnasayfa.Location = new System.Drawing.Point(16, 74);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(211, 45);
            this.btnAnasayfa.TabIndex = 1;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // btnTakipler
            // 
            this.btnTakipler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(81)))), ((int)(((byte)(251)))));
            this.btnTakipler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTakipler.FlatAppearance.BorderSize = 0;
            this.btnTakipler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakipler.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTakipler.ForeColor = System.Drawing.Color.White;
            this.btnTakipler.Location = new System.Drawing.Point(16, 227);
            this.btnTakipler.Name = "btnTakipler";
            this.btnTakipler.Size = new System.Drawing.Size(211, 45);
            this.btnTakipler.TabIndex = 1;
            this.btnTakipler.Text = "Takip Ettiklerin";
            this.btnTakipler.UseVisualStyleBackColor = false;
            this.btnTakipler.Click += new System.EventHandler(this.btnTakipler_Click);
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(81)))), ((int)(((byte)(251)))));
            this.btnKullanicilar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKullanicilar.FlatAppearance.BorderSize = 0;
            this.btnKullanicilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullanicilar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKullanicilar.ForeColor = System.Drawing.Color.White;
            this.btnKullanicilar.Location = new System.Drawing.Point(16, 278);
            this.btnKullanicilar.Name = "btnKullanicilar";
            this.btnKullanicilar.Size = new System.Drawing.Size(211, 45);
            this.btnKullanicilar.TabIndex = 1;
            this.btnKullanicilar.Text = "Kullanıcılar";
            this.btnKullanicilar.UseVisualStyleBackColor = false;
            this.btnKullanicilar.Click += new System.EventHandler(this.btnKullanicilar_Click);
            // 
            // btnSarkilar
            // 
            this.btnSarkilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(81)))), ((int)(((byte)(251)))));
            this.btnSarkilar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSarkilar.FlatAppearance.BorderSize = 0;
            this.btnSarkilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSarkilar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSarkilar.ForeColor = System.Drawing.Color.White;
            this.btnSarkilar.Location = new System.Drawing.Point(16, 125);
            this.btnSarkilar.Name = "btnSarkilar";
            this.btnSarkilar.Size = new System.Drawing.Size(211, 45);
            this.btnSarkilar.TabIndex = 2;
            this.btnSarkilar.Text = "Şarkılar";
            this.btnSarkilar.UseVisualStyleBackColor = false;
            this.btnSarkilar.Click += new System.EventHandler(this.btnSarkilar_Click);
            // 
            // SidebarMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.btnSarkilar);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnKullanicilar);
            this.Controls.Add(this.btnTakipler);
            this.Controls.Add(this.btnCalmaListesi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.label1);
            this.Name = "SidebarMenuControl";
            this.Size = new System.Drawing.Size(246, 648);
            this.Load += new System.EventHandler(this.SidebarMenuControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Button btnCalmaListesi;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Button btnTakipler;
        private System.Windows.Forms.Button btnKullanicilar;
        private System.Windows.Forms.Button btnSarkilar;
    }
}
