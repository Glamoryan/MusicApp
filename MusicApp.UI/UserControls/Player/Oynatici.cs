using MusicApp.Entities.Concrete;
using System.Windows.Forms;
using WMPLib;

namespace MusicApp.UI.UserControls.Player
{
    public static class Oynatici
    {
        public static bool caliyorMu { get; set; }
        public static Sarki suankiSarki { get; set; }

        private static WindowsMediaPlayer _mediaPlayer;
        public static Label sesLabel;        
        private static string _sarkiYolu;

        public static WindowsMediaPlayer GetOynatici()
        {
            return _mediaPlayer;
        }

        public static string GetSesDuzeyi()
        {
            return _mediaPlayer.settings.volume.ToString();
        }        

        public static void oynaticiBaslat(Sarki sarki)
        {
            suankiSarki = sarki;
            string yeniYol = sarki.sarkiYolu + "\\" + sarki.sarkiAdi + ".mp3";

            if (_mediaPlayer == null)
                _mediaPlayer = new WindowsMediaPlayer();            

            if (_sarkiYolu != yeniYol)
            {
                _sarkiYolu = sarki.sarkiYolu + "\\" + sarki.sarkiAdi + ".mp3";
                _mediaPlayer.URL = _sarkiYolu;
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

        public static void sesYukselt()
        {
            if (_mediaPlayer.settings.volume < 100)
                _mediaPlayer.settings.volume = (_mediaPlayer.settings.volume + 10);
            sesLabel.Text = _mediaPlayer.settings.volume.ToString();
        }

        public static void sesDusur()
        {
            if (_mediaPlayer.settings.volume > 0)
                _mediaPlayer.settings.volume = (_mediaPlayer.settings.volume - 10);
            sesLabel.Text = _mediaPlayer.settings.volume.ToString();
        }        
    }
}
