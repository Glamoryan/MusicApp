using MusicApp.UI.AuthControls;
using System;
using System.Windows.Forms;

namespace MusicApp.UI.UserControls.Sections
{
    public partial class OynaticiControl : UserControl
    {
        public OynaticiControl()
        {
            InitializeComponent();
        }

        private void CikisYap()
        {
            DialogResult sonuc = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış Yap?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(sonuc == DialogResult.Yes)
            {
                LoginManager.etkinKullanici = null;
                Form suankiForm = FindForm();
                suankiForm.Hide();
                var girisForm = new signForm();
                girisForm.FormClosed += (s, args) => suankiForm.Close();
                girisForm.Show();
            }            
        }

        private void pcbxCikis_Click(object sender, EventArgs e)
        {
            CikisYap();
        }
    }
}
