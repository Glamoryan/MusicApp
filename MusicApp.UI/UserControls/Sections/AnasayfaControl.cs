using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using MusicApp.UI.AuthControls;
using MusicApp.UI.Tools;
using MusicApp.UI.UserControls.Player;
using MusicApp.UI.UserControls.Sections.List_Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MusicApp.UI.UserControls.Sections
{
    public partial class AnasayfaControl : UserControl
    {
        private ISarkiService _sarkiService;
        private ISanatciService _sanatciService;
        private IAlbumDetayService _albumDetayService;
        private ICalmaListesiService _calmaListesiService;

        private List<Sarki> _tumSarkilar;
        private List<Sarki> _genelEncok;
        private List<Sarki> _ulkeEncok;

        private OynaticiControl oynaticiControl;
        private Button ilkButton;

        public AnasayfaControl()
        {
            InitializeComponent();
            _sarkiService = InstanceFactory.GetInstance<ISarkiService>();
            _sanatciService = InstanceFactory.GetInstance<ISanatciService>();
            _albumDetayService = InstanceFactory.GetInstance<IAlbumDetayService>();
            _calmaListesiService = InstanceFactory.GetInstance<ICalmaListesiService>();
        }

        private void oynaticiyiGuncelle(Button sarkiButonu)
        {
            oynaticiControl = new OynaticiControl();
            oynaticiControl.btnPlay.Enabled = true;
            oynaticiControl.lblMuzikAdi.Text = Oynatici.suankiSarki.sarkiAdi;
            oynaticiControl.lblSanatciAdi.Text = _sanatciService.SanatciGetir(Oynatici.suankiSarki.sanatciId).sanatciAdi;
            oynaticiControl.lblSesDuzey.Text = Oynatici.GetSesDuzeyi();
            oynaticiControl.btnSesYukselt.Enabled = true;
            oynaticiControl.btnSesYukselt.Click += (s, e) => Oynatici.sesYukselt(oynaticiControl.lblSesDuzey);
            oynaticiControl.btnSesDusur.Enabled = true;
            oynaticiControl.btnSesDusur.Click += (s, e) => Oynatici.sesDusur(oynaticiControl.lblSesDuzey);

            if (sarkiButonu != ilkButton && ilkButton != null)
                ilkButton.Image = Properties.Resources.play;

            if (Oynatici.caliyorMu)
            {
                oynaticiControl.btnPlay.Image = Properties.Resources.pause;
                sarkiButonu.Image = Properties.Resources.pause;
            }
            else
            {
                oynaticiControl.btnPlay.Image = Properties.Resources.play;
                sarkiButonu.Image = Properties.Resources.play;
            }
            ilkButton = sarkiButonu;
            Utilities.icerikDegistir(Parent.Parent.Controls.Find("pnlPlayer", true)[0], oynaticiControl);
        }

        private void oynaticiyiAktifEt(Sarki sarki, Button sarkiButonu)
        {
            Oynatici.oynaticiBaslat(sarki);
            oynaticiyiGuncelle(sarkiButonu);
        }

        private bool calmaListesindeVarmi(Sarki sarki)
        {
            List<CalmaListesi> calmaListesi = _calmaListesiService.KullaniciCalmaListeleriniGetir(LoginManager.etkinKullanici.kullaniciId);
            if (calmaListesi.Count > 0)
            {
                foreach (CalmaListesi liste in calmaListesi)
                {
                    if (sarki.sarkiId == liste.sarkiId)
                        return true;
                }
            }
            return false;
        }

        private void calmaListesineEkle(Sarki sarki)
        {
            if (!calmaListesindeVarmi(sarki))
            {
                CalmaListesi calmaListesi = new CalmaListesi
                {
                    kullaniciId = LoginManager.etkinKullanici.kullaniciId,
                    sarkiId = sarki.sarkiId,
                    turId = _albumDetayService.SarkiAlbumuGetir(sarki.sarkiId).turId
                };
                _calmaListesiService.CalmaListesiEkle(calmaListesi);
                MessageBox.Show("Çalma listesine eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sarkilariGetir();
            }
            else
                MessageBox.Show("Bu şarkı çalma listenizde zaten mevcut!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ulkelereGoreGetir()
        {
            _ulkeEncok = _sarkiService.TumSarkilariGetir();
            var liste = _ulkeEncok.GroupBy(x => x.sarkiUlke)
                .Select(g =>
                new
                {
                    UlkeAdi = g.Key,
                    Sarkilar = g.OrderByDescending(x => x.sarkiDinlenmesi)
                })
                .OrderByDescending(g => g.Sarkilar.First().sarkiDinlenmesi);

            TopUlkeItem topUlkeItem;

            int ulkeSayac = 0;
            foreach (var grup in liste)
            {
                foreach (Sarki sarki in grup.Sarkilar)
                {
                    if (ulkeSayac < 10)
                    {
                        topUlkeItem = new TopUlkeItem();
                        topUlkeItem.Top = (ulkeSayac * 60);
                        topUlkeItem.lblSarkiAdi.Text = Utilities.textSinirla(sarki.sarkiAdi, 10);
                        topUlkeItem.lblDinlenme.Text = sarki.sarkiDinlenmesi.ToString();
                        topUlkeItem.lblUlke.Text = sarki.sarkiUlke;
                        topUlkeItem.btnOynat.Click += (s, e) => oynaticiyiAktifEt(sarki, s as Button);
                        topUlkeItem.lblSayac.Text = (ulkeSayac + 1).ToString();
                        pnlUlke.Controls.Add(topUlkeItem);
                        ulkeSayac++;
                    }
                    else
                        break;
                }
            }
        }

        private void sarkilariGetir()
        {
            pnlPop.Controls.Clear();
            pnlJazz.Controls.Clear();
            pnlKlasik.Controls.Clear();
            pnlGenel.Controls.Clear();
            pnlUlke.Controls.Clear();

            _tumSarkilar = _sarkiService.TumSarkilariGetir();
            _genelEncok = _tumSarkilar.OrderByDescending(x => x.sarkiDinlenmesi).ToList();           

            TopSarkiItem topSarkiItem;
            TopGenelItem topGenelItem;            
            int turId;

            int popSayac = 0, jazzSayac = 0, klasikSayac = 0, genelSayac = 0;
            foreach (Sarki sarki in _genelEncok)
            {
                turId = _albumDetayService.SarkiAlbumuGetir(sarki.sarkiId).turId;

                topGenelItem = new TopGenelItem();
                topGenelItem.lblMuzikAdi.Text = Utilities.textSinirla(sarki.sarkiAdi,16);
                topGenelItem.lblSanatciAdi.Text = Utilities.textSinirla(_sanatciService.SanatciGetir(sarki.sanatciId).sanatciAdi);
                topGenelItem.lblDinlenme.Text = sarki.sarkiDinlenmesi.ToString();
                topGenelItem.btnOynat.Click += (s, e) => oynaticiyiAktifEt(sarki, s as Button);
                topGenelItem.btnEkle.Click += (s, e) => calmaListesineEkle(sarki);
                topGenelItem.lblSayac.Text = (genelSayac + 1).ToString();

                topSarkiItem = new TopSarkiItem();
                topSarkiItem.lblSarkiAdi.Text = Utilities.textSinirla(sarki.sarkiAdi);
                topSarkiItem.lblSanatciAdi.Text = Utilities.textSinirla(_sanatciService.SanatciGetir(sarki.sanatciId).sanatciAdi);
                topSarkiItem.lblDinlenme.Text = sarki.sarkiDinlenmesi.ToString();
                topSarkiItem.btnOynat.Click += (s, e) => oynaticiyiAktifEt(sarki, s as Button);

                switch (turId)
                {
                    case 1:
                        if (popSayac <= 10)
                        {
                            topSarkiItem.Top = (popSayac * 60);
                            pnlPop.Controls.Add(topSarkiItem);
                            popSayac++;
                        }
                        break;
                    case 2:
                        if (jazzSayac <= 10)
                        {
                            topSarkiItem.Top = (jazzSayac * 60);
                            pnlJazz.Controls.Add(topSarkiItem);
                            jazzSayac++;
                        }
                        break;
                    case 3:
                        if (klasikSayac <= 10)
                        {
                            topSarkiItem.Top = (klasikSayac * 60);
                            pnlKlasik.Controls.Add(topSarkiItem);
                            klasikSayac++;
                        }
                        break;                    
                }

                if (genelSayac < 10)
                {
                    topGenelItem.Top = (genelSayac * 70);
                    pnlGenel.Controls.Add(topGenelItem);
                    genelSayac++;
                }
            }
            ulkelereGoreGetir();
        }

        private void AnasayfaControl_Load(object sender, EventArgs e)
        {
            Utilities.scroolbarEkle(pnlGenel);
            Utilities.scroolbarEkle(pnlJazz);
            Utilities.scroolbarEkle(pnlKlasik);
            Utilities.scroolbarEkle(pnlPop);
            Utilities.scroolbarEkle(pnlUlke);

            sarkilariGetir();
        }
    }
}
