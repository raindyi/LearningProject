namespace NT.TestDemo.UI.Forms
{
    partial class FormJsonToClass
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
            this.splitContainerLR = new System.Windows.Forms.SplitContainer();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.splitContainerTB = new System.Windows.Forms.SplitContainer();
            this.btnJsonToClass = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.saveFileDialogMain = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLR)).BeginInit();
            this.splitContainerLR.Panel1.SuspendLayout();
            this.splitContainerLR.Panel2.SuspendLayout();
            this.splitContainerLR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTB)).BeginInit();
            this.splitContainerTB.Panel1.SuspendLayout();
            this.splitContainerTB.Panel2.SuspendLayout();
            this.splitContainerTB.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerLR
            // 
            this.splitContainerLR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLR.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLR.Name = "splitContainerLR";
            // 
            // splitContainerLR.Panel1
            // 
            this.splitContainerLR.Panel1.Controls.Add(this.textBoxSource);
            // 
            // splitContainerLR.Panel2
            // 
            this.splitContainerLR.Panel2.Controls.Add(this.splitContainerTB);
            this.splitContainerLR.Size = new System.Drawing.Size(777, 538);
            this.splitContainerLR.SplitterDistance = 417;
            this.splitContainerLR.TabIndex = 0;
            // 
            // textBoxSource
            // 
            this.textBoxSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSource.Location = new System.Drawing.Point(0, 0);
            this.textBoxSource.Multiline = true;
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(417, 538);
            this.textBoxSource.TabIndex = 0;
            // 
            // splitContainerTB
            // 
            this.splitContainerTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTB.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerTB.IsSplitterFixed = true;
            this.splitContainerTB.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTB.Name = "splitContainerTB";
            this.splitContainerTB.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTB.Panel1
            // 
            this.splitContainerTB.Panel1.Controls.Add(this.btnJsonToClass);
            this.splitContainerTB.Panel1.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainerTB.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainerTB.Panel2
            // 
            this.splitContainerTB.Panel2.Controls.Add(this.textBoxResult);
            this.splitContainerTB.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainerTB.Size = new System.Drawing.Size(356, 538);
            this.splitContainerTB.SplitterDistance = 30;
            this.splitContainerTB.TabIndex = 0;
            // 
            // btnJsonToClass
            // 
            this.btnJsonToClass.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnJsonToClass.Location = new System.Drawing.Point(278, 3);
            this.btnJsonToClass.Name = "btnJsonToClass";
            this.btnJsonToClass.Size = new System.Drawing.Size(75, 24);
            this.btnJsonToClass.TabIndex = 0;
            this.btnJsonToClass.Text = "JsonToClass";
            this.btnJsonToClass.UseVisualStyleBackColor = true;
            this.btnJsonToClass.Click += new System.EventHandler(this.btnJsonToClass_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult.Location = new System.Drawing.Point(0, 0);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(356, 504);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxResult_MouseDoubleClick);
            // 
            // FormJsonToClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 538);
            this.Controls.Add(this.splitContainerLR);
            this.Name = "FormJsonToClass";
            this.Text = "JsonToClass";
            this.splitContainerLR.Panel1.ResumeLayout(false);
            this.splitContainerLR.Panel1.PerformLayout();
            this.splitContainerLR.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLR)).EndInit();
            this.splitContainerLR.ResumeLayout(false);
            this.splitContainerTB.Panel1.ResumeLayout(false);
            this.splitContainerTB.Panel2.ResumeLayout(false);
            this.splitContainerTB.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTB)).EndInit();
            this.splitContainerTB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerLR;
        private System.Windows.Forms.SplitContainer splitContainerTB;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button btnJsonToClass;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain;
    }
}