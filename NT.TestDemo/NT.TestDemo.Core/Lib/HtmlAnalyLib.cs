using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HtmlAgilityPack;

namespace NT.TestDemo.Core.Lib
{
    public class HtmlAnalyLib
    {
        public void AnalyHtml(String path)
        {
            String html = File.ReadAllText(path);
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            HtmlNode tabhn = doc.DocumentNode.SelectSingleNode("/html/body/div/div[2]/div/div[2]/div/table/tbody");
            if (tabhn != null && tabhn.HasChildNodes)
            {
                foreach (var hntr in tabhn.ChildNodes)
                {
                    if (hntr.HasChildNodes)
                    {
                        String text = hntr.ChildNodes[7].InnerText;
                    }
                }
            }
        }
    }
}
