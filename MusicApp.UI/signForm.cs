using MusicApp.UI.AuthControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MusicApp.UI
{
    public partial class signForm : Form
    {
        public signForm()
        {
            InitializeComponent();
        }

        private void girisEkraniGetir()
        {
            GirisControl girisEkran = new GirisControl();
            pnlAuthMain.Controls.Clear();
            pnlAuthMain.Controls.Add(girisEkran);
        }

        private void signForm_Load(object sender, EventArgs e)
        {
            girisEkraniGetir();
        }
    }
}
