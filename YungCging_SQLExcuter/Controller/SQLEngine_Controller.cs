using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YungCging_SQLExcuter.Model;
using YungChing_TestHomeWork_Client.DataSet;

namespace YungCging_SQLExcuter.Controller
{
    public  class SQLEngine_Controller
    {
        public DataSet_ExcuteResult SetDataInfo(Enum_Action Receive_Action_Flow, DataSet_User_CRUD Receive_UserData, string SQL_Command_Str)
        {
            return SQL_Engine.getInstance().Set_SQL_Request_Info(Receive_Action_Flow, Receive_UserData, SQL_Command_Str);
        }

        public DataSet_ExcuteResult SetSQLParameter()
        {
            return SQL_Engine.getInstance().Set_SQL_Parameter();
        }

        public DataSet_ExcuteResult ExcuteSQLCommand()
        {
            return SQL_Engine.getInstance().Excute_SQL_Request();
        }

        #region Singleton

        public static SQLEngine_Controller Instance = new SQLEngine_Controller();
        public static SQLEngine_Controller getInstance()
        {
            return Instance;
        }
        private SQLEngine_Controller()
        {

        }
        #endregion

    }
}
