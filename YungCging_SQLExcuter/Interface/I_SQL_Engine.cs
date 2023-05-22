using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YungChing_TestHomeWork_Client.DataSet;

namespace YungCging_SQLExcuter.Interface
{
    public interface I_SQL_Engine
    {
        Enum_Action Action_Flow { get; set; }
        DataSet_User_CRUD UserData { get; set; }
        DataSet_ExcuteResult result { get; set; }

        void Init_result();
        DataSet_ExcuteResult Set_SQL_Request_Info(Enum_Action Receive_Action_Flow, DataSet_User_CRUD Receive_UserData, string SQL_Command_Str);
        DataSet_ExcuteResult Set_SQL_Parameter();
        DataSet_ExcuteResult Excute_SQL_Request();

        SqlCommand SQL_Command { get; set; } 
        


    }
}
