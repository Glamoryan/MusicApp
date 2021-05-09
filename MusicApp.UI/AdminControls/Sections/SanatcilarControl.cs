using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
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

        public SanatcilarControl()
        {
            InitializeComponent();
            _sanatciService = InstanceFactory.GetInstance<ISanatciService>();
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
                pnlSanatcilar.Controls.Add(sanatciItem);
                sayac++;
            }
        }

        private void SanatcilarControl_Load(object sender, EventArgs e)
        {
            Utilities.scroolbarEkle(pnlSanatcilar);
            sanatcilariGetir();
        }
    }
}
