using MusicApp.UI.AdminControls;
using MusicApp.UI.UserControls;
using System;
using System.Windows.Forms;

namespace MusicApp.UI
{
    public partial class mainForm : Form
    {
        private Control mainControl;       
        public mainForm(bool adminMi)
        {
            if (!adminMi)
                mainControl = new UserMainControl();
            else
                mainControl = new AdminMainControl();

            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {            
            pnlMain.Controls.Add(mainControl);
        }
    }
}
