using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YungChing_TestHomeWork_Client.DataSet;

namespace YungChing_TestHomeWork_Client.Interface
{
    public interface I_Receive_Process
    {
        string FeedBackMessage { get; set; }
        byte[] FileBytesbuffer { get; set; }
        DataSet_ExcuteResult Excute_Specific_Method(DataSet_User_CRUD UserData);
    }
}
