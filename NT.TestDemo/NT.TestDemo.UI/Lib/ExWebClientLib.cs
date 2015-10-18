using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NT.MultithreadingTaskService.UI.Lib
{
    public class ExWebClientLib:WebClient
    {
        #region Veriable
        public int TimeOut { get; set; }
        public bool TimeOutEnable = false;

        private static object _locker = new object();
        private CookieContainer cookieContainer;
        
        /// <summary>
        /// Cookie 容器
        /// </summary>
        public CookieContainer Cookies
        {
            get;
            set;
        }
        #endregion

        #region Function
        /// <summary>
        /// 创建带有 CookieContainer 的 HttpWebRequest。
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>8
        protected override WebRequest GetWebRequest(Uri address)
        {
            lock (_locker)
            {
                string ad = "";

                WebRequest request = base.GetWebRequest(new Uri(address.AbsoluteUri + ad));
                if (this.TimeOutEnable)
                {
                    request.Timeout = this.TimeOut;
                }

                if (request is HttpWebRequest)
                {
                    HttpWebRequest httpRequest = request as HttpWebRequest;
                    httpRequest.CookieContainer = this.cookieContainer; // 继承Cookies
                    httpRequest.ServicePoint.Expect100Continue = false; // 禁止协议版本握手 解决代理时的417
                    httpRequest.UseDefaultCredentials = true;
                    
                    // gzip, deflate
                    var gzip = httpRequest.Headers["Accept-Encoding"];
                    if (!string.IsNullOrEmpty(gzip))
                    {
                        if (gzip.Contains("gzip") || gzip.Contains("deflate"))
                        {
                            httpRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                        }
                    }
                }

                return request;
            }

        }
        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true; //总是接受 
        }
        #endregion
    }
}
