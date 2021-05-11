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
    public partial class KullanicilarControl : UserControl
    {
        private IKullaniciService _kullaniciService;
        private IRolService _rolService;
        private IAboneService _aboneService;
        private ICalmaListesiService _calmaListesiService;
        private IKullaniciTakipService _kullaniciTakipService;

        public KullanicilarControl()
        {
            InitializeComponent();
            _kullaniciService = InstanceFactory.GetInstance<IKullaniciService>();
            _rolService = InstanceFactory.GetInstance<IRolService>();
            _aboneService = InstanceFactory.GetInstance<IAboneService>();
            _calmaListesiService = InstanceFactory.GetInstance<ICalmaListesiService>();
            _kullaniciTakipService = InstanceFactory.GetInstance<IKullaniciTakipService>();
        }
     
        private void kullaniciDuzenleEkraniGetir(Kullanici kullanici)
        {            
            KullaniciEdit kullaniciEdit = new KullaniciEdit(kullanici);                        

            Utilities.icerikDegistir(Parent, kullaniciEdit);
        }

        private void abonelerdenSil(Kullanici kullanici)
        {
            Abone abone = _aboneService.AboneyiGetir(kullanici.kullaniciId);
            _aboneService.AboneSil(abone);
        }

        private void calmaListeleriniSil(Kullanici kullanici)
        {
            List<CalmaListesi> calmaListeleri = _calmaListesiService.KullaniciCalmaListeleriniGetir(kullanici.kullaniciId);
            if(calmaListeleri.Count > 0)
            {
                foreach (CalmaListesi liste in calmaListeleri)
                {
                    _calmaListesiService.CalmaListesiSil(liste);
                }
            }
        }

        private void takiplesmeleriSil(Kullanici kullanici)
        {
            List<KullaniciTakip> takipEttikleri = _kullaniciTakipService.TakipEttikleriniGetir(kullanici.kullaniciId);            
            if(takipEttikleri.Count > 0)
            {
                foreach (KullaniciTakip takip in takipEttikleri)
                {
                    _kullaniciTakipService.KullaniciTakipSil(takip);
                }
            }

            List<KullaniciTakip> takipEdenler = _kullaniciTakipService.KullanicininTakipcileriniGetir(kullanici.kullaniciId);
            if(takipEdenler.Count > 0)
            {
                foreach (KullaniciTakip takip in takipEdenler)
                {
                    _kullaniciTakipService.KullaniciTakipSil(takip);
                }
            }
        }

        private void kullaniciSil(Kullanici kullanici)
        {
            DialogResult sonuc = MessageBox.Show("Kullanıcı silinsin mi?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(sonuc == DialogResult.Yes)
            {
                abonelerdenSil(kullanici);
                calmaListeleriniSil(kullanici);
                takiplesmeleriSil(kullanici);
                _kullaniciService.KullaniciSil(kullanici);
                MessageBox.Show("Kullanıcı silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Controls.Clear();
                Controls.Add(new KullanicilarControl());
            }
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
                kullaniciItem.btnDuzenle.Click += (s, e) => kullaniciDuzenleEkraniGetir(kullanici);
                kullaniciItem.btnSil.Click += (s, e) => kullaniciSil(kullanici);
                pnlKullanici.Controls.Add(kullaniciItem);
                sayac++;
            }
        }

        private void kullaniciEkleEkraniGetir()
        {
            KullaniciAdd kullaniciAdd = new KullaniciAdd();

            Utilities.icerikDegistir(Parent, kullaniciAdd);
        }

        private void KullanicilarControl_Load(object sender, EventArgs e)
        {
            Utilities.scroolbarEkle(pnlKullanici);
            kullanicilariGetir();
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            kullaniciEkleEkraniGetir();
        }
    }
}
