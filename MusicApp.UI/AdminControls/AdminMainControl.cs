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
        private SarkilarControl _sarkilarControl;
        private SanatcilarControl _sanatcilarControl;
        private AlbumlerControl _albumlerControl;

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

        private void sanatciEkraniGetir()
        {
            if (_sanatcilarControl == null)
                _sanatcilarControl = new SanatcilarControl();

            Utilities.icerikDegistir(pnlAdminContent, _sanatcilarControl);
        }

        private void albumEkraniGetir()
        {
            if (_albumlerControl == null)
                _albumlerControl = new AlbumlerControl();

            Utilities.icerikDegistir(pnlAdminContent, _albumlerControl);
        }

        private void sarkiEkraniGetir()
        {
            if (_sarkilarControl == null)
                _sarkilarControl = new SarkilarControl();

            Utilities.icerikDegistir(pnlAdminContent, _sarkilarControl);
        }

        private void CikisYap()
        {
            DialogResult sonuc = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış Yap?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {                
                LoginManager.etkinKullanici = null;
                Form suankiForm = FindForm();
                suankiForm.Hide();
                var girisForm = new signForm();
                girisForm.FormClosed += (s, args) => suankiForm.Close();
                girisForm.Show();
            }
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

        private void btnSarkilar_Click(object sender, EventArgs e)
        {
            sarkiEkraniGetir();
        }

        private void btnSanatcilar_Click(object sender, EventArgs e)
        {
            sanatciEkraniGetir();
        }

        private void btnAlbumler_Click(object sender, EventArgs e)
        {
            albumEkraniGetir();
        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            CikisYap();
        }
    }
}
