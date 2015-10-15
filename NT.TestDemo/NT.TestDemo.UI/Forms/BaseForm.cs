using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT.MultithreadingTaskService.UI.Forms
{
    public class BaseForm :Form
    {
        public Boolean Fixable { get; set; }
        public BaseForm()
        {
            Fixable = true;
        }
        protected override void WndProc(ref Message m)
        {
            if (Fixable)
            {
                const int WM_SYSCOMMAND = 0x112;
                const int SC_CLOSE = 0xf060; //关闭  
                const int SC_MINSIZE = 0xf020; //最大化  
                const int SC_MAXISIZE = 0xf030; //最小化  
                const int SC_NORMAL = 0xf120; //还原  
                const int SC_DOUBLECLICK = 0xf122; //双击窗体标题栏  
                if ((m.Msg == WM_SYSCOMMAND) && ((int) m.WParam == SC_CLOSE)) //关闭  
                {
                    return;
                }
                if ((m.Msg == WM_SYSCOMMAND) && ((int) m.WParam == SC_MAXISIZE)) //最大化  
                {
                    return;
                }
                if ((m.Msg == WM_SYSCOMMAND) && ((int) m.WParam == SC_MINSIZE)) //最小化  
                {
                    return;
                }
                if ((m.Msg == WM_SYSCOMMAND) && ((int) m.WParam == SC_NORMAL)) //还原  
                {
                    return;
                }
                if ((m.Msg == WM_SYSCOMMAND) && ((int) m.WParam == SC_DOUBLECLICK)) ///双击窗体标题栏  
                {
                    return;
                }
            }
            base.WndProc(ref m);
        }
    }
}
