namespace NT.TestDemo.UI.Forms
{
    partial class FormThreadGroup
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.buttonGroup1 = new System.Windows.Forms.Button();
            this.buttonGroup2 = new System.Windows.Forms.Button();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.buttonGroup3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.buttonGroup3);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonGroup2);
            this.splitContainerMain.Panel1.Controls.Add(this.buttonGroup1);
            this.splitContainerMain.Panel1.Padding = new System.Windows.Forms.Padding(2);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.richTextBoxLog);
            this.splitContainerMain.Size = new System.Drawing.Size(691, 414);
            this.splitContainerMain.SplitterDistance = 75;
            this.splitContainerMain.TabIndex = 0;
            // 
            // buttonGroup1
            // 
            this.buttonGroup1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGroup1.Location = new System.Drawing.Point(2, 2);
            this.buttonGroup1.Name = "buttonGroup1";
            this.buttonGroup1.Size = new System.Drawing.Size(71, 23);
            this.buttonGroup1.TabIndex = 0;
            this.buttonGroup1.Text = "Group1";
            this.buttonGroup1.UseVisualStyleBackColor = true;
            this.buttonGroup1.Click += new System.EventHandler(this.buttonGroup1_Click);
            // 
            // buttonGroup2
            // 
            this.buttonGroup2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGroup2.Location = new System.Drawing.Point(2, 25);
            this.buttonGroup2.Name = "buttonGroup2";
            this.buttonGroup2.Size = new System.Drawing.Size(71, 23);
            this.buttonGroup2.TabIndex = 1;
            this.buttonGroup2.Text = "Group2";
            this.buttonGroup2.UseVisualStyleBackColor = true;
            this.buttonGroup2.Click += new System.EventHandler(this.buttonGroup2_Click);
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLog.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(612, 414);
            this.richTextBoxLog.TabIndex = 0;
            this.richTextBoxLog.Text = "";
            // 
            // buttonGroup3
            // 
            this.buttonGroup3.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGroup3.Location = new System.Drawing.Point(2, 48);
            this.buttonGroup3.Name = "buttonGroup3";
            this.buttonGroup3.Size = new System.Drawing.Size(71, 23);
            this.buttonGroup3.TabIndex = 2;
            this.buttonGroup3.Text = "Group3";
            this.buttonGroup3.UseVisualStyleBackColor = true;
            this.buttonGroup3.Click += new System.EventHandler(this.buttonGroup3_Click);
            // 
            // FormThreadGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 414);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "FormThreadGroup";
            this.Text = "FormThreadGroup";
            this.Load += new System.EventHandler(this.FormThreadGroup_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Button buttonGroup1;
        private System.Windows.Forms.Button buttonGroup2;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Button buttonGroup3;
    }
}