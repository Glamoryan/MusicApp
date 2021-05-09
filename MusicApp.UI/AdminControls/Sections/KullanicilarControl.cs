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
    public partial class KullanicilarControl : UserControl
    {
        private IKullaniciService _kullaniciService;
        private IRolService _rolService;

        public KullanicilarControl()
        {
            InitializeComponent();
            _kullaniciService = InstanceFactory.GetInstance<IKullaniciService>();
            _rolService = InstanceFactory.GetInstance<IRolService>();
        }

        private void kullanicilariGetir()
        {
            pnlKullanici.Controls.Clear();

            List<Kullanici> kullanicilar = _kullaniciService.TumKullanicilariGetir();

            int sayac = 0;
            KullaniciItem kullaniciItem;
            foreach (Kullanici kullanici in kullanicilar)
            {
                kullaniciItem = new KullaniciItem();
                kullaniciItem.Top = sayac * 60;
                kullaniciItem.lblKullaniciId.Text = kullanici.kullaniciId.ToString();
                kullaniciItem.lblKullaniciAdi.Text = kullanici.kullaniciAdi;
                kullaniciItem.lblKullaniciRol.Text = _rolService.RolGetir(kullanici.rolId).rolAdi;
                kullaniciItem.lblKullaniciMail.Text = kullanici.kullaniciMail;
                kullaniciItem.lblKullaniciUlke.Text = kullanici.ulkeAdi;
                pnlKullanici.Controls.Add(kullaniciItem);
                sayac++;
            }
        }

        private void KullanicilarControl_Load(object sender, EventArgs e)
        {
            Utilities.scroolbarEkle(pnlKullanici);
            kullanicilariGetir();
        }
    }
}
