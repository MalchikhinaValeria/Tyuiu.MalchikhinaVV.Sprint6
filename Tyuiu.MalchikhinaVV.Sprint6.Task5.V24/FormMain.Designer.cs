namespace Tyuiu.MalchikhinaVV.Sprint6.Task5.V24
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop_MVV = new Panel();
            buttonHelp_MVV = new Button();
            buttonOpen_MVV = new Button();
            buttonDone_MVV = new Button();
            groupBoxTask = new GroupBox();
            textBoxTask_MVV = new TextBox();
            panelLeft_MVV = new Panel();
            groupBoxResult_MVV = new GroupBox();
            dataGridViewResult_MVV = new DataGridView();
            panelFill_MVV = new Panel();
            chartFunction_MVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelTop_MVV.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelLeft_MVV.SuspendLayout();
            groupBoxResult_MVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_MVV).BeginInit();
            panelFill_MVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_MVV).BeginInit();
            SuspendLayout();
            // 
            // panelTop_MVV
            // 
            panelTop_MVV.Controls.Add(buttonHelp_MVV);
            panelTop_MVV.Controls.Add(buttonOpen_MVV);
            panelTop_MVV.Controls.Add(buttonDone_MVV);
            panelTop_MVV.Controls.Add(groupBoxTask);
            panelTop_MVV.Dock = DockStyle.Top;
            panelTop_MVV.Location = new Point(0, 0);
            panelTop_MVV.Name = "panelTop_MVV";
            panelTop_MVV.Size = new Size(975, 125);
            panelTop_MVV.TabIndex = 0;
            // 
            // buttonHelp_MVV
            // 
            buttonHelp_MVV.BackColor = Color.FromArgb(255, 192, 255);
            buttonHelp_MVV.Location = new Point(869, 28);
            buttonHelp_MVV.Name = "buttonHelp_MVV";
            buttonHelp_MVV.Size = new Size(94, 71);
            buttonHelp_MVV.TabIndex = 1;
            buttonHelp_MVV.Text = "Справка";
            buttonHelp_MVV.UseVisualStyleBackColor = false;
            buttonHelp_MVV.Click += buttonHelp_MVV_Click;
            // 
            // buttonOpen_MVV
            // 
            buttonOpen_MVV.BackColor = Color.FromArgb(224, 224, 224);
            buttonOpen_MVV.Location = new Point(755, 28);
            buttonOpen_MVV.Name = "buttonOpen_MVV";
            buttonOpen_MVV.Size = new Size(94, 71);
            buttonOpen_MVV.TabIndex = 1;
            buttonOpen_MVV.Text = "Открыть файл";
            buttonOpen_MVV.UseVisualStyleBackColor = false;
            buttonOpen_MVV.Click += buttonOpen_MVV_Click;
            // 
            // buttonDone_MVV
            // 
            buttonDone_MVV.BackColor = Color.FromArgb(255, 224, 192);
            buttonDone_MVV.Location = new Point(636, 28);
            buttonDone_MVV.Name = "buttonDone_MVV";
            buttonDone_MVV.Size = new Size(99, 71);
            buttonDone_MVV.TabIndex = 1;
            buttonDone_MVV.Text = "Выполнить";
            buttonDone_MVV.UseVisualStyleBackColor = false;
            buttonDone_MVV.Click += buttonDone_MVV_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask_MVV);
            groupBoxTask.Location = new Point(3, 3);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Padding = new Padding(5);
            groupBoxTask.Size = new Size(627, 119);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask_MVV
            // 
            textBoxTask_MVV.Dock = DockStyle.Fill;
            textBoxTask_MVV.Location = new Point(5, 25);
            textBoxTask_MVV.Multiline = true;
            textBoxTask_MVV.Name = "textBoxTask_MVV";
            textBoxTask_MVV.ReadOnly = true;
            textBoxTask_MVV.Size = new Size(617, 89);
            textBoxTask_MVV.TabIndex = 0;
            textBoxTask_MVV.Text = "Прочитать данные из файла InPutFileTask5V24.txt. Вывести в dataGridView.\r\n Дан список из чисел.\r\n Вывести все элементы, равные 0.\r\n Построить диаграмму по этим значениям.";
            // 
            // panelLeft_MVV
            // 
            panelLeft_MVV.Controls.Add(groupBoxResult_MVV);
            panelLeft_MVV.Dock = DockStyle.Left;
            panelLeft_MVV.Location = new Point(0, 125);
            panelLeft_MVV.Name = "panelLeft_MVV";
            panelLeft_MVV.Size = new Size(289, 450);
            panelLeft_MVV.TabIndex = 0;
            // 
            // groupBoxResult_MVV
            // 
            groupBoxResult_MVV.Controls.Add(dataGridViewResult_MVV);
            groupBoxResult_MVV.Dock = DockStyle.Fill;
            groupBoxResult_MVV.Location = new Point(0, 0);
            groupBoxResult_MVV.Name = "groupBoxResult_MVV";
            groupBoxResult_MVV.Padding = new Padding(5);
            groupBoxResult_MVV.Size = new Size(289, 450);
            groupBoxResult_MVV.TabIndex = 0;
            groupBoxResult_MVV.TabStop = false;
            groupBoxResult_MVV.Text = "Вывод данных";
            // 
            // dataGridViewResult_MVV
            // 
            dataGridViewResult_MVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_MVV.ColumnHeadersVisible = false;
            dataGridViewResult_MVV.Dock = DockStyle.Fill;
            dataGridViewResult_MVV.Location = new Point(5, 25);
            dataGridViewResult_MVV.Name = "dataGridViewResult_MVV";
            dataGridViewResult_MVV.RowHeadersVisible = false;
            dataGridViewResult_MVV.RowHeadersWidth = 51;
            dataGridViewResult_MVV.Size = new Size(279, 420);
            dataGridViewResult_MVV.TabIndex = 0;
            // 
            // panelFill_MVV
            // 
            panelFill_MVV.Controls.Add(chartFunction_MVV);
            panelFill_MVV.Dock = DockStyle.Fill;
            panelFill_MVV.Location = new Point(289, 125);
            panelFill_MVV.Name = "panelFill_MVV";
            panelFill_MVV.Size = new Size(686, 450);
            panelFill_MVV.TabIndex = 0;
            // 
            // chartFunction_MVV
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_MVV.ChartAreas.Add(chartArea1);
            chartFunction_MVV.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_MVV.Legends.Add(legend1);
            chartFunction_MVV.Location = new Point(0, 0);
            chartFunction_MVV.Name = "chartFunction_MVV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_MVV.Series.Add(series1);
            chartFunction_MVV.Size = new Size(686, 450);
            chartFunction_MVV.TabIndex = 0;
            chartFunction_MVV.Text = "chart1";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(289, 125);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 450);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 575);
            Controls.Add(splitter1);
            Controls.Add(panelFill_MVV);
            Controls.Add(panelLeft_MVV);
            Controls.Add(panelTop_MVV);
            MinimumSize = new Size(882, 500);
            Name = "FormMain";
            Text = "Form1";
            panelTop_MVV.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelLeft_MVV.ResumeLayout(false);
            groupBoxResult_MVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_MVV).EndInit();
            panelFill_MVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_MVV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_MVV;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask_MVV;
        private Panel panelLeft_MVV;
        private GroupBox groupBoxResult_MVV;
        private DataGridView dataGridViewResult_MVV;
        private Panel panelFill_MVV;
        private Splitter splitter1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MVV;
        private Button buttonHelp_MVV;
        private Button buttonOpen_MVV;
        private Button buttonDone_MVV;
    }
}
