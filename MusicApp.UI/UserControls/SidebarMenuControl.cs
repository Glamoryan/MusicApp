using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using MusicApp.UI.AuthControls;
using MusicApp.UI.Tools;
using MusicApp.UI.UserControls.Sections;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicApp.UI.UserControls
{
    public partial class SidebarMenuControl : UserControl
    {
        private Panel contentPaneli;        

        private CalmaListesiControl calmaListesiControl;
        private AnasayfaControl anasayfaControl;
        private TakiplerControl takiplerControl;
        private KullanicilarControl kullanicilarControl;
        private SarkilarControl sarkilarControl;
        private AlbumlerControl albumlerControl;

        private IAboneService _aboneService;
        public SidebarMenuControl()
        {
            InitializeComponent();
            _aboneService = InstanceFactory.GetInstance<IAboneService>();
        }

        private bool premiumMu()
        {
            Abone abonemiz = _aboneService.AboneyiGetir(LoginManager.etkinKullanici.kullaniciId);
            return abonemiz.abonelikId == 2 ? true : false;
        }

        private void calmaListesiniGetir()
        {            
            if(calmaListesiControl == null)
                calmaListesiControl = new CalmaListesiControl();
            else
            {
                if (contentPaneli.Controls.ContainsKey("CalmaListesiControl"))
                {
                    calmaListesiControl = new CalmaListesiControl();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }
            Utilities.icerikDegistir(contentPaneli, calmaListesiControl);            
        }

        private void anasayfaGetir()
        {
            if (anasayfaControl == null)
                anasayfaControl = new AnasayfaControl();
            else
            {
                if (contentPaneli.Controls.ContainsKey("AnasayfaControl"))
                {
                    anasayfaControl = new AnasayfaControl();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }
            Utilities.icerikDegistir(contentPaneli, anasayfaControl);            
        }

        private void takipleriGetir()
        {
            if (takiplerControl == null)
                takiplerControl = new TakiplerControl();
            else
            {
                if (contentPaneli.Controls.ContainsKey("TakiplerControl"))
                {
                    takiplerControl = new TakiplerControl();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }
            Utilities.icerikDegistir(contentPaneli, takiplerControl);
        }

        private void kullanicilariGetir()
        {
            if (kullanicilarControl == null)
                kullanicilarControl = new KullanicilarControl();
            else
            {
                if (contentPaneli.Controls.ContainsKey("KullanicilarControl"))
                {
                    kullanicilarControl = new KullanicilarControl();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }
            Utilities.icerikDegistir(contentPaneli, kullanicilarControl);
        }

        private void sarkilariGetir()
        {
            if (sarkilarControl == null)
                sarkilarControl = new SarkilarControl();
            else
            {
                if (contentPaneli.Controls.ContainsKey("SarkilarControl"))
                {
                    sarkilarControl = new SarkilarControl();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }
            Utilities.icerikDegistir(contentPaneli, sarkilarControl);
        }

        private void albumleriGetir()
        {
            if (albumlerControl == null)
                albumlerControl = new AlbumlerControl();
            else
            {
                if (contentPaneli.Controls.ContainsKey("AlbumlerControl"))
                {
                    albumlerControl = new AlbumlerControl();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }
            Utilities.icerikDegistir(contentPaneli, albumlerControl);
        }

        private void bilgileriYazdir()
        {
            if (premiumMu())
                lblKullaniciAdi.ForeColor = Color.Yellow;
            else
                lblKullaniciAdi.ForeColor = Color.White;

            lblKullaniciAdi.Text = LoginManager.etkinKullanici.kullaniciAdi;
        }

        private void SidebarMenuControl_Load(object sender, EventArgs e)
        {
            contentPaneli = Parent.Parent.Controls.Find("pnlContent", true)[0] as Panel;            
            anasayfaGetir();
            bilgileriYazdir();
        }

        private void btnCalmaListesi_Click(object sender, EventArgs e)
        {
            calmaListesiniGetir();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            anasayfaGetir();
        }

        private void btnTakipler_Click(object sender, EventArgs e)
        {
            takipleriGetir();
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            kullanicilariGetir();
        }

        private void btnSarkilar_Click(object sender, EventArgs e)
        {
            sarkilariGetir();
        }

        private void btnAlbumler_Click(object sender, EventArgs e)
        {
            albumleriGetir();
        }
    }
}
