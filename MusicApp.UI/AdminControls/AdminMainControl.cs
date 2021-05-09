using MusicApp.UI.AdminControls.Sections;
using MusicApp.UI.AuthControls;
using MusicApp.UI.Tools;
using System;
using System.Windows.Forms;

namespace MusicApp.UI.AdminControls
{
    public partial class AdminMainControl : UserControl
    {
        private KullanicilarControl _kullanicilarControl;

        public AdminMainControl()
        {
            InitializeComponent();
        }

        private void bilgiYazdir()
        {
            lblKullaniciAdi.Text = LoginManager.etkinKullanici.kullaniciAdi;
        }

        private void kullaniciEkraniGetir()
        {
            if (_kullanicilarControl == null)
                _kullanicilarControl = new KullanicilarControl();

            Utilities.icerikDegistir(pnlAdminContent, _kullanicilarControl);
        }

        private void AdminMainControl_Load(object sender, EventArgs e)
        {
            bilgiYazdir();
            kullaniciEkraniGetir();
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            kullaniciEkraniGetir();
        }
    }
}
