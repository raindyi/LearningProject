namespace NT.TestDemo.UI.Forms
{
    partial class FormChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartUserInfo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonCreateData = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.chartUserBidResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessReportDataSet = new NT.TestDemo.UI.BusinessReportDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pieDataTableAdapter = new NT.TestDemo.UI.BusinessReportDataSetTableAdapters.PieDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chartUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUserBidResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessReportDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartUserInfo
            // 
            this.chartUserInfo.BorderlineColor = System.Drawing.SystemColors.ActiveBorder;
            this.chartUserInfo.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartUserInfo.Location = new System.Drawing.Point(3, 3);
            this.chartUserInfo.Name = "chartUserInfo";
            this.chartUserInfo.Size = new System.Drawing.Size(300, 522);
            this.chartUserInfo.TabIndex = 0;
            this.chartUserInfo.Text = "UserInfo";
            // 
            // buttonCreateData
            // 
            this.buttonCreateData.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCreateData.Location = new System.Drawing.Point(0, 0);
            this.buttonCreateData.Name = "buttonCreateData";
            this.buttonCreateData.Size = new System.Drawing.Size(75, 30);
            this.buttonCreateData.TabIndex = 1;
            this.buttonCreateData.Text = "CreateData";
            this.buttonCreateData.UseVisualStyleBackColor = true;
            this.buttonCreateData.Click += new System.EventHandler(this.buttonCreateData_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonReport.Location = new System.Drawing.Point(75, 0);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(75, 30);
            this.buttonReport.TabIndex = 2;
            this.buttonReport.Text = "Report";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // chartUserBidResult
            // 
            this.chartUserBidResult.BorderlineColor = System.Drawing.SystemColors.ActiveBorder;
            this.chartUserBidResult.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Area3DStyle.Inclination = 20;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.PointDepth = 1000;
            chartArea1.Area3DStyle.Rotation = 35;
            chartArea1.Area3DStyle.WallWidth = 3;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 55.87659F;
            chartArea1.InnerPlotPosition.Width = 95F;
            chartArea1.InnerPlotPosition.X = 1.368402F;
            chartArea1.InnerPlotPosition.Y = 22.0617F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 100F;
            chartArea1.Position.Y = 3F;
            this.chartUserBidResult.ChartAreas.Add(chartArea1);
            this.chartUserBidResult.DataSource = this.pieDataBindingSource;
            this.chartUserBidResult.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.SameAsSeriesOrder;
            legend1.Name = "Legend1";
            this.chartUserBidResult.Legends.Add(legend1);
            this.chartUserBidResult.Location = new System.Drawing.Point(309, 3);
            this.chartUserBidResult.Name = "chartUserBidResult";
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "DrawSideBySide=True, BarLabelStyle=Center, LabelStyle=Top";
            series1.IsXValueIndexed = true;
            series1.Label = "#VALX #VAL";
            series1.Legend = "Legend1";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.XValueMember = "Account";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueMembers = "Amount";
            this.chartUserBidResult.Series.Add(series1);
            this.chartUserBidResult.Size = new System.Drawing.Size(874, 522);
            this.chartUserBidResult.TabIndex = 3;
            this.chartUserBidResult.Text = "UserBidResult";
            // 
            // pieDataBindingSource
            // 
            this.pieDataBindingSource.DataMember = "PieData";
            this.pieDataBindingSource.DataSource = this.businessReportDataSet;
            // 
            // businessReportDataSet
            // 
            this.businessReportDataSet.DataSetName = "BusinessReportDataSet";
            this.businessReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.88533F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.11467F));
            this.tableLayoutPanel1.Controls.Add(this.chartUserBidResult, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartUserInfo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1186, 528);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonReport);
            this.splitContainer1.Panel1.Controls.Add(this.buttonCreateData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1186, 562);
            this.splitContainer1.SplitterDistance = 30;
            this.splitContainer1.TabIndex = 5;
            // 
            // pieDataTableAdapter
            // 
            this.pieDataTableAdapter.ClearBeforeFill = true;
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 562);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormChart";
            this.Text = "FormChart";
            this.Load += new System.EventHandler(this.FormChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUserBidResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessReportDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartUserInfo;
        private System.Windows.Forms.Button buttonCreateData;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUserBidResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private BusinessReportDataSet businessReportDataSet;
        private System.Windows.Forms.BindingSource pieDataBindingSource;
        private BusinessReportDataSetTableAdapters.PieDataTableAdapter pieDataTableAdapter;
    }
}