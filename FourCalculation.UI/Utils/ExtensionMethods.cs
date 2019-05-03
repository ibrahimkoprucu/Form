using System.Windows.Forms;

namespace FourCalculation.UI.Utils
{
    public static class ExtensionMethods
    {
        public static void OpenFormOrBringToFront(this Form form)
        {
            if (form.WindowState == FormWindowState.Minimized)
            {
                form.WindowState = FormWindowState.Normal;
            }

            form.BringToFront();

            form.Show();
        }
    }
}