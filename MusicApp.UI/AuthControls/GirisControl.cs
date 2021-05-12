using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using MusicApp.UI.Tools;
using System;
using System.Windows.Forms;

namespace MusicApp.UI.AuthControls
{
    public partial class GirisControl : UserControl
    {
        private IKullaniciService _kullaniciService;
        private IAboneService _aboneService;

        public GirisControl()
        {
            InitializeComponent();

            _kullaniciService = InstanceFactory.GetInstance<IKullaniciService>();
            _aboneService = InstanceFactory.GetInstance<IAboneService>();
        }

        private void girisYap()
        {
            string kullaniciAdi = tbxKullaniciAdi.Text.Trim();
            string sifre = tbxSifre.Text.Trim();

            Kullanici kullanici = _kullaniciService.KullaniciLogin(kullaniciAdi, sifre);

            if (kullanici == null)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Hatalı Bilgiler", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            else
            {
                LoginManager.etkinKullanici = kullanici;
                LoginManager.premiumMu = _aboneService.AboneyiGetir(kullanici.kullaniciId).abonelikId == 1 ? false : true;

                switch (yetkiyiKontrolEt(kullanici))
                {                    
                    case 0:                        
                        anaEkraniGetir(false);
                        break;
                    case 1:                        
                        anaEkraniGetir(true);
                        break;
                }
                
            }
        }

        private void anaEkraniGetir(bool adminMi)
        {
            Form suankiForm = FindForm();
            suankiForm.Hide();
            var anaForm = new mainForm(adminMi);            
            anaForm.FormClosed += (s, args) => suankiForm.Close();
            anaForm.Show();
        }

        //Giriş inputlarını kontrol eden fonksiyon
        private bool bilgileriKontrolEt()
        {
            if (string.IsNullOrEmpty(tbxKullaniciAdi.Text) || string.IsNullOrEmpty(tbxSifre.Text))
            {
                MessageBox.Show("Boş alan bırakılamaz!", "Gerekli Alanlar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        //Yetki kontrol (Admin ise 1, Normal kullanıcı is 0 döndürür)
        private int yetkiyiKontrolEt(Kullanici suankiKullanici)
        {
            if (suankiKullanici.rolId == 2)
                return 1;
            else
                return 0;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (bilgileriKontrolEt())
            {
                girisYap();
            }
        }

        private void kayitEkraniGetir()
        {
            Utilities.icerikDegistir(Parent, new KayitControl());
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            kayitEkraniGetir();
        }
    }
}
