using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using YungChing_TestHomeWork_Client.DataSet;
using YungChing_TestHomeWork_Client.Interface;
using YungChing_TestHomeWork_Client.Model;

namespace YungChing_TestHomeWork_Client.Controller
{
    public class Client_Controller : Request
    {

        public DataSet_ExcuteResult SetConnectObject(string IP, int port)
        {
            DataSet_ExcuteResult result = new DataSet_ExcuteResult();
            try
            {
                if (0 < port && port < 65535)
                {
                    Set_IPEndPoint(IP, port);
                    Set_ClientSocket();
                    TestConnect();


                    result.Success = true;
                    result.FeedBackMessage = "設置 連線物件 成功";
                }
                else
                {
                    result.Success = false;
                    result.FeedBackMessage = "請確認 Port 的設置是否正常";
                }
            }
            catch (Exception)
            {
                throw new Exception("設置 連線物件 失敗，請檢查 Server IP, Port 是否正確以及檢查伺服器是否開啟");
            }
            return result;
        }

        public void TestConnect()
        {
            try
            {
                ClientSocket.Connect(ClientIPEndPoint);
                int receiveLength = Client_Controller.getInstance().ClientSocket.Receive(new byte[1024]);
            }
            catch (Exception)
            {
                throw new Exception("測試連線時發生問題");
            }

        }


        public DataSet_ExcuteResult Request_Action(I_Request_Action RequestAction_Object)
        {
            DataSet_ExcuteResult result = new DataSet_ExcuteResult();

            if (this.ClientSocket != null)
            {
                switch (RequestAction_Object.Action_Flow)
                {
                    case Enum_Action.ADDUSER:
                        return Send_Request_Command(RequestAction_Object);
                    case Enum_Action.REMOVEUSER:
                        return Send_Request_Command(RequestAction_Object);
                    case Enum_Action.READUSER:
                        return Send_Request_Command(RequestAction_Object);
                    case Enum_Action.UPDATEUSER:
                        result.Success = false;
                        result.FeedBackMessage = "Can't find Action_Flow";
                        break;
                    default:
                        result.Success = false;
                        result.FeedBackMessage = "Can't find Action_Flow";
                        break;
                }
            }
            else
            {
                result.Success = false;
                result.FeedBackMessage = "連線物件設置錯誤";
            }
            return result;
        }

        public void Refresh()
        {
            this.ClientIPEndPoint = null;
            this.ClientSocket = null;
            GC.Collect();
        }

        public DataSet_ExcuteResult Receive_ResponseRsult()
        {
            DataSet_ExcuteResult result = new DataSet_ExcuteResult();
            try
            {
                byte[] ReceiveBuffer = new byte[20000];
                int ReceiveBufferLength = this.ClientSocket.Receive(ReceiveBuffer);

                if (ReceiveBufferLength > 0)
                {
                    Deserialization_Result.getInstance().Result.Data_Buffer = new byte[ReceiveBuffer.Length];
                    Deserialization_Result.getInstance().Set_ReceiveResult(ReceiveBuffer);
                    Deserialization_Result.getInstance().Get_FileBytePack();
                    Deserialization_Result.getInstance().Get_FeedBackMessage();
                    Deserialization_Result.getInstance().Get_ActionFlow();
                    return Query_ReceiveProcess();
                }
                else
                {
                    result.Success = false;
                    result.FeedBackMessage = "解析封包 失敗";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public DataSet_ExcuteResult Query_ReceiveProcess()
        {
            DataSet_ExcuteResult result = new DataSet_ExcuteResult();
            switch (Deserialization_Result.getInstance().Action_Flow)
            {
                case Enum_Action.CREATEUSER:
                    return Deserialization_Result.getInstance().Query_Action_Process(new ReceiveProcess_GetFilesInCurrentFolder());
                case Enum_Action.REMOVEUSER:
                    return Deserialization_Result.getInstance().Query_Action_Process(new ReceiveProcess_DownloadFile());
                case Enum_Action.READUSER:
                    return Deserialization_Result.getInstance().Query_Action_Process(new ReceiveProcess_CloseConnect());
                case Enum_Action.UPDATEUSER:
                    result.Success = false;
                    result.FeedBackMessage = "Can't find Action_Flow";
                    break;
                default:
                    result.Success = false;
                    result.FeedBackMessage = "Can't find Action_Flow";
                    break;
            }
            return result;
        }

        #region Singleton

        private Client_Controller()
        {

        }

        public static Client_Controller Instance = new Client_Controller();
        public static Client_Controller getInstance()
        {
            return Instance;
        }

        #endregion

    }
}


