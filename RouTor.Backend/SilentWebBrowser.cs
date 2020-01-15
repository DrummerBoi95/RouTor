using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RouTor.Backend
{
    public class SilentWebBrowser
    {
        public WebBrowser WebBrowser { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string LANIP { get; set; }

        public SilentWebBrowser()
        {

        }
                
        public void NavigateLogin(string strURL)
        {
            WebBrowser.Navigate(strURL);
            System.Threading.Thread.Sleep(2000);
        }  
        
        public void PerformLogin()
        {
            HtmlElementCollection theElementCollection;
            theElementCollection = WebBrowser.Document.GetElementsByTagName("input");
            foreach (HtmlElement curElement in theElementCollection)
            {
                string controlName = curElement.GetAttribute("name").ToString();
                if (controlName == "UserNameTextBox")
                    curElement.SetAttribute("Value", UserName);
                else if (controlName == "PasswordTextBox")
                    curElement.SetAttribute("Value", Password);
            }

            theElementCollection = WebBrowser.Document.GetElementsByTagName("input");
            foreach (HtmlElement curElement in theElementCollection)
            {
                if (curElement.GetAttribute("value").Equals("Login"))
                    curElement.InvokeMember("click");
            }

            WebBrowser.Document.GetElementById("AuthName").SetAttribute("value", UserName);
            WebBrowser.Document.GetElementById("Display").SetAttribute("value", Password);
            WebBrowser.Document.GetElementById("submit").InvokeMember("click");
            // WebBrowser1.Document.GetElementById("network").InvokeMember("click")
            System.Threading.Thread.Sleep(50000);

            LoadPages();
            if (WebBrowser.Url.ToString().Contains("index"))
            {
                LoadPages();
                WebBrowser.DocumentCompleted += DocumentCompleted;
            }
        }

        private void DocumentCompleted(System.Object sender, System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e)
        {
         
        }
        
        private void LoadPages()
        {
            WebBrowser.Document.GetElementById("network-homeNetworking").InvokeMember("click");
            WebBrowser.Document.GetElementById("network-homeNetworking").InvokeMember("click");

            System.Threading.Thread.Sleep(10000);
            WebBrowser.Document.GetElementById("t6").InvokeMember("click");
            WebBrowser.Document.GetElementById("wakeOnLanIPAddr").SetAttribute("value", LANIP);
            WebBrowser.Document.GetElementById("str1").SetAttribute("value", "00");
            WebBrowser.Document.GetElementById("str2").SetAttribute("value", "e0");
            WebBrowser.Document.GetElementById("str3").SetAttribute("value", "4c");
            WebBrowser.Document.GetElementById("str4").SetAttribute("value", "29");
            WebBrowser.Document.GetElementById("str5").SetAttribute("value", "13");
            WebBrowser.Document.GetElementById("str6").SetAttribute("value", "8c");
            WebBrowser.Document.GetElementById("wakeUpBtn").InvokeMember("click");
        }
    }    
}
