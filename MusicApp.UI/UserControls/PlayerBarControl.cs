using MusicApp.UI.Tools;
using MusicApp.UI.UserControls.Sections;
using System;
using System.Windows.Forms;

namespace MusicApp.UI.UserControls
{
    public partial class PlayerBarControl : UserControl
    {        
        private OynaticiControl oynaticiControl;
        public PlayerBarControl()
        {
            InitializeComponent();
        }

        private void oynaticiyiGetir()
        {
            if (oynaticiControl == null)
                oynaticiControl = new OynaticiControl();
            Utilities.icerikDegistir(this, oynaticiControl);
        }

        private void PlayerBarControl_Load(object sender, EventArgs e)
        {            
            oynaticiyiGetir();
        }
    }
}
