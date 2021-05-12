using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using MusicApp.UI.Tools;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicApp.UI.AuthControls
{
    public partial class KayitControl : UserControl
    {
        private IKullaniciService _kullaniciService;
        private IAboneService _aboneService;

        public KayitControl()
        {
            InitializeComponent();
            _kullaniciService = InstanceFactory.GetInstance<IKullaniciService>();
            _aboneService = InstanceFactory.GetInstance<IAboneService>();
        }

        private bool bosAlanVarmi()
        {
            if (string.IsNullOrEmpty(tbxKullaniciAdi.Text) || string.IsNullOrEmpty(tbxMail.Text) || string.IsNullOrEmpty(tbxSifre.Text) || string.IsNullOrEmpty(tbxUlke.Text))
                return true;
            else
                return false;
        }

        private bool kullaniciAdiAlinmisMi()
        {
            List<Kullanici> kullanicilar = _kullaniciService.TumKullanicilariGetir();
            if (kullanicilar.Count > 0)
            {
                foreach (Kullanici kullanici in kullanicilar)
                {
                    if (kullanici.kullaniciAdi.ToLower() == tbxKullaniciAdi.Text.ToLower().Trim())
                        return true;
                }
            }
            return false;
        }

        private void kayitOl()
        {
            if (!bosAlanVarmi())
            {
                if (!kullaniciAdiAlinmisMi())
                {
                    Kullanici kullanici = new Kullanici
                    {
                        kullaniciAdi = tbxKullaniciAdi.Text.Trim(),
                        kullaniciMail = tbxMail.Text.Trim(),
                        kullaniciSifre = tbxSifre.Text.Trim(),
                        rolId = 1,
                        ulkeAdi = tbxUlke.Text.Trim()
                    };

                    Abone abone = new Abone
                    {
                        abonelikId = 1,
                        kullaniciId = _kullaniciService.KullaniciEkle(kullanici).kullaniciId,
                        odendi = false
                    };

                    _aboneService.AboneEkle(abone);

                    MessageBox.Show("Hesabınız oluşturuldu! Giriş yapabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Utilities.icerikDegistir(Parent, new GirisControl());
                }
                else
                    MessageBox.Show("Bu kullanıcı adı daha önce alınmış!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Boş alan bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Utilities.icerikDegistir(Parent, new GirisControl());
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            kayitOl();
        }
    }
}
