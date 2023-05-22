using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YungChing_TestHomeWork_Client.DataSet;
using YungChing_TestHomeWork_Client.Interface;

namespace YungChing_TestHomeWork_Client.Abstract
{
    public abstract class Receive_Process : I_Receive_Process
    {
        public string FeedBackMessage { get; set; } 
        public byte[] FileBytesbuffer { get; set; }

        public abstract DataSet_ExcuteResult Excute_Specific_Method();
    }
}
