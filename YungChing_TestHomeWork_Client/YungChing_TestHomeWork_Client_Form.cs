using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YungChing_TestHomeWork_Client.Controller;
using YungChing_TestHomeWork_Client.DataSet;
using YungChing_TestHomeWork_Client.Model;

namespace YungChing_TestHomeWork_Client
{
    public partial class YungChing_TestHomeWork_Client_Form : Form
    {

        private void Connect_Server_Button_Click(object sender, EventArgs e)
        {
            byte[] receive_buffer = new byte[1024];
            /// 需再寫防呆
            try
            {
                if(Client_Controller.getInstance().SetConnectObject(Server_IP_Textbox.Text, int.Parse(Server_Port_Textbox.Text)).Success)
                {
                    UpdateConsoleLog_Method(string.Format("伺服器訊息：{0}", "已成功連入伺服器"));

                    Connected_OnButton();
                }
                else
                {
                    UpdateConsoleLog_Method(string.Format("伺服器訊息：{0}", "發生問題請檢查連線"));

                }
            }
            catch (Exception ex)
            {
                UpdateConsoleLog_Method(string.Format("伺服器訊息：{0}", ex.Message));
            }
        }
        private void DisConnect_Server_Button_Click(object sender, EventArgs e)
        {
            DataSet_ExcuteResult result = new DataSet_ExcuteResult();
            try
            {
                result = Client_Controller.getInstance().Request_Action(new RequestAction_CreateUser());

                if (result.Success)
                {
                    result = Client_Controller.getInstance().Receive_ResponseRsult();
                    Client_Controller.getInstance().Refresh();
                    UpdateConsoleLog_Method(string.Format("伺服器訊息：{0}", result.FeedBackMessage));

                    DisConnect_OffButton();

                }

            }
            catch (Exception ex)
            {
                Refresh();
                DisConnect_OffButton();
                UpdateConsoleLog_Method(string.Format("伺服器訊息：{0}，{1}", "已自動斷開連線",ex.Message));
            }
        }
        private void Send_Request_DownloadFile_Button_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet_ExcuteResult result = Client_Controller.getInstance().Request_Action(new RequestAction_DeleteUser());
                if (result.Success)
                {
                    result = Client_Controller.getInstance().Receive_ResponseRsult();
                    if(result.Success)
                    {
                        UpdateConsoleLog_Method(string.Format("伺服器訊息：{0}", "已成功下載檔案"));
                        this.Request_FileName_Textbox.Text = result.FeedBackMessage.Split(' ')[0];
                        this.Request_SaveFilePath_Textbox.Text = result.FeedBackMessage.Split(' ')[1];
                    }
                    else
                    {
                        UpdateConsoleLog_Method(string.Format("伺服器訊息：{0}", result.FeedBackMessage));
                    }

                }
            }
            catch (Exception ex)
            {
                UpdateConsoleLog_Method(string.Format("伺服器訊息：{0}", ex.Message));
            }
        }
        #region Delegate

        public delegate void UpdateConsoleLog(string log);
        UpdateConsoleLog UpdateLog = new UpdateConsoleLog(DelegateUpdateLog);
        UpdateConsoleLog UpdateRequestSaveFilePath = new UpdateConsoleLog(DelegateUpdateRequestSaveFilePath);

        public static void UpdateConsoleLog_Method(string log)
        {
            Instance.BeginInvoke(new UpdateConsoleLog(DelegateUpdateLog), log);
        }
        public static void DelegateUpdateLog(string log)
        {
            Instance.ConsoleLog_Textbox.Text += string.Format("{0}\r\n", log);
        }
        public static void UpdateRequestSaveFilePath_Method(string log)
        {
            Instance.BeginInvoke(new UpdateConsoleLog(DelegateUpdateRequestSaveFilePath), log);
        }
        public static void DelegateUpdateRequestSaveFilePath(string log)
        {
            Instance.Request_GetServerFilesFolderFilesName_Textbox.Text += string.Format("{0}\r\n", log);
        }
        #endregion
        #region Singleton

        public static YungChing_TestHomeWork_Client_Form Instance = new YungChing_TestHomeWork_Client_Form();
        public static YungChing_TestHomeWork_Client_Form getInstance()
        {
            return Instance;
        }
        private YungChing_TestHomeWork_Client_Form()
        {
            InitializeComponent();
        }
        #region YC Design

        #endregion 
        #endregion

        private void Send_Get_Server_FilesFolder_FilesName_Button_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet_ExcuteResult result = Client_Controller.getInstance().Request_Action(new RequestAction_UpdateUser());
                if (result.Success)
                {
                    result = Client_Controller.getInstance().Receive_ResponseRsult();
                    UpdateRequestSaveFilePath_Method(string.Format("<<成功獲取>>\r\n{0}\r\n", result.FeedBackMessage));
                    UpdateConsoleLog_Method(string.Format("伺服器訊息：{0}", "已獲取下載目錄底下所有檔案名稱"));

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Default_GetFile_Request_button_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet_ExcuteResult result = Client_Controller.getInstance().Request_Action(new RequestAction_DeleteUser());
                result = Client_Controller.getInstance().Receive_ResponseRsult();
                if (result.Success)
                {
                    UpdateConsoleLog_Method(string.Format("伺服器訊息：{0}", "已成功下載檔案"));
                    this.Request_FileName_Textbox.Text = result.FeedBackMessage.Split(' ')[0];
                    this.Request_SaveFilePath_Textbox.Text = result.FeedBackMessage.Split(' ')[1];
                }
                else
                {
                    UpdateConsoleLog_Method(string.Format("伺服器訊息：{0}", result.FeedBackMessage));
                }
            }
            catch (Exception ex)
            {
                UpdateConsoleLog_Method(string.Format("伺服器訊息：{0}", ex.Message));
            }
        }

        private void Send_Request_Command_Button_Click(object sender, EventArgs e)
        {
            try
            {
                
                Client_Controller.getInstance().ClientSocket.Send(Encoding.UTF8.GetBytes(Command_Textbox.Text.ToUpper()));
                DataSet_ExcuteResult result = Client_Controller.getInstance().Receive_ResponseRsult();
                if (result.Success)
                {
                    UpdateConsoleLog_Method(string.Format("伺服器訊息：{0}", result.FeedBackMessage));
                    if (Command_Textbox.Text.ToUpper().Contains("DOWNLOADFILE"))
                    {
                        this.Request_FileName_Textbox.Text = result.FeedBackMessage.Split(' ')[0];
                        this.Request_SaveFilePath_Textbox.Text = result.FeedBackMessage.Split(' ')[1];
                    }

                }
                else
                {
                    UpdateConsoleLog_Method(string.Format("伺服器訊息：{0}", result.FeedBackMessage));
                }
            }
            catch (Exception ex)
            {
                UpdateConsoleLog_Method(string.Format("伺服器訊息：{0}", ex.Message));
            }
        }
        public void Connected_OnButton()
        {
            DisConnect_Server_Button.Enabled = true;
            Send_Request_Command_Button.Enabled = true;
            Send_Request_DownloadFile_Button.Enabled = true;
            Send_Get_Server_FilesFolder_FilesName_Button.Enabled = true;
            Default_GetFile_Request_button.Enabled = true;
            Connect_Server_Button.Enabled = false;
        }
        public void DisConnect_OffButton()
        {
            DisConnect_Server_Button.Enabled = false;
            Send_Request_Command_Button.Enabled = false;
            Send_Request_DownloadFile_Button.Enabled = false;
            Send_Get_Server_FilesFolder_FilesName_Button.Enabled = false;
            Default_GetFile_Request_button.Enabled = false;
            Connect_Server_Button.Enabled = true;
        }
    }
}
