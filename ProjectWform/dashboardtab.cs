using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectWform
{
    public partial class dashboardtab : UserControl
    {
        public dashboardtab()
        {
            InitializeComponent();
            //MySqlConnection conn = DBUtils.GetDBConnection()
            using(MySqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("Select COUNT(*) from Users", conn))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    totalusers.Text = count.ToString();
                }
                using (var tproducts = new MySqlCommand("Select COUNT(*) from Products", conn))
                {
                    int countproducts = Convert.ToInt32(tproducts.ExecuteScalar());
                    totalproducts.Text = countproducts.ToString();
                }
                using (var sproducts = new MySqlCommand("Select COUNT(*) from Salelog", conn))
                {
                    int countsproducts = Convert.ToInt32(sproducts.ExecuteScalar());
                    productsold.Text = countsproducts.ToString();
                }
                conn.Close();
            }
            ChartLoad();
        }
        void ChartLoad()
        {
            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisX.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 0;
            chart.AxisY.Minimum = 0;

            chart.AxisX.Interval = 0.5;
            chart.AxisY.Interval = 10;

            chart1.Series[0].IsVisibleInLegend = false;

            chart1.Series.Add("P1");
            chart1.Series["P1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["P1"].Color = Color.Green;

            chart1.Series.Add("P2");
            chart1.Series["P2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["P2"].Color = Color.Red;
            //Query Add data Draw
            chart1.Series["P1"].Points.AddXY(1, 20);
            chart1.Series["P1"].Points.AddXY(2, 20);
            chart1.Series["P1"].Points.AddXY(3, 40);
            chart1.Series["P1"].Points.AddXY(4, 30);
            chart1.Series["P2"].Points.AddXY(1, 60);
            chart1.Series["P2"].Points.AddXY(2, 30);
            chart1.Series["P2"].Points.AddXY(3, 50);
            chart1.Series["P2"].Points.AddXY(4, 30);
            //End
            //query add PIE data
            chart2.Series["s2"].Points.AddXY("1", "30");
            chart2.Series["s2"].Points.AddXY("2", "20");
            chart2.Series["s2"].Points.AddXY("3", "10");
            chart2.Series["s2"].Points.AddXY("4", "25");
            chart2.Series["s2"].Points.AddXY("5", "15");
            //end
        }
        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
