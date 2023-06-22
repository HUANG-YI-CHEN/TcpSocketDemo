
namespace TcpSocketDemo
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rtb_SendMsg = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Disconnect_Client = new System.Windows.Forms.Button();
            this.Btn_Connect_Client = new System.Windows.Forms.Button();
            this.Btn_Send_Client = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Tb_Port_Client = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb_IP_Client = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Disconnect_Server = new System.Windows.Forms.Button();
            this.Btn_Connect_Server = new System.Windows.Forms.Button();
            this.Btn_Send_Server = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Tb_Port_Server = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_IP_Server = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_ClearMsg = new System.Windows.Forms.Button();
            this.Rtb_RecieveMsg = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 152);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(671, 152);
            this.splitContainer1.SplitterDistance = 397;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rtb_SendMsg);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send Message";
            // 
            // Rtb_SendMsg
            // 
            this.Rtb_SendMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rtb_SendMsg.Location = new System.Drawing.Point(3, 18);
            this.Rtb_SendMsg.Name = "Rtb_SendMsg";
            this.Rtb_SendMsg.Size = new System.Drawing.Size(391, 131);
            this.Rtb_SendMsg.TabIndex = 0;
            this.Rtb_SendMsg.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel4);
            this.groupBox4.Controls.Add(this.tableLayoutPanel2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 75);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Client";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.Btn_Disconnect_Client, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Btn_Connect_Client, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Btn_Send_Client, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 46);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(264, 26);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // Btn_Disconnect_Client
            // 
            this.Btn_Disconnect_Client.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Disconnect_Client.Location = new System.Drawing.Point(179, 3);
            this.Btn_Disconnect_Client.Name = "Btn_Disconnect_Client";
            this.Btn_Disconnect_Client.Size = new System.Drawing.Size(75, 20);
            this.Btn_Disconnect_Client.TabIndex = 3;
            this.Btn_Disconnect_Client.Text = "Disconnect";
            this.Btn_Disconnect_Client.UseVisualStyleBackColor = true;
            this.Btn_Disconnect_Client.EnabledChanged += new System.EventHandler(this.Btn_Disconnect_Client_EnabledChanged);
            this.Btn_Disconnect_Client.Click += new System.EventHandler(this.Btn_Disconnect_Client_Click);
            // 
            // Btn_Connect_Client
            // 
            this.Btn_Connect_Client.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Connect_Client.Location = new System.Drawing.Point(91, 3);
            this.Btn_Connect_Client.Name = "Btn_Connect_Client";
            this.Btn_Connect_Client.Size = new System.Drawing.Size(75, 20);
            this.Btn_Connect_Client.TabIndex = 2;
            this.Btn_Connect_Client.Text = "Connect";
            this.Btn_Connect_Client.UseVisualStyleBackColor = true;
            this.Btn_Connect_Client.EnabledChanged += new System.EventHandler(this.Btn_Connect_Client_EnabledChanged);
            this.Btn_Connect_Client.Click += new System.EventHandler(this.Btn_Connect_Client_Click);
            // 
            // Btn_Send_Client
            // 
            this.Btn_Send_Client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Btn_Send_Client.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Send_Client.Location = new System.Drawing.Point(3, 3);
            this.Btn_Send_Client.Name = "Btn_Send_Client";
            this.Btn_Send_Client.Size = new System.Drawing.Size(75, 20);
            this.Btn_Send_Client.TabIndex = 1;
            this.Btn_Send_Client.Text = "Send";
            this.Btn_Send_Client.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.1194F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.8806F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.Controls.Add(this.Tb_Port_Client, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Tb_IP_Client, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(264, 28);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Tb_Port_Client
            // 
            this.Tb_Port_Client.Location = new System.Drawing.Point(199, 3);
            this.Tb_Port_Client.Name = "Tb_Port_Client";
            this.Tb_Port_Client.Size = new System.Drawing.Size(61, 22);
            this.Tb_Port_Client.TabIndex = 3;
            this.Tb_Port_Client.Text = "9153";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port";
            // 
            // Tb_IP_Client
            // 
            this.Tb_IP_Client.Location = new System.Drawing.Point(44, 3);
            this.Tb_IP_Client.Name = "Tb_IP_Client";
            this.Tb_IP_Client.Size = new System.Drawing.Size(109, 22);
            this.Tb_IP_Client.TabIndex = 2;
            this.Tb_IP_Client.Text = "127.0.0.1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 77);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.Btn_Disconnect_Server, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.Btn_Connect_Server, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Btn_Send_Server, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 46);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(264, 28);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // Btn_Disconnect_Server
            // 
            this.Btn_Disconnect_Server.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Disconnect_Server.Location = new System.Drawing.Point(179, 3);
            this.Btn_Disconnect_Server.Name = "Btn_Disconnect_Server";
            this.Btn_Disconnect_Server.Size = new System.Drawing.Size(75, 22);
            this.Btn_Disconnect_Server.TabIndex = 2;
            this.Btn_Disconnect_Server.Text = "Disconnect";
            this.Btn_Disconnect_Server.UseVisualStyleBackColor = true;
            this.Btn_Disconnect_Server.EnabledChanged += new System.EventHandler(this.Btn_Disconnect_Server_EnabledChanged);
            this.Btn_Disconnect_Server.Click += new System.EventHandler(this.Btn_Disconnect_Server_Click);
            // 
            // Btn_Connect_Server
            // 
            this.Btn_Connect_Server.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Connect_Server.Location = new System.Drawing.Point(91, 3);
            this.Btn_Connect_Server.Name = "Btn_Connect_Server";
            this.Btn_Connect_Server.Size = new System.Drawing.Size(75, 22);
            this.Btn_Connect_Server.TabIndex = 1;
            this.Btn_Connect_Server.Text = "Connect";
            this.Btn_Connect_Server.UseVisualStyleBackColor = true;
            this.Btn_Connect_Server.EnabledChanged += new System.EventHandler(this.Btn_Connect_Server_EnabledChanged);
            this.Btn_Connect_Server.Click += new System.EventHandler(this.Btn_Connect_Server_Click);
            // 
            // Btn_Send_Server
            // 
            this.Btn_Send_Server.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Btn_Send_Server.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Send_Server.Location = new System.Drawing.Point(3, 3);
            this.Btn_Send_Server.Name = "Btn_Send_Server";
            this.Btn_Send_Server.Size = new System.Drawing.Size(75, 22);
            this.Btn_Send_Server.TabIndex = 0;
            this.Btn_Send_Server.Text = "Send";
            this.Btn_Send_Server.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.1194F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.8806F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.Controls.Add(this.Tb_Port_Server, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Tb_IP_Server, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(264, 28);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Tb_Port_Server
            // 
            this.Tb_Port_Server.Location = new System.Drawing.Point(199, 3);
            this.Tb_Port_Server.Name = "Tb_Port_Server";
            this.Tb_Port_Server.Size = new System.Drawing.Size(61, 22);
            this.Tb_Port_Server.TabIndex = 3;
            this.Tb_Port_Server.Text = "9153";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // Tb_IP_Server
            // 
            this.Tb_IP_Server.Location = new System.Drawing.Point(44, 3);
            this.Tb_IP_Server.Name = "Tb_IP_Server";
            this.Tb_IP_Server.Size = new System.Drawing.Size(109, 22);
            this.Tb_IP_Server.TabIndex = 2;
            this.Tb_IP_Server.Text = "127.0.0.1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 245);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_ClearMsg);
            this.groupBox2.Controls.Add(this.Rtb_RecieveMsg);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 245);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recieve Message";
            // 
            // Btn_ClearMsg
            // 
            this.Btn_ClearMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ClearMsg.Location = new System.Drawing.Point(615, 216);
            this.Btn_ClearMsg.Name = "Btn_ClearMsg";
            this.Btn_ClearMsg.Size = new System.Drawing.Size(53, 23);
            this.Btn_ClearMsg.TabIndex = 1;
            this.Btn_ClearMsg.Text = "Clear";
            this.Btn_ClearMsg.UseVisualStyleBackColor = true;
            this.Btn_ClearMsg.Click += new System.EventHandler(this.Btn_ClearMsg_Click);
            // 
            // Rtb_RecieveMsg
            // 
            this.Rtb_RecieveMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rtb_RecieveMsg.Location = new System.Drawing.Point(3, 18);
            this.Rtb_RecieveMsg.Name = "Rtb_RecieveMsg";
            this.Rtb_RecieveMsg.Size = new System.Drawing.Size(665, 224);
            this.Rtb_RecieveMsg.TabIndex = 0;
            this.Rtb_RecieveMsg.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 397);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TcpSocketDemo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox Rtb_SendMsg;
        private System.Windows.Forms.RichTextBox Rtb_RecieveMsg;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_ClearMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_IP_Server;
        private System.Windows.Forms.TextBox Tb_Port_Server;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox Tb_Port_Client;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tb_IP_Client;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Btn_Send_Server;
        private System.Windows.Forms.Button Btn_Disconnect_Client;
        private System.Windows.Forms.Button Btn_Connect_Client;
        private System.Windows.Forms.Button Btn_Send_Client;
        private System.Windows.Forms.Button Btn_Disconnect_Server;
        private System.Windows.Forms.Button Btn_Connect_Server;
    }
}

