namespace App
{
    partial class MainFrame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer obComponents = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="bDisposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool bDisposing)
        {
            if (bDisposing && (obComponents != null))
            {
                obComponents.Dispose();
            }
            base.Dispose(bDisposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.obComponents = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Text = "Joint desktop";
        }

        #endregion
    }
}

