using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using NT.TestDemo.UI.Helper;

namespace NT.TestDemo.UI.Forms
{
    public partial class FormChart : Form
    {
        private DataTable _sourceUser = null;
        private DataTable _sourceBid = null;
        private RandomDataHelper _helper=new RandomDataHelper();
        public FormChart()
        {
            InitializeComponent();
        }
        private void ClearChart()
        {
            chartUserInfo.ChartAreas.Clear();
            chartUserInfo.Legends.Clear();
            chartUserInfo.Series.Clear();

            chartUserBidResult.ChartAreas.Clear();
            chartUserBidResult.Legends.Clear();
            chartUserBidResult.Series.Clear();
        }
        private void CreateReport()
        {
            if (_sourceUser != null && _sourceBid!=null)
            {
                ClearChart();
                DataTable reportdt = _sourceUser.Copy();
                chartUserInfo.DataSource = reportdt;
                ChartArea area = new ChartArea("caUser");
                area.Area3DStyle.Enable3D = true;
                Legend led = new Legend("ledUser");
                led.Docking = Docking.Bottom;
                Series ser = new Series("serUser");
                ser.XValueMember = "Account";
                ser.YValueMembers = "Summary";
                ser.ChartArea = area.Name;
                ser.ChartType = SeriesChartType.Pie;
                ser.CustomProperties = "PieLineColor=ActiveCaptionText, PieDrawingStyle=SoftEdge, PieLabelStyle=Outside";
                ser.Legend = led.Name;
                ser.Label = "#VALX #PERCENT";
                ser.IsVisibleInLegend = false;
                chartUserInfo.ChartAreas.Add(area);
                chartUserInfo.Legends.Add(led);
                chartUserInfo.Series.Add(ser);

                //TODO Column
                DataTable reportbid = _sourceBid.Copy();
                chartUserBidResult.DataSource = reportbid;
                ChartArea areabid = new ChartArea("caBid");
                Legend ledbid = new Legend("ledBid");
                ledbid.Docking=Docking.Bottom;
                
                Series serbidx = new Series("serBidx");
                serbidx.XValueMember = "";
                //serbidx.XValueMember = "SQ";
                serbidx.YValueMembers = "X";
                serbidx.ChartArea = areabid.Name;
                serbidx.ChartType = SeriesChartType.Bar;
                serbidx.Legend = ledbid.Name;
                serbidx.Label = "#VALX(#VAL{D})";
                serbidx.IsXValueIndexed = true;
                serbidx.CustomProperties = "DrawSideBySide=true";

                //Series serbidy = new Series("serBidy");
                //serbidy.XValueMember = "Account";
                //serbidy.YValueMembers = "Y";
                //serbidy.ChartArea = areabid.Name;
                //serbidy.ChartType = SeriesChartType.Bar;
                //serbidy.Legend = ledbid.Name;
                //serbidy.Label = "#VAL{D}";

                //Series serbidz = new Series("serBidz");
                //serbidz.XValueMember = "Account";
                //serbidz.YValueMembers = "Z";
                //serbidz.ChartArea = areabid.Name;
                //serbidz.ChartType = SeriesChartType.Bar;
                //serbidz.Legend = ledbid.Name;
                //serbidz.Label = "#VAL{D}";

                chartUserBidResult.ChartAreas.Add(areabid);
                chartUserBidResult.Legends.Add(ledbid);
                chartUserBidResult.Series.Add(serbidx);
                //chartUserBidResult.Series.Add(serbidy);
                //chartUserBidResult.Series.Add(serbidz);
            }
        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'businessReportDataSet.PieData' table. You can move, or remove it, as needed.
            this.pieDataTableAdapter.Fill(this.businessReportDataSet.PieData);
            
        }

        private void buttonCreateData_Click(object sender, EventArgs e)
        {
            _sourceUser = _helper.GetRandomReportData1();
            _sourceBid = _helper.GetRandomReportData2();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            CreateReport();
        }
    }
}
