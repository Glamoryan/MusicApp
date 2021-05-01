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

            Utilities.icerikDegistir(contentPaneli, calmaListesiControl);            
        }

        private void anasayfaGetir()
        {
            if (anasayfaControl == null)
                anasayfaControl = new AnasayfaControl();
            Utilities.icerikDegistir(contentPaneli, anasayfaControl);            
        }

        private void takipleriGetir()
        {
            if (takiplerControl == null)
                takiplerControl = new TakiplerControl();
            Utilities.icerikDegistir(contentPaneli, takiplerControl);
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
    }
}
