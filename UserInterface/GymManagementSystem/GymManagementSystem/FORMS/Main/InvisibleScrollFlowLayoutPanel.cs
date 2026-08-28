using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GymManagementSystem.FORMS.Main
{
    [DesignerCategory("")]
    internal class InvisibleScrollFlowLayoutPanel : FlowLayoutPanel
    {
        // =========================================================
        // Windows Messages
        // =========================================================

        private const int WM_NCPAINT = 0x0085;
        private const int WM_NCCALCSIZE = 0x0083;
        private const int WM_SIZE = 0x0005;
        private const int WM_WINDOWPOSCHANGED = 0x0047;
        private const int WM_STYLECHANGED = 0x007D;
        private const int WM_VSCROLL = 0x0115;
        private const int WM_HSCROLL = 0x0114;

        // =========================================================
        // Scrollbar Constants
        // =========================================================

        private const int SB_HORZ = 0;
        private const int SB_VERT = 1;

        // =========================================================
        // Windows API
        // =========================================================

        [DllImport("user32.dll")]
        private static extern bool ShowScrollBar(
            IntPtr hWnd,
            int wBar,
            bool bShow);

        // =========================================================
        // Constructor
        // =========================================================

        public InvisibleScrollFlowLayoutPanel()
        {
            AutoScroll = true;

            HorizontalScroll.Enabled = false;
            HorizontalScroll.Visible = false;

            VerticalScroll.Enabled = true;
            VerticalScroll.Visible = false;

            DoubleBuffered = true;

            HideScrollBars();
        }

        // =========================================================
        // Hide Scrollbars
        // =========================================================

        private void HideScrollBars()
        {
            if (!IsHandleCreated)
                return;

            try
            {
                ShowScrollBar(
                    Handle,
                    SB_VERT,
                    false);

                ShowScrollBar(
                    Handle,
                    SB_HORZ,
                    false);
            }
            catch
            {
                // Ignore Windows API errors
            }
        }

        // =========================================================
        // Handle Created
        // =========================================================

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            HideScrollBars();
        }

        // =========================================================
        // Layout
        // =========================================================

        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            HideScrollBars();
        }

        // =========================================================
        // Resize
        // =========================================================

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            HideScrollBars();
        }

        // =========================================================
        // Scroll
        // =========================================================

        protected override void OnScroll(ScrollEventArgs se)
        {
            base.OnScroll(se);

            HideScrollBars();
        }

        // =========================================================
        // Windows Message Processing
        // =========================================================

        protected override void WndProc(ref Message m)
        {
            // -----------------------------------------------------
            // Prevent non-client scrollbar painting
            // -----------------------------------------------------

            if (m.Msg == WM_NCPAINT)
            {
                return;
            }

            // -----------------------------------------------------
            // Non-client calculation
            // -----------------------------------------------------

            if (m.Msg == WM_NCCALCSIZE)
            {
                base.WndProc(ref m);

                HideScrollBars();

                return;
            }

            // -----------------------------------------------------
            // Normal processing
            // -----------------------------------------------------

            base.WndProc(ref m);

            // -----------------------------------------------------
            // Re-hide scrollbar after Windows updates it
            // -----------------------------------------------------

            switch (m.Msg)
            {
                case WM_SIZE:
                case WM_WINDOWPOSCHANGED:
                case WM_STYLECHANGED:
                case WM_VSCROLL:
                case WM_HSCROLL:

                    HideScrollBars();

                    break;
            }
        }
    }
}