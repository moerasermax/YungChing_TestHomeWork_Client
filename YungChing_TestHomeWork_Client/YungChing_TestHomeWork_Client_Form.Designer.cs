namespace YungChing_TestHomeWork_Client
{
    partial class YungChing_TestHomeWork_Client_Form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Client_Show_Groupbox = new System.Windows.Forms.GroupBox();
            this.DisConnect_Server_Button = new System.Windows.Forms.Button();
            this.Connect_Server_Button = new System.Windows.Forms.Button();
            this.Server_Port_Textbox = new System.Windows.Forms.TextBox();
            this.Server_Port_Label = new System.Windows.Forms.Label();
            this.Server_IP_Textbox = new System.Windows.Forms.TextBox();
            this.Server_IP_Label = new System.Windows.Forms.Label();
            this.RequestFile_Information_Groupbox = new System.Windows.Forms.GroupBox();
            this.Request_SaveFilePath_Textbox = new System.Windows.Forms.TextBox();
            this.Default_GetFile_Request_button = new System.Windows.Forms.Button();
            this.Send_Request_DownloadFile_Button = new System.Windows.Forms.Button();
            this.Request_FilePath_Label = new System.Windows.Forms.Label();
            this.Request_FileName_Textbox = new System.Windows.Forms.TextBox();
            this.Request_FileName_Label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Request_GetServerFilesFolderFilesName_Textbox = new System.Windows.Forms.TextBox();
            this.Send_Get_Server_FilesFolder_FilesName_Button = new System.Windows.Forms.Button();
            this.Request_GetServerFilesFolderFilesName_Label = new System.Windows.Forms.Label();
            this.ConsoleLog_Groupbox = new System.Windows.Forms.GroupBox();
            this.ConsoleLog_Textbox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.API_Send_Request = new System.Windows.Forms.TabPage();
            this.CommandLine_Send_Request = new System.Windows.Forms.TabPage();
            this.Notice_Label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Send_Request_Command_Button = new System.Windows.Forms.Button();
            this.Command_Textbox = new System.Windows.Forms.TextBox();
            this.Command_Label = new System.Windows.Forms.Label();
            this.Client_Show_Groupbox.SuspendLayout();
            this.RequestFile_Information_Groupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ConsoleLog_Groupbox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.API_Send_Request.SuspendLayout();
            this.CommandLine_Send_Request.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Client_Show_Groupbox
            // 
            this.Client_Show_Groupbox.Controls.Add(this.DisConnect_Server_Button);
            this.Client_Show_Groupbox.Controls.Add(this.Connect_Server_Button);
            this.Client_Show_Groupbox.Controls.Add(this.Server_Port_Textbox);
            this.Client_Show_Groupbox.Controls.Add(this.Server_Port_Label);
            this.Client_Show_Groupbox.Controls.Add(this.Server_IP_Textbox);
            this.Client_Show_Groupbox.Controls.Add(this.Server_IP_Label);
            this.Client_Show_Groupbox.Location = new System.Drawing.Point(31, 12);
            this.Client_Show_Groupbox.Name = "Client_Show_Groupbox";
            this.Client_Show_Groupbox.Size = new System.Drawing.Size(777, 83);
            this.Client_Show_Groupbox.TabIndex = 0;
            this.Client_Show_Groupbox.TabStop = false;
            this.Client_Show_Groupbox.Text = "Server_Information";
            // 
            // DisConnect_Server_Button
            // 
            this.DisConnect_Server_Button.Enabled = false;
            this.DisConnect_Server_Button.Location = new System.Drawing.Point(627, 30);
            this.DisConnect_Server_Button.Name = "DisConnect_Server_Button";
            this.DisConnect_Server_Button.Size = new System.Drawing.Size(131, 23);
            this.DisConnect_Server_Button.TabIndex = 1;
            this.DisConnect_Server_Button.Text = "DisConnect_Server";
            this.DisConnect_Server_Button.UseVisualStyleBackColor = true;
            this.DisConnect_Server_Button.Click += new System.EventHandler(this.DisConnect_Server_Button_Click);
            // 
            // Connect_Server_Button
            // 
            this.Connect_Server_Button.Location = new System.Drawing.Point(481, 32);
            this.Connect_Server_Button.Name = "Connect_Server_Button";
            this.Connect_Server_Button.Size = new System.Drawing.Size(115, 23);
            this.Connect_Server_Button.TabIndex = 1;
            this.Connect_Server_Button.Text = "Connect_Server";
            this.Connect_Server_Button.UseVisualStyleBackColor = true;
            this.Connect_Server_Button.Click += new System.EventHandler(this.Connect_Server_Button_Click);
            // 
            // Server_Port_Textbox
            // 
            this.Server_Port_Textbox.Location = new System.Drawing.Point(315, 33);
            this.Server_Port_Textbox.Name = "Server_Port_Textbox";
            this.Server_Port_Textbox.Size = new System.Drawing.Size(100, 22);
            this.Server_Port_Textbox.TabIndex = 1;
            this.Server_Port_Textbox.Text = "5050";
            // 
            // Server_Port_Label
            // 
            this.Server_Port_Label.AutoSize = true;
            this.Server_Port_Label.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Server_Port_Label.Location = new System.Drawing.Point(223, 36);
            this.Server_Port_Label.Name = "Server_Port_Label";
            this.Server_Port_Label.Size = new System.Drawing.Size(91, 17);
            this.Server_Port_Label.TabIndex = 0;
            this.Server_Port_Label.Text = "Server_Port：";
            // 
            // Server_IP_Textbox
            // 
            this.Server_IP_Textbox.Location = new System.Drawing.Point(88, 34);
            this.Server_IP_Textbox.Name = "Server_IP_Textbox";
            this.Server_IP_Textbox.Size = new System.Drawing.Size(100, 22);
            this.Server_IP_Textbox.TabIndex = 1;
            this.Server_IP_Textbox.Text = "127.0.0.1";
            // 
            // Server_IP_Label
            // 
            this.Server_IP_Label.AutoSize = true;
            this.Server_IP_Label.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Server_IP_Label.Location = new System.Drawing.Point(12, 36);
            this.Server_IP_Label.Name = "Server_IP_Label";
            this.Server_IP_Label.Size = new System.Drawing.Size(77, 17);
            this.Server_IP_Label.TabIndex = 0;
            this.Server_IP_Label.Text = "Server_IP：";
            // 
            // RequestFile_Information_Groupbox
            // 
            this.RequestFile_Information_Groupbox.Controls.Add(this.Request_SaveFilePath_Textbox);
            this.RequestFile_Information_Groupbox.Controls.Add(this.Default_GetFile_Request_button);
            this.RequestFile_Information_Groupbox.Controls.Add(this.Send_Request_DownloadFile_Button);
            this.RequestFile_Information_Groupbox.Controls.Add(this.Request_FilePath_Label);
            this.RequestFile_Information_Groupbox.Controls.Add(this.Request_FileName_Textbox);
            this.RequestFile_Information_Groupbox.Controls.Add(this.Request_FileName_Label);
            this.RequestFile_Information_Groupbox.Location = new System.Drawing.Point(11, 13);
            this.RequestFile_Information_Groupbox.Name = "RequestFile_Information_Groupbox";
            this.RequestFile_Information_Groupbox.Size = new System.Drawing.Size(762, 132);
            this.RequestFile_Information_Groupbox.TabIndex = 0;
            this.RequestFile_Information_Groupbox.TabStop = false;
            this.RequestFile_Information_Groupbox.Text = "RequestFile_Information";
            // 
            // Request_SaveFilePath_Textbox
            // 
            this.Request_SaveFilePath_Textbox.Location = new System.Drawing.Point(160, 89);
            this.Request_SaveFilePath_Textbox.Name = "Request_SaveFilePath_Textbox";
            this.Request_SaveFilePath_Textbox.Size = new System.Drawing.Size(421, 22);
            this.Request_SaveFilePath_Textbox.TabIndex = 1;
            // 
            // Default_GetFile_Request_button
            // 
            this.Default_GetFile_Request_button.Enabled = false;
            this.Default_GetFile_Request_button.Location = new System.Drawing.Point(589, 45);
            this.Default_GetFile_Request_button.Name = "Default_GetFile_Request_button";
            this.Default_GetFile_Request_button.Size = new System.Drawing.Size(154, 26);
            this.Default_GetFile_Request_button.TabIndex = 1;
            this.Default_GetFile_Request_button.Text = "Default_GetFile_Request";
            this.Default_GetFile_Request_button.UseVisualStyleBackColor = true;
            this.Default_GetFile_Request_button.Click += new System.EventHandler(this.Default_GetFile_Request_button_Click);
            // 
            // Send_Request_DownloadFile_Button
            // 
            this.Send_Request_DownloadFile_Button.Enabled = false;
            this.Send_Request_DownloadFile_Button.Location = new System.Drawing.Point(589, 87);
            this.Send_Request_DownloadFile_Button.Name = "Send_Request_DownloadFile_Button";
            this.Send_Request_DownloadFile_Button.Size = new System.Drawing.Size(154, 26);
            this.Send_Request_DownloadFile_Button.TabIndex = 1;
            this.Send_Request_DownloadFile_Button.Text = "Send_Request_DownloadFile";
            this.Send_Request_DownloadFile_Button.UseVisualStyleBackColor = true;
            this.Send_Request_DownloadFile_Button.Click += new System.EventHandler(this.Send_Request_DownloadFile_Button_Click);
            // 
            // Request_FilePath_Label
            // 
            this.Request_FilePath_Label.AutoSize = true;
            this.Request_FilePath_Label.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Request_FilePath_Label.Location = new System.Drawing.Point(12, 92);
            this.Request_FilePath_Label.Name = "Request_FilePath_Label";
            this.Request_FilePath_Label.Size = new System.Drawing.Size(152, 17);
            this.Request_FilePath_Label.TabIndex = 0;
            this.Request_FilePath_Label.Text = "Request_SaveFilePath：";
            // 
            // Request_FileName_Textbox
            // 
            this.Request_FileName_Textbox.Location = new System.Drawing.Point(159, 48);
            this.Request_FileName_Textbox.Name = "Request_FileName_Textbox";
            this.Request_FileName_Textbox.Size = new System.Drawing.Size(424, 22);
            this.Request_FileName_Textbox.TabIndex = 1;
            // 
            // Request_FileName_Label
            // 
            this.Request_FileName_Label.AutoSize = true;
            this.Request_FileName_Label.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Request_FileName_Label.Location = new System.Drawing.Point(22, 49);
            this.Request_FileName_Label.Name = "Request_FileName_Label";
            this.Request_FileName_Label.Size = new System.Drawing.Size(132, 17);
            this.Request_FileName_Label.TabIndex = 0;
            this.Request_FileName_Label.Text = "Request_FileName：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Request_GetServerFilesFolderFilesName_Textbox);
            this.groupBox1.Controls.Add(this.Send_Get_Server_FilesFolder_FilesName_Button);
            this.groupBox1.Controls.Add(this.Request_GetServerFilesFolderFilesName_Label);
            this.groupBox1.Location = new System.Drawing.Point(793, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RequestFile_Information";
            // 
            // Request_GetServerFilesFolderFilesName_Textbox
            // 
            this.Request_GetServerFilesFolderFilesName_Textbox.Location = new System.Drawing.Point(157, 44);
            this.Request_GetServerFilesFolderFilesName_Textbox.Multiline = true;
            this.Request_GetServerFilesFolderFilesName_Textbox.Name = "Request_GetServerFilesFolderFilesName_Textbox";
            this.Request_GetServerFilesFolderFilesName_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Request_GetServerFilesFolderFilesName_Textbox.Size = new System.Drawing.Size(724, 82);
            this.Request_GetServerFilesFolderFilesName_Textbox.TabIndex = 1;
            // 
            // Send_Get_Server_FilesFolder_FilesName_Button
            // 
            this.Send_Get_Server_FilesFolder_FilesName_Button.Enabled = false;
            this.Send_Get_Server_FilesFolder_FilesName_Button.Location = new System.Drawing.Point(347, 12);
            this.Send_Get_Server_FilesFolder_FilesName_Button.Name = "Send_Get_Server_FilesFolder_FilesName_Button";
            this.Send_Get_Server_FilesFolder_FilesName_Button.Size = new System.Drawing.Size(215, 26);
            this.Send_Get_Server_FilesFolder_FilesName_Button.TabIndex = 1;
            this.Send_Get_Server_FilesFolder_FilesName_Button.Text = "Send_Get_Server_FilesFolder_FilesName";
            this.Send_Get_Server_FilesFolder_FilesName_Button.UseVisualStyleBackColor = true;
            this.Send_Get_Server_FilesFolder_FilesName_Button.Click += new System.EventHandler(this.Send_Get_Server_FilesFolder_FilesName_Button_Click);
            // 
            // Request_GetServerFilesFolderFilesName_Label
            // 
            this.Request_GetServerFilesFolderFilesName_Label.AutoSize = true;
            this.Request_GetServerFilesFolderFilesName_Label.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Request_GetServerFilesFolderFilesName_Label.Location = new System.Drawing.Point(8, 55);
            this.Request_GetServerFilesFolderFilesName_Label.Name = "Request_GetServerFilesFolderFilesName_Label";
            this.Request_GetServerFilesFolderFilesName_Label.Size = new System.Drawing.Size(153, 17);
            this.Request_GetServerFilesFolderFilesName_Label.TabIndex = 0;
            this.Request_GetServerFilesFolderFilesName_Label.Text = "DownloadFolder_Files：";
            // 
            // ConsoleLog_Groupbox
            // 
            this.ConsoleLog_Groupbox.Controls.Add(this.ConsoleLog_Textbox);
            this.ConsoleLog_Groupbox.Location = new System.Drawing.Point(31, 300);
            this.ConsoleLog_Groupbox.Name = "ConsoleLog_Groupbox";
            this.ConsoleLog_Groupbox.Size = new System.Drawing.Size(1690, 156);
            this.ConsoleLog_Groupbox.TabIndex = 0;
            this.ConsoleLog_Groupbox.TabStop = false;
            this.ConsoleLog_Groupbox.Text = "ConsoleLog";
            // 
            // ConsoleLog_Textbox
            // 
            this.ConsoleLog_Textbox.Location = new System.Drawing.Point(15, 21);
            this.ConsoleLog_Textbox.Multiline = true;
            this.ConsoleLog_Textbox.Name = "ConsoleLog_Textbox";
            this.ConsoleLog_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ConsoleLog_Textbox.Size = new System.Drawing.Size(1663, 129);
            this.ConsoleLog_Textbox.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.API_Send_Request);
            this.tabControl1.Controls.Add(this.CommandLine_Send_Request);
            this.tabControl1.Location = new System.Drawing.Point(31, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1694, 193);
            this.tabControl1.TabIndex = 1;
            // 
            // API_Send_Request
            // 
            this.API_Send_Request.Controls.Add(this.RequestFile_Information_Groupbox);
            this.API_Send_Request.Controls.Add(this.groupBox1);
            this.API_Send_Request.Location = new System.Drawing.Point(4, 22);
            this.API_Send_Request.Name = "API_Send_Request";
            this.API_Send_Request.Padding = new System.Windows.Forms.Padding(3);
            this.API_Send_Request.Size = new System.Drawing.Size(1686, 167);
            this.API_Send_Request.TabIndex = 0;
            this.API_Send_Request.Text = "API_Send_Request";
            this.API_Send_Request.UseVisualStyleBackColor = true;
            // 
            // CommandLine_Send_Request
            // 
            this.CommandLine_Send_Request.Controls.Add(this.Notice_Label);
            this.CommandLine_Send_Request.Controls.Add(this.groupBox2);
            this.CommandLine_Send_Request.Location = new System.Drawing.Point(4, 22);
            this.CommandLine_Send_Request.Name = "CommandLine_Send_Request";
            this.CommandLine_Send_Request.Padding = new System.Windows.Forms.Padding(3);
            this.CommandLine_Send_Request.Size = new System.Drawing.Size(1686, 167);
            this.CommandLine_Send_Request.TabIndex = 1;
            this.CommandLine_Send_Request.Text = "CommandLine_Send_Request";
            this.CommandLine_Send_Request.UseVisualStyleBackColor = true;
            // 
            // Notice_Label
            // 
            this.Notice_Label.AutoSize = true;
            this.Notice_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Notice_Label.Location = new System.Drawing.Point(748, 35);
            this.Notice_Label.Name = "Notice_Label";
            this.Notice_Label.Size = new System.Drawing.Size(243, 72);
            this.Notice_Label.TabIndex = 2;
            this.Notice_Label.Text = "Notice：\r\n             This function has the following function：\r\n\r\n              " +
    "     1./ GetServerFilesfolderFile\r\n\r\n                   2./  Download {File_Name" +
    "}";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Send_Request_Command_Button);
            this.groupBox2.Controls.Add(this.Command_Textbox);
            this.groupBox2.Controls.Add(this.Command_Label);
            this.groupBox2.Location = new System.Drawing.Point(45, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RequestFile_Information";
            // 
            // Send_Request_Command_Button
            // 
            this.Send_Request_Command_Button.Enabled = false;
            this.Send_Request_Command_Button.Location = new System.Drawing.Point(369, 43);
            this.Send_Request_Command_Button.Name = "Send_Request_Command_Button";
            this.Send_Request_Command_Button.Size = new System.Drawing.Size(196, 26);
            this.Send_Request_Command_Button.TabIndex = 1;
            this.Send_Request_Command_Button.Text = "Send_Request_Command";
            this.Send_Request_Command_Button.UseVisualStyleBackColor = true;
            this.Send_Request_Command_Button.Click += new System.EventHandler(this.Send_Request_Command_Button_Click);
            // 
            // Command_Textbox
            // 
            this.Command_Textbox.Location = new System.Drawing.Point(109, 47);
            this.Command_Textbox.Name = "Command_Textbox";
            this.Command_Textbox.Size = new System.Drawing.Size(208, 22);
            this.Command_Textbox.TabIndex = 1;
            // 
            // Command_Label
            // 
            this.Command_Label.AutoSize = true;
            this.Command_Label.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Command_Label.Location = new System.Drawing.Point(21, 50);
            this.Command_Label.Name = "Command_Label";
            this.Command_Label.Size = new System.Drawing.Size(85, 17);
            this.Command_Label.TabIndex = 0;
            this.Command_Label.Text = "Command：";
            // 
            // YungChing_TestHomeWork_Client_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1737, 468);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ConsoleLog_Groupbox);
            this.Controls.Add(this.Client_Show_Groupbox);
            this.Name = "YungChing_TestHomeWork_Client_Form";
            this.Text = "YungChing_TestHomeWork_Client";
            this.Client_Show_Groupbox.ResumeLayout(false);
            this.Client_Show_Groupbox.PerformLayout();
            this.RequestFile_Information_Groupbox.ResumeLayout(false);
            this.RequestFile_Information_Groupbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ConsoleLog_Groupbox.ResumeLayout(false);
            this.ConsoleLog_Groupbox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.API_Send_Request.ResumeLayout(false);
            this.CommandLine_Send_Request.ResumeLayout(false);
            this.CommandLine_Send_Request.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Client_Show_Groupbox;
        private System.Windows.Forms.GroupBox RequestFile_Information_Groupbox;
        private System.Windows.Forms.Button DisConnect_Server_Button;
        private System.Windows.Forms.Button Connect_Server_Button;
        private System.Windows.Forms.TextBox Server_Port_Textbox;
        private System.Windows.Forms.Label Server_Port_Label;
        private System.Windows.Forms.TextBox Server_IP_Textbox;
        private System.Windows.Forms.Label Server_IP_Label;
        private System.Windows.Forms.TextBox Request_SaveFilePath_Textbox;
        private System.Windows.Forms.Label Request_FilePath_Label;
        private System.Windows.Forms.TextBox Request_FileName_Textbox;
        private System.Windows.Forms.Label Request_FileName_Label;
        private System.Windows.Forms.Button Send_Request_DownloadFile_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Request_GetServerFilesFolderFilesName_Textbox;
        private System.Windows.Forms.Button Send_Get_Server_FilesFolder_FilesName_Button;
        private System.Windows.Forms.Label Request_GetServerFilesFolderFilesName_Label;
        private System.Windows.Forms.GroupBox ConsoleLog_Groupbox;
        private System.Windows.Forms.TextBox ConsoleLog_Textbox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage API_Send_Request;
        private System.Windows.Forms.TabPage CommandLine_Send_Request;
        private System.Windows.Forms.Label Notice_Label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Send_Request_Command_Button;
        private System.Windows.Forms.TextBox Command_Textbox;
        private System.Windows.Forms.Label Command_Label;
        private System.Windows.Forms.Button Default_GetFile_Request_button;
    }
}

