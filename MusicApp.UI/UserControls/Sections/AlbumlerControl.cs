using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
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

        private AlbumItem _albumItem;

        public AlbumlerControl()
        {
            InitializeComponent();
            _albumService = InstanceFactory.GetInstance<IAlbumService>();
            _albumDetayService = InstanceFactory.GetInstance<IAlbumDetayService>();
            _sanatciService = InstanceFactory.GetInstance<ISanatciService>();
            _turService = InstanceFactory.GetInstance<ITurService>();
            _sarkiService = InstanceFactory.GetInstance<ISarkiService>();
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
                    pnlSarkilar.Controls.Add(sarkiItem);
                    sayac++;
                }
            }
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
