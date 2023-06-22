using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace TcpSocketDemo
{
    public partial class MainForm : Form
    {
        #region Exec Infomation
        public string CurExecPath { get; set; }
        public string CurExecName { get; set; }
        public string CurExecVer { get; set; }
        public string XmlPath { get; set; } = AppDomain.CurrentDomain.BaseDirectory + "PROCESS.xml";
        public int CounterExit { get; set; } = 0;
        #endregion

        public MainForm()
        {
            InitializeComponent();

            #region Exec Infomation
            CurExecPath = System.Windows.Forms.Application.ExecutablePath;
            CurExecName = Path.GetFileNameWithoutExtension(CurExecPath);
            CurExecVer = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion.ToString();
            #endregion

            #region Icon  
            this.Text = string.Format("{0} ({1})", CurExecName, CurExecVer);
            this.Icon =TcpSocketDemo.Properties.Resources.web_socket_32x32;
            #endregion    
        }

        #region ~MainForm
        ~MainForm()
        {
            this.Dispose();
            this.Close();
            Environment.Exit(Environment.ExitCode);
        }
        #endregion

        #region How to fix the flickering in User controls
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        #endregion

        #region MainForm_Load
        private void MainForm_Load(object sender, EventArgs e)
        {
            Btn_Connect_Server.Enabled = true;
            Btn_Connect_Client.Enabled = true;
            Btn_Disconnect_Server.Enabled = false;
            Btn_Disconnect_Client.Enabled = false;            
        }
        #endregion

        #region Button Enable Change
        private void Btn_Connect_Server_EnabledChanged(object sender, EventArgs e)
        {
            if (Btn_Connect_Server.Enabled)
            {
                Btn_Connect_Server.BackColor = Color.LightGray;
                Btn_Disconnect_Server.Enabled = false;
            }                
            else
            {
                Btn_Connect_Server.BackColor = Color.LightGreen;
                Btn_Disconnect_Server.Enabled = true;
            }
        }

        private void Btn_Disconnect_Server_EnabledChanged(object sender, EventArgs e)
        {
            if (Btn_Disconnect_Server.Enabled)
            {
                Btn_Disconnect_Server.BackColor = Color.LightGray;
                Btn_Connect_Server.Enabled = false;
            }
            else
            {
                Btn_Disconnect_Server.BackColor = Color.LightPink;
                Btn_Connect_Server.Enabled = true;
            }
        }


        private void Btn_Connect_Client_EnabledChanged(object sender, EventArgs e)
        {
            if (Btn_Connect_Client.Enabled)
            {
                Btn_Connect_Client.BackColor = Color.LightGray;
                Btn_Disconnect_Client.Enabled = false;
            }                
            else
            {
                Btn_Connect_Client.BackColor = Color.LightGreen;
                Btn_Disconnect_Client.Enabled = true;
            }                
        }

        private void Btn_Disconnect_Client_EnabledChanged(object sender, EventArgs e)
        {
            if (Btn_Disconnect_Client.Enabled)
            {
                Btn_Disconnect_Client.BackColor = Color.LightGray;
                Btn_Connect_Client.Enabled = false;
            }
            else
            {
                Btn_Disconnect_Client.BackColor = Color.LightPink;
                Btn_Connect_Client.Enabled = true;
            }

        }
        #endregion

        #region Button Click Change
        private void Btn_Connect_Server_Click(object sender, EventArgs e)
        {
            if (Btn_Connect_Server.Enabled)
                Btn_Connect_Server.Enabled = false;
        }

        private void Btn_Disconnect_Server_Click(object sender, EventArgs e)
        {
            if (Btn_Disconnect_Server.Enabled)
                Btn_Disconnect_Server.Enabled = false;
        }
        private void Btn_Connect_Client_Click(object sender, EventArgs e)
        {
            if (Btn_Connect_Client.Enabled)
                Btn_Connect_Client.Enabled = false;
        }

        private void Btn_Disconnect_Client_Click(object sender, EventArgs e)
        {
            if (Btn_Disconnect_Client.Enabled)
                Btn_Disconnect_Client.Enabled = false;
        }

        private void Btn_ClearMsg_Click(object sender, EventArgs e)
        {
            Rtb_RecieveMsg.Text = "";
        }
        #endregion
    }
}
