using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace UI
{
    public class ChatPanel : ListBox
    {
        // private Dictionary<string, ChatItem> m_hmChatItem;
        private SortedDictionary<ulong, string> m_setChatTime;

        public ChatPanel()
        {
        }

        // private void AddItem(ChatItem obChatItem)
        // {
        //     this.Items.Add(obChatItem);
        // }

        public void PupolateItem()
        {
        }

        protected override void OnDrawItem(DrawItemEventArgs eDrawItem)
        {
            if (this.Items.Count > 0)
            {
                foreach (var obItem in this.Controls)
                {
                    // _imageSize = new Size(80,60);
                    // this.ItemHeight = _imageSize.Height + this.Margin.Vertical;
                    // _fmt = new StringFormat();
                    // _fmt.Alignment = StringAlignment.Near;
                    // _fmt.LineAlignment = StringAlignment.Near;
                    // _titleFont = new Font(this.Font, FontStyle.Bold);
                    // _detailsFont = new Font(this.Font, FontStyle.Regular);
                    ((exListBoxItem) obItem).drawItem(eDrawItem, DefaultPadding, new Font(this.Font, FontStyle.Bold), 
                    new Font(this.Font, FontStyle.Regular), new StringFormat(), new Size(80,60));
                }
            }
        }

        protected override void OnPaint(PaintEventArgs ePaint)
        {
            base.OnPaint(ePaint);
        }
    }
}