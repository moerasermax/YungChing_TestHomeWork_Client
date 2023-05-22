using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using YungChing_TestHomeWork_Client.DataSet;
using YungChing_TestHomeWork_Client.Interface;

namespace YungChing_TestHomeWork_Client.Model
{
    public class Request : I_Request
    {
        public Socket ClientSocket { get; set; }
        public IPAddress IP { get; set; }
        public int Port { get; set; }
        public IPEndPoint ClientIPEndPoint { get; set; }

        public DataSet_ExcuteResult Set_IPEndPoint(string IP, int Port)
        {
            DataSet_ExcuteResult result = new DataSet_ExcuteResult();
            try
            {
                this.IP = IPAddress.Parse(IP);
                this.Port = Port;
                this.ClientIPEndPoint = new IPEndPoint(this.IP, this.Port);

                result.Success = true;
                result.FeedBackMessage = "設置 IPEndPoint 成功";
            }
            catch (Exception)
            {
                throw new Exception("設置 IPEndPoint 失敗");
            }
            return result;
        }
        public DataSet_ExcuteResult Set_ClientSocket()
        {
            DataSet_ExcuteResult result = new DataSet_ExcuteResult();
            try
            {
                ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                result.Success = true;
                result.FeedBackMessage = string.Format("設置 ClientSokect物件 成功");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.FeedBackMessage = ex.Message;
            }
            return result;
        }
        public DataSet_ExcuteResult Send_Request_Command(I_Request_Action Request_Object)
        {
            DataSet_ExcuteResult result = new DataSet_ExcuteResult();

            try
            {
                this.ClientSocket.Send(CommandToByte(Request_Object.Get_Reqeust_Command()));
                result.Success = true;
                result.FeedBackMessage = "發送 指令 完成";
            }
            catch (Exception ex)
            {
                throw new Exception("發送 指令 錯誤 \r\n 原因："+ex.Message);
            }
            return result;

        }
        public byte[] CommandToByte(string command)
        {
            try
            {
                return Encoding.UTF8.GetBytes(command);
            }
            catch (Exception)
            {
                throw new Exception("轉換 指令物件 錯誤");
            }
        }



    }
}
