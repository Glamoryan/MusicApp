using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicApp.UI.AdminControls.Sections.Edit_Controls
{
    public partial class SanatciEdit : UserControl
    {
        private ISanatciService _sanatciService;
        private ISarkiService _sarkiService;

        private Sanatci _sanatci;

        public SanatciEdit(Sanatci sanatci)
        {
            InitializeComponent();
            _sanatciService = InstanceFactory.GetInstance<ISanatciService>();
            _sarkiService = InstanceFactory.GetInstance<ISarkiService>();

            _sanatci = sanatci;
        }

        private void sarkiUlkesiniGuncelle(int sanatciId)
        {
            List<Sarki> sanatciSarkilari = _sarkiService.SanatciSarkilariniGetir(sanatciId);
            if(sanatciSarkilari.Count > 0)
            {
                foreach (Sarki sarki in sanatciSarkilari)
                {
                    sarki.sarkiUlke = tbxSanatciUlke.Text.Trim();
                    _sarkiService.SarkiGuncelle(sarki);
                }
            }
        }       

        private bool bosAlanVarmi()
        {
            if (string.IsNullOrEmpty(tbxSanatciAdi.Text) || string.IsNullOrEmpty(tbxSanatciUlke.Text))
                return true;
            else
                return false;
        }

        private void bilgileriYazdir()
        {
            tbxSanatciAdi.Text = _sanatci.sanatciAdi;
            tbxSanatciUlke.Text = _sanatci.ulkeAdi;
        }

        private void sanatciGuncelle()
        {
            if (!bosAlanVarmi())
            {
                _sanatci.sanatciAdi = tbxSanatciAdi.Text.Trim();
                _sanatci.ulkeAdi = tbxSanatciUlke.Text.Trim();

                sarkiUlkesiniGuncelle(_sanatci.sanatciId);
                _sanatciService.SanatciGuncelle(_sanatci);

                MessageBox.Show("Sanatçı güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Controls.Clear();
                Controls.Add(new SanatcilarControl());
            }
            else
                MessageBox.Show("Boş alan bırakılamaz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SanatciEdit_Load(object sender, EventArgs e)
        {
            bilgileriYazdir();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new SanatcilarControl());
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            sanatciGuncelle();
        }
    }
}
