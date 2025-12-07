namespace Tyuiu.MalchikhinaVV.Sprint6.Task2.V9
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
            groupBoxTask_MVV = new GroupBox();
            textBoxTask_MVV = new TextBox();
            groupBoxResult_MVV = new GroupBox();
            chartFunction_MVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewResult_MVV = new DataGridView();
            labelResult_MVV = new Label();
            groupBoxInput_MVV = new GroupBox();
            labelStop_MVV = new Label();
            labelStart_MVV = new Label();
            textBoxStopStep_MVV = new TextBox();
            textBoxStartStep_MVV = new TextBox();
            buttonDone_MVV = new Button();
            buttonHelp_MVV = new Button();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            groupBoxTask_MVV.SuspendLayout();
            groupBoxResult_MVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_MVV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_MVV).BeginInit();
            groupBoxInput_MVV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_MVV
            // 
            groupBoxTask_MVV.Controls.Add(textBoxTask_MVV);
            groupBoxTask_MVV.Location = new Point(12, 12);
            groupBoxTask_MVV.Name = "groupBoxTask_MVV";
            groupBoxTask_MVV.Size = new Size(540, 326);
            groupBoxTask_MVV.TabIndex = 0;
            groupBoxTask_MVV.TabStop = false;
            groupBoxTask_MVV.Text = "Условие";
            // 
            // textBoxTask_MVV
            // 
            textBoxTask_MVV.BorderStyle = BorderStyle.None;
            textBoxTask_MVV.Location = new Point(6, 26);
            textBoxTask_MVV.Multiline = true;
            textBoxTask_MVV.Name = "textBoxTask_MVV";
            textBoxTask_MVV.ReadOnly = true;
            textBoxTask_MVV.Size = new Size(528, 76);
            textBoxTask_MVV.TabIndex = 0;
            textBoxTask_MVV.Text = "Протабулировать функцию F(x) = (3*x-1,5/sin(x)-3+x) + 2 на заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxResult_MVV
            // 
            groupBoxResult_MVV.Controls.Add(chartFunction_MVV);
            groupBoxResult_MVV.Controls.Add(dataGridViewResult_MVV);
            groupBoxResult_MVV.Controls.Add(labelResult_MVV);
            groupBoxResult_MVV.Location = new Point(558, 12);
            groupBoxResult_MVV.Name = "groupBoxResult_MVV";
            groupBoxResult_MVV.Size = new Size(570, 460);
            groupBoxResult_MVV.TabIndex = 1;
            groupBoxResult_MVV.TabStop = false;
            groupBoxResult_MVV.Text = "Вывод данных";
            // 
            // chartFunction_MVV
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_MVV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_MVV.Legends.Add(legend1);
            chartFunction_MVV.Location = new Point(189, 60);
            chartFunction_MVV.Name = "chartFunction_MVV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_MVV.Series.Add(series1);
            chartFunction_MVV.Size = new Size(375, 375);
            chartFunction_MVV.TabIndex = 2;
            chartFunction_MVV.Text = "chart1";
            // 
            // dataGridViewResult_MVV
            // 
            dataGridViewResult_MVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_MVV.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewResult_MVV.Location = new Point(13, 48);
            dataGridViewResult_MVV.Name = "dataGridViewResult_MVV";
            dataGridViewResult_MVV.RowHeadersVisible = false;
            dataGridViewResult_MVV.RowHeadersWidth = 51;
            dataGridViewResult_MVV.Size = new Size(170, 406);
            dataGridViewResult_MVV.TabIndex = 1;
            // 
            // labelResult_MVV
            // 
            labelResult_MVV.AutoSize = true;
            labelResult_MVV.Location = new Point(13, 25);
            labelResult_MVV.Name = "labelResult_MVV";
            labelResult_MVV.Size = new Size(78, 20);
            labelResult_MVV.TabIndex = 0;
            labelResult_MVV.Text = "Результат:";
            // 
            // groupBoxInput_MVV
            // 
            groupBoxInput_MVV.Controls.Add(labelStop_MVV);
            groupBoxInput_MVV.Controls.Add(labelStart_MVV);
            groupBoxInput_MVV.Controls.Add(textBoxStopStep_MVV);
            groupBoxInput_MVV.Controls.Add(textBoxStartStep_MVV);
            groupBoxInput_MVV.Location = new Point(12, 344);
            groupBoxInput_MVV.Name = "groupBoxInput_MVV";
            groupBoxInput_MVV.Size = new Size(287, 123);
            groupBoxInput_MVV.TabIndex = 2;
            groupBoxInput_MVV.TabStop = false;
            groupBoxInput_MVV.Text = "Ввод данных";
            // 
            // labelStop_MVV
            // 
            labelStop_MVV.AutoSize = true;
            labelStop_MVV.Location = new Point(158, 39);
            labelStop_MVV.Name = "labelStop_MVV";
            labelStop_MVV.Size = new Size(94, 20);
            labelStop_MVV.TabIndex = 3;
            labelStop_MVV.Text = "Конец шага:";
            // 
            // labelStart_MVV
            // 
            labelStart_MVV.AutoSize = true;
            labelStart_MVV.Location = new Point(12, 40);
            labelStart_MVV.Name = "labelStart_MVV";
            labelStart_MVV.Size = new Size(88, 20);
            labelStart_MVV.TabIndex = 2;
            labelStart_MVV.Text = "Старт шага:";
            // 
            // textBoxStopStep_MVV
            // 
            textBoxStopStep_MVV.Location = new Point(156, 66);
            textBoxStopStep_MVV.Name = "textBoxStopStep_MVV";
            textBoxStopStep_MVV.Size = new Size(125, 27);
            textBoxStopStep_MVV.TabIndex = 1;
            // 
            // textBoxStartStep_MVV
            // 
            textBoxStartStep_MVV.Location = new Point(6, 66);
            textBoxStartStep_MVV.Name = "textBoxStartStep_MVV";
            textBoxStartStep_MVV.Size = new Size(125, 27);
            textBoxStartStep_MVV.TabIndex = 0;
            // 
            // buttonDone_MVV
            // 
            buttonDone_MVV.BackColor = Color.FromArgb(192, 192, 255);
            buttonDone_MVV.FlatStyle = FlatStyle.Flat;
            buttonDone_MVV.Location = new Point(421, 374);
            buttonDone_MVV.Name = "buttonDone_MVV";
            buttonDone_MVV.Size = new Size(125, 63);
            buttonDone_MVV.TabIndex = 3;
            buttonDone_MVV.Text = "Выполнить";
            buttonDone_MVV.UseVisualStyleBackColor = false;
            buttonDone_MVV.Click += buttonDone_MVV_Click;
            // 
            // buttonHelp_MVV
            // 
            buttonHelp_MVV.BackColor = Color.FromArgb(255, 192, 128);
            buttonHelp_MVV.FlatStyle = FlatStyle.Flat;
            buttonHelp_MVV.Location = new Point(305, 374);
            buttonHelp_MVV.Name = "buttonHelp_MVV";
            buttonHelp_MVV.Size = new Size(94, 63);
            buttonHelp_MVV.TabIndex = 4;
            buttonHelp_MVV.Text = "Справка";
            buttonHelp_MVV.UseVisualStyleBackColor = false;
            buttonHelp_MVV.Click += buttonHelp_MVV_Click;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.Width = 90;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 479);
            Controls.Add(buttonHelp_MVV);
            Controls.Add(buttonDone_MVV);
            Controls.Add(groupBoxInput_MVV);
            Controls.Add(groupBoxResult_MVV);
            Controls.Add(groupBoxTask_MVV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBoxTask_MVV.ResumeLayout(false);
            groupBoxTask_MVV.PerformLayout();
            groupBoxResult_MVV.ResumeLayout(false);
            groupBoxResult_MVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_MVV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_MVV).EndInit();
            groupBoxInput_MVV.ResumeLayout(false);
            groupBoxInput_MVV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_MVV;
        private TextBox textBoxTask_MVV;
        private GroupBox groupBoxResult_MVV;
        private GroupBox groupBoxInput_MVV;
        private Label labelResult_MVV;
        private Label labelStop_MVV;
        private Label labelStart_MVV;
        private TextBox textBoxStopStep_MVV;
        private TextBox textBoxStartStep_MVV;
        private Button buttonDone_MVV;
        private Button buttonHelp_MVV;
        private DataGridView dataGridViewResult_MVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MVV;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
    }
}
