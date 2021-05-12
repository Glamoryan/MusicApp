using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MusicApp.UI.AdminControls.Sections.Edit_Controls
{
    public partial class AlbumAdd : UserControl
    {
        private ISanatciService _sanatciService;
        private ITurService _turService;
        private IAlbumService _albumService;
        private ISarkiService _sarkiService;
        private IAlbumDetayService _albumDetayService;

        private string _sarkiYolu;

        public AlbumAdd()
        {
            InitializeComponent();
            _sanatciService = InstanceFactory.GetInstance<ISanatciService>();
            _turService = InstanceFactory.GetInstance<ITurService>();
            _albumService = InstanceFactory.GetInstance<IAlbumService>();
            _sarkiService = InstanceFactory.GetInstance<ISarkiService>();
            _albumDetayService = InstanceFactory.GetInstance<IAlbumDetayService>();
        }

        private void sanatcilariGetir()
        {
            var sanatcilar = new BindingSource();
            sanatcilar.DataSource = _sanatciService.TumSanatcilariGetir();

            cbxSanatcilar.DataSource = sanatcilar.DataSource;
            cbxSanatcilar.DisplayMember = "sanatciAdi";
            cbxSanatcilar.ValueMember = "sanatciId";
            cbxSanatcilar.SelectedIndex = 0;
        }

        private void turleriGetir()
        {
            var turler = new BindingSource();
            turler.DataSource = _turService.TumTurleriGetir();

            cbxTurler.DataSource = turler.DataSource;
            cbxTurler.DisplayMember = "turAdi";
            cbxTurler.ValueMember = "turId";
            cbxTurler.SelectedIndex = 0;
        }

        private bool bosAlanVarmi()
        {
            if (string.IsNullOrEmpty(tbxAlbumAdi.Text) || string.IsNullOrEmpty(tbxSarkiAdi.Text) || string.IsNullOrEmpty(sarkiSecici.FileName))
                return true;
            else
                return false;
        }

        private bool albumAdiAlinmisMi()
        {
            List<Album> albumler = _albumService.TumAlbumleriGetir();
            if (albumler.Count > 0)
            {
                foreach (Album album in albumler)
                {
                    if (album.albumAdi.Trim().ToLower() == tbxAlbumAdi.Text.Trim().ToLower())
                        return true;
                }
            }
            return false;
        }

        private void dosyaSec()
        {
            sarkiSecici.Filter = "Desteklenen türler | *.mp3";
            DialogResult sonuc = sarkiSecici.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                _sarkiYolu = Path.GetDirectoryName(sarkiSecici.FileName);
                lblYol.Text = sarkiSecici.FileName;
            }
        }
        private bool sarkiVarmi()
        {
            List<Sarki> sarkilar = _sarkiService.TumSarkilariGetir();

            foreach (Sarki sarki in sarkilar)
            {
                if ((sarki.sarkiAdi.ToLower().Trim() == tbxSarkiAdi.Text.ToLower().Trim()) && (sarki.sanatciId == Convert.ToInt32(cbxSanatcilar.SelectedValue)))
                    return true;
            }
            return false;
        }

        private void ilkSarkisiniEkle(int albumId)
        {
            Sarki sarki = new Sarki
            {
                sanatciId = Convert.ToInt32(cbxSanatcilar.SelectedValue),
                sarkiAdi = tbxSarkiAdi.Text.Trim(),
                sarkiDinlenmesi = 0,
                sarkiTarih = DateTime.Now,
                sarkiUlke = _sanatciService.SanatciGetir(Convert.ToInt32(cbxSanatcilar.SelectedValue)).ulkeAdi,
                sarkiYolu = _sarkiYolu
            };

            AlbumDetay albumDetay = new AlbumDetay
            {
                albumId = albumId,
                sanatciId = Convert.ToInt32(cbxSanatcilar.SelectedValue),
                sarkiId = _sarkiService.SarkiEkle(sarki).sarkiId,
                turId = Convert.ToInt32(cbxTurler.SelectedValue)
            };

            _albumDetayService.AlbumDetayEkle(albumDetay);
        }

        private void albumEkle()
        {
            if (!bosAlanVarmi())
            {
                if (!albumAdiAlinmisMi() && !sarkiVarmi())
                {
                    Album album = new Album
                    {
                        albumAdi = tbxAlbumAdi.Text.Trim(),
                        albumTarih = DateTime.Now
                    };
                    ilkSarkisiniEkle(_albumService.AlbumEkle(album).albumId);

                    MessageBox.Show("Albüm eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Controls.Clear();
                    Controls.Add(new AlbumlerControl());
                }
                else
                    MessageBox.Show("Bu albüm adı zaten mevcut", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Boş alan bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            albumEkle();
        }

        private void AlbumAdd_Load(object sender, EventArgs e)
        {           
            sanatcilariGetir();
            turleriGetir();
        }

        private void btnSarkiSec_Click(object sender, EventArgs e)
        {
            dosyaSec();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new AlbumlerControl());
        }
    }
}
