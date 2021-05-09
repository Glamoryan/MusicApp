using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using MusicApp.UI.AdminControls.Sections.List_Items;
using MusicApp.UI.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MusicApp.UI.AdminControls.Sections
{
    public partial class SarkilarControl : UserControl
    {
        private ISarkiService _sarkiService;
        private ISanatciService _sanatciService;

        public SarkilarControl()
        {
            InitializeComponent();
            _sarkiService = InstanceFactory.GetInstance<ISarkiService>();
            _sanatciService = InstanceFactory.GetInstance<ISanatciService>();
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
                pnlSarkilar.Controls.Add(sarkiItem);
                sayac++;
            }
        }

        private void SarkilarControl_Load(object sender, EventArgs e)
        {
            Utilities.scroolbarEkle(pnlSarkilar);
            sarkilariGetir();
        }
    }
}
