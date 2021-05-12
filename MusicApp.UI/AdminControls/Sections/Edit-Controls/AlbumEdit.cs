using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicApp.UI.AdminControls.Sections.Edit_Controls
{
    public partial class AlbumEdit : UserControl
    {
        private IAlbumDetayService _albumDetayService;
        private ISanatciService _sanatciService;
        private IAlbumService _albumService;

        private Album _album;

        public AlbumEdit(Album album)
        {
            InitializeComponent();
            _albumDetayService = InstanceFactory.GetInstance<IAlbumDetayService>();
            _sanatciService = InstanceFactory.GetInstance<ISanatciService>();
            _albumService = InstanceFactory.GetInstance<IAlbumService>();

            _album = album;
        }

        private bool bosAlanVarmi()
        {
            if (string.IsNullOrEmpty(tbxAlbumAdi.Text))
                return true;
            else
                return false;
        }

        private void bilgileriYazdir()
        {
            AlbumDetay albumDetay = _albumDetayService.AlbumDetayiGetir(_album.albumId)[0];            
            tbxAlbumAdi.Text = _album.albumAdi;
            lblSanatciAdi.Text = _sanatciService.SanatciGetir(albumDetay.sanatciId).sanatciAdi;
        }

        private bool albumAdiAlinmiMi()
        {
            List<Album> albumler = _albumService.TumAlbumleriGetir();
            if(albumler.Count > 0)
            {
                foreach (Album album in albumler)
                {
                    if (album.albumAdi.ToLower().Trim() == tbxAlbumAdi.Text.ToLower().Trim())
                        return true;
                }
            }
            return false;
        }

        private void albumGuncelle()
        {
            if (!bosAlanVarmi())
            {
                if (!albumAdiAlinmiMi())
                {
                    _album.albumAdi = tbxAlbumAdi.Text.Trim();
                    _albumService.AlbumGuncelle(_album);

                    MessageBox.Show("Album guncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Controls.Clear();
                    Controls.Add(new AlbumlerControl());
                }
                else
                    MessageBox.Show("Bu albüm adı zaten mevcut", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Boş alan bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AlbumEdit_Load(object sender, EventArgs e)
        {
            bilgileriYazdir();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            albumGuncelle();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new AlbumlerControl());
        }
    }
}
