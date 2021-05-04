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
    public partial class AlbumlerControl : UserControl
    {
        private IAlbumService _albumService;
        private IAlbumDetayService _albumDetayService;
        private ISanatciService _sanatciService;
        private ITurService _turService;
        private ISarkiService _sarkiService;
        private ICalmaListesiService _calmaListesiService;

        private AlbumItem _albumItem;

        public AlbumlerControl()
        {
            InitializeComponent();
            _albumService = InstanceFactory.GetInstance<IAlbumService>();
            _albumDetayService = InstanceFactory.GetInstance<IAlbumDetayService>();
            _sanatciService = InstanceFactory.GetInstance<ISanatciService>();
            _turService = InstanceFactory.GetInstance<ITurService>();
            _sarkiService = InstanceFactory.GetInstance<ISarkiService>();
            _calmaListesiService = InstanceFactory.GetInstance<ICalmaListesiService>();
        }        

        private void albumSarkilariniGetir(Album album)
        {
            pnlSarkilar.Controls.Clear();
            List<AlbumDetay> albumDetaylari = _albumDetayService.AlbumDetayiGetir(album.albumId);
            SarkiItem sarkiItem;
            Sarki sarki;
            if(albumDetaylari.Count >= 1)
            {
                int sayac = 0;
                foreach (AlbumDetay albumDetay in albumDetaylari)
                {
                    sarkiItem = new SarkiItem();
                    sarki = _sarkiService.SarkiGetir(albumDetay.sarkiId);
                    sarkiItem.Top = (sayac * 60);
                    sarkiItem.lblMuzikAdi.Text = sarki.sarkiAdi;
                    sarkiItem.lblSanatciAdi.Text = _sanatciService.SanatciGetir(albumDetay.sanatciId).sanatciAdi;
                    sarkiItem.lblTurAdi.Text = _turService.TurGetir(albumDetay.turId).turAdi;
                    sarkiItem.lblIzlenmeSayisi.Text = sarki.sarkiIzlenme.ToString();
                    sarkiItem.btnEkle.Click += (s, e) => calmaListesineEkle(albumDetay.sarkiId);
                    pnlSarkilar.Controls.Add(sarkiItem);
                    sayac++;
                }
            }
        }

        private bool calmaListesindeVarmi(int sarkiId)
        {
            List<CalmaListesi> calmaListesi = _calmaListesiService.KullaniciCalmaListeleriniGetir(LoginManager.etkinKullanici.kullaniciId);
            if (calmaListesi.Count >= 1)
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

        private void calmaListesineEkle(int sarkiId)
        {
            if (!calmaListesindeVarmi(sarkiId))
            {
                CalmaListesi calmaListesi = new CalmaListesi
                {
                    kullaniciId = LoginManager.etkinKullanici.kullaniciId,
                    sarkiId = sarkiId,
                    turId = _albumDetayService.SarkiAlbumuGetir(sarkiId).turId
                };
                _calmaListesiService.CalmaListesiEkle(calmaListesi);
                MessageBox.Show("Şarkı çalma listesine eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Şarkı çalma listesinde zaten mevcut", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void albumleriGetir()
        {
            pnlAlbumler.Controls.Clear();
            List<Album> albumler = _albumService.TumAlbumleriGetir();
            List<AlbumDetay> albumDetay;
            int sayac = 0;
            foreach (Album album in albumler)
            {
                _albumItem = new AlbumItem();
                albumDetay = _albumDetayService.AlbumDetayiGetir(album.albumId);
                _albumItem.Top = (sayac * 60);
                _albumItem.lblAlbumAdi.Text = album.albumAdi;
                _albumItem.lblSanatciAdi.Text = _sanatciService.SanatciGetir(albumDetay[0].sanatciId).sanatciAdi;
                _albumItem.lblAlbumTarihi.Text = album.albumTarih.ToShortDateString();
                _albumItem.lblAlbumTuru.Text = _turService.TurGetir(albumDetay[0].turId).turAdi;
                _albumItem.btnSec.Click += (s, e) => albumSarkilariniGetir(album);
                pnlAlbumler.Controls.Add(_albumItem);
                sayac++;
            }
        }

        private void AlbumlerControl_Load(object sender, EventArgs e)
        {
            Utilities.scroolbarEkle(pnlAlbumler);
            Utilities.scroolbarEkle(pnlSarkilar);

            albumleriGetir();
        }
    }
}
