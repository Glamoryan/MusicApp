﻿using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
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

        private SarkiItem _sarkiItem;        

        private Button ilkButton;      

        public SarkilarControl()
        {
            InitializeComponent();
            _sarkiService = InstanceFactory.GetInstance<ISarkiService>();
            _sanatciService = InstanceFactory.GetInstance<ISanatciService>();
            _albumDetayService = InstanceFactory.GetInstance<IAlbumDetayService>();
            _turService = InstanceFactory.GetInstance<ITurService>();
        }         

        private void sarkiyiBaslat(string sarkiYolu, string sarkiAdi, Button sender)
        {            
            string sarkiUrl = sarkiYolu + "\\" + sarkiAdi + ".mp3";
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
                    break;
                case WMPPlayState.wmppsPaused:
                    oynatici.controls.play();
                    sender.Image = Properties.Resources.pause;
                    break;
                case WMPPlayState.wmppsPlaying:
                    oynatici.controls.pause();
                    sender.Image = Properties.Resources.play;
                    break;                               
            }

        }

        private void sarkilariGetir()
        {
            List<Sarki> sarkilar = _sarkiService.TumSarkilariGetir();
            
            int sayac = 0;
            foreach (Sarki sarki in sarkilar)
            {                
                _sarkiItem = new SarkiItem();
                _sarkiItem.Top = (sayac * 60);
                _sarkiItem.lblMuzikAdi.Text = sarki.sarkiAdi;
                _sarkiItem.lblSanatciAdi.Text = _sanatciService.SanatciGetir(sarki.sanatciId).sanatciAdi;
                _sarkiItem.lblTurAdi.Text = _turService.TurGetir(_albumDetayService.SarkiAlbumuGetir(sarki.sarkiId).turId).turAdi;
                _sarkiItem.lblIzlenmeSayisi.Text = sarki.sarkiIzlenme.ToString();
                _sarkiItem.btnOynat.Click += (s, e) => sarkiyiBaslat(sarki.sarkiYolu, sarki.sarkiAdi, s as Button);
                pnlSarkilar.Controls.Add(_sarkiItem);
                sayac++;
            }
        }

        private void SarkilarControl_Load(object sender, EventArgs e)
        {
            sarkilariGetir();
        }
    }
}
