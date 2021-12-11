using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace UI
{
    public class ChatPanel : ListBox
    {
        private Form m_obParent;
        private Dictionary<string, ChatItem> m_hmChatItem;
        private SortedDictionary<ulong, string> m_setChatTime;

        public ChatPanel(Form obParent)
        {
            this.m_obParent = obParent;
        }
        // public override OnDrawItem(System.Drawing.evet)

        public void Initialize()
        {
            this.BackColor = Color.FromArgb(255, 145, 245, 168);
            // Position
            this.Top = m_obParent.Top;
            this.Left = m_obParent.Left;
            this.MinimumSize = new Size(100, m_obParent.Height);
            this.Height = m_obParent.Height;
            this.Width = 200;
            this.TabStop = false;
            this.SelectedIndex = -1;
        }

        private void AddItem(ChatItem obChatItem)
        {
            this.Items.Add(obChatItem);
        }

        public void PupolateItem()
        {
            ChatItem obItem = new ChatItem(this);
            obItem.SetChatName("Chat for test");
            this.AddItem(obItem);
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
            MessageBox.Show("tt", "sontv", MessageBoxButtons.OK);
        }

        protected override void OnPaint(PaintEventArgs ePaint)
        {
            base.OnPaint(ePaint);
        }
    }
}