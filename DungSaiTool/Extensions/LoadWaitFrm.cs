using DevExpress.XtraSplashScreen;
using System.Windows.Forms;

namespace DungSaiTool.Extensions
{
    public class LoadWaitFrm
    {
        public delegate void delLoadWaitFrm();

        public static void Loading(Form frm, delLoadWaitFrm waitFrm, string caption)
        {
            SplashScreenManager.ShowForm(frm, typeof(frmWaiting), true, true, false);
            SplashScreenManager.Default.SetWaitFormCaption(caption);
            waitFrm();
            SplashScreenManager.CloseForm();
        }
    }
}