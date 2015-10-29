namespace NT.TestDemo.UI.Forms
{
    partial class FormCapture
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCapture));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.textBoxVerificationCode = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelVerificationCode = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.btnConfigDetail = new System.Windows.Forms.Button();
            this.labelConfig = new System.Windows.Forms.Label();
            this.comboBoxConfig = new System.Windows.Forms.ComboBox();
            this.tabInformation = new System.Windows.Forms.TabControl();
            this.tabPageResult = new System.Windows.Forms.TabPage();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.tabPageSummary = new System.Windows.Forms.TabPage();
            this.textBoxSummary = new System.Windows.Forms.TextBox();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabInformation.SuspendLayout();
            this.tabPageResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.tabPageLog.SuspendLayout();
            this.tabPageSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.btnLogin);
            this.splitContainerMain.Panel1.Controls.Add(this.btnSummary);
            this.splitContainerMain.Panel1.Controls.Add(this.btnExit);
            this.splitContainerMain.Panel1.Controls.Add(this.btnStop);
            this.splitContainerMain.Panel1.Controls.Add(this.btnPause);
            this.splitContainerMain.Panel1.Controls.Add(this.btnStart);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxVerificationCode);
            this.splitContainerMain.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainerMain.Panel1.Controls.Add(this.labelVerificationCode);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxPassword);
            this.splitContainerMain.Panel1.Controls.Add(this.labelPassword);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxUser);
            this.splitContainerMain.Panel1.Controls.Add(this.labelUser);
            this.splitContainerMain.Panel1.Controls.Add(this.btnConfigDetail);
            this.splitContainerMain.Panel1.Controls.Add(this.labelConfig);
            this.splitContainerMain.Panel1.Controls.Add(this.comboBoxConfig);
            this.splitContainerMain.Panel1MinSize = 125;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tabInformation);
            this.splitContainerMain.Size = new System.Drawing.Size(684, 462);
            this.splitContainerMain.SplitterDistance = 125;
            this.splitContainerMain.TabIndex = 0;
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(435, 73);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(75, 30);
            this.btnSummary.TabIndex = 14;
            this.btnSummary.Text = "统计";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(647, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 13;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(516, 37);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 30);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(435, 37);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 30);
            this.btnPause.TabIndex = 11;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(354, 37);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 30);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // textBoxVerificationCode
            // 
            this.textBoxVerificationCode.Location = new System.Drawing.Point(61, 89);
            this.textBoxVerificationCode.Name = "textBoxVerificationCode";
            this.textBoxVerificationCode.PasswordChar = '*';
            this.textBoxVerificationCode.Size = new System.Drawing.Size(151, 20);
            this.textBoxVerificationCode.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(218, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 68);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelVerificationCode
            // 
            this.labelVerificationCode.AutoSize = true;
            this.labelVerificationCode.Location = new System.Drawing.Point(12, 92);
            this.labelVerificationCode.Name = "labelVerificationCode";
            this.labelVerificationCode.Size = new System.Drawing.Size(43, 13);
            this.labelVerificationCode.TabIndex = 7;
            this.labelVerificationCode.Text = "验证码";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(61, 63);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(151, 20);
            this.textBoxPassword.TabIndex = 6;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(24, 66);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(31, 13);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "密码";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(61, 37);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(151, 20);
            this.textBoxUser.TabIndex = 4;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(24, 40);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(31, 13);
            this.labelUser.TabIndex = 3;
            this.labelUser.Text = "用户";
            // 
            // btnConfigDetail
            // 
            this.btnConfigDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfigDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnConfigDetail.Image")));
            this.btnConfigDetail.Location = new System.Drawing.Point(214, 7);
            this.btnConfigDetail.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.btnConfigDetail.Name = "btnConfigDetail";
            this.btnConfigDetail.Size = new System.Drawing.Size(25, 25);
            this.btnConfigDetail.TabIndex = 2;
            this.btnConfigDetail.UseVisualStyleBackColor = true;
            // 
            // labelConfig
            // 
            this.labelConfig.AutoSize = true;
            this.labelConfig.Location = new System.Drawing.Point(24, 13);
            this.labelConfig.Name = "labelConfig";
            this.labelConfig.Size = new System.Drawing.Size(31, 13);
            this.labelConfig.TabIndex = 1;
            this.labelConfig.Text = "配置";
            // 
            // comboBoxConfig
            // 
            this.comboBoxConfig.FormattingEnabled = true;
            this.comboBoxConfig.Location = new System.Drawing.Point(61, 10);
            this.comboBoxConfig.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.comboBoxConfig.Name = "comboBoxConfig";
            this.comboBoxConfig.Size = new System.Drawing.Size(151, 21);
            this.comboBoxConfig.TabIndex = 0;
            this.comboBoxConfig.SelectedValueChanged += new System.EventHandler(this.comboBoxConfig_SelectedValueChanged);
            // 
            // tabInformation
            // 
            this.tabInformation.Controls.Add(this.tabPageResult);
            this.tabInformation.Controls.Add(this.tabPageLog);
            this.tabInformation.Controls.Add(this.tabPageSummary);
            this.tabInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInformation.Location = new System.Drawing.Point(0, 0);
            this.tabInformation.Name = "tabInformation";
            this.tabInformation.SelectedIndex = 0;
            this.tabInformation.Size = new System.Drawing.Size(684, 333);
            this.tabInformation.TabIndex = 0;
            // 
            // tabPageResult
            // 
            this.tabPageResult.Controls.Add(this.dataGridViewResult);
            this.tabPageResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResult.Size = new System.Drawing.Size(676, 307);
            this.tabPageResult.TabIndex = 0;
            this.tabPageResult.Text = "结果";
            this.tabPageResult.UseVisualStyleBackColor = true;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(670, 301);
            this.dataGridViewResult.TabIndex = 0;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.textBoxLog);
            this.tabPageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(676, 307);
            this.tabPageLog.TabIndex = 1;
            this.tabPageLog.Text = "日志";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.Color.Black;
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxLog.Location = new System.Drawing.Point(3, 3);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(670, 301);
            this.textBoxLog.TabIndex = 0;
            // 
            // tabPageSummary
            // 
            this.tabPageSummary.Controls.Add(this.textBoxSummary);
            this.tabPageSummary.Location = new System.Drawing.Point(4, 22);
            this.tabPageSummary.Name = "tabPageSummary";
            this.tabPageSummary.Size = new System.Drawing.Size(676, 307);
            this.tabPageSummary.TabIndex = 2;
            this.tabPageSummary.Text = "统计";
            this.tabPageSummary.UseVisualStyleBackColor = true;
            // 
            // textBoxSummary
            // 
            this.textBoxSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSummary.Location = new System.Drawing.Point(0, 0);
            this.textBoxSummary.Multiline = true;
            this.textBoxSummary.Name = "textBoxSummary";
            this.textBoxSummary.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSummary.Size = new System.Drawing.Size(676, 307);
            this.textBoxSummary.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(354, 73);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 30);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FormCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainerMain);
            this.Name = "FormCapture";
            this.Text = "FormCapture";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCapture_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabInformation.ResumeLayout(false);
            this.tabPageResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.tabPageLog.ResumeLayout(false);
            this.tabPageLog.PerformLayout();
            this.tabPageSummary.ResumeLayout(false);
            this.tabPageSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TabControl tabInformation;
        private System.Windows.Forms.TabPage tabPageResult;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label labelConfig;
        private System.Windows.Forms.ComboBox comboBoxConfig;
        private System.Windows.Forms.Button btnConfigDetail;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelVerificationCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxVerificationCode;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.TabPage tabPageSummary;
        private System.Windows.Forms.TextBox textBoxSummary;
        private System.Windows.Forms.Button btnLogin;
    }
}