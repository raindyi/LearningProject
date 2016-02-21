namespace NT.Private.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelConfig = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonSplit = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.radioButtonKB = new System.Windows.Forms.RadioButton();
            this.labelSize = new System.Windows.Forms.Label();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.labelSplit = new System.Windows.Forms.Label();
            this.numericUpDownSplit = new System.Windows.Forms.NumericUpDown();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.buttonPause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.flowLayoutPanelConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSplit)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.flowLayoutPanelConfig);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.richTextBoxMessage);
            this.splitContainerMain.Size = new System.Drawing.Size(614, 176);
            this.splitContainerMain.SplitterDistance = 232;
            this.splitContainerMain.TabIndex = 1;
            // 
            // flowLayoutPanelConfig
            // 
            this.flowLayoutPanelConfig.Controls.Add(this.buttonChoose);
            this.flowLayoutPanelConfig.Controls.Add(this.buttonSplit);
            this.flowLayoutPanelConfig.Controls.Add(this.buttonPause);
            this.flowLayoutPanelConfig.Controls.Add(this.buttonOpen);
            this.flowLayoutPanelConfig.Controls.Add(this.labelFileName);
            this.flowLayoutPanelConfig.Controls.Add(this.radioButtonM);
            this.flowLayoutPanelConfig.Controls.Add(this.radioButtonKB);
            this.flowLayoutPanelConfig.Controls.Add(this.labelSize);
            this.flowLayoutPanelConfig.Controls.Add(this.numericUpDownSize);
            this.flowLayoutPanelConfig.Controls.Add(this.labelSplit);
            this.flowLayoutPanelConfig.Controls.Add(this.numericUpDownSplit);
            this.flowLayoutPanelConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelConfig.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelConfig.Name = "flowLayoutPanelConfig";
            this.flowLayoutPanelConfig.Padding = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelConfig.Size = new System.Drawing.Size(232, 176);
            this.flowLayoutPanelConfig.TabIndex = 0;
            // 
            // buttonChoose
            // 
            this.buttonChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoose.Image = ((System.Drawing.Image)(resources.GetObject("buttonChoose.Image")));
            this.buttonChoose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonChoose.Location = new System.Drawing.Point(5, 5);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(50, 50);
            this.buttonChoose.TabIndex = 1;
            this.buttonChoose.Text = "&C";
            this.buttonChoose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonSplit
            // 
            this.buttonSplit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSplit.Image = ((System.Drawing.Image)(resources.GetObject("buttonSplit.Image")));
            this.buttonSplit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSplit.Location = new System.Drawing.Point(61, 5);
            this.buttonSplit.Name = "buttonSplit";
            this.buttonSplit.Size = new System.Drawing.Size(50, 50);
            this.buttonSplit.TabIndex = 1;
            this.buttonSplit.Text = "&S";
            this.buttonSplit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSplit.UseVisualStyleBackColor = true;
            this.buttonSplit.Click += new System.EventHandler(this.buttonSplit_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileName.Location = new System.Drawing.Point(5, 61);
            this.labelFileName.Margin = new System.Windows.Forms.Padding(3);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(177, 23);
            this.labelFileName.TabIndex = 0;
            // 
            // radioButtonM
            // 
            this.radioButtonM.Location = new System.Drawing.Point(5, 90);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(100, 20);
            this.radioButtonM.TabIndex = 3;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "M";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // radioButtonKB
            // 
            this.radioButtonKB.Location = new System.Drawing.Point(111, 90);
            this.radioButtonKB.Name = "radioButtonKB";
            this.radioButtonKB.Size = new System.Drawing.Size(100, 20);
            this.radioButtonKB.TabIndex = 4;
            this.radioButtonKB.TabStop = true;
            this.radioButtonKB.Text = "KB";
            this.radioButtonKB.UseVisualStyleBackColor = true;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(5, 116);
            this.labelSize.Margin = new System.Windows.Forms.Padding(3);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(37, 16);
            this.labelSize.TabIndex = 1;
            this.labelSize.Text = "Size:";
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.numericUpDownSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSize.Location = new System.Drawing.Point(48, 116);
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(145, 22);
            this.numericUpDownSize.TabIndex = 2;
            // 
            // labelSplit
            // 
            this.labelSplit.AutoSize = true;
            this.labelSplit.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSplit.Location = new System.Drawing.Point(5, 138);
            this.labelSplit.Margin = new System.Windows.Forms.Padding(3);
            this.labelSplit.Name = "labelSplit";
            this.labelSplit.Size = new System.Drawing.Size(37, 16);
            this.labelSplit.TabIndex = 5;
            this.labelSplit.Text = "Split:";
            // 
            // numericUpDownSplit
            // 
            this.numericUpDownSplit.Dock = System.Windows.Forms.DockStyle.Left;
            this.numericUpDownSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSplit.Location = new System.Drawing.Point(48, 138);
            this.numericUpDownSplit.Name = "numericUpDownSplit";
            this.numericUpDownSplit.Size = new System.Drawing.Size(145, 22);
            this.numericUpDownSplit.TabIndex = 6;
            // 
            // buttonOpen
            // 
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen.Image")));
            this.buttonOpen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOpen.Location = new System.Drawing.Point(173, 5);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(50, 50);
            this.buttonOpen.TabIndex = 7;
            this.buttonOpen.Text = "&O";
            this.buttonOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.BackColor = System.Drawing.Color.SlateGray;
            this.richTextBoxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxMessage.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxMessage.ForeColor = System.Drawing.Color.SeaShell;
            this.richTextBoxMessage.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(378, 176);
            this.richTextBoxMessage.TabIndex = 0;
            this.richTextBoxMessage.Text = "";
            // 
            // openFileDialogMain
            // 
            this.openFileDialogMain.FileName = "openFileDialog1";
            // 
            // buttonPause
            // 
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.Image = ((System.Drawing.Image)(resources.GetObject("buttonPause.Image")));
            this.buttonPause.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPause.Location = new System.Drawing.Point(117, 5);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(50, 50);
            this.buttonPause.TabIndex = 8;
            this.buttonPause.Text = "&O";
            this.buttonPause.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 176);
            this.Controls.Add(this.splitContainerMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Split File";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.flowLayoutPanelConfig.ResumeLayout(false);
            this.flowLayoutPanelConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSplit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelConfig;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonSplit;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.RadioButton radioButtonKB;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.Label labelSplit;
        private System.Windows.Forms.NumericUpDown numericUpDownSplit;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.Button buttonPause;

    }
}