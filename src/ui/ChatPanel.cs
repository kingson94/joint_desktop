using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace UI
{
    public class ChatPanel : ListBox
    {
        private Dictionary<string, ChatItem> m_hmChatItem;
        private SortedDictionary<ulong, string> m_setChatTime;

        public ChatPanel()
        {
        }

        private void AddItem(ChatItem obChatItem)
        {
            this.Items.Add(obChatItem);
        }

        public void PupolateItem()
        {
        }

        protected override void OnDrawItem(DrawItemEventArgs eDrawItem)
        {
            if (this.Items.Count > 0)
            {
                foreach (var obItem in this.Items)
                {
                    ((ChatItem) obItem).Draw(eDrawItem);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs ePaint)
        {
            base.OnPaint(ePaint);
        }
    }
}