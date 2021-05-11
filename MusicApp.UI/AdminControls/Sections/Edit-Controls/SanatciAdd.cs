using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using System;
using System.Windows.Forms;

namespace MusicApp.UI.AdminControls.Sections.Edit_Controls
{
    public partial class SanatciAdd : UserControl
    {
        private ISanatciService _sanatciService;        

        public SanatciAdd()
        {
            InitializeComponent();
            _sanatciService = InstanceFactory.GetInstance<ISanatciService>();           
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sanatciEkle();
        }

        private bool bosAlanVarmi()
        {
            if (string.IsNullOrEmpty(tbxSanatciAdi.Text) || string.IsNullOrEmpty(tbxUlkeAdi.Text))
                return true;
            else
                return false;
        }

        private bool sanatciVarmi(string sanatciAdi)
        {
            return _sanatciService.TumSanatcilariGetir().Find(x => x.sanatciAdi == sanatciAdi) != null ? true : false;
        }
            
        private void sanatciEkle()
        {
            if (!bosAlanVarmi())
            {
                if (!sanatciVarmi(tbxSanatciAdi.Text.Trim()))
                {
                    Sanatci sanatci = new Sanatci
                    {
                        sanatciAdi = tbxSanatciAdi.Text.Trim(),
                        ulkeAdi = tbxUlkeAdi.Text.Trim()
                    };
                    _sanatciService.SanatciEkle(sanatci);
                    MessageBox.Show("Sanatçı eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Controls.Clear();
                    Controls.Add(new SanatcilarControl());
                }
                else
                    MessageBox.Show("Böyle bir sanatçı zaten var!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Boş alan bırakılamaz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new SanatcilarControl());
        }              
    }
}
