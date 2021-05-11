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
    public partial class SanatcilarControl : UserControl
    {
        private ISanatciService _sanatciService;
        private ISarkiService _sarkiService;
        private IAlbumDetayService _albumDetayService;
        private IAlbumService _albumService;
        private ICalmaListesiService _calmaListesiService;

        public SanatcilarControl()
        {
            InitializeComponent();
            _sanatciService = InstanceFactory.GetInstance<ISanatciService>();
            _sarkiService = InstanceFactory.GetInstance<ISarkiService>();
            _albumDetayService = InstanceFactory.GetInstance<IAlbumDetayService>();
            _albumService = InstanceFactory.GetInstance<IAlbumService>();
            _calmaListesiService = InstanceFactory.GetInstance<ICalmaListesiService>();
        }

        private void sarkilariniSil(Sanatci sanatci)
        {
            List<Sarki> sarkilari = _sarkiService.SanatciSarkilariniGetir(sanatci.sanatciId);
            List<AlbumDetay> albumDetaylari = _albumDetayService.SanatciAlbumuGetir(sanatci.sanatciId);
            Album sanatciAlbumu = _albumService.AlbumGetir(albumDetaylari[0].albumId);
            List<CalmaListesi> calmaListeleri;

            if (albumDetaylari.Count > 0)
            {
                foreach (AlbumDetay albumDetay in albumDetaylari)
                {
                    _albumDetayService.AlbumDetaySil(albumDetay);
                }
                _albumService.AlbumSil(sanatciAlbumu);
            }            
            if(sarkilari.Count > 0)
            {
                foreach (Sarki sarki in sarkilari)
                {
                    calmaListeleri = _calmaListesiService.SarkiCalmaListeleriGetir(sarki.sanatciId);
                    if (calmaListeleri.Count > 0)
                    {
                        foreach (CalmaListesi liste in calmaListeleri)
                        {
                            _calmaListesiService.CalmaListesiSil(liste);
                        }
                    }
                    _sarkiService.SarkiSil(sarki);
                }
            }            
        }

        private void sanatciSil(Sanatci sanatci)
        {
            DialogResult sonuc = MessageBox.Show("Sanatçı silinsin mi?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                sarkilariniSil(sanatci);
                _sanatciService.SanatciSil(sanatci);
                MessageBox.Show("Sanatçı, albümleri ve şarkıları silindi?", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Controls.Clear();
                Controls.Add(new SanatcilarControl());
            }
        }

        private void sanatcilariGetir()
        {
            pnlSanatcilar.Controls.Clear();

            List<Sanatci> sanatcilar = _sanatciService.TumSanatcilariGetir();

            SanatciItem sanatciItem;
            int sayac = 0;
            foreach (Sanatci sanatci in sanatcilar)
            {
                sanatciItem = new SanatciItem();
                sanatciItem.Top = sayac * 60;
                sanatciItem.lblSanatciId.Text = sanatci.sanatciId.ToString();
                sanatciItem.lblSanatciAdi.Text = sanatci.sanatciAdi;
                sanatciItem.lblUlkeAdi.Text = sanatci.ulkeAdi;
                sanatciItem.btnSil.Click += (s, e) => sanatciSil(sanatci);
                pnlSanatcilar.Controls.Add(sanatciItem);
                sayac++;
            }
        }

        private void sanatciEkleEkraniGetir()
        {
            SanatciAdd sanatciAdd = new SanatciAdd();
            Utilities.icerikDegistir(Parent, sanatciAdd);
        }

        private void SanatcilarControl_Load(object sender, EventArgs e)
        {
            Utilities.scroolbarEkle(pnlSanatcilar);
            sanatcilariGetir();
        }

        private void btnSanatciEkle_Click(object sender, EventArgs e)
        {
            sanatciEkleEkraniGetir();
        }
    }
}
