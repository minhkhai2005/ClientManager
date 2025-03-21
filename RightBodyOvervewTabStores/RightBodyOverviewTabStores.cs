using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;

namespace RightBodyOvervewTabStores
{
    
    public partial class RightBodyOverviewTabStores: UserControl
    {
        private readonly string[] languages = {"English", "Vietnamese"};
        private readonly string[] time = { "Day", "Week" };
        public RightBodyOverviewTabStores()
        {
            InitializeComponent();
            DisplayBarChart();
            LanguagesBox.Items.AddRange(languages);
            TimeBox.Items.AddRange(time);
            LanguagesBox.SelectedIndex = 0;
            TimeBox.SelectedIndex = 0;
        }

        public void DisplayBarChart()
        {
            // this function is used for debugging purposes
            // it is used to display a bar chart on the right body overview tab
            double[] xs1 = { 1, 2, 3, 4 };
            double[] ys1 = { 5, 10, 7, 13 };
            var bars1 = formsPlot1.Plot.Add.Bars(xs1, ys1);
            bars1.LegendText = "Alpha";

            double[] xs2 = { 6, 7, 8, 9 };
            double[] ys2 = { 7, 12, 9, 15 };
            var bars2 = formsPlot1.Plot.Add.Bars(xs2, ys2);
            bars2.LegendText = "Beta";

            formsPlot1.Plot.ShowLegend(Alignment.UpperLeft);
            formsPlot1.Plot.Axes.Margins(bottom: 0);


            formsPlot1.Refresh();
        }
    }
}
