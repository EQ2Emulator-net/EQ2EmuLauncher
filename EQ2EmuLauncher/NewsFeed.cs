using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace EQ2EmuLauncher
{
    public partial class NewsFeed : UserControl
    {
        private bool kill_nav;
        private bool kill_nav2 = false;
        public NewsFeed()
        {
            InitializeComponent();
            kill_nav = false;

            webNews.DocumentText = "<html>" +
                   "<style>" +
                   "body { color:white; background-color: #460A0A; }" + /* #3C3C3A - first, #460A0A - second,  #712C0D - third*/
                   "div.title { color:blue; font-size:32px; }" +
                   "div.post { font-size:12px; }" +
                   "a:link { color:#0099CC; }" +
                   "a:visited { color:#0099CC; }" +
                   "a:hover { color:#0099CC; }" +
                   "a:active { color:#0099CC; }" +
                   "</style>" +
                   "<body></body></html>";
            

            Thread retrieve_news = new Thread(new ThreadStart(GetNews));
            retrieve_news.Start();
            /*
            // Get the html for the web browser
            webNews.DocumentText = Settings.GetNews();
            // Set the flag so the web browser can't be changed.
            kill_nav = true;*/
        }

        private void GetNews()
        {
            string html = Settings.GetNews();
            SetNews(html);
        }

        public void SetNews(string html)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(delegate() { SetNews(html); }));
                return;
            }

            webNews.DocumentText = html;
            kill_nav = true;
        }

        private void webNews_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            // Once the flag is set don't allow the browser to change, open any link clicks in the users default browser
            if (kill_nav2)
            {
                e.Cancel = true;
                Process.Start(e.Url.ToString());
            }

            // Once threading was added setting kill_nav was being set before this function was triggered preventing the news from displaying,
            // adding this second flag allows it to function properly.
            if (kill_nav)
                kill_nav2 = true;
        }
    }
}
