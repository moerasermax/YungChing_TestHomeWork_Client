﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using YungChing_TestHomeWork_Client.DataSet;
using YungChing_TestHomeWork_Client.Interface;

namespace YungChing_TestHomeWork_Client.Model
{
    public class Deserialization_Result : I_Deserialization_Result
    {
        public DataSet_ExcuteResult Result { get ; set ; }
        public string Receive_Result { get ; set ; }
        public Enum_Action Action_Flow { get; set; }

        /// FeedBackMessage：{Commnad} {系統訊息}..{資料}
        public void Set_ReceiveResult(byte[] buffer)
        {
            Receive_Result = BufferToStringFormat(buffer);
        }

        public void Get_FileBytePack()
        {
            this.Receive_Result = this.Receive_Result.Replace("\0", "");
            string reponse =Regex.Split(this.Receive_Result, "..Split..")[2];
            Result.Data_Buffer = Encoding.UTF8.GetBytes(reponse);
        }
        public string Get_FeedBackMessage()
        {
            return Regex.Split(this.Receive_Result, "..Split..")[2];
        }
        public void Get_ActionFlow()
        {
            this.Action_Flow = (Enum_Action)Enum.Parse(typeof(Enum_Action), Regex.Split(this.Receive_Result, "..Split..")[0]);
        }

        public DataSet_ExcuteResult Query_Action_Process(I_Receive_Process Process_Object)
        {
            DataSet_ExcuteResult result = new DataSet_ExcuteResult();
            switch (this.Action_Flow)
            {
                case Enum_Action.CREATEUSER:
                    return Process_Object.Excute_Specific_Method();
                case Enum_Action.DELETEUSER:
                    return Process_Object.Excute_Specific_Method();
                case Enum_Action.READUSER:
                    return Process_Object.Excute_Specific_Method();
                case Enum_Action.UPDATEUSER:
                    return Process_Object.Excute_Specific_Method();
                case Enum_Action.FAIL:
                    result.Success = false;
                    result.FeedBackMessage = "Can't find Action_Flow";
                    break;
                default:
                    result.Success = false;
                    result.FeedBackMessage = "Can't find Action_Flow";
                    break;
            }
            return result;
        }
        public string BufferToStringFormat(byte[] buffer)
        {
            return Encoding.UTF8.GetString(buffer);
        }

        #region Singleton
        public static Deserialization_Result Instance = new Deserialization_Result();
        public static Deserialization_Result getInstance()
        {
            return Instance;
        }
        private Deserialization_Result()
        {
            Result = new DataSet_ExcuteResult();
        }
        #region YC Design

        #endregion 
        #endregion

    }
}
