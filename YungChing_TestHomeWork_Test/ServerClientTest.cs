using System.Text;
using YungChing_TestHomeWork_Client.Controller;
using YungChing_TestHomeWork_Client.DataSet;
using YungChing_TestHomeWork_Client.Model;

namespace YungChing_TestHomeWork_Client_Test
{
    [TestClass]
    public class ServerClientTest
    {
        #region 需要Server開啟服務

        [TestMethod]
        public void ConnectObjectTest()
        {
            Client_Controller client = Client_Controller.getInstance();
            client.SetConnectObject("127.0.0.1", 66666);
            client.SetConnectObject("127.0.0.1", 5050);
            client.Request_Action(new RequestAction_CreateUser());
            client.Refresh();
        }
        [TestMethod]
        public void RequestAction_NoSetConnectObject_Test()
        {
            Client_Controller client = Client_Controller.getInstance();
            client.Request_Action(new RequestAction_GetServerFilesFolderFilesName());
            client.Request_Action(new RequestAction_DownloadFile());
            client.Request_Action(new RequestAction_CreateUser());
            client.Refresh();
        }


        [TestMethod]
        public void ErrorServerIPPortConnectObjectTest()
        {
            Client_Controller client = Client_Controller.getInstance();
            client.SetConnectObject("127.0.0.1", 5050);
            client.Refresh();
        }
        [TestMethod]
        public void RequestAction_SetConnectObject_Test()
        {
            Client_Controller client = Client_Controller.getInstance();
            client.SetConnectObject("127.0.0.1", 5050);
            client.Request_Action(new RequestAction_CreateUser());
            client.Receive_ResponseRsult();
            client.Request_Action(new RequestAction_GetServerFilesFolderFilesName());
            client.Receive_ResponseRsult();
            client.Request_Action(new RequestAction_DownloadFile() { Content = "test2.txt" });
            client.Receive_ResponseRsult();
            client.Refresh();
        }

        [TestMethod]
        public void RequestAction_RequestActionGetServerFilesFolderFilesName_Test()
        {
            Client_Controller client = Client_Controller.getInstance();
            client.SetConnectObject("127.0.0.1", 5050);
            client.Request_Action(new RequestAction_GetServerFilesFolderFilesName());
            client.Receive_ResponseRsult();
            client.Refresh();
        }
        [TestMethod]
        public void RequestAction_FileRequest_Test()
        {
            Client_Controller client = Client_Controller.getInstance();
            client.SetConnectObject("127.0.0.1", 5050);
            client.Request_Action(new RequestAction_DownloadFile() { Content = "test.txt" });
            client.Receive_ResponseRsult();
            client.Refresh();
        }
        [TestMethod]
        public void RequestAction_DisConnect_Test()
        {
            Client_Controller client = Client_Controller.getInstance();
            client.SetConnectObject("127.0.0.1", 5050);
            client.Request_Action(new RequestAction_CreateUser());
            client.Receive_ResponseRsult();
            client.Refresh();
        }

        [TestMethod]
        public void RequestAction_ErrorCommand_Test()
        {
            Client_Controller client = Client_Controller.getInstance();
            client.SetConnectObject("127.0.0.1", 5050);
            client.ClientSocket.Send(Encoding.UTF8.GetBytes("sdaweqw qweas"));
            client.Receive_ResponseRsult();
            client.Refresh();
        }
        [TestMethod]
        public void RequestAction_CorrectCommand_Test()
        {
            Client_Controller client = Client_Controller.getInstance();
            client.SetConnectObject("127.0.0.1", 5050);
            client.ClientSocket.Send(Encoding.UTF8.GetBytes("GETSERVERFILESFOLDERFILESNAME"));
            client.Receive_ResponseRsult();
            client.Refresh();
        }
        #region YC Design

        #endregion 
        #endregion



        [TestMethod]
        public void RefreshTest()
        {
            Client_Controller client = Client_Controller.getInstance();
            client.Refresh();
        }
    }
}