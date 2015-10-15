using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace NT.TestDemo.Common.WebClientHelper
{
    public class XWebClient : WebClient
    {
        static private object Locker = new object();

        public int TimeOut { get; set; }
        public bool TimeOutEnable = false;

        static private bool Init = false;
        private CookieContainer cookieContainer;

        public XWebClient()
            : this(null, false, false, false, false)
        {
        }

        public XWebClient(CookieContainer cookieContainer)
            : this(cookieContainer, false, false, false, false)
        {
        }

        public XWebClient(bool addDefaultAccept, bool addDefaultContentType,
            bool addDefaultMiscellaneous, bool addDefaultUserAccept)
            : this(null, addDefaultAccept, addDefaultContentType, addDefaultMiscellaneous, addDefaultUserAccept)
        {
        }

        public XWebClient(CookieContainer cookieContainer, bool addDefaultAccept, bool addDefaultContentType,
            bool addDefaultMiscellaneous, bool addDefaultUserAccept)
        {
            if (cookieContainer == null)
            {
                this.cookieContainer = new CookieContainer();
            }
            else
            {
                this.cookieContainer = cookieContainer;
            }

            if (addDefaultAccept)
            {
                AddDefaultAccept();
            }
            if (addDefaultContentType)
            {
                AddDefaultContentType();
            }
            if (addDefaultMiscellaneous)
            {
                AddDefaultMiscellaneous();
            }
            if (addDefaultUserAccept)
            {
                AddDefaultUserAccept();
            }

            if (!Init)
            {
                Init = true;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
            }
        }

        public void AddDefaultAccept()
        {
            this.Headers.Add("Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
        }

        public void AddDefaultContentType()
        {
            this.Headers.Add("Content-Type:application/x-www-form-urlencoded; charset=UTF-8");
        }

        public void AddDefaultMiscellaneous()
        {
            this.Headers.Add("Referer:https://user.qunar.com/passport/login.jsp?ret=http%3A%2F%2Ffuwu.qunar.com%2Fuserpass/clean");
        }
        public void AddDefaultUserAccept()
        {
            this.Headers.Add("User-Agent: Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/30.0.1599.101 Safari/537.36");
        }

        /// <summary>
        /// Cookie 容器
        /// </summary>
        public CookieContainer Cookies
        {
            get;
            set;
        }

        /// <summary>
        /// 创建带有 CookieContainer 的 HttpWebRequest。
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        protected override WebRequest GetWebRequest(Uri address)
        {
            lock (Locker)
            {
                string ad = "";

                WebRequest request = base.GetWebRequest(new Uri(address.AbsoluteUri + ad));
                if (TimeOutEnable)
                {
                    request.Timeout = this.TimeOut;
                }
                if (request is HttpWebRequest)
                {
                    HttpWebRequest httpRequest = request as HttpWebRequest;

                    httpRequest.CookieContainer = cookieContainer;      //继承Cookies
                    httpRequest.ServicePoint.Expect100Continue = false; //禁止协议版本握手 解决代理时的417
                    httpRequest.UseDefaultCredentials = true;
                }
                return request;
            }

        }

        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true; //总是接受 
        }
    }
}
