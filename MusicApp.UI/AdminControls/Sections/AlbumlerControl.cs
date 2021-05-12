using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using MusicApp.UI.AdminControls.Sections.Edit_Controls;
using MusicApp.UI.AdminControls.Sections.List_Items;
using MusicApp.UI.Tools;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicApp.UI.AdminControls.Sections
{
    public partial class AlbumlerControl : UserControl
    {
        private IAlbumService _albumService;
        private IAlbumDetayService _albumDetayService;
        private ISanatciService _sanatciService;
        private ITurService _turService;
        private ISarkiService _sarkiService;

        private List<int> _albumSarkiIdleri;

        public AlbumlerControl()
        {
            InitializeComponent();
            _albumService = InstanceFactory.GetInstance<IAlbumService>();
            _albumDetayService = InstanceFactory.GetInstance<IAlbumDetayService>();
            _sanatciService = InstanceFactory.GetInstance<ISanatciService>();
            _turService = InstanceFactory.GetInstance<ITurService>();
            _sarkiService = InstanceFactory.GetInstance<ISarkiService>();
        }

        private void albumleriGetir()
        {
            pnlAlbumler.Controls.Clear();

            List<Album> albumler = _albumService.TumAlbumleriGetir();

            AlbumItem albumItem;
            int sayac = 0;
            foreach (Album album in albumler)
            {
                albumItem = new AlbumItem();
                albumItem.Top = sayac * 60;
                albumItem.lblAlbumId.Text = album.albumId.ToString();
                albumItem.lblAlbumAdi.Text = album.albumAdi;
                albumItem.lblSanatciAdi.Text = _sanatciService.SanatciGetir(_albumDetayService.AlbumDetayiGetir(album.albumId)[0].sanatciId).sanatciAdi;
                albumItem.lblAlbumTarih.Text = album.albumTarih.ToShortDateString();
                albumItem.lblAlbumTuru.Text = _turService.TurGetir(_albumDetayService.AlbumDetayiGetir(album.albumId)[0].turId).turAdi;
                albumItem.lblSarkiSayisi.Text = _albumDetayService.AlbumDetayiGetir(album.albumId).Count.ToString();
                albumItem.btnSil.Click += (s, e) => albumSil(album);
                pnlAlbumler.Controls.Add(albumItem);
                sayac++;
            }
        }

        private void albumDetayiSil(Album album)
        {
            List<AlbumDetay> albumDetaylari = _albumDetayService.AlbumDetayiGetir(album.albumId);
            _albumSarkiIdleri = new List<int>();
            if(albumDetaylari.Count > 0)
            {
                foreach (AlbumDetay albumDetay in albumDetaylari)
                {
                    _albumSarkiIdleri.Add(albumDetay.sarkiId);
                    _albumDetayService.AlbumDetaySil(albumDetay);
                }
            }
        }

        private void sarkilariSil()
        {
            if (_albumSarkiIdleri.Count > 0)
            {
                foreach (int sarkiId in _albumSarkiIdleri)
                {
                    _sarkiService.SarkiSil(_sarkiService.SarkiGetir(sarkiId));
                }
            }
        }

        private void albumSil(Album album)
        {
            DialogResult sonuc = MessageBox.Show("Şarkılarıyla birlikte albüm silinsin mi?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                albumDetayiSil(album);
                sarkilariSil();
                _albumService.AlbumSil(album);

                MessageBox.Show("Albüm silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Controls.Clear();
                Controls.Add(new AlbumlerControl());
            }
        }

        private void albumEkleEkraniGetir()
        {
            AlbumAdd albumAdd = new AlbumAdd();
            Utilities.icerikDegistir(Parent, albumAdd);
        }

        private void AlbumlerControl_Load(object sender, EventArgs e)
        {
            Utilities.scroolbarEkle(pnlAlbumler);

            albumleriGetir();
        }

        private void btnAlbumEkle_Click(object sender, EventArgs e)
        {
            albumEkleEkraniGetir();
        }
    }
}
