using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using MusicApp.UI.AuthControls;
using MusicApp.UI.UserControls.Sections.List_Items;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicApp.UI.UserControls.Sections
{
    public partial class TakiplerControl : UserControl
    {
        private IKullaniciService _kullaniciService;
        private IKullaniciTakipService _kullaniciTakipService;

        private TakipItem _takipItem;

        public TakiplerControl()
        {
            InitializeComponent();
            _kullaniciService = InstanceFactory.GetInstance<IKullaniciService>();
            _kullaniciTakipService = InstanceFactory.GetInstance<IKullaniciTakipService>();
        }

        private void takiptenCik(KullaniciTakip kullaniciTakip)
        {
            _kullaniciTakipService.KullaniciTakipSil(kullaniciTakip);
            MessageBox.Show("Takipten çıkıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            takipleriGetir();
        }

        private void takipleriGetir()
        {
            pnlTakipler.Controls.Clear();
            List<KullaniciTakip> kullaniciTakipleri = _kullaniciTakipService.TakipEttikleriniGetir(LoginManager.etkinKullanici.kullaniciId);
            Kullanici kullanici;
            if (kullaniciTakipleri.Count > 0)
            {
                int sayac = 0;
                foreach (KullaniciTakip kullaniciTakip in kullaniciTakipleri)
                {
                    kullanici = _kullaniciService.KullaniciGetir(kullaniciTakip.kullaniciId);
                    _takipItem = new TakipItem();
                    _takipItem.Top = (sayac * 80);
                    _takipItem.lblKullaniciAdi.Text = kullanici.kullaniciAdi;
                    _takipItem.lblTakipciSayisi.Text = _kullaniciTakipService.KullanicininTakipcileriniGetir(kullaniciTakip.kullaniciId).Count.ToString();
                    _takipItem.lblTakipEdilen.Text = _kullaniciTakipService.TakipEttikleriniGetir(kullaniciTakip.kullaniciId).Count.ToString();
                    _takipItem.btnTakiptenCik.Click += (s, e) => takiptenCik(kullaniciTakip);
                    pnlTakipler.Controls.Add(_takipItem);
                    sayac++;
                }
            }
        }

        private void TakiplerControl_Load(object sender, EventArgs e)
        {
            takipleriGetir();
        }
    }
}
