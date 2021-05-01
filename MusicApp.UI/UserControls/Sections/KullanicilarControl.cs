﻿using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using MusicApp.UI.UserControls.Sections.List_Items;
using System;
using System.Collections.Generic;
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
                _kullaniciItem = new KullaniciItem();
                _kullaniciItem.Top = (sayac * 60);
                _kullaniciItem.lblKullaniciAdi.Text = kullanici.kullaniciAdi;
                _kullaniciItem.lblRolAdi.Text = kullanici.rolId == 1 ? "Kullanıcı" : "Admin";
                _kullaniciItem.lblAbonelikAdi.Text = _abonelikService.AbonelikGetir(_aboneService.AboneyiGetir(kullanici.kullaniciId).abonelikId).abonelikAdi;
                _kullaniciItem.lblUlkeAdi.Text = kullanici.ulkeAdi;
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
