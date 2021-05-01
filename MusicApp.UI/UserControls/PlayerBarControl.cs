using MusicApp.UI.Tools;
using MusicApp.UI.UserControls.Sections;
using System;
using System.Windows.Forms;

namespace MusicApp.UI.UserControls
{
    public partial class PlayerBarControl : UserControl
    {
        private Panel oynaticiPaneli;
        private OynaticiControl oynaticiControl;
        public PlayerBarControl()
        {
            InitializeComponent();
        }

        private void oynaticiyiGetir()
        {
            if (oynaticiControl == null)
                oynaticiControl = new OynaticiControl();
            Utilities.icerikDegistir(oynaticiPaneli, oynaticiControl);
        }

        private void PlayerBarControl_Load(object sender, EventArgs e)
        {
            oynaticiPaneli = Parent.Parent.Controls.Find("pnlPlayer", true)[0] as Panel;
            oynaticiyiGetir();
        }
    }
}
