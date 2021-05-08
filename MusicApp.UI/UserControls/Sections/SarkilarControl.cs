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

        OynaticiControl oynaticiControl;
        Button ilkButton;

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
                _sarkiItem.lblIzlenmeSayisi.Text = sarki.sarkiDinlenmesi.ToString();
                _sarkiItem.lblSarkiTarih.Text = sarki.sarkiTarih.ToShortDateString();
                _sarkiItem.btnOynat.Click += (s, e) => oynaticiyiAktifEt(sarki, s as Button);
                _sarkiItem.btnEkle.Click += (s, e) => calmaListesineEkle(sarki);
                _sarkiItem.lblSayac.Text = (sayac + 1).ToString();

                if (calmaListesindeVarmi(sarki))
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
