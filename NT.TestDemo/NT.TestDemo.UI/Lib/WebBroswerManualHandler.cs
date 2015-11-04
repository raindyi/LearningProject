using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using NT.TestDemo.Common.Model;
using NT.TestDemo.Common.WebClientHelper;
using NT.TestDemo.Core.Events;
using NT.TestDemo.Core.Model;

namespace NT.TestDemo.UI.Lib
{
    public class WebBroswerManualHandler
    {
        #region Veriable
        private ILog _log = LogManager.GetLogger(typeof (WebBroswerManualHandler));
        public WebBrowser WBrowser;

        public event LoginProcessEventHandler LoginEvnet;
        private LoginProcessModel _loginModel;
        public LoginProcessModel LoginModel {
            get { return _loginModel; }
            set { _loginModel = value; }
        }

        public String CookieInformation;
        #endregion

        #region Structure

        public WebBroswerManualHandler(WebBrowser browser = null)
        {
            WBrowser = browser ?? new WebBrowser();
            if (WBrowser != null)
            {
                WBrowser.DocumentCompleted += _webBrowser_DocumentCompleted;
            }
        }

        #region Function

        protected void OnLoginHandler(HandlingResult loginResult)
        {
            if (LoginEvnet != null)
            {
                LoginEvnet(loginResult);
            }
        }

        public void Login()
        {
            if (_loginModel != null)
            {
                WBrowser.Navigate(_loginModel.LoginUrl);
            }
            else
            {
                //TODO message
            }
        }
        

        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool InternetGetCookieEx(string pchUrl, string pchCookieName, StringBuilder pchCookieData, ref int pcchCookieData, int dwFlags, string lpReserved);
        private string GetCookieString(string url)
        {
            // Determine the size of the cookie          
            int datasize = 5000;
            StringBuilder cookieData = new StringBuilder(datasize);
            if (!InternetGetCookieEx(url, null, cookieData, ref datasize, 0x00002000, null))
            {
                if (datasize < 0)
                    return null;
                // Allocate stringbuilder large enough to hold the cookie        
                cookieData = new StringBuilder(datasize);
                if (!InternetGetCookieEx(url, null, cookieData, ref datasize, 0x00002000, null))
                    return null;
            }
            return cookieData.ToString();
        }
        #endregion
        #region Event
        void _webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HandlingResult result=new HandlingResult();
            result.Successed = false;
            if (e.Url.AbsoluteUri.Contains(_loginModel.LoginCondition))
            {
                result.Successed = true;
                if (_loginModel.ContainsCook)
                {
                    CookieInformation = GetCookieString(e.Url.AbsoluteUri);
                    XWebClient client = new XWebClient();
                    client.Headers.Add(HttpRequestHeader.Accept, "application/x-ms-application, image/jpeg, application/xaml+xml, image/gif, image/pjpeg, application/x-ms-xbap, */*");
                    client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/5.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; .NET4.0C; .NET4.0E)");
                    client.Headers.Add(HttpRequestHeader.Cookie, CookieInformation);
                }

                OnLoginHandler(result);
            }
        }
        #endregion
        #endregion
    }
}
