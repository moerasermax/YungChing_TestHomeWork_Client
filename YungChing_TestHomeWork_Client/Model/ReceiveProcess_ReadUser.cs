using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using YungChing_TestHomeWork_Client.Abstract;
using YungChing_TestHomeWork_Client.DataSet;

namespace YungChing_TestHomeWork_Client.Model
{
    public class ReceiveProcess_ReadUser : Receive_Process
    {
        public override DataSet_ExcuteResult Excute_Specific_Method()
        {
            DataSet_ExcuteResult result = new DataSet_ExcuteResult();
            try
            {
                result.Success = true;
                result.FeedBackMessage = Deserialization_Result.getInstance().Get_FeedBackMessage();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.FeedBackMessage = ex.Message;
            }
            return result;
        }
    }
}
