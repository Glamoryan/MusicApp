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
    public partial class SarkilarControl : UserControl
    {
        private ISarkiService _sarkiService;
        private ISanatciService _sanatciService;
        private IAlbumDetayService _albumDetayService;
        private ICalmaListesiService _calmaListesiService;
        private IAlbumService _albumService;

        private int _albumId;

        public SarkilarControl()
        {
            InitializeComponent();
            _sarkiService = InstanceFactory.GetInstance<ISarkiService>();
            _sanatciService = InstanceFactory.GetInstance<ISanatciService>();
            _albumDetayService = InstanceFactory.GetInstance<IAlbumDetayService>();
            _calmaListesiService = InstanceFactory.GetInstance<ICalmaListesiService>();
            _albumService = InstanceFactory.GetInstance<IAlbumService>();
        }

        private bool albumSarkiSayisi1mi(Sarki sarki)
        {
            _albumId = _albumDetayService.TumAlbumDetaylariGetir().Find(x => x.sanatciId == sarki.sanatciId).albumId;
            List<AlbumDetay> albumListe = _albumDetayService.AlbumDetayiGetir(_albumId);
            if (albumListe.Count == 1)
                return true;
            else
                return false;
        }

        private void calmaListelerindenSil(Sarki sarki)
        {
            List<CalmaListesi> calmaListeleri = _calmaListesiService.SarkiCalmaListeleriGetir(sarki.sarkiId);     
            if (calmaListeleri.Count > 0)
            {
                foreach (CalmaListesi liste in calmaListeleri)
                {
                    _calmaListesiService.CalmaListesiSil(liste);
                }
            }            
        }

        private void sarkiSil(Sarki sarki)
        {
            DialogResult sonuc = MessageBox.Show("Şarkı silinsin mi?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                if (albumSarkiSayisi1mi(sarki))
                {
                    sonuc = MessageBox.Show("Bu şarkı albümdeki son şarkı olduğu için albümde silinecektir! ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(sonuc == DialogResult.Yes)
                    {
                        _albumDetayService.AlbumDetaySil(_albumDetayService.SarkiAlbumuGetir(sarki.sarkiId));
                        _albumService.AlbumSil(_albumService.AlbumGetir(_albumId));
                        calmaListelerindenSil(sarki);
                        _sarkiService.SarkiSil(sarki);

                        MessageBox.Show("Şarkı ve Albüm silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    }                    
                }
                else
                {
                    _albumDetayService.AlbumDetaySil(_albumDetayService.SarkiAlbumuGetir(sarki.sarkiId));
                    _sarkiService.SarkiSil(sarki);
                    calmaListelerindenSil(sarki);
                    MessageBox.Show("Şarkı silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Controls.Clear();
                Controls.Add(new SarkilarControl());
            }

        }

        private void sarkiDuzenleEkraniGetir(Sarki sarki)
        {
            SarkiEdit sarkiEdit = new SarkiEdit(sarki);
            Utilities.icerikDegistir(Parent, sarkiEdit);
        }

        private void sarkilariGetir()
        {
            pnlSarkilar.Controls.Clear();

            List<Sarki> sarkilar = _sarkiService.TumSarkilariGetir();

            SarkiItem sarkiItem;
            int sayac = 0;
            foreach (Sarki sarki in sarkilar)
            {
                sarkiItem = new SarkiItem();
                sarkiItem.Top = sayac * 60;
                sarkiItem.lblSarkiId.Text = sarki.sarkiId.ToString();
                sarkiItem.lblSanatciAdi.Text = Utilities.textSinirla(_sanatciService.SanatciGetir(sarki.sanatciId).sanatciAdi,14);
                sarkiItem.lblSarkiAdi.Text = Utilities.textSinirla(sarki.sarkiAdi,18);
                sarkiItem.lblDinlenme.Text = sarki.sarkiDinlenmesi.ToString();
                sarkiItem.lblUlkeAdi.Text = sarki.sarkiUlke;
                sarkiItem.lblTarih.Text = sarki.sarkiTarih.ToShortDateString();
                sarkiItem.btnSarkiSil.Click += (s, e) => sarkiSil(sarki);
                sarkiItem.btnDuzenle.Click += (s, e) => sarkiDuzenleEkraniGetir(sarki);
                pnlSarkilar.Controls.Add(sarkiItem);
                sayac++;
            }
        }

        private void sarkiEkleEkraniGetir()
        {
            SarkiAdd sarkiAdd = new SarkiAdd();
            Utilities.icerikDegistir(Parent, sarkiAdd);
        }

        private void SarkilarControl_Load(object sender, EventArgs e)
        {
            Utilities.scroolbarEkle(pnlSarkilar);
            sarkilariGetir();
        }

        private void btnSarkiEkle_Click(object sender, EventArgs e)
        {
            sarkiEkleEkraniGetir();
        }
    }
}
