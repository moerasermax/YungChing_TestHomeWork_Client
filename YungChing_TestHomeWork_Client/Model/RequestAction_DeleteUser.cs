using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YungChing_TestHomeWork_Client.Abstract;
using YungChing_TestHomeWork_Client.DataSet;

namespace YungChing_TestHomeWork_Client.Model
{
    public class RequestAction_DeleteUser : Request_Action
    {
        
        public override string Get_Reqeust_Command(DataSet_User_CRUD UserData)
        {
            throw (new NotImplementedException());

        }
        public RequestAction_DeleteUser(string content = "test.txt") /// 設定初始值
        {
        }
    }
}
