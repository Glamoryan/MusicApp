using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
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

        private List<Sarki> _tumSarkilar;
        private List<Sarki> _genelEncok;

        private OynaticiControl oynaticiControl;
        private Button ilkButton;

        public AnasayfaControl()
        {
            InitializeComponent();
            _sarkiService = InstanceFactory.GetInstance<ISarkiService>();
            _sanatciService = InstanceFactory.GetInstance<ISanatciService>();
            _albumDetayService = InstanceFactory.GetInstance<IAlbumDetayService>();
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

        private void sarkilariGetir()
        {
            pnlPop.Controls.Clear();
            pnlJazz.Controls.Clear();
            pnlKlasik.Controls.Clear();

            _tumSarkilar = _sarkiService.TumSarkilariGetir();
            _genelEncok = _tumSarkilar.OrderByDescending(x => x.sarkiDinlenmesi).ToList();
            

            TopSarkiItem topSarkiItem;
            int turId;

            int popSayac = 0, jazzSayac = 0, klasikSayac = 0;
            foreach (Sarki sarki in _genelEncok)
            {
                turId = _albumDetayService.SarkiAlbumuGetir(sarki.sarkiId).turId;

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
                        if(klasikSayac <= 10)
                        {
                            topSarkiItem.Top = (klasikSayac * 60);
                            pnlKlasik.Controls.Add(topSarkiItem);
                            klasikSayac++;
                        }                        
                        break;
                }                
            }
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
