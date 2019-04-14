using System;
using System.Windows.Forms;


// $G$ THE-001 (-8) your grade on diagrams document - 92. please see comments inside the document. (40% of your grade).

namespace View
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FacebookDesktopForm desktopFacebook = new FacebookDesktopForm();
            desktopFacebook.StartLoginSession();
        }
    }
}