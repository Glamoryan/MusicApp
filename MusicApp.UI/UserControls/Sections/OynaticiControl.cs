using MusicApp.UI.AuthControls;
using MusicApp.UI.UserControls.Player;
using System;
using System.Windows.Forms;
using WMPLib;

namespace MusicApp.UI.UserControls.Sections
{
    public partial class OynaticiControl : UserControl
    {
        private double yuzde = 0;
        private WindowsMediaPlayer oynatici;

        public OynaticiControl()
        {
            InitializeComponent();

            if (Oynatici.caliyorMu)
                tmrSureSayac.Enabled = true;
            else
                tmrSureSayac.Enabled = false;
        }

        private void CikisYap()
        {
            DialogResult sonuc = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış Yap?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                Oynatici.sarkiDurdur();

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

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (Oynatici.caliyorMu)
            {
                Oynatici.sarkiDuraklat();
                btnPlay.Image = Properties.Resources.play;
                tmrSureSayac.Stop();
            }
            else
            {
                Oynatici.sarkiOynat();
                btnPlay.Image = Properties.Resources.pause;
                tmrSureSayac.Start();
            }
        }

        private void tmrSureSayac_Tick(object sender, EventArgs e)
        {
            if (!Oynatici.caliyorMu)
                tmrSureSayac.Enabled = false;

            if (oynatici == null)
                oynatici = Oynatici.GetOynatici();

            lblSure.Text = oynatici.controls.currentPositionString;
            lblSarkiSure.Text = oynatici.controls.currentItem.durationString;
            yuzde = (double)oynatici.controls.currentPosition / oynatici.controls.currentItem.duration;
            pgbSure.Value = (int)(yuzde * pgbSure.Maximum);
        }
    }
}
