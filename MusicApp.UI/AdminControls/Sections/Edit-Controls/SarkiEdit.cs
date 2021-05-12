using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicApp.UI.AdminControls.Sections.Edit_Controls
{
    public partial class SarkiEdit : UserControl
    {
        private ISanatciService _sanatciService;
        private ISarkiService _sarkiService;        

        private Sarki _sarki;

        public SarkiEdit(Sarki sarki)
        {
            InitializeComponent();

            _sanatciService = InstanceFactory.GetInstance<ISanatciService>();
            _sarkiService = InstanceFactory.GetInstance<ISarkiService>();            

            _sarki = sarki;
        }

        private void bilgileriYazdir()
        {
            var sanatcilar = new BindingSource();
            sanatcilar.DataSource = _sanatciService.TumSanatcilariGetir();

            tbxSarkiAdi.Text = _sarki.sarkiAdi;
            sarkiSecici.FileName = _sarki.sarkiYolu;
            lblYol.Text = sarkiSecici.FileName;            
        }

        private bool sarkiVarmi()
        {
            List<Sarki> sarkilar = _sarkiService.TumSarkilariGetir();

            foreach (Sarki sarki in sarkilar)
            {
                if (sarki.sarkiAdi.ToLower().Trim() == tbxSarkiAdi.Text.ToLower().Trim())
                    return true;
            }
            return false;
        }

        private bool bosAlanVarmi()
        {
            if (string.IsNullOrEmpty(tbxSarkiAdi.Text) || string.IsNullOrEmpty(sarkiSecici.FileName))
                return true;
            else
                return false;
        }

        private void sarkiGuncelle()
        {
            if (!bosAlanVarmi())
            {
                _sarki.sarkiAdi = tbxSarkiAdi.Text.Trim();
                _sarki.sarkiYolu = sarkiSecici.FileName;
                if (!sarkiVarmi())
                {                    
                    _sarkiService.SarkiGuncelle(_sarki);
                    MessageBox.Show("Şarkı güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SarkilarControl sarkilarControl = new SarkilarControl();
                    Controls.Clear();
                    Controls.Add(sarkilarControl);
                }      
                else
                    MessageBox.Show("Şarkı adı bu sanatçıda zaten mevcut!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Boş alan bırakılamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SarkiEdit_Load(object sender, EventArgs e)
        {
            bilgileriYazdir();
        }        

        private void btnIptal_Click(object sender, EventArgs e)
        {
            SarkilarControl sarkilarControl = new SarkilarControl();
            Controls.Clear();
            Controls.Add(sarkilarControl);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            sarkiGuncelle();
        }
    }
}
