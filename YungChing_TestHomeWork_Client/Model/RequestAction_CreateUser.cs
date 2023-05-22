using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YungChing_TestHomeWork_Client.Abstract;
using YungChing_TestHomeWork_Client.Controller;
using YungChing_TestHomeWork_Client.DataSet;

namespace YungChing_TestHomeWork_Client.Model
{
    public class RequestAction_CreateUser : Request_Action
    {
        
        public override string Get_Reqeust_Command(DataSet_User_CRUD UserData)
        {
            Action_Flow = Enum_Action.CREATEUSER;
            return string.Format("{0}..Split..{1}..Split..{2}", Enum_Action.CREATEUSER, "INSERT INTO [YungChing_TestHomework].[dbo].[User] VALUES(@Account,@Password,@Name,@Age);", JsonConvert.SerializeObject(UserData));
        }
    }
}
