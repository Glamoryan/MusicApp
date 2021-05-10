using MusicApp.Business.Abstract;
using MusicApp.Business.Ninject;
using MusicApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicApp.UI.AdminControls.Sections.Edit_Controls
{
    public partial class KullaniciAdd : UserControl
    {
        private IKullaniciService _kullaniciService;
        private IRolService _rolService;

        public KullaniciAdd()
        {
            InitializeComponent();

            _kullaniciService = InstanceFactory.GetInstance<IKullaniciService>();
            _rolService = InstanceFactory.GetInstance<IRolService>();
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

        private void kullaniciEkle()
        {
            if (!bosAlanVarmi())
            {
                if (!kullaniciAdiAlinmisMi())
                {
                    Kullanici kullanici = new Kullanici
                    {
                        kullaniciAdi = tbxKullaniciAdi.Text.Trim(),
                        kullaniciMail = tbxMail.Text.Trim(),
                        kullaniciSifre = tbxSifre.Text.Trim(),
                        rolId = Convert.ToInt32(cbxRol.SelectedValue),
                        ulkeAdi = tbxUlke.Text.Trim()
                    };
                    _kullaniciService.KullaniciEkle(kullanici);
                    MessageBox.Show("Kullanıcı eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Controls.Clear();
                    Controls.Add(new KullanicilarControl());
                }
                else
                    MessageBox.Show("Bu kullanıcı adı daha önce alınmış!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Alanlar boş bırakılamaz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void rolleriGetir()
        {
            var roller = new BindingSource();
            roller.DataSource = _rolService.TumRolleriGetir();

            cbxRol.DataSource = roller.DataSource;
            cbxRol.DisplayMember = "rolAdi";
            cbxRol.ValueMember = "id";
            cbxRol.SelectedIndex = 0;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            kullaniciEkle();
        }

        private void KullaniciAdd_Load(object sender, EventArgs e)
        {
            rolleriGetir();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(new KullanicilarControl());
        }
    }
}
