namespace Lynn.SocketProject.Server.UI
{
    partial class ServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            this.groupBoxServerControl = new System.Windows.Forms.GroupBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.labelServerState = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.listBoxClientList = new System.Windows.Forms.ListBox();
            this.richTextBoxReceiver = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSender = new System.Windows.Forms.RichTextBox();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.tsslabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.buttonSender = new System.Windows.Forms.Button();
            this.groupBoxSender = new System.Windows.Forms.GroupBox();
            this.groupBoxReceiver = new System.Windows.Forms.GroupBox();
            this.groupBoxClientList = new System.Windows.Forms.GroupBox();
            this.checkBoxGroup = new System.Windows.Forms.CheckBox();
            this.groupBoxServerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.statusStripMain.SuspendLayout();
            this.groupBoxSender.SuspendLayout();
            this.groupBoxReceiver.SuspendLayout();
            this.groupBoxClientList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxServerControl
            // 
            this.groupBoxServerControl.Controls.Add(this.labelPort);
            this.groupBoxServerControl.Controls.Add(this.numericUpDownPort);
            this.groupBoxServerControl.Controls.Add(this.labelServerState);
            this.groupBoxServerControl.Controls.Add(this.buttonStop);
            this.groupBoxServerControl.Controls.Add(this.buttonStart);
            this.groupBoxServerControl.Location = new System.Drawing.Point(12, 6);
            this.groupBoxServerControl.Name = "groupBoxServerControl";
            this.groupBoxServerControl.Size = new System.Drawing.Size(209, 110);
            this.groupBoxServerControl.TabIndex = 14;
            this.groupBoxServerControl.TabStop = false;
            this.groupBoxServerControl.Text = "控制设置";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(119, 24);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(31, 13);
            this.labelPort.TabIndex = 4;
            this.labelPort.Text = "端口";
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPort.Location = new System.Drawing.Point(119, 43);
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(84, 26);
            this.numericUpDownPort.TabIndex = 3;
            this.numericUpDownPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelServerState
            // 
            this.labelServerState.AutoSize = true;
            this.labelServerState.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServerState.Location = new System.Drawing.Point(6, 72);
            this.labelServerState.Name = "labelServerState";
            this.labelServerState.Size = new System.Drawing.Size(145, 29);
            this.labelServerState.TabIndex = 2;
            this.labelServerState.Text = "Server State";
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(62, 19);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(50, 50);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(6, 19);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(50, 50);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // listBoxClientList
            // 
            this.listBoxClientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxClientList.FormattingEnabled = true;
            this.listBoxClientList.Location = new System.Drawing.Point(3, 16);
            this.listBoxClientList.Name = "listBoxClientList";
            this.listBoxClientList.Size = new System.Drawing.Size(275, 91);
            this.listBoxClientList.TabIndex = 2;
            // 
            // richTextBoxReceiver
            // 
            this.richTextBoxReceiver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxReceiver.Location = new System.Drawing.Point(3, 16);
            this.richTextBoxReceiver.Name = "richTextBoxReceiver";
            this.richTextBoxReceiver.Size = new System.Drawing.Size(369, 400);
            this.richTextBoxReceiver.TabIndex = 5;
            this.richTextBoxReceiver.Text = "";
            // 
            // richTextBoxSender
            // 
            this.richTextBoxSender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxSender.Location = new System.Drawing.Point(3, 16);
            this.richTextBoxSender.Name = "richTextBoxSender";
            this.richTextBoxSender.Size = new System.Drawing.Size(370, 328);
            this.richTextBoxSender.TabIndex = 7;
            this.richTextBoxSender.Text = "";
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslabelMessage});
            this.statusStripMain.Location = new System.Drawing.Point(0, 544);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(784, 22);
            this.statusStripMain.TabIndex = 20;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // tsslabelMessage
            // 
            this.tsslabelMessage.AutoSize = false;
            this.tsslabelMessage.Name = "tsslabelMessage";
            this.tsslabelMessage.Size = new System.Drawing.Size(300, 17);
            // 
            // textBoxSender
            // 
            this.textBoxSender.Location = new System.Drawing.Point(396, 475);
            this.textBoxSender.Multiline = true;
            this.textBoxSender.Name = "textBoxSender";
            this.textBoxSender.Size = new System.Drawing.Size(291, 63);
            this.textBoxSender.TabIndex = 19;
            // 
            // buttonSender
            // 
            this.buttonSender.Location = new System.Drawing.Point(693, 475);
            this.buttonSender.Name = "buttonSender";
            this.buttonSender.Size = new System.Drawing.Size(35, 63);
            this.buttonSender.TabIndex = 18;
            this.buttonSender.Text = "发送(&S)";
            this.buttonSender.UseVisualStyleBackColor = true;
            this.buttonSender.Click += new System.EventHandler(this.buttonSender_Click);
            // 
            // groupBoxSender
            // 
            this.groupBoxSender.Controls.Add(this.richTextBoxSender);
            this.groupBoxSender.Location = new System.Drawing.Point(396, 122);
            this.groupBoxSender.Name = "groupBoxSender";
            this.groupBoxSender.Size = new System.Drawing.Size(376, 347);
            this.groupBoxSender.TabIndex = 17;
            this.groupBoxSender.TabStop = false;
            this.groupBoxSender.Text = "发送消息";
            // 
            // groupBoxReceiver
            // 
            this.groupBoxReceiver.Controls.Add(this.richTextBoxReceiver);
            this.groupBoxReceiver.Location = new System.Drawing.Point(12, 122);
            this.groupBoxReceiver.Name = "groupBoxReceiver";
            this.groupBoxReceiver.Size = new System.Drawing.Size(375, 419);
            this.groupBoxReceiver.TabIndex = 16;
            this.groupBoxReceiver.TabStop = false;
            this.groupBoxReceiver.Text = "接收消息";
            // 
            // groupBoxClientList
            // 
            this.groupBoxClientList.Controls.Add(this.listBoxClientList);
            this.groupBoxClientList.Location = new System.Drawing.Point(396, 6);
            this.groupBoxClientList.Name = "groupBoxClientList";
            this.groupBoxClientList.Size = new System.Drawing.Size(281, 110);
            this.groupBoxClientList.TabIndex = 15;
            this.groupBoxClientList.TabStop = false;
            this.groupBoxClientList.Text = "客户端列表";
            // 
            // checkBoxGroup
            // 
            this.checkBoxGroup.Location = new System.Drawing.Point(734, 475);
            this.checkBoxGroup.Name = "checkBoxGroup";
            this.checkBoxGroup.Size = new System.Drawing.Size(38, 63);
            this.checkBoxGroup.TabIndex = 21;
            this.checkBoxGroup.Text = "群发";
            this.checkBoxGroup.UseVisualStyleBackColor = true;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 566);
            this.Controls.Add(this.checkBoxGroup);
            this.Controls.Add(this.groupBoxServerControl);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.textBoxSender);
            this.Controls.Add(this.buttonSender);
            this.Controls.Add(this.groupBoxSender);
            this.Controls.Add(this.groupBoxReceiver);
            this.Controls.Add(this.groupBoxClientList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServerForm";
            this.Text = "ServerForm";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.groupBoxServerControl.ResumeLayout(false);
            this.groupBoxServerControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.groupBoxSender.ResumeLayout(false);
            this.groupBoxReceiver.ResumeLayout(false);
            this.groupBoxClientList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxServerControl;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.Label labelServerState;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ListBox listBoxClientList;
        private System.Windows.Forms.RichTextBox richTextBoxReceiver;
        private System.Windows.Forms.RichTextBox richTextBoxSender;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslabelMessage;
        private System.Windows.Forms.TextBox textBoxSender;
        private System.Windows.Forms.Button buttonSender;
        private System.Windows.Forms.GroupBox groupBoxSender;
        private System.Windows.Forms.GroupBox groupBoxReceiver;
        private System.Windows.Forms.GroupBox groupBoxClientList;
        private System.Windows.Forms.CheckBox checkBoxGroup;
    }
}