using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GymManagementSystem.FORMS.Main
{
    public static class ScrollBarHelper
    {
        private const int SB_HORZ = 0;
        private const int SB_VERT = 1;

        [DllImport("user32.dll")]
        private static extern bool ShowScrollBar(
            IntPtr hWnd,
            int wBar,
            bool bShow);

        public static void HideScrollBar(Control control)
        {
            if (control == null)
                return;

            if (!control.IsHandleCreated)
                return;

            ShowScrollBar(control.Handle, SB_VERT, false);
            ShowScrollBar(control.Handle, SB_HORZ, false);
        }
    }
}