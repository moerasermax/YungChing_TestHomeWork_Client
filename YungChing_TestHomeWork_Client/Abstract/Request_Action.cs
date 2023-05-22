using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YungChing_TestHomeWork_Client.DataSet;
using YungChing_TestHomeWork_Client.Interface;

namespace YungChing_TestHomeWork_Client.Abstract
{
    public abstract class Request_Action : I_Request_Action
    {
        public Enum_Action Action_Flow { get; set; }
        public string Content { get ; set; }
        public DataSet_User_CRUD UserData { get ; set; }
        public abstract string Get_Reqeust_Command();
    }
}
