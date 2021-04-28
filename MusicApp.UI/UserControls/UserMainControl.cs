using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MusicApp.UI.UserControls
{
    public partial class UserMainControl : UserControl
    {
        private ContentControl contentControl;
        private PlayerBarControl playerBarControl;
        private SidebarMenuControl sidebarMenuControl;
        public UserMainControl()
        {
            InitializeComponent();

            contentControl = new ContentControl();
            playerBarControl  = new PlayerBarControl();
            sidebarMenuControl = new SidebarMenuControl();
        }

        private void UserMainControl_Load(object sender, EventArgs e)
        {
            pnlSidebar.Controls.Add(sidebarMenuControl);
            pnlPlayer.Controls.Add(playerBarControl);
            pnlContent.Controls.Add(contentControl);
        }
    }
}
