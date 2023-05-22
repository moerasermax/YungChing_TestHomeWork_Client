using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YungChing_TestHomeWork_Client.DataSet;

namespace YungChing_TestHomeWork_Client.Interface
{
    public interface I_Deserialization_Result
    {
        Enum_Action Action_Flow { get; set; }
        DataSet_ExcuteResult Result { get; set; }
        string Receive_Result { get; set; }
        void Set_ReceiveResult(byte[] buffer);
        void Get_FileBytePack();
        void Get_ActionFlow();
        string Get_FeedBackMessage();
        string BufferToStringFormat(byte[] buffer); 
        DataSet_ExcuteResult Query_Action_Process(I_Receive_Process Process_Object);
    }
}
