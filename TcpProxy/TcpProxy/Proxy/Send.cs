using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpProxy.Proxy
{
    public class Send
    {
        public static void Data(System.Net.Sockets.Socket SocketValue, byte[] buffer)
        {
            SocketValue.Send(buffer, 0, buffer.Length, System.Net.Sockets.SocketFlags.None);

        }
        public static void Data(System.Net.Sockets.Socket SocketValue, byte[] buffer, int received)
        {
            //This function is a overload
            //for some reason I cannot send using buffer.Length, only using received which is int.
            SocketValue.Send(buffer, 0, received, System.Net.Sockets.SocketFlags.None);
        }
    }
}
