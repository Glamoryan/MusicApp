using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using System.Windows.Forms;
using WMPLib;

namespace MusicApp.UI.UserControls.Player
{
    public static class Oynatici
    {
        private static ISarkiService _sarkiService;

        public static bool caliyorMu { get; set; }
        public static Sarki suankiSarki { get; set; }

        private static WindowsMediaPlayer _mediaPlayer;          
        private static string _sarkiYolu;

        public static WindowsMediaPlayer GetOynatici()
        {
            return _mediaPlayer;
        }

        public static string GetSesDuzeyi()
        {
            return _mediaPlayer.settings.volume.ToString();
        }    
        
        private static void sarkiIzlenmesiGuncelle(Sarki sarki)
        {
            sarki.sarkiIzlenme++;
            _sarkiService.SarkiGuncelle(sarki);
        }

        public static void oynaticiBaslat(Sarki sarki)
        {
            suankiSarki = sarki;
            string yeniYol = sarki.sarkiYolu + "\\" + sarki.sarkiAdi + ".mp3";

            if (_mediaPlayer == null)
            {
                _mediaPlayer = new WindowsMediaPlayer();
                _sarkiService = InstanceFactory.GetInstance<ISarkiService>();
            }
                

            if (_sarkiYolu != yeniYol)
            {
                _sarkiYolu = sarki.sarkiYolu + "\\" + sarki.sarkiAdi + ".mp3";
                _mediaPlayer.URL = _sarkiYolu;
                sarkiIzlenmesiGuncelle(sarki);
                sarkiOynat();
            }
            else
            {
                if (caliyorMu)
                    sarkiDuraklat();
                else
                    sarkiOynat();                
            }                
        }

        public static void sarkiOynat()
        {            
            _mediaPlayer.controls.play();            
            caliyorMu = true;
        }

        public static void sarkiDuraklat()
        {
            _mediaPlayer.controls.pause();
            caliyorMu = false;
        }

        public static void sarkiDurdur()
        {
            _mediaPlayer.controls.stop();
            caliyorMu = false;
        }

        public static void sesYukselt(Label sesLabel)
        {
            if (_mediaPlayer.settings.volume < 100)
                _mediaPlayer.settings.volume = (_mediaPlayer.settings.volume + 10);
            sesLabel.Text = GetSesDuzeyi();
        }

        public static void sesDusur(Label sesLabel)
        {
            if (_mediaPlayer.settings.volume > 0)
                _mediaPlayer.settings.volume = (_mediaPlayer.settings.volume - 10);
            sesLabel.Text = GetSesDuzeyi();
        }        
    }
}
