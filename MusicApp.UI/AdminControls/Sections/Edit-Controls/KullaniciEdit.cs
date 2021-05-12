using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicApp.UI.AdminControls.Sections.Edit_Controls
{
    public partial class KullaniciEdit : UserControl
    {
        private IRolService _rolService;
        private IKullaniciService _kullaniciService;

        private Kullanici _kullanici;

        public KullaniciEdit(Kullanici kullanici)
        {
            InitializeComponent();
            _rolService = InstanceFactory.GetInstance<IRolService>();
            _kullaniciService = InstanceFactory.GetInstance<IKullaniciService>();

            _kullanici = kullanici;
        }
        
        private void bilgileriYazdir()
        {
            var roller = new BindingSource();
            roller.DataSource = _rolService.TumRolleriGetir();

            tbxKullaniciAdi.Text = _kullanici.kullaniciAdi;
            tbxSifre.Text = _kullanici.kullaniciSifre;
            tbxUlke.Text = _kullanici.ulkeAdi;
            tbxMail.Text = _kullanici.kullaniciMail;
            cbxRol.DataSource = roller.DataSource;
            cbxRol.DisplayMember = "rolAdi";
            cbxRol.ValueMember = "id";
            cbxRol.SelectedValue = _kullanici.rolId;
        }   
        
        private bool kullaniciAdiAlinmisMi()
        {
            List<Kullanici> kullanicilar = _kullaniciService.TumKullanicilariGetir();
            foreach (Kullanici kullanici in kullanicilar)
            {
                if (kullanici.kullaniciAdi.Trim().ToLower() == tbxKullaniciAdi.Text.Trim().ToLower())
                    return true;                                
            }
            return false;
        }

        private bool bosAlanVarmi()
        {
            if (string.IsNullOrEmpty(tbxKullaniciAdi.Text) || string.IsNullOrEmpty(tbxMail.Text) || string.IsNullOrEmpty(tbxSifre.Text) || string.IsNullOrEmpty(tbxUlke.Text))
                return true;
            else
                return false;
        }

        private void kullaniciGuncelle()
        {
            if (!bosAlanVarmi())
            {
                _kullanici.kullaniciAdi = tbxKullaniciAdi.Text.Trim();
                _kullanici.kullaniciMail = tbxMail.Text.Trim();
                _kullanici.kullaniciSifre = tbxSifre.Text.Trim();
                _kullanici.rolId = Convert.ToInt32(cbxRol.SelectedValue);
                _kullanici.ulkeAdi = tbxUlke.Text.Trim();

                if (!kullaniciAdiAlinmisMi())
                {
                    _kullaniciService.KullaniciGuncelle(_kullanici);
                    MessageBox.Show("Kullanıcı güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Controls.Clear();
                    Controls.Add(new KullanicilarControl());
                }
                else
                    MessageBox.Show("Bu kullanıcı adı daha önce alınmış!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Alanlar boş bırakılamaz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            KullanicilarControl kullanicilarControl = new KullanicilarControl();
            Controls.Clear();
            Controls.Add(kullanicilarControl);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            kullaniciGuncelle();
        }

        private void KullaniciEdit_Load(object sender, EventArgs e)
        {
            bilgileriYazdir();
        }        
    }
}
