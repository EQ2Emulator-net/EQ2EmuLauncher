namespace EQ2EmuLauncher
{
    partial class NewsFeed
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webNews = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webNews
            // 
            this.webNews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webNews.Location = new System.Drawing.Point(3, 3);
            this.webNews.MinimumSize = new System.Drawing.Size(20, 20);
            this.webNews.Name = "webNews";
            this.webNews.Size = new System.Drawing.Size(546, 309);
            this.webNews.TabIndex = 0;
            this.webNews.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webNews_Navigating);
            // 
            // NewsFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EQ2EmuLauncher.Resources.border_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.webNews);
            this.Name = "NewsFeed";
            this.Size = new System.Drawing.Size(552, 315);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webNews;
    }
}
