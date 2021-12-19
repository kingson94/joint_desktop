using System.Windows.Forms;

namespace UI
{
    public enum E_ICON_STYLE
    {
        NONE = 0,
        LEFT = 1,
        RIGHT = 2
    }

    public class TSTextBox : TextBox
    {
        public TSTextBox() : base() 
        {
            this.SetStyle(ControlStyles.UserPaint, false);
        }

        protected override void OnPaint(PaintEventArgs evtPaint)
        {
            base.OnPaint(evtPaint);
            // evtPaint.Graphics.DrawRectangle(System.Drawing.Pens.Red, 0, 0, this.Width, this.Height);
        }
    }
}