using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using MusicApp.UI.AuthControls;
using MusicApp.UI.Tools;
using MusicApp.UI.UserControls.Player;
using MusicApp.UI.UserControls.Sections.List_Items;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicApp.UI.UserControls.Sections
{
    public partial class SarkilarControl : UserControl
    {
        private ISarkiService _sarkiService;
        private ISanatciService _sanatciService;
        private IAlbumDetayService _albumDetayService;
        private ITurService _turService;
        private ICalmaListesiService _calmaListesiService;

        private SarkiItem _sarkiItem;

        private Button ilkButton;

        OynaticiControl oynaticiControl;
        Panel oynaticiPanel;

        public SarkilarControl()
        {
            InitializeComponent();
            _sarkiService = InstanceFactory.GetInstance<ISarkiService>();
            _sanatciService = InstanceFactory.GetInstance<ISanatciService>();
            _albumDetayService = InstanceFactory.GetInstance<IAlbumDetayService>();
            _turService = InstanceFactory.GetInstance<ITurService>();
            _calmaListesiService = InstanceFactory.GetInstance<ICalmaListesiService>();
        }

        private void oynaticiyiGuncelle(Button sarkiButonu)
        {
            oynaticiControl = new OynaticiControl();
            oynaticiControl.btnPlay.Enabled = true;
            oynaticiControl.lblMuzikAdi.Text = Oynatici.suankiSarki.sarkiAdi;
            oynaticiControl.lblSanatciAdi.Text = _sanatciService.SanatciGetir(Oynatici.suankiSarki.sanatciId).sanatciAdi;

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



            Utilities.icerikDegistir(Parent.Parent.Controls.Find("pnlPlayer", true)[0], oynaticiControl);

            //switch (durum)
            //{
            //    case 0: //ilk şarkı başladığında (transitioning)
            //        oynaticiControl = new OynaticiControl();
            //        oynaticiControl.lblMuzikAdi.Text = calanSarki.sarkiAdi;
            //        oynaticiControl.lblSanatciAdi.Text = _sanatciService.SanatciGetir(calanSarki.sanatciId).sanatciAdi;
            //        oynaticiControl.btnPlay.Enabled = true;
            //        oynaticiControl.btnSesYukselt.Enabled = true;
            //        oynaticiControl.btnSesDusur.Enabled = true;                    
            //        oynaticiControl.btnSesYukselt.Click += (s, e) => Oynatici.sesYukselt();
            //        oynaticiControl.btnSesDusur.Click += (s, e) => Oynatici.sesDusur();
            //        Oynatici.sesLabel = oynaticiControl.lblSesDuzey;                    
            //        oynaticiControl.btnPlay.Image = Properties.Resources.pause;                    
            //        ilkButton.Image = Properties.Resources.pause;
            //        oynaticiControl.btnPlay.Click += (s, e) => oynaticiyiAktifEt(calanSarki,s as Button);
            //        oynaticiPanel = Parent.Parent.Controls.Find("pnlPlayer", true)[0] as Panel;
            //        oynaticiControl.lblSesDuzey.Text = Oynatici.GetSesDuzeyi();
            //        Utilities.icerikDegistir(oynaticiPanel, oynaticiControl);                    
            //        break;
            //    case 1: //Şarkı çalıyorsa
            //        oynaticiControl.btnPlay.Image = Properties.Resources.play;
            //        ilkButton.Image = Properties.Resources.play;                    
            //        break;
            //    case 2: //Şarkı durmuşsa
            //        oynaticiControl.btnPlay.Image = Properties.Resources.pause;
            //        ilkButton.Image = Properties.Resources.pause;                    
            //        break;
            //}                        
        }

        private void oynaticiyiAktifEt(Sarki sarki, Button sarkiButonu)
        {            
            Oynatici.oynaticiBaslat(sarki);
            oynaticiyiGuncelle(sarkiButonu);            
            





            //string sarkiYolu = sarki.sarkiYolu + "\\" + sarki.sarkiAdi + ".mp3";

            //if (Oynatici.GetOynatici().URL != sarkiYolu)
            //{
            //    if(ilkButton != null)
            //        ilkButton.Image = Properties.Resources.play;
            //    Oynatici.GetOynatici().URL = sarkiYolu;
            //}                

            //switch (Oynatici.GetOynatici().playState)
            //{
            //    case WMPPlayState.wmppsTransitioning:
            //        Oynatici.sarkiOynat();
            //        sender.Image = Properties.Resources.pause;                    
            //        ilkButton = sender;
            //        oynaticiyiGuncelle(sarki,0);
            //        break;
            //    case WMPPlayState.wmppsPaused:
            //        Oynatici.sarkiOynat();
            //        sender.Image = Properties.Resources.pause;
            //        oynaticiyiGuncelle(sarki, 2);
            //        break;
            //    case WMPPlayState.wmppsPlaying:
            //        Oynatici.sarkiDuraklat();
            //        sender.Image = Properties.Resources.play;
            //        oynaticiyiGuncelle(sarki, 1);
            //        break;                               
            //}
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

        private void sarkilariGetir()
        {
            pnlSarkilar.Controls.Clear();
            List<Sarki> sarkilar = _sarkiService.TumSarkilariGetir();

            int sayac = 0;
            foreach (Sarki sarki in sarkilar)
            {
                _sarkiItem = new SarkiItem();
                _sarkiItem.Top = (sayac * 60);
                _sarkiItem.lblMuzikAdi.Text = Utilities.textSinirla(sarki.sarkiAdi, 15);
                _sarkiItem.lblSanatciAdi.Text = Utilities.textSinirla(_sanatciService.SanatciGetir(sarki.sanatciId).sanatciAdi, 15);
                _sarkiItem.lblTurAdi.Text = _turService.TurGetir(_albumDetayService.SarkiAlbumuGetir(sarki.sarkiId).turId).turAdi;
                _sarkiItem.lblIzlenmeSayisi.Text = sarki.sarkiIzlenme.ToString();
                _sarkiItem.btnOynat.Click += (s, e) => oynaticiyiAktifEt(sarki, s as Button);

                if (!calmaListesindeVarmi(sarki))
                    _sarkiItem.btnEkle.Click += (s, e) => calmaListesineEkle(sarki);
                else
                    _sarkiItem.btnEkle.Visible = false;

                pnlSarkilar.Controls.Add(_sarkiItem);
                sayac++;
            }
        }

        private void SarkilarControl_Load(object sender, EventArgs e)
        {
            Utilities.scroolbarEkle(pnlSarkilar);

            sarkilariGetir();
        }
    }
}
