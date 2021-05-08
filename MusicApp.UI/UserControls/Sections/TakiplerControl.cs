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

        private bool calmaListesindeVarmi(int sarkiId)
        {
            List<CalmaListesi> calmaListesi = _calmaListesiService.KullaniciCalmaListeleriniGetir(LoginManager.etkinKullanici.kullaniciId);
            if(calmaListesi.Count >= 1)
            {
                foreach (CalmaListesi liste in calmaListesi)
                {
                    if (liste.sarkiId == sarkiId)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void tumunuCalmaListesineEkle(int kullaniciId)
        {
            List<CalmaListesi> calmaListesi = _calmaListesiService.KullaniciCalmaListeleriniGetir(kullaniciId);
            CalmaListesi yeniListe;
            bool eklendi = false;
            if(calmaListesi.Count >= 1)
            {
                foreach (CalmaListesi liste in calmaListesi)
                {
                    if (calmaListesindeVarmi(liste.sarkiId))
                        continue;
                    else
                    {
                        yeniListe = new CalmaListesi
                        {
                            kullaniciId = LoginManager.etkinKullanici.kullaniciId,
                            sarkiId = liste.sarkiId,
                            turId = liste.turId
                        };
                        _calmaListesiService.CalmaListesiEkle(yeniListe);
                        eklendi = true;
                    }
                }
                if (eklendi)
                    MessageBox.Show("Çalma listenizde olmayan tüm şarkılar çalma listenize eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                else
                    MessageBox.Show("Bu şarkılar zaten çalma listenizde mevcut", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Seçili kullanıcının çalma listesi boş", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void calmaListesineEkle(Sarki sarki,int turId)
        {
            if (!calmaListesindeVarmi(sarki.sarkiId))
            {
                CalmaListesi yeniListe = new CalmaListesi
                {
                    kullaniciId = LoginManager.etkinKullanici.kullaniciId,
                    sarkiId = sarki.sarkiId,
                    turId = turId
                };
                _calmaListesiService.CalmaListesiEkle(yeniListe);
                MessageBox.Show("Şarkı çalma listenize eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("Şarkı çalma listenizde zaten mevcut", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                       
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
                    kullaniciCalmaListesiItem.lblMuzikAdi.Text = Utilities.textSinirla(sarki.sarkiAdi);
                    kullaniciCalmaListesiItem.lblSanatciAdi.Text = Utilities.textSinirla(_sanatciService.SanatciGetir(sarki.sanatciId).sanatciAdi);
                    kullaniciCalmaListesiItem.btnEkle.Click += (s, e) => calmaListesineEkle(sarki,liste.turId);

                    switch (tur.turAdi.Trim().ToLower())
                    {
                        case "pop":
                            kullaniciCalmaListesiItem.Top = (popSayac * 60);
                            kullaniciCalmaListesiItem.lblSayac.Text = (popSayac + 1).ToString();
                            pnlPop.Controls.Add(kullaniciCalmaListesiItem);
                            popSayac++;
                            break;
                        case "jazz":
                            kullaniciCalmaListesiItem.Top = (jazzSayac * 60);
                            kullaniciCalmaListesiItem.lblSayac.Text = (jazzSayac + 1).ToString();
                            pnlJazz.Controls.Add(kullaniciCalmaListesiItem);
                            jazzSayac++;
                            break;
                        case "klasik":
                            kullaniciCalmaListesiItem.Top = (klasikSayac * 60);
                            kullaniciCalmaListesiItem.lblSayac.Text = (klasikSayac + 1).ToString();
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
                    _takipItem.lblKullaniciAdi.Text = Utilities.textSinirla(kullanici.kullaniciAdi,14);
                    _takipItem.lblTakipciSayisi.Text = _kullaniciTakipService.KullanicininTakipcileriniGetir(kullaniciTakip.kullaniciId).Count.ToString();
                    _takipItem.lblTakipEdilen.Text = _kullaniciTakipService.TakipEttikleriniGetir(kullaniciTakip.kullaniciId).Count.ToString();
                    _takipItem.btnTakiptenCik.Click += (s, e) => takiptenCik(kullaniciTakip);
                    _takipItem.btnSec.Click += (s, e) => kullaniciCalmaListesiGetir(kullaniciTakip.kullaniciId);
                    _takipItem.btnTumunuEkle.Click += (s, e) => tumunuCalmaListesineEkle(kullaniciTakip.kullaniciId);
                    _takipItem.lblSayac.Text = (sayac + 1).ToString();
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
