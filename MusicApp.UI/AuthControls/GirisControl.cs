using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using System;
using System.Windows.Forms;

namespace MusicApp.UI.AuthControls
{
    public partial class GirisControl : UserControl
    {
        private IKullaniciService _kullaniciService;

        public GirisControl()
        {
            InitializeComponent();

            _kullaniciService = InstanceFactory.GetInstance<IKullaniciService>();
        }

        private bool girisYap()
        {
            string kullaniciAdi = tbxKullaniciAdi.Text.Trim();
            string sifre = tbxSifre.Text.Trim();

            Kullanici kullanici = _kullaniciService.KullaniciLogin(kullaniciAdi, sifre);

            if (kullanici == null)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Hatalı Bilgiler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show(kullanici.kullaniciAdi + " giriş yapıldı");
                return true;
            }

        }

        //Giriş inputlarını kontrol eden fonksiyon
        private bool bilgileriKontrolEt()
        {
            if(string.IsNullOrEmpty(tbxKullaniciAdi.Text) || string.IsNullOrEmpty(tbxSifre.Text))
            {
                MessageBox.Show("Boş alan bırakılamaz!", "Gerekli Alanlar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;                     
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (bilgileriKontrolEt())
            {
                girisYap();
            }
        }
    }
}
