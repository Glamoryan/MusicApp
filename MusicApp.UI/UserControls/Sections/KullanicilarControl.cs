using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using MusicApp.UI.AuthControls;
using MusicApp.UI.UserControls.Sections.List_Items;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MusicApp.UI.UserControls.Sections
{
    public partial class KullanicilarControl : UserControl
    {
        private IKullaniciService _kullaniciService;
        private IAboneService _aboneService;
        private IAbonelikService _abonelikService;

        private KullaniciItem _kullaniciItem;

        public KullanicilarControl()
        {
            InitializeComponent();
            _kullaniciService = InstanceFactory.GetInstance<IKullaniciService>();
            _aboneService = InstanceFactory.GetInstance<IAboneService>();
            _abonelikService = InstanceFactory.GetInstance<IAbonelikService>();
        }       

        private void kullanicilariGetir()
        {
            List<Kullanici> kullanicilar = _kullaniciService.TumKullanicilariGetir();

            int sayac = 0;
            foreach (Kullanici kullanici in kullanicilar)
            {
                if (kullanici.rolId == 2)
                    continue;
                string abonelikAdi = _abonelikService.AbonelikGetir(_aboneService.AboneyiGetir(kullanici.kullaniciId).abonelikId).abonelikAdi;                

                _kullaniciItem = new KullaniciItem();
                _kullaniciItem.lblAbonelikAdi.ForeColor = abonelikAdi == "Premium" ? Color.Yellow : Color.White;
                _kullaniciItem.Top = (sayac * 60);
                _kullaniciItem.lblKullaniciAdi.Text = kullanici.kullaniciAdi;
                _kullaniciItem.lblRolAdi.Text = "Kullanıcı";
                _kullaniciItem.lblAbonelikAdi.Text = abonelikAdi;
                _kullaniciItem.lblUlkeAdi.Text = kullanici.ulkeAdi;

                if (abonelikAdi == "Normal" || LoginManager.etkinKullanici.kullaniciId == kullanici.kullaniciId)
                    _kullaniciItem.btnTakip.Visible = false;

                pnlKullanicilar.Controls.Add(_kullaniciItem);
                sayac++;
            }
        }

        private void KullanicilarControl_Load(object sender, EventArgs e)
        {
            pnlKullanicilar.AutoScroll = false;
            pnlKullanicilar.HorizontalScroll.Enabled = false;
            pnlKullanicilar.HorizontalScroll.Visible = false;
            pnlKullanicilar.HorizontalScroll.Maximum = 0;
            pnlKullanicilar.AutoScroll = true;

            kullanicilariGetir();
        }
    }
}
