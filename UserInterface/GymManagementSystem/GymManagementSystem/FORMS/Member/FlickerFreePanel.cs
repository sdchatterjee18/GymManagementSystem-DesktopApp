using System.Windows.Forms;

namespace GymManagementSystem.FORMS.Member
{
    public class FlickerFreePanel : Panel
    {
        public FlickerFreePanel()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            this.DoubleBuffered = true;
        }
    }
}