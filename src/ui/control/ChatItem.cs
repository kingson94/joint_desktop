// using System.Drawing;
// using System.Windows.Forms;

// namespace UI
// {
//     class ChatItem : Control
//     {
//         private string m_strAvatar;
//         private Image m_imgAvatar;
//         private string m_strChatName;
//         private string m_strLastMessage;
//         private Size m_ptSize;

//         // Graphic tools
//         private System.Drawing.Font m_fntChatName;
//         private System.Drawing.Font m_fntLastMessage;
//         private System.Drawing.Rectangle m_rcChatName;
//         private StringFormat m_sfChatName;

//         public void SetChatName(string strChatName)
//         {
//             m_strChatName = strChatName;
//         }

//         public void SetLastMessage(string strLastMessage)
//         {
//             m_strLastMessage = strLastMessage;
//         }

//         public ChatItem()
//         {
//             m_rcChatName = new Rectangle(0, 0, 100, 30);
//             m_sfChatName = new StringFormat();
//             m_sfChatName.Alignment = StringAlignment.Near;
//         }

//         public void Draw(DrawItemEventArgs eDrawItem)
//         {
//             if (m_strChatName.Length > 0)
//             {
//                 eDrawItem.Graphics.DrawString(m_strChatName, m_fntChatName, Brushes.Black, m_rcChatName, m_sfChatName);
//             }
//         }
//     }
// }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    class exListBoxItem
    {
        private string _title;
        private string _details;
        private Image _itemImage;
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public exListBoxItem(int id, string title, string details, Image image)
        {
            _id = id;
            _title = title;
            _details = details;
            _itemImage = image;
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Details
        {
            get { return _details; }
            set { _details = value; }
        }

        public Image ItemImage
        {
            get { return _itemImage; }
            set { _itemImage = value; }
        }

        public void drawItem(DrawItemEventArgs e, Padding margin, 
                             Font titleFont, Font detailsFont, StringFormat aligment, 
                             Size imageSize)
        {            

            // if selected, mark the background differently
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(Brushes.CornflowerBlue, e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.Beige, e.Bounds);
            }

            // draw some item separator
            e.Graphics.DrawLine(Pens.DarkGray, e.Bounds.X, e.Bounds.Y, e.Bounds.X + e.Bounds.Width, e.Bounds.Y);

            // draw item image
            e.Graphics.DrawImage(this.ItemImage, e.Bounds.X + margin.Left, e.Bounds.Y + margin.Top, imageSize.Width, imageSize.Height);

            // calculate bounds for title text drawing
            Rectangle titleBounds = new Rectangle(e.Bounds.X + margin.Horizontal + imageSize.Width,
                                                  e.Bounds.Y + margin.Top,
                                                  e.Bounds.Width - margin.Right - imageSize.Width - margin.Horizontal,
                                                  (int)titleFont.GetHeight() + 2);
            
            // calculate bounds for details text drawing
            Rectangle detailBounds = new Rectangle(e.Bounds.X + margin.Horizontal + imageSize.Width,
                                                   e.Bounds.Y + (int)titleFont.GetHeight() + 2 + margin.Vertical + margin.Top,
                                                   e.Bounds.Width - margin.Right - imageSize.Width - margin.Horizontal,
                                                   e.Bounds.Height - margin.Bottom - (int)titleFont.GetHeight() - 2 - margin.Vertical - margin.Top);

            // draw the text within the bounds
            e.Graphics.DrawString(this.Title, titleFont, Brushes.Black, titleBounds, aligment);
            e.Graphics.DrawString(this.Details, detailsFont, Brushes.DarkGray, detailBounds, aligment);            
            
            // put some focus rectangle
            e.DrawFocusRectangle();
        
        }

    }
}
