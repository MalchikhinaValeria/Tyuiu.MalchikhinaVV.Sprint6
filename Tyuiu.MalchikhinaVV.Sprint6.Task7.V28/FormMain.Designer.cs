namespace Tyuiu.MalchikhinaVV.Sprint6.Task7.V28
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_MVV = new Panel();
            buttonAbout_MVV = new Button();
            buttonSave_MVV = new Button();
            buttonDone_MVV = new Button();
            buttonLoadFile_MVV = new Button();
            panel2Top_MVV = new Panel();
            groupBoxTask = new GroupBox();
            textBoxTask_MVV = new TextBox();
            panelLeft_MVV = new Panel();
            groupBoxInput_MVV = new GroupBox();
            dataGridViewIn_MVV = new DataGridView();
            panelRight_MVV = new Panel();
            groupBoxOutput_MVV = new GroupBox();
            dataGridViewOut_MVV = new DataGridView();
            splitter1 = new Splitter();
            openFileDialogTask_MVV = new OpenFileDialog();
            toolTipButtons_MVV = new ToolTip(components);
            saveFileDialogMatrix_MVV = new SaveFileDialog();
            panelTop_MVV.SuspendLayout();
            panel2Top_MVV.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelLeft_MVV.SuspendLayout();
            groupBoxInput_MVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_MVV).BeginInit();
            panelRight_MVV.SuspendLayout();
            groupBoxOutput_MVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_MVV).BeginInit();
            SuspendLayout();
            // 
            // panelTop_MVV
            // 
            panelTop_MVV.Controls.Add(buttonAbout_MVV);
            panelTop_MVV.Controls.Add(buttonSave_MVV);
            panelTop_MVV.Controls.Add(buttonDone_MVV);
            panelTop_MVV.Controls.Add(buttonLoadFile_MVV);
            panelTop_MVV.Dock = DockStyle.Top;
            panelTop_MVV.Location = new Point(0, 0);
            panelTop_MVV.Name = "panelTop_MVV";
            panelTop_MVV.Size = new Size(1146, 94);
            panelTop_MVV.TabIndex = 0;
            // 
            // buttonAbout_MVV
            // 
            buttonAbout_MVV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_MVV.BackgroundImage = (Image)resources.GetObject("buttonAbout_MVV.BackgroundImage");
            buttonAbout_MVV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAbout_MVV.Location = new Point(1015, 3);
            buttonAbout_MVV.Name = "buttonAbout_MVV";
            buttonAbout_MVV.Size = new Size(119, 85);
            buttonAbout_MVV.TabIndex = 1;
            toolTipButtons_MVV.SetToolTip(buttonAbout_MVV, "Сведения о программе");
            buttonAbout_MVV.UseVisualStyleBackColor = true;
            buttonAbout_MVV.Click += buttonAbout_MVV_Click;
            // 
            // buttonSave_MVV
            // 
            buttonSave_MVV.BackgroundImage = (Image)resources.GetObject("buttonSave_MVV.BackgroundImage");
            buttonSave_MVV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSave_MVV.Enabled = false;
            buttonSave_MVV.Location = new Point(303, 3);
            buttonSave_MVV.Name = "buttonSave_MVV";
            buttonSave_MVV.Size = new Size(119, 85);
            buttonSave_MVV.TabIndex = 1;
            toolTipButtons_MVV.SetToolTip(buttonSave_MVV, "Сохранить обработанные данные в формате CSV\r\n\r\n");
            buttonSave_MVV.UseVisualStyleBackColor = true;
            buttonSave_MVV.Click += buttonSave_MVV_Click;
            // 
            // buttonDone_MVV
            // 
            buttonDone_MVV.BackgroundImage = (Image)resources.GetObject("buttonDone_MVV.BackgroundImage");
            buttonDone_MVV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDone_MVV.Enabled = false;
            buttonDone_MVV.Location = new Point(157, 3);
            buttonDone_MVV.Name = "buttonDone_MVV";
            buttonDone_MVV.Size = new Size(119, 85);
            buttonDone_MVV.TabIndex = 1;
            toolTipButtons_MVV.SetToolTip(buttonDone_MVV, "Выполнить обработку данных");
            buttonDone_MVV.UseVisualStyleBackColor = true;
            buttonDone_MVV.Click += buttonDone_MVV_Click;
            // 
            // buttonLoadFile_MVV
            // 
            buttonLoadFile_MVV.BackgroundImage = (Image)resources.GetObject("buttonLoadFile_MVV.BackgroundImage");
            buttonLoadFile_MVV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonLoadFile_MVV.Location = new Point(12, 3);
            buttonLoadFile_MVV.Name = "buttonLoadFile_MVV";
            buttonLoadFile_MVV.Size = new Size(119, 85);
            buttonLoadFile_MVV.TabIndex = 1;
            toolTipButtons_MVV.SetToolTip(buttonLoadFile_MVV, "Открыть файл для обработки данных в формате CSV");
            buttonLoadFile_MVV.UseVisualStyleBackColor = true;
            buttonLoadFile_MVV.Click += buttonLoadFile_MVV_Click;
            // 
            // panel2Top_MVV
            // 
            panel2Top_MVV.Controls.Add(groupBoxTask);
            panel2Top_MVV.Dock = DockStyle.Top;
            panel2Top_MVV.Location = new Point(0, 94);
            panel2Top_MVV.Name = "panel2Top_MVV";
            panel2Top_MVV.Size = new Size(1146, 102);
            panel2Top_MVV.TabIndex = 0;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask_MVV);
            groupBoxTask.Dock = DockStyle.Fill;
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Padding = new Padding(5);
            groupBoxTask.Size = new Size(1146, 102);
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
            textBoxTask_MVV.Size = new Size(1136, 72);
            textBoxTask_MVV.TabIndex = 0;
            textBoxTask_MVV.Text = resources.GetString("textBoxTask_MVV.Text");
            // 
            // panelLeft_MVV
            // 
            panelLeft_MVV.Controls.Add(groupBoxInput_MVV);
            panelLeft_MVV.Dock = DockStyle.Left;
            panelLeft_MVV.Location = new Point(0, 196);
            panelLeft_MVV.Name = "panelLeft_MVV";
            panelLeft_MVV.Size = new Size(632, 372);
            panelLeft_MVV.TabIndex = 0;
            // 
            // groupBoxInput_MVV
            // 
            groupBoxInput_MVV.Controls.Add(dataGridViewIn_MVV);
            groupBoxInput_MVV.Dock = DockStyle.Fill;
            groupBoxInput_MVV.Location = new Point(0, 0);
            groupBoxInput_MVV.Name = "groupBoxInput_MVV";
            groupBoxInput_MVV.Padding = new Padding(5);
            groupBoxInput_MVV.Size = new Size(632, 372);
            groupBoxInput_MVV.TabIndex = 0;
            groupBoxInput_MVV.TabStop = false;
            groupBoxInput_MVV.Text = "Ввод:";
            // 
            // dataGridViewIn_MVV
            // 
            dataGridViewIn_MVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_MVV.ColumnHeadersVisible = false;
            dataGridViewIn_MVV.Dock = DockStyle.Fill;
            dataGridViewIn_MVV.Location = new Point(5, 25);
            dataGridViewIn_MVV.Name = "dataGridViewIn_MVV";
            dataGridViewIn_MVV.RowHeadersVisible = false;
            dataGridViewIn_MVV.RowHeadersWidth = 51;
            dataGridViewIn_MVV.Size = new Size(622, 342);
            dataGridViewIn_MVV.TabIndex = 0;
            // 
            // panelRight_MVV
            // 
            panelRight_MVV.Controls.Add(groupBoxOutput_MVV);
            panelRight_MVV.Controls.Add(splitter1);
            panelRight_MVV.Dock = DockStyle.Fill;
            panelRight_MVV.Location = new Point(632, 196);
            panelRight_MVV.Name = "panelRight_MVV";
            panelRight_MVV.Size = new Size(514, 372);
            panelRight_MVV.TabIndex = 0;
            // 
            // groupBoxOutput_MVV
            // 
            groupBoxOutput_MVV.Controls.Add(dataGridViewOut_MVV);
            groupBoxOutput_MVV.Dock = DockStyle.Fill;
            groupBoxOutput_MVV.Location = new Point(10, 0);
            groupBoxOutput_MVV.Name = "groupBoxOutput_MVV";
            groupBoxOutput_MVV.Padding = new Padding(5);
            groupBoxOutput_MVV.Size = new Size(504, 372);
            groupBoxOutput_MVV.TabIndex = 1;
            groupBoxOutput_MVV.TabStop = false;
            groupBoxOutput_MVV.Text = "Вывод:";
            // 
            // dataGridViewOut_MVV
            // 
            dataGridViewOut_MVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_MVV.ColumnHeadersVisible = false;
            dataGridViewOut_MVV.Dock = DockStyle.Fill;
            dataGridViewOut_MVV.Location = new Point(5, 25);
            dataGridViewOut_MVV.Name = "dataGridViewOut_MVV";
            dataGridViewOut_MVV.RowHeadersVisible = false;
            dataGridViewOut_MVV.RowHeadersWidth = 51;
            dataGridViewOut_MVV.Size = new Size(494, 342);
            dataGridViewOut_MVV.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 372);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // openFileDialogTask_MVV
            // 
            openFileDialogTask_MVV.FileName = "openFileDialog1";
            // 
            // toolTipButtons_MVV
            // 
            toolTipButtons_MVV.IsBalloon = true;
            toolTipButtons_MVV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 568);
            Controls.Add(panelRight_MVV);
            Controls.Add(panelLeft_MVV);
            Controls.Add(panel2Top_MVV);
            Controls.Add(panelTop_MVV);
            MinimizeBox = false;
            MinimumSize = new Size(1164, 615);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sprint6 | Task7";
            panelTop_MVV.ResumeLayout(false);
            panel2Top_MVV.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelLeft_MVV.ResumeLayout(false);
            groupBoxInput_MVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_MVV).EndInit();
            panelRight_MVV.ResumeLayout(false);
            groupBoxOutput_MVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_MVV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_MVV;
        private Panel panel2Top_MVV;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask_MVV;
        private Panel panelLeft_MVV;
        private Panel panelRight_MVV;
        private Splitter splitter1;
        private GroupBox groupBoxInput_MVV;
        private GroupBox groupBoxOutput_MVV;
        private DataGridView dataGridViewIn_MVV;
        private DataGridView dataGridViewOut_MVV;
        private Button buttonAbout_MVV;
        private Button buttonSave_MVV;
        private Button buttonDone_MVV;
        private Button buttonLoadFile_MVV;
        private OpenFileDialog openFileDialogTask_MVV;
        private ToolTip toolTipButtons_MVV;
        private SaveFileDialog saveFileDialogMatrix_MVV;
    }
}
