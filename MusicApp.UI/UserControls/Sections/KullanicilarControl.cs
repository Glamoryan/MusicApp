using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using MusicApp.UI.AuthControls;
using MusicApp.UI.Tools;
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
        private IKullaniciTakipService _kullaniciTakipService;
        private IAboneService _aboneService;
        private IAbonelikService _abonelikService;

        private KullaniciItem _kullaniciItem;

        public KullanicilarControl()
        {
            InitializeComponent();
            _kullaniciService = InstanceFactory.GetInstance<IKullaniciService>();
            _aboneService = InstanceFactory.GetInstance<IAboneService>();
            _abonelikService = InstanceFactory.GetInstance<IAbonelikService>();
            _kullaniciTakipService = InstanceFactory.GetInstance<IKullaniciTakipService>();
        }       
        
        private bool takipEdiliyorMu(Kullanici takipEdilecekKullanici)
        {
            List<KullaniciTakip> kullanicininTakipcileri = _kullaniciTakipService.KullanicininTakipcileriniGetir(takipEdilecekKullanici.kullaniciId);
            if (kullanicininTakipcileri.Count > 0)
            {
                foreach (KullaniciTakip kullaniciTakip in kullanicininTakipcileri)
                {
                    if (kullaniciTakip.takipciId == LoginManager.etkinKullanici.kullaniciId)
                        return true;
                }
            }            
            return false;
        }

        private void takipEt(Kullanici takipEdilecekKullanici)
        {
            KullaniciTakip kullaniciTakip = new KullaniciTakip
            {
                kullaniciId = takipEdilecekKullanici.kullaniciId,
                takipciId = LoginManager.etkinKullanici.kullaniciId
            };
            _kullaniciTakipService.KullaniciTakipEkle(kullaniciTakip);
            MessageBox.Show("Kullanıcı takip edildi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            kullanicilariGetir();
        }

        private void kullanicilariGetir()
        {
            pnlKullanicilar.Controls.Clear();
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
                _kullaniciItem.lblKullaniciAdi.Text = Utilities.textSinirla(kullanici.kullaniciAdi,18);
                _kullaniciItem.lblRolAdi.Text = "Kullanıcı";
                _kullaniciItem.lblAbonelikAdi.Text = abonelikAdi;
                _kullaniciItem.lblUlkeAdi.Text = Utilities.textSinirla(kullanici.ulkeAdi);

                if (takipEdiliyorMu(kullanici))
                {
                    _kullaniciItem.btnTakip.Text = "Takiptesin";
                    _kullaniciItem.btnTakip.Enabled = false;
                }                    

                _kullaniciItem.btnTakip.Click += (s, e) => takipEt(kullanici);

                if (abonelikAdi == "Normal" || LoginManager.etkinKullanici.kullaniciId == kullanici.kullaniciId)
                    _kullaniciItem.btnTakip.Visible = false;
                
                pnlKullanicilar.Controls.Add(_kullaniciItem);
                sayac++;
            }
        }

        private void KullanicilarControl_Load(object sender, EventArgs e)
        {
            Utilities.scroolbarEkle(pnlKullanicilar);

            kullanicilariGetir();
        }
    }
}
