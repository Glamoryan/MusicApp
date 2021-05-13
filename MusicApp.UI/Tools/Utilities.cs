using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MusicApp.UI.Tools
{
    public static class Utilities
    {
        public static int? sarkiSayisi;
        public static void icerikDegistir(Control eklenecek,Control eklenen)
        {
            eklenecek.Controls.Clear();
            eklenecek.Controls.Add(eklenen);
        }

        public static void scroolbarEkle(Panel eklenecekPanel)
        {
            eklenecekPanel.AutoScroll = false;
            eklenecekPanel.HorizontalScroll.Enabled = false;
            eklenecekPanel.HorizontalScroll.Visible = false;
            eklenecekPanel.HorizontalScroll.Maximum = 0;
            eklenecekPanel.AutoScroll = true;
        }

        public static string textSinirla(string text,int max=12)
        {
            return Regex.Replace(text.Trim(), "(?<=^.{"+max+"}).*", "...");
        }
    }
}
