using MusicApp.UI.AuthControls;
using System;
using System.Windows.Forms;

namespace MusicApp.UI
{
    public partial class signForm : Form
    {
        private GirisControl _girisEkran;

        public signForm()
        {
            InitializeComponent();
        }

        //Giriş kontrolünü ekrana getiren fonksiyon
        private void girisEkraniGetir()
        {
            _girisEkran = new GirisControl();
            pnlAuthMain.Controls.Clear();
            pnlAuthMain.Controls.Add(_girisEkran);
        }

        private void signForm_Load(object sender, EventArgs e)
        {
            girisEkraniGetir();
        }
    }
}
