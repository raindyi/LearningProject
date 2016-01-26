using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Lynn.SocketProject.Server.Core.Model
{
    [StructLayout(LayoutKind.Sequential)]
    public class ClientInformation
    {
        public IntPtr ConnId { get; set; }
        public String IpAddress { get; set; }
        public ushort Port { get; set; }

        public String GetFullAddress()
        {
            return String.Format("{0}:{1}", IpAddress, Port);
        }
    }
}
