using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using YungChing_TestHomeWork_Client.DataSet;

namespace YungChing_TestHomeWork_Client.Interface
{
    public interface I_Request
    {
        IPAddress IP { get; set; }
        int Port { get; set; }
        Socket ClientSocket { get; set; }
        IPEndPoint ClientIPEndPoint { get; set; }
        DataSet_ExcuteResult Send_Request_Command(I_Request_Action Request_Object);
        DataSet_ExcuteResult Set_ClientSocket();
        DataSet_ExcuteResult Set_IPEndPoint(string IP, int Port);
        byte[] CommandToByte(string command);
    }
}
