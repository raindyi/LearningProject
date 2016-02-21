using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NT.TestDemo.Core.Lib
{
    public class RegexLib
    {
        public RegexLib()
        {
        }

        public Int32 Match(String source)
        {
            //Regex reg = new Regex(@"【\w*<aw>】尾号为[0-9]*<cardno>的卡已为\w*<name>\(票号[0-9]*<ticketno>\)",RegexOptions.Compiled|RegexOptions.IgnoreCase);
            Regex reg = new Regex(@"已[为\/]{1,}(?<name>\w*)（票号", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matchs = reg.Matches(source);
            foreach (Match mat in matchs)
            {
                String result = mat.Result("${name}");
            }
            return matchs.Count;
        }
    }
}
