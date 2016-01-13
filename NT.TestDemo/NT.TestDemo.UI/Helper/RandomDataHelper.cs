using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT.TestDemo.UI.Helper
{
    public class RandomDataHelper
    {
        /// <summary>
        /// Account Summary
        /// </summary>
        /// <returns></returns>
        public DataTable GetRandomReportData1()
        {
            DataTable dt=new DataTable();
            dt.Columns.Add(new DataColumn("Account", typeof (String)));
            dt.Columns.Add(new DataColumn("Summary", typeof(Int32)));
            Random r = new Random();
            for (Int32 i = 1; i <= 20; i++)
            {
                DataRow dr = dt.NewRow();
                Int32 mod = i%20;
                String acc = "";
                switch (mod)
                {
                    case 1:
                    {
                        acc = "Mali";
                        break;
                    }
                    case 2:
                    {
                        acc = "Bill";
                        break;
                    }
                    case 3:
                    {
                        acc = "Cook";
                        break;
                    }
                    case 4:
                    {
                        acc = "Jobs";
                        break;
                    }
                    case 5:
                    {
                        acc = "Jack";
                        break;
                    }
                    case 6:
                    {
                        acc = "Sera";
                        break;
                    }
                    case 7:
                    {
                        acc = "July";
                        break;
                    }
                    case 8:
                    {
                        acc = "Aron";
                        break;
                    }
                    case 9:
                    {
                        acc = "Vcter";
                        break;
                    }
                    case 10:
                    {
                        acc = "Holo";
                        break;
                    }
                    case 11:
                    {
                        acc = "Steven";
                        break;
                    }
                    case 12:
                    {
                        acc = "Dora";
                        break;
                    }
                    case 13:
                    {
                        acc = "Will";
                        break;
                    }
                    case 14:
                    {
                        acc = "Jim";
                        break;
                    }
                    case 15:
                    {
                        acc = "Philie";
                        break;
                    }
                    case 16:
                    {
                        acc = "Aline";
                        break;
                    }
                    case 17:
                    {
                        acc = "Nieo";
                        break;
                    }
                    case 18:
                    {
                        acc = "Frank";
                        break;
                    }
                    case 19:
                    {
                        acc = "Orio";
                        break;
                    }
                    default:
                    {
                        acc = "Tom";
                        break;
                    }
                }
                dr["Account"] = acc;
                dr["Summary"] = r.Next(1, 3000);
                dt.Rows.Add(dr);
            }
            return dt;
        }
        /// <summary>
        /// Account X Y Z
        /// </summary>
        /// <returns></returns>
        public DataTable GetRandomReportData2()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Account", typeof(String)));
            dt.Columns.Add(new DataColumn("SQ", typeof(Int32)));
            dt.Columns.Add(new DataColumn("X", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Y", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Z", typeof(Int32)));
            Random r = new Random();
            for (Int32 i = 1; i <= 10; i++)
            {
                DataRow dr = dt.NewRow();
                Int32 mod = i % 10;
                String acc = "";
                switch (mod)
                {
                    case 1:
                        {
                            acc = "Mali";
                            break;
                        }
                    case 2:
                        {
                            acc = "Bill";
                            break;
                        }
                    case 3:
                        {
                            acc = "Cook";
                            break;
                        }
                    case 4:
                        {
                            acc = "Jobs";
                            break;
                        }
                    case 5:
                        {
                            acc = "Jack";
                            break;
                        }
                    case 6:
                        {
                            acc = "Sera";
                            break;
                        }
                    case 7:
                        {
                            acc = "July";
                            break;
                        }
                    case 8:
                        {
                            acc = "Aron";
                            break;
                        }
                    case 9:
                        {
                            acc = "Vcter";
                            break;
                        }
                    default:
                        {
                            acc = "Tom";
                            break;
                        }
                }
                dr["Account"] = acc;
                dr["SQ"] = i;
                dr["X"] = r.Next(1, 2000);
                dr["Y"] = r.Next(1, 3000);
                dr["Z"] = r.Next(1, 1000);
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
