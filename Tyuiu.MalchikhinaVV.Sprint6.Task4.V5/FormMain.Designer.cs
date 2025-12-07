namespace Tyuiu.MalchikhinaVV.Sprint6.Task4.V5
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelTop_MVV = new Panel();
            buttonHelp_MVV = new Button();
            buttonSave_MVV = new Button();
            buttonDone_MVV = new Button();
            groupBoxInput_MVV = new GroupBox();
            labelStop_MVV = new Label();
            labelStart_MVV = new Label();
            textBoxStop_MVV = new TextBox();
            textBoxStart_MVV = new TextBox();
            groupBoxTask_MVV = new GroupBox();
            textBoxTask_MVV = new TextBox();
            panelLeft_MVV = new Panel();
            groupBoxResult_MVV = new GroupBox();
            textBoxResult_MVV = new TextBox();
            panelFill_MVV = new Panel();
            chartFunction_MVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelTop_MVV.SuspendLayout();
            groupBoxInput_MVV.SuspendLayout();
            groupBoxTask_MVV.SuspendLayout();
            panelLeft_MVV.SuspendLayout();
            groupBoxResult_MVV.SuspendLayout();
            panelFill_MVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_MVV).BeginInit();
            SuspendLayout();
            // 
            // panelTop_MVV
            // 
            panelTop_MVV.Controls.Add(buttonHelp_MVV);
            panelTop_MVV.Controls.Add(buttonSave_MVV);
            panelTop_MVV.Controls.Add(buttonDone_MVV);
            panelTop_MVV.Controls.Add(groupBoxInput_MVV);
            panelTop_MVV.Controls.Add(groupBoxTask_MVV);
            panelTop_MVV.Dock = DockStyle.Top;
            panelTop_MVV.Location = new Point(0, 0);
            panelTop_MVV.Name = "panelTop_MVV";
            panelTop_MVV.Size = new Size(1130, 125);
            panelTop_MVV.TabIndex = 0;
            // 
            // buttonHelp_MVV
            // 
            buttonHelp_MVV.BackColor = Color.FromArgb(128, 128, 255);
            buttonHelp_MVV.FlatStyle = FlatStyle.Popup;
            buttonHelp_MVV.Location = new Point(1016, 28);
            buttonHelp_MVV.Name = "buttonHelp_MVV";
            buttonHelp_MVV.Size = new Size(102, 79);
            buttonHelp_MVV.TabIndex = 2;
            buttonHelp_MVV.Text = "Справка";
            buttonHelp_MVV.UseVisualStyleBackColor = false;
            buttonHelp_MVV.Click += buttonHelp_MVV_Click;
            // 
            // buttonSave_MVV
            // 
            buttonSave_MVV.BackColor = Color.FromArgb(128, 255, 128);
            buttonSave_MVV.FlatStyle = FlatStyle.Popup;
            buttonSave_MVV.Location = new Point(908, 28);
            buttonSave_MVV.Name = "buttonSave_MVV";
            buttonSave_MVV.Size = new Size(102, 79);
            buttonSave_MVV.TabIndex = 2;
            buttonSave_MVV.Text = "Сохранить...";
            buttonSave_MVV.UseVisualStyleBackColor = false;
            buttonSave_MVV.Click += buttonSave_MVV_Click;
            // 
            // buttonDone_MVV
            // 
            buttonDone_MVV.BackColor = Color.FromArgb(128, 255, 255);
            buttonDone_MVV.FlatStyle = FlatStyle.Popup;
            buttonDone_MVV.Location = new Point(800, 28);
            buttonDone_MVV.Name = "buttonDone_MVV";
            buttonDone_MVV.Size = new Size(102, 79);
            buttonDone_MVV.TabIndex = 2;
            buttonDone_MVV.Text = "Выполнить";
            buttonDone_MVV.UseVisualStyleBackColor = false;
            buttonDone_MVV.Click += buttonDone_MVV_Click;
            // 
            // groupBoxInput_MVV
            // 
            groupBoxInput_MVV.Controls.Add(labelStop_MVV);
            groupBoxInput_MVV.Controls.Add(labelStart_MVV);
            groupBoxInput_MVV.Controls.Add(textBoxStop_MVV);
            groupBoxInput_MVV.Controls.Add(textBoxStart_MVV);
            groupBoxInput_MVV.Location = new Point(501, 3);
            groupBoxInput_MVV.Name = "groupBoxInput_MVV";
            groupBoxInput_MVV.Size = new Size(293, 116);
            groupBoxInput_MVV.TabIndex = 1;
            groupBoxInput_MVV.TabStop = false;
            groupBoxInput_MVV.Text = "Ввод данных";
            // 
            // labelStop_MVV
            // 
            labelStop_MVV.AutoSize = true;
            labelStop_MVV.Location = new Point(164, 38);
            labelStop_MVV.Name = "labelStop_MVV";
            labelStop_MVV.Size = new Size(94, 20);
            labelStop_MVV.TabIndex = 3;
            labelStop_MVV.Text = "Конец шага:";
            // 
            // labelStart_MVV
            // 
            labelStart_MVV.AutoSize = true;
            labelStart_MVV.Location = new Point(6, 37);
            labelStart_MVV.Name = "labelStart_MVV";
            labelStart_MVV.Size = new Size(88, 20);
            labelStart_MVV.TabIndex = 2;
            labelStart_MVV.Text = "Старт шага:";
            // 
            // textBoxStop_MVV
            // 
            textBoxStop_MVV.Location = new Point(162, 60);
            textBoxStop_MVV.Name = "textBoxStop_MVV";
            textBoxStop_MVV.Size = new Size(125, 27);
            textBoxStop_MVV.TabIndex = 1;
            // 
            // textBoxStart_MVV
            // 
            textBoxStart_MVV.Location = new Point(6, 60);
            textBoxStart_MVV.Name = "textBoxStart_MVV";
            textBoxStart_MVV.Size = new Size(125, 27);
            textBoxStart_MVV.TabIndex = 0;
            // 
            // groupBoxTask_MVV
            // 
            groupBoxTask_MVV.Controls.Add(textBoxTask_MVV);
            groupBoxTask_MVV.Location = new Point(3, 3);
            groupBoxTask_MVV.Name = "groupBoxTask_MVV";
            groupBoxTask_MVV.Padding = new Padding(5);
            groupBoxTask_MVV.Size = new Size(492, 116);
            groupBoxTask_MVV.TabIndex = 0;
            groupBoxTask_MVV.TabStop = false;
            groupBoxTask_MVV.Text = "Условие:";
            // 
            // textBoxTask_MVV
            // 
            textBoxTask_MVV.Dock = DockStyle.Fill;
            textBoxTask_MVV.Location = new Point(5, 25);
            textBoxTask_MVV.Multiline = true;
            textBoxTask_MVV.Name = "textBoxTask_MVV";
            textBoxTask_MVV.ReadOnly = true;
            textBoxTask_MVV.Size = new Size(482, 86);
            textBoxTask_MVV.TabIndex = 0;
            textBoxTask_MVV.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в textBox, построить график функции и сохранить в файл\r\nOutputFileTask.txt по нажатию кнопки.";
            // 
            // panelLeft_MVV
            // 
            panelLeft_MVV.Controls.Add(groupBoxResult_MVV);
            panelLeft_MVV.Dock = DockStyle.Left;
            panelLeft_MVV.Location = new Point(0, 125);
            panelLeft_MVV.Name = "panelLeft_MVV";
            panelLeft_MVV.Size = new Size(340, 393);
            panelLeft_MVV.TabIndex = 0;
            // 
            // groupBoxResult_MVV
            // 
            groupBoxResult_MVV.Controls.Add(textBoxResult_MVV);
            groupBoxResult_MVV.Dock = DockStyle.Fill;
            groupBoxResult_MVV.Location = new Point(0, 0);
            groupBoxResult_MVV.Name = "groupBoxResult_MVV";
            groupBoxResult_MVV.Padding = new Padding(5);
            groupBoxResult_MVV.Size = new Size(340, 393);
            groupBoxResult_MVV.TabIndex = 0;
            groupBoxResult_MVV.TabStop = false;
            groupBoxResult_MVV.Text = "Вывод:";
            // 
            // textBoxResult_MVV
            // 
            textBoxResult_MVV.Dock = DockStyle.Fill;
            textBoxResult_MVV.Location = new Point(5, 25);
            textBoxResult_MVV.Multiline = true;
            textBoxResult_MVV.Name = "textBoxResult_MVV";
            textBoxResult_MVV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_MVV.Size = new Size(330, 363);
            textBoxResult_MVV.TabIndex = 0;
            // 
            // panelFill_MVV
            // 
            panelFill_MVV.Controls.Add(chartFunction_MVV);
            panelFill_MVV.Dock = DockStyle.Fill;
            panelFill_MVV.Location = new Point(340, 125);
            panelFill_MVV.Name = "panelFill_MVV";
            panelFill_MVV.Size = new Size(790, 393);
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
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_MVV.Series.Add(series1);
            chartFunction_MVV.Size = new Size(790, 393);
            chartFunction_MVV.TabIndex = 0;
            chartFunction_MVV.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График функции";
            chartFunction_MVV.Titles.Add(title1);
            // 
            // splitter1
            // 
            splitter1.Location = new Point(340, 125);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 393);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 518);
            Controls.Add(splitter1);
            Controls.Add(panelFill_MVV);
            Controls.Add(panelLeft_MVV);
            Controls.Add(panelTop_MVV);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelTop_MVV.ResumeLayout(false);
            groupBoxInput_MVV.ResumeLayout(false);
            groupBoxInput_MVV.PerformLayout();
            groupBoxTask_MVV.ResumeLayout(false);
            groupBoxTask_MVV.PerformLayout();
            panelLeft_MVV.ResumeLayout(false);
            groupBoxResult_MVV.ResumeLayout(false);
            groupBoxResult_MVV.PerformLayout();
            panelFill_MVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_MVV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_MVV;
        private Panel panelLeft_MVV;
        private GroupBox groupBoxResult_MVV;
        private Panel panelFill_MVV;
        private Splitter splitter1;
        private GroupBox groupBoxInput_MVV;
        private GroupBox groupBoxTask_MVV;
        private TextBox textBoxResult_MVV;
        private Label labelStop_MVV;
        private Label labelStart_MVV;
        private TextBox textBoxStop_MVV;
        private TextBox textBoxStart_MVV;
        private TextBox textBoxTask_MVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MVV;
        private Button buttonHelp_MVV;
        private Button buttonSave_MVV;
        private Button buttonDone_MVV;
    }
}
