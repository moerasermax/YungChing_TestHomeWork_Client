using Newtonsoft.Json;
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
        
        public override string Get_Reqeust_Command()
        {
            if (UserData != null)
            {
                if(UserData.Account != null)
                {
                    return string.Format("{0}..Split..{1}..Split..{2}", Enum_Action.DELETEUSER, "DELETE FROM [YungChing_TestHomework].[dbo].[User] WHERE account = @Account;", JsonConvert.SerializeObject(UserData));
                }
                else
                {
                    throw new Exception("請設置 UserData 的 Account");
                }
            }
            else
            {
                throw new Exception("請設置 UserData ");
            }
        }
        public RequestAction_DeleteUser()
        {
            Action_Flow = Enum_Action.DELETEUSER;
        }

    }
}
