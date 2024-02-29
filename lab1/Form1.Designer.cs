using System.Windows.Forms.DataVisualization.Charting;

namespace lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ChartArea chartArea1 = new ChartArea();
            Series series1 = new Series();
            panel1 = new Panel();
            WeightInput = new NumericUpDown();
            label4 = new Label();
            Size = new Label();
            SizeInput = new NumericUpDown();
            SpeedInput = new NumericUpDown();
            AngleInput = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            HeightInput = new NumericUpDown();
            CalculateButton = new Button();
            MyChart = new Chart();
            timer1 = new System.Windows.Forms.Timer(components);
            OutputTable = new TableLayoutPanel();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WeightInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SizeInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpeedInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AngleInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HeightInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MyChart).BeginInit();
            OutputTable.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(WeightInput);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Size);
            panel1.Controls.Add(SizeInput);
            panel1.Controls.Add(SpeedInput);
            panel1.Controls.Add(AngleInput);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(HeightInput);
            panel1.Controls.Add(CalculateButton);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 156);
            panel1.TabIndex = 0;
            // 
            // WeightInput
            // 
            WeightInput.Location = new Point(305, 67);
            WeightInput.Name = "WeightInput";
            WeightInput.Size = new Size(150, 27);
            WeightInput.TabIndex = 10;
            WeightInput.Value = new decimal(new int[] { 45, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(245, 67);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 9;
            label4.Text = "Weight";
            // 
            // Size
            // 
            Size.AutoSize = true;
            Size.Location = new Point(245, 13);
            Size.Name = "Size";
            Size.Size = new Size(36, 20);
            Size.TabIndex = 8;
            Size.Text = "Size";
            // 
            // SizeInput
            // 
            SizeInput.Location = new Point(305, 11);
            SizeInput.Name = "SizeInput";
            SizeInput.Size = new Size(150, 27);
            SizeInput.TabIndex = 7;
            // 
            // SpeedInput
            // 
            SpeedInput.Location = new Point(70, 115);
            SpeedInput.Name = "SpeedInput";
            SpeedInput.Size = new Size(150, 27);
            SpeedInput.TabIndex = 6;
            SpeedInput.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // AngleInput
            // 
            AngleInput.Location = new Point(70, 67);
            AngleInput.Name = "AngleInput";
            AngleInput.Size = new Size(150, 27);
            AngleInput.TabIndex = 5;
            AngleInput.Value = new decimal(new int[] { 45, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 117);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 4;
            label3.Text = "Speed";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 67);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 3;
            label2.Text = "Angle";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 13);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 2;
            label1.Text = "Height";
            label1.Click += label1_Click;
            // 
            // HeightInput
            // 
            HeightInput.Location = new Point(70, 11);
            HeightInput.Name = "HeightInput";
            HeightInput.Size = new Size(150, 27);
            HeightInput.TabIndex = 1;
            HeightInput.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(245, 113);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(210, 29);
            CalculateButton.TabIndex = 0;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += button1_Click;
            // 
            // MyChart
            // 
            MyChart.BackImageAlignment = ChartImageAlignmentStyle.Top;
            MyChart.BorderlineColor = SystemColors.WindowFrame;
            chartArea1.AxisX.Maximum = 50D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 50D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            MyChart.ChartAreas.Add(chartArea1);
            MyChart.Location = new Point(2, 151);
            MyChart.Name = "MyChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Line;
            series1.Color = Color.Black;
            series1.LabelBackColor = Color.Black;
            series1.LabelBorderColor = Color.Black;
            series1.Name = "Series1";
            MyChart.Series.Add(series1);
            MyChart.Size = new Size(700, 700);
            MyChart.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // OutputTable
            // 
            OutputTable.ColumnCount = 1;
            OutputTable.ColumnStyles.Add(new ColumnStyle());
            OutputTable.ColumnStyles.Add(new ColumnStyle());
            OutputTable.Controls.Add(label5, 0, 0);
            OutputTable.Controls.Add(label7, 0, 2);
            OutputTable.Controls.Add(label6, 0, 1);
            OutputTable.Controls.Add(label8, 0, 3);
            OutputTable.Location = new Point(718, 165);
            OutputTable.Name = "OutputTable";
            OutputTable.RowCount = 4;
            OutputTable.RowStyles.Add(new RowStyle());
            OutputTable.RowStyles.Add(new RowStyle());
            OutputTable.RowStyles.Add(new RowStyle());
            OutputTable.RowStyles.Add(new RowStyle());
            OutputTable.Size = new Size(233, 85);
            OutputTable.TabIndex = 2;
            OutputTable.Paint += tableLayoutPanel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 0;
            label5.Text = "Time step";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 40);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 2;
            label7.Text = "Max height";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 20);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 1;
            label6.Text = "Distance";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(3, 60);
            label8.Name = "label8";
            label8.Size = new Size(204, 20);
            label8.TabIndex = 3;
            label8.Text = "Speed at the end of the point";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 762);
            Controls.Add(OutputTable);
            Controls.Add(MyChart);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WeightInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)SizeInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpeedInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)AngleInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)HeightInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)MyChart).EndInit();
            OutputTable.ResumeLayout(false);
            OutputTable.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private NumericUpDown HeightInput;
        private Button CalculateButton;
        private Label label2;
        private Label label3;
        private NumericUpDown SpeedInput;
        private NumericUpDown AngleInput;
        private NumericUpDown WeightInput;
        private Label label4;
        private Label Size;
        private NumericUpDown SizeInput;
        private Chart MyChart;
        private System.Windows.Forms.Timer timer1;
        private TableLayoutPanel OutputTable;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label6;
    }
}