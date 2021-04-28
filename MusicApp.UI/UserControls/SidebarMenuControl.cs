using MusicApp.UI.AuthControls;
using MusicApp.UI.UserControls.Sections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MusicApp.UI.UserControls
{
    public partial class SidebarMenuControl : UserControl
    {
        private Panel contentPaneli;
        private CalmaListesiControl calmaListesiControl;
        private AnasayfaControl anasayfaControl;
        public SidebarMenuControl()
        {
            InitializeComponent();            
        }

        private void icerikDegistir(Control control)
        {
            contentPaneli.Controls.Clear();
            contentPaneli.Controls.Add(control);
        }

        private void calmaListesiniGetir()
        {            
            if(calmaListesiControl == null)
                calmaListesiControl = new CalmaListesiControl();

            icerikDegistir(calmaListesiControl);
        }

        private void anasayfaGetir()
        {
            if (anasayfaControl == null)
                anasayfaControl = new AnasayfaControl();
            icerikDegistir(anasayfaControl);
        }

        private void bilgileriYazdir()
        {
            lblKullaniciAdi.Text = LoginManager.etkinKullanici.kullaniciAdi;
        }

        private void SidebarMenuControl_Load(object sender, EventArgs e)
        {
            contentPaneli = Parent.Parent.Controls.Find("pnlContent", true)[0] as Panel;
            anasayfaGetir();
            bilgileriYazdir();
        }

        private void btnCalmaListesi_Click(object sender, EventArgs e)
        {
            calmaListesiniGetir();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            anasayfaGetir();
        }
    }
}
