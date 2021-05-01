using System.Windows.Forms;

namespace MusicApp.UI.Tools
{
    public static class Utilities
    {
        public static void icerikDegistir(Control eklenecek,Control eklenen)
        {
            eklenecek.Controls.Clear();
            eklenecek.Controls.Add(eklenen);
        }
    }
}
