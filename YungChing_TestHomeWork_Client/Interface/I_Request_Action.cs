using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YungChing_TestHomeWork_Client.DataSet;

namespace YungChing_TestHomeWork_Client.Interface
{
    public interface I_Request_Action
    {
        Enum_Action Action_Flow { get; set; }
        string Content { get; set; }
        DataSet_User_CRUD UserData { get; set; }
        string Get_Reqeust_Command();
    }
}
