using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
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
                    oynaticiControl.btnPlay.Image = Properties.Resources.pause;                   
                    ilkButton.Image = Properties.Resources.pause;
                    oynaticiControl.btnPlay.Click += (s, e) => oynaticiyiAktifEt(calanSarki,s as Button);
                    oynaticiPanel = Parent.Parent.Controls.Find("pnlPlayer", true)[0] as Panel;
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
                _sarkiItem.btnOynat.Click += (s, e) => oynaticiyiAktifEt(sarki, s as Button);
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
