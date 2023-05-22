using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YungCging_SQLExcuter.Controller;
using YungCging_SQLExcuter.Model;
using YungChing_TestHomeWork_Client.DataSet;
namespace YungCging_SQLExcuter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet_ExcuteResult result = new DataSet_ExcuteResult();
            DataSet_User_CRUD User_Data = new DataSet_User_CRUD()
            {
                Account ="XC",
                Age ="21",
                Name ="BBOYXC",
                Password = "CX"
            };


            result = SQLEngine_Controller.getInstance().SetDataInfo(Enum_Action.READUSER, User_Data, "SELECT * FROM [YungChing_TestHomework].[dbo].[User] WHERE account = @Account;");
            if (result.Success) { result = SQLEngine_Controller.getInstance().SetSQLParameter(); } else { MessageBox.Show(result.FeedBackMessage); }
            if (result.Success) { result = SQLEngine_Controller.getInstance().ExcuteSQLCommand();} else { MessageBox.Show(result.FeedBackMessage); }
            MessageBox.Show(string.Format("{0}", result.FeedBackMessage));
        }           
    }
}
