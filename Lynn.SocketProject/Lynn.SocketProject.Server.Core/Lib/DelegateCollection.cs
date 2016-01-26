using System;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace Lynn.SocketProject.Server.Core.Lib
{
    public delegate void AddMessageDelegate(String message);
    public delegate void AddMessageToControlDelegate(RichTextBox sender, String message);

    public delegate void UpdateDataSourceDelegate();

    public delegate void ClearTextDelegate(Control sender);

    public delegate void SetTextDelegate(Control sender, String text, Boolean append = false);
}