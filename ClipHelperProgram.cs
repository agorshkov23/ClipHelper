using System;
using System.Windows.Forms;

namespace ClipHelper
{
    static class ClipHelperProgram
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ClipHelperForm());
        }
    }
}
