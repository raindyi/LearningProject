namespace Lynn.SocketProject.Client.UI
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelServer = new System.Windows.Forms.Label();
            this.textBoxServerIP = new System.Windows.Forms.TextBox();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.tsslabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonSender = new System.Windows.Forms.Button();
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.groupBoxClientList = new System.Windows.Forms.GroupBox();
            this.listBoxClientList = new System.Windows.Forms.ListBox();
            this.groupBoxConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.statusStripMain.SuspendLayout();
            this.groupBoxClientList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.buttonStop);
            this.groupBoxConfig.Controls.Add(this.buttonConnect);
            this.groupBoxConfig.Controls.Add(this.numericUpDownPort);
            this.groupBoxConfig.Controls.Add(this.labelPort);
            this.groupBoxConfig.Controls.Add(this.labelServer);
            this.groupBoxConfig.Controls.Add(this.textBoxServerIP);
            this.groupBoxConfig.Location = new System.Drawing.Point(12, 6);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(616, 60);
            this.groupBoxConfig.TabIndex = 14;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "服务器配置";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(389, 12);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(60, 40);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "停止(&T)";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(323, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(60, 40);
            this.buttonConnect.TabIndex = 5;
            this.buttonConnect.Text = "连接(&L)";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPort.Location = new System.Drawing.Point(233, 19);
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(84, 26);
            this.numericUpDownPort.TabIndex = 4;
            this.numericUpDownPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(196, 26);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(31, 13);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "端口";
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(6, 27);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(43, 13);
            this.labelServer.TabIndex = 1;
            this.labelServer.Text = "服务器";
            // 
            // textBoxServerIP
            // 
            this.textBoxServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxServerIP.Location = new System.Drawing.Point(55, 19);
            this.textBoxServerIP.Name = "textBoxServerIP";
            this.textBoxServerIP.Size = new System.Drawing.Size(135, 26);
            this.textBoxServerIP.TabIndex = 0;
            this.textBoxServerIP.Text = "192.168.2.225";
            this.textBoxServerIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslabelMessage});
            this.statusStripMain.Location = new System.Drawing.Point(0, 457);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(640, 22);
            this.statusStripMain.TabIndex = 18;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // tsslabelMessage
            // 
            this.tsslabelMessage.AutoSize = false;
            this.tsslabelMessage.Name = "tsslabelMessage";
            this.tsslabelMessage.Size = new System.Drawing.Size(300, 17);
            // 
            // buttonSender
            // 
            this.buttonSender.Location = new System.Drawing.Point(479, 388);
            this.buttonSender.Name = "buttonSender";
            this.buttonSender.Size = new System.Drawing.Size(60, 60);
            this.buttonSender.TabIndex = 17;
            this.buttonSender.Text = "发送(&S)";
            this.buttonSender.UseVisualStyleBackColor = true;
            this.buttonSender.Click += new System.EventHandler(this.buttonSender_Click);
            // 
            // textBoxSender
            // 
            this.textBoxSender.Location = new System.Drawing.Point(12, 388);
            this.textBoxSender.Multiline = true;
            this.textBoxSender.Name = "textBoxSender";
            this.textBoxSender.Size = new System.Drawing.Size(460, 60);
            this.textBoxSender.TabIndex = 16;
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxMessage.Location = new System.Drawing.Point(12, 72);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(460, 310);
            this.richTextBoxMessage.TabIndex = 15;
            this.richTextBoxMessage.Text = "";
            // 
            // groupBoxClientList
            // 
            this.groupBoxClientList.Controls.Add(this.listBoxClientList);
            this.groupBoxClientList.Location = new System.Drawing.Point(479, 72);
            this.groupBoxClientList.Name = "groupBoxClientList";
            this.groupBoxClientList.Size = new System.Drawing.Size(149, 310);
            this.groupBoxClientList.TabIndex = 19;
            this.groupBoxClientList.TabStop = false;
            this.groupBoxClientList.Text = "客户端列表";
            // 
            // listBoxClientList
            // 
            this.listBoxClientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxClientList.FormattingEnabled = true;
            this.listBoxClientList.Location = new System.Drawing.Point(3, 16);
            this.listBoxClientList.Name = "listBoxClientList";
            this.listBoxClientList.Size = new System.Drawing.Size(143, 291);
            this.listBoxClientList.TabIndex = 0;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 479);
            this.Controls.Add(this.groupBoxClientList);
            this.Controls.Add(this.groupBoxConfig);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.buttonSender);
            this.Controls.Add(this.textBoxSender);
            this.Controls.Add(this.richTextBoxMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.groupBoxConfig.ResumeLayout(false);
            this.groupBoxConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.groupBoxClientList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.TextBox textBoxServerIP;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslabelMessage;
        private System.Windows.Forms.Button buttonSender;
        private System.Windows.Forms.TextBox textBoxSender;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.GroupBox groupBoxClientList;
        private System.Windows.Forms.ListBox listBoxClientList;
    }
}