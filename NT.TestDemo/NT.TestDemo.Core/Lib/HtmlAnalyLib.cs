using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NT.TestDemo.Core.Model;

namespace NT.TestDemo.Core.Lib
{
    public class HtmlAnalyLib
    {
        public void AnalyHtml(String path)
        {
            String html = File.ReadAllText(path);
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            //html/body/div[2]/div[2]/div/div[2]/form[2]/table/tbody
            HtmlNode trhn = doc.DocumentNode.SelectSingleNode("html/body/div[1]/div[2]/div/div[2]/table/tbody/tr");
            if (trhn != null && trhn.HasChildNodes)
            {
                String rete = trhn.ChildNodes[9].InnerText.Trim();
                String rare= trhn.ChildNodes[11].InnerText.Trim();
            }
            

            //List<FareModel> models = new List<FareModel>();
            //if (tabhn != null && tabhn.HasChildNodes)
            //{
            //    foreach (var hntr in tabhn.ChildNodes)
            //    {
            //        if (hntr.HasChildNodes)
            //        {
            //            try
            //            {
            //                FareModel model = new FareModel();
            //                model.AW = hntr.ChildNodes[9].InnerText.Trim();
            //                model.ArrCode = hntr.ChildNodes[11].InnerText.Trim();
            //                model.DepCode = hntr.ChildNodes[13].InnerText.Trim();
            //                model.Cabin = hntr.ChildNodes[17].InnerText.Trim();
            //                model.ExportId = hntr.ChildNodes[7].InnerText.Trim();
            //                model.FareCode = hntr.ChildNodes[5].InnerText.Trim();
            //                String sd = hntr.ChildNodes[19].InnerText.Trim();
            //                if (!sd.Contains("至"))
            //                {
            //                    model.StartSDate = DateTime.Parse(hntr.ChildNodes[19].InnerText.Trim());
            //                }
            //                else
            //                {
            //                    String[] dtstr = sd.Split(new string[] { "至" }, StringSplitOptions.RemoveEmptyEntries);
            //                    model.StartSDate = DateTime.Parse(dtstr[0]);
            //                    model.StartFDate = DateTime.Parse(dtstr[1]);
            //                    //break;
            //                }
            //                String fd = hntr.ChildNodes[21].InnerText.Trim();
            //                if (!sd.Contains("至"))
            //                {
            //                    model.FinishSDate = DateTime.Parse(hntr.ChildNodes[21].InnerText.Trim());
            //                }
            //                else
            //                {
            //                    String[] dtstr = sd.Split(new string[] { "至" }, StringSplitOptions.RemoveEmptyEntries);
            //                    model.FinishSDate = DateTime.Parse(dtstr[0]);
            //                    model.FinishFDate = DateTime.Parse(dtstr[1]);
            //                    //break;
            //                }
            //                model.FlightNo = hntr.ChildNodes[35].InnerText.Trim();
            //                model.TicketPrice = Int32.Parse(hntr.ChildNodes[43].InnerText.Trim());
            //                models.Add(model);
            //            }
            //            catch (Exception ex)
            //            {
            //                //_log.Error("解析政策列表数据异常", ex);
            //                continue;
            //            }
            //        }
            //    }
            //}
            HtmlNode pagehn= doc.GetElementbyId("J_Pagination");
            HtmlNode sphn = pagehn.NextSibling.NextSibling;
            String sp = sphn.InnerText.Trim();
            String[] sps= sp.Split(new char[] {'(', ')'});
            var jsobj= JsonConvert.DeserializeObject(sps[4].Trim().Replace("\"",""));
            JObject jobj = (JObject) jsobj;
        }
    }
}
