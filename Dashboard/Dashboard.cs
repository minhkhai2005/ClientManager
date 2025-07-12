using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseClass;
using static Sign_In.Sign_in;
using System.Windows.Forms.DataVisualization.Charting;

namespace Dashboard
{
   
    public partial class Dashboard: UserControl
    {
        readonly List<string> TimeBoxItems = new List<String> { "Month", "Week", "Day" };
        List<DatabaseAccess.MonthRevenue> monthlyRevenue = new List<DatabaseAccess.MonthRevenue>();
        List<DatabaseAccess.WeekRevenue> weeklyRevenue = new List<DatabaseAccess.WeekRevenue>();
        List<DatabaseAccess.DayRevenue> dailyRevenue = new List<DatabaseAccess.DayRevenue>();

        public Dashboard()
        {
            InitializeComponent();
            
            // Load initial data
            monthlyRevenue = DatabaseAccess.GetMonthlyRevenue(Session.UID);
            weeklyRevenue = DatabaseAccess.GetWeeklyRevenue(Session.UID);
            dailyRevenue = DatabaseAccess.GetDailyRevenue(Session.UID);

            TimeComboBox.DataSource = TimeBoxItems;
            TimeComboBox.SelectedIndex = 0; // Default to "Month"
        }
        public void UpdateData(double revenue, int orders)
        {
            RevenueValue.Text = revenue.ToString();
            OrderValue.Text = orders.ToString();
        }
        public void DrawMonthlyChart()
        {
            chart1.Series.Clear();
            chart1.Series.Add("Monthly Revenue");
            chart1.Series["Monthly Revenue"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (var item in monthlyRevenue)
            {
                chart1.Series["Monthly Revenue"].Points.AddXY(item.month, item.revenue);
            }
        }
        public void DrawWeeklyChart()
        {
            chart1.Series.Clear();
            chart1.Series.Add("Weekly Revenue");
            chart1.Series["Weekly Revenue"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (var item in weeklyRevenue)
            {
                chart1.Series["Weekly Revenue"].Points.AddXY(item.week, item.revenue);
            }
        }
        public void DrawDailyChart()
        {
            chart1.Series.Clear();
            chart1.Series.Add("Daily Revenue");
            chart1.Series["Daily Revenue"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (var item in dailyRevenue)
            {
                chart1.Series["Daily Revenue"].Points.AddXY(item.day, item.revenue);
            }
        }

        private void TimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TimeComboBox.SelectedItem.ToString())
            {
                case "Month":
                    DrawMonthlyChart();
                    break;
                case "Week":
                    DrawWeeklyChart();
                    break;
                case "Day":
                    DrawDailyChart();
                    break;
                default:
                    MessageBox.Show("Invalid selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
