using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MusicApp.UI.AdminControls.Sections.Edit_Controls
{
    public partial class SarkiAdd : UserControl
    {
        private ISarkiService _sarkiService;
        private ISanatciService _sanatciService;
        private IAlbumService _albumService;
        private IAlbumDetayService _albumDetayService;

        private string _sarkiYolu;        

        public SarkiAdd()
        {
            InitializeComponent();
            _sarkiService = InstanceFactory.GetInstance<ISarkiService>();
            _sanatciService = InstanceFactory.GetInstance<ISanatciService>();
            _albumDetayService = InstanceFactory.GetInstance<IAlbumDetayService>();
            _albumService = InstanceFactory.GetInstance<IAlbumService>();
        }

        private bool bosAlanVarmi()
        {
            if (string.IsNullOrEmpty(tbxSarkiAdi.Text) || string.IsNullOrEmpty(dosyaSecici.FileName))
                return true;
            else
                return false;
        }

        private void sanatcilariGetir()
        {
            var sanatcilar = new BindingSource();
            sanatcilar.DataSource = _sanatciService.TumSanatcilariGetir();

            cbxSanatci.DataSource = sanatcilar.DataSource;
            cbxSanatci.ValueMember = "sanatciId";
            cbxSanatci.DisplayMember = "sanatciAdi";
            cbxSanatci.SelectedIndex = 0;
        }

        private bool sarkiVarmi()
        {
            List<Sarki> sarkilar = _sarkiService.TumSarkilariGetir();    

            foreach (Sarki sarki in sarkilar)
            {
                if ((sarki.sarkiAdi.ToLower().Trim() == tbxSarkiAdi.Text.ToLower().Trim()) && (sarki.sanatciId == Convert.ToInt32(cbxSanatci.SelectedValue)))
                    return true;
            }
            return false;
        }

        private void dosyaSec()
        {
            dosyaSecici.Filter = "Desteklenen türler | *.mp3";
            DialogResult sonuc = dosyaSecici.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                _sarkiYolu = Path.GetDirectoryName(dosyaSecici.FileName);
                lblYol.Text = dosyaSecici.FileName;                
            }                       
        }        

        private void sarkiEkle()
        {
            if (!bosAlanVarmi())
            {
                if (!sarkiVarmi())
                {
                    Sarki sarki = new Sarki
                    {
                        sanatciId = Convert.ToInt32(cbxSanatci.SelectedValue),
                        sarkiAdi = tbxSarkiAdi.Text,
                        sarkiDinlenmesi = 0,
                        sarkiTarih = DateTime.Now,
                        sarkiUlke = _sanatciService.SanatciGetir(Convert.ToInt32(cbxSanatci.SelectedValue)).ulkeAdi,
                        sarkiYolu = _sarkiYolu
                    };

                    AlbumDetay sanatcininAlbumu = _albumDetayService.SanatciAlbumuGetir(Convert.ToInt32(cbxSanatci.SelectedValue));
                    AlbumDetay albumDetay = new AlbumDetay
                    {
                        albumId = sanatcininAlbumu.albumId,
                        sanatciId = Convert.ToInt32(cbxSanatci.SelectedValue),
                        sarkiId = _sarkiService.SarkiEkle(sarki).sarkiId,
                        turId = sanatcininAlbumu.turId
                    };

                    _albumDetayService.AlbumDetayEkle(albumDetay);
                    
                    MessageBox.Show("Şarkı eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Controls.Clear();
                    Controls.Add(new SarkilarControl());
                }
                else
                    MessageBox.Show("Bu şarkı adında bir şarkı zaten mevcut", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Boş alan bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sarkiEkle();
        }

        private void btnSarkiSec_Click(object sender, EventArgs e)
        {
            dosyaSec();
        }

        private void SarkiAdd_Load(object sender, EventArgs e)
        {
            sanatcilariGetir();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new SarkilarControl());
        }
    }
}
