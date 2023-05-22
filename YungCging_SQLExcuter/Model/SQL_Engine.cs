using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YungCging_SQLExcuter.Interface;
using YungChing_TestHomeWork_Client.DataSet;

namespace YungCging_SQLExcuter.Model
{
    public class SQL_Engine : I_SQL_Engine
    {
        public Enum_Action Action_Flow { get; set; }
        public DataSet_User_CRUD UserData { get; set ; }
        public DataSet_ExcuteResult result { get ; set; }
        public SqlCommand SQL_Command { get; set; }

        public DataSet_ExcuteResult Set_SQL_Request_Info(Enum_Action Receive_Action_Flow, DataSet_User_CRUD Receive_UserData, string SQL_Command_Str)
        {
            Init_result();
            try
            {
                Action_Flow = Receive_Action_Flow;
                UserData = Receive_UserData;
                SQL_Command = new SqlCommand(SQL_Command_Str);

                result.Success = true;
                result.FeedBackMessage = "[SQL引擎]設置Request 資料成功。";
            }
            catch (Exception ex)
            {
                result.FeedBackMessage = "[SQL引擎]設置Request 資料錯誤。";
            }

            return result;
        }
        public DataSet_ExcuteResult Set_SQL_Parameter()
        {
            Init_result();
            /// @Account,@Password,@Name,@Age
            try
            {
                switch (Action_Flow)
                {
                    case Enum_Action.CREATEUSER:
                        SQL_Command.Parameters.AddWithValue("@Account", UserData.Account);
                        SQL_Command.Parameters.AddWithValue("@Password", UserData.Password);
                        SQL_Command.Parameters.AddWithValue("@Name", UserData.Name);
                        SQL_Command.Parameters.AddWithValue("@Age", UserData.Age);

                        break;
                    case Enum_Action.DELETEUSER:
                        break;
                    case Enum_Action.UPDATEUSER:
                        break;
                    case Enum_Action.READUSER:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                result.FeedBackMessage = "[SQL引擎]設置Request參數錯誤。";
            }
            return result;
        }
        public DataSet_ExcuteResult Excute_SQL_Request()
        {
            Init_result();

            throw new NotImplementedException();
        }

        public void Init_result()
        {
            result = new DataSet_ExcuteResult() { Success = false, FeedBackMessage = "" };
        }
    }
}
