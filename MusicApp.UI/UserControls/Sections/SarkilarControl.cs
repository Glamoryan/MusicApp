﻿using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using MusicApp.UI.AuthControls;
using MusicApp.UI.Tools;
using MusicApp.UI.UserControls.Sections.List_Items;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WMPLib;

namespace MusicApp.UI.UserControls.Sections
{
    public partial class SarkilarControl : UserControl
    {
        private WindowsMediaPlayer oynatici;

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
        
        private void sesYukselt(WindowsMediaPlayer aktifOynatici)
        {
            if (aktifOynatici.settings.volume < 100)
                aktifOynatici.settings.volume = (aktifOynatici.settings.volume + 10);
            oynaticiControl.lblSesDuzey.Text = oynatici.settings.volume.ToString();
        }

        private void sesDusur(WindowsMediaPlayer aktifOynatici)
        {
            if (aktifOynatici.settings.volume > 0)
                aktifOynatici.settings.volume = (aktifOynatici.settings.volume - 10);
            oynaticiControl.lblSesDuzey.Text = oynatici.settings.volume.ToString();
        }

        private void oynaticiyiGuncelle(Sarki calanSarki,byte durum)
        {
            switch (durum)
            {
                case 0: //ilk şarkı başladığında (transitioning)
                    oynaticiControl = new OynaticiControl();
                    oynaticiControl.lblMuzikAdi.Text = calanSarki.sarkiAdi;
                    oynaticiControl.lblSanatciAdi.Text = _sanatciService.SanatciGetir(calanSarki.sanatciId).sanatciAdi;
                    oynaticiControl.btnPlay.Enabled = true;
                    oynaticiControl.btnSesYukselt.Enabled = true;
                    oynaticiControl.btnSesDusur.Enabled = true;                    
                    oynaticiControl.btnSesYukselt.Click += (s, e) => sesYukselt(oynatici);
                    oynaticiControl.btnSesDusur.Click += (s, e) => sesDusur(oynatici);
                    oynaticiControl.btnPlay.Image = Properties.Resources.pause;                    
                    ilkButton.Image = Properties.Resources.pause;
                    oynaticiControl.btnPlay.Click += (s, e) => oynaticiyiAktifEt(calanSarki,s as Button);
                    oynaticiPanel = Parent.Parent.Controls.Find("pnlPlayer", true)[0] as Panel;
                    oynaticiControl.lblSesDuzey.Text = oynatici.settings.volume.ToString();
                    Utilities.icerikDegistir(oynaticiPanel, oynaticiControl);                    
                    break;
                case 1: //Şarkı çalıyorsa
                    oynaticiControl.btnPlay.Image = Properties.Resources.play;
                    ilkButton.Image = Properties.Resources.play;                    
                    break;
                case 2: //Şarkı durmuşsa
                    oynaticiControl.btnPlay.Image = Properties.Resources.pause;
                    ilkButton.Image = Properties.Resources.pause;                    
                    break;
            }                        
        }

        private void oynaticiyiAktifEt(Sarki sarki, Button sender)
        {            
            string sarkiUrl = sarki.sarkiYolu + "\\" + sarki.sarkiAdi + ".mp3";            
            if (oynatici == null)
                oynatici = new WindowsMediaPlayer();            

            if (oynatici.URL != sarkiUrl)
            {
                if(ilkButton != null)
                    ilkButton.Image = Properties.Resources.play;
                oynatici.URL = sarkiUrl;
            }                

            switch (oynatici.playState)
            {
                case WMPPlayState.wmppsTransitioning:
                    oynatici.controls.play();
                    sender.Image = Properties.Resources.pause;                    
                    ilkButton = sender;
                    oynaticiyiGuncelle(sarki,0);
                    break;
                case WMPPlayState.wmppsPaused:
                    oynatici.controls.play();
                    sender.Image = Properties.Resources.pause;
                    oynaticiyiGuncelle(sarki, 2);
                    break;
                case WMPPlayState.wmppsPlaying:
                    oynatici.controls.pause();
                    sender.Image = Properties.Resources.play;
                    oynaticiyiGuncelle(sarki, 1);
                    break;                               
            }
        }

        private bool calmaListesindeVarmi(Sarki sarki)
        {
            List<CalmaListesi> calmaListesi = _calmaListesiService.KullaniciCalmaListeleriniGetir(LoginManager.etkinKullanici.kullaniciId);
            if(calmaListesi.Count > 0)
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
                _sarkiItem.lblMuzikAdi.Text = Utilities.textSinirla(sarki.sarkiAdi,15);
                _sarkiItem.lblSanatciAdi.Text = Utilities.textSinirla(_sanatciService.SanatciGetir(sarki.sanatciId).sanatciAdi,15);
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
