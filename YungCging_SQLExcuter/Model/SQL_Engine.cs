using Newtonsoft.Json;
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
                result.FeedBackMessage = "[SQL引擎]設置 Request 資料成功。";
            }
            catch (Exception ex)
            {
                result.FeedBackMessage = "[SQL引擎]設置 Request 資料錯誤。";
            }

            return result;
        }
        public DataSet_ExcuteResult Set_SQL_Parameter()
        {
            Init_result();
            result.Success = true;
            result.FeedBackMessage = "[SQL引擎]設置 SQL_Command 參數成功";
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
                        SQL_Command.Parameters.AddWithValue("@Account", UserData.Account);
                        break;
                    case Enum_Action.UPDATEUSER:
                        SQL_Command.Parameters.AddWithValue("@Account", UserData.Account);
                        SQL_Command.Parameters.AddWithValue("@Password", UserData.Password);
                        SQL_Command.Parameters.AddWithValue("@Name", UserData.Name);
                        SQL_Command.Parameters.AddWithValue("@Age", UserData.Age);
                        break;
                    case Enum_Action.READUSER:
                        SQL_Command.Parameters.AddWithValue("@Account", UserData.Account);
                        break;
                    default:
                        result.Success = false;
                        result.FeedBackMessage = "[SQL引擎]設置 SQL_Command 參數失敗。\r\n錯誤原因：Can't find Action_Flow";
                        break;
                }
                return result;
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
            result.Success = true;
            result.FeedBackMessage = "[SQL引擎]SQL執行成功..Split..";
            try
            {
                switch (Action_Flow)
                {
                    case Enum_Action.CREATEUSER:
                        ExcuteNonQuery();
                        break;
                    case Enum_Action.DELETEUSER:
                        ExcuteNonQuery();
                        break;
                    case Enum_Action.UPDATEUSER:
                        ExcuteNonQuery();
                        break;
                    case Enum_Action.READUSER:
                        ExecuteReader();
                        break;
                    default:
                        result.Success = false;
                        result.FeedBackMessage = "[SQL引擎]設置 SQL_Command 參數失敗。\r\n錯誤原因：Can't find Action_Flow";
                        break;
                }
            }
            catch (Exception ex)
            {
                result.FeedBackMessage = "[SQL引擎]SQL執行失敗";
            }
            return result;
        }

        public void Init_result()
        {
            result = new DataSet_ExcuteResult() { Success = false, FeedBackMessage = "" };
        }

        public void ExcuteNonQuery()
        {
            SQL_Command.Connection = new SqlConnection(string.Format("Data Source=127.0.0.1;Initial Catalog=AirLife;User ID=YC;Password=as123456;Application Name=testAP")); ///先寫死
            SQL_Command.Connection.Open();
            if(SQL_Command.ExecuteNonQuery() >= 1)
            {
                result.FeedBackMessage += "資料已成功修改。";
            }
            else
            {
                result.Success = false;
                result.FeedBackMessage = "[SQL引擎]SQL執行成功，資料尚未異動。";
            }
            SQL_Command.Connection.Close();
        }

        public void ExecuteReader()
        {
            SqlConnection conn = new SqlConnection(string.Format("Data Source=127.0.0.1;Initial Catalog=AirLife;User ID=YC;Password=as123456;Application Name=testAP")); ///先寫死
            conn.Open();

            SQL_Command.Connection = new SqlConnection(string.Format("Data Source=127.0.0.1;Initial Catalog=AirLife;User ID=YC;Password=as123456;Application Name=testAP")); ///先寫死
            SQL_Command.Connection.Open();
            SqlDataReader reader = SQL_Command.ExecuteReader();

            List<DataSet_User_CRUD> List_User_Data = new List<DataSet_User_CRUD>();

            while (reader.Read())
            {
                DataSet_User_CRUD Temp_User_Data = new DataSet_User_CRUD();
                Temp_User_Data.Account = reader["account"].ToString();
                Temp_User_Data.Password = reader["password"].ToString();
                Temp_User_Data.Name = reader["name"].ToString();
                Temp_User_Data.Age = reader["age"].ToString();
                List_User_Data.Add(Temp_User_Data);
            }
            reader.Close();
            SQL_Command.Connection.Close();

            result.FeedBackMessage += JsonConvert.SerializeObject(List_User_Data);
        }


        #region Singleton
        public static SQL_Engine Instance = new SQL_Engine();
        public static SQL_Engine getInstance()
        {
            return Instance;
        }
        private SQL_Engine()
        {

        }
        #endregion
    }
}
