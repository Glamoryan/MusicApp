using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using MusicApp.UI.AuthControls;
using MusicApp.UI.Tools;
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
        private ICalmaListesiService _calmaListesiService;
        private ISarkiService _sarkiService;
        private ISanatciService _sanatciService;
        private ITurService _turService;

        private TakipItem _takipItem;        

        public TakiplerControl()
        {
            InitializeComponent();
            _kullaniciService = InstanceFactory.GetInstance<IKullaniciService>();
            _kullaniciTakipService = InstanceFactory.GetInstance<IKullaniciTakipService>();
            _calmaListesiService = InstanceFactory.GetInstance<ICalmaListesiService>();
            _sarkiService = InstanceFactory.GetInstance<ISarkiService>();
            _sanatciService = InstanceFactory.GetInstance<ISanatciService>();
            _turService = InstanceFactory.GetInstance<ITurService>();
        }

        private void takiptenCik(KullaniciTakip kullaniciTakip)
        {
            _kullaniciTakipService.KullaniciTakipSil(kullaniciTakip);
            MessageBox.Show("Takipten çıkıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            takipleriGetir();
        }

        private void kullaniciCalmaListesiGetir(int kullaniciId)
        {
            pnlPop.Controls.Clear();
            pnlJazz.Controls.Clear();
            pnlKlasik.Controls.Clear();

            lblKullaniciAdi.Text = _kullaniciService.KullaniciGetir(kullaniciId).kullaniciAdi;

            List<CalmaListesi> calmaListesi = _calmaListesiService.KullaniciCalmaListeleriniGetir(kullaniciId);
            KullaniciCalmaListesiItem kullaniciCalmaListesiItem;
            if(calmaListesi.Count >= 1)
            {
                int popSayac = 0, jazzSayac = 0, klasikSayac = 0;
                foreach (CalmaListesi liste in calmaListesi)
                {
                    Sarki sarki = _sarkiService.SarkiGetir(liste.sarkiId);
                    Tur tur = _turService.TurGetir(liste.turId);
                    kullaniciCalmaListesiItem = new KullaniciCalmaListesiItem();
                    kullaniciCalmaListesiItem.lblMuzikAdi.Text = sarki.sarkiAdi;
                    kullaniciCalmaListesiItem.lblSanatciAdi.Text = _sanatciService.SanatciGetir(sarki.sanatciId).sanatciAdi;

                    switch (tur.turAdi.Trim().ToLower())
                    {
                        case "pop":
                            kullaniciCalmaListesiItem.Top = (popSayac * 60);
                            pnlPop.Controls.Add(kullaniciCalmaListesiItem);
                            popSayac++;
                            break;
                        case "jazz":
                            kullaniciCalmaListesiItem.Top = (jazzSayac * 60);
                            pnlJazz.Controls.Add(kullaniciCalmaListesiItem);
                            jazzSayac++;
                            break;
                        case "klasik":
                            kullaniciCalmaListesiItem.Top = (klasikSayac * 60);
                            pnlKlasik.Controls.Add(kullaniciCalmaListesiItem);
                            klasikSayac++;
                            break;
                    }
                }
            }
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
                    _takipItem.btnSec.Click += (s, e) => kullaniciCalmaListesiGetir(kullaniciTakip.kullaniciId);
                    pnlTakipler.Controls.Add(_takipItem);
                    sayac++;
                }
            }
        }

        private void TakiplerControl_Load(object sender, EventArgs e)
        {
            Utilities.scroolbarEkle(pnlTakipler);
            Utilities.scroolbarEkle(pnlPop);
            Utilities.scroolbarEkle(pnlJazz);
            Utilities.scroolbarEkle(pnlKlasik);

            takipleriGetir();
        }
    }
}
