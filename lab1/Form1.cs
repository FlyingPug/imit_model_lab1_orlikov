using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab1
{
    public partial class Form1 : Form
    {
        const decimal g = 9.81M;
        const decimal C = 0.15M;
        const decimal rho = 1.29M;

        int numberOfTests = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        decimal t, x, y, v0, cosa, sina, S, m, k, vx, vy;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                dt = 0.1M * ++numberOfTests;

                OutputTable.ColumnCount = numberOfTests + 1;
                OutputTable.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                for (int j = 0; j < 3; j++)
                {
                    OutputTable.Controls.Add(new Label() { Text = dt.ToString() }, numberOfTests, j + 1);
                }
                OutputTable.Controls.Add(new Label() { Text = (dt).ToString() }, numberOfTests, 0);
                OutputTable.Width += 100;

                maxHeightLabel = OutputTable.GetControlFromPosition(numberOfTests, 1) as Label;
                maxDistanceLabel = OutputTable.GetControlFromPosition(numberOfTests, 2) as Label;
                endSpeedLabel = OutputTable.GetControlFromPosition(numberOfTests, 3) as Label;

                MyChart.Series.Add(numberOfTests.ToString());
                MyChart.Series[numberOfTests - 1].Points.Clear();
                t = 0;
                x = 0;
                y = HeightInput.Value;
                v0 = SpeedInput.Value; // начальная скорость
                double a = (double)AngleInput.Value * Math.PI / 180;
                cosa = (decimal)Math.Cos(a);
                sina = (decimal)Math.Sin(a);
                S = SizeInput.Value; // размер
                m = WeightInput.Value; // весы
                k = 0.5M * C * rho * S / m;
                vx = v0 * cosa;
                vy = v0 * sina;
                MyChart.Series[numberOfTests - 1].Points.AddXY(x, y);
                MyChart.Series[numberOfTests - 1].ChartType = SeriesChartType.Line;

                timer1.Interval = (int)(dt * (decimal)1000);
                timer1.Start();
            }
        }

        decimal dt = 0.1M;
        decimal maxHeight = 0;
        Label maxHeightLabel;
        Label maxDistanceLabel;
        Label endSpeedLabel;
        private void timer1_Tick(object sender, EventArgs e)
        {
            t += dt;
            decimal v = (decimal)Math.Sqrt((double)(vx * vx + vy * vy));
            vx = vx - k * vx * v * dt;
            vy = vy - (g + k * vy * v) * dt;
            x = x + vx * dt;
            y = y + vy * dt;

            if (y > maxHeight) maxHeight = y;
            maxHeightLabel.Text = maxHeight.ToString();

            maxDistanceLabel.Text = x.ToString();
            Console.WriteLine(x);
            MyChart.Series[numberOfTests - 1].Points.AddXY(x, y);
            if (y <= 0)
            {
                endSpeedLabel.Text = v.ToString();
                timer1.Stop();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}