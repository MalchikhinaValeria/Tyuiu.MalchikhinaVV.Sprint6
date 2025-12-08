namespace Tyuiu.MalchikhinaVV.Sprint6.Task6.V20
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
            buttonDone_MVV = new Button();
            buttonOpenFile_MVV = new Button();
            panel2Top_MVV = new Panel();
            groupBoxTask_MVV = new GroupBox();
            textBoxTask_MVV = new TextBox();
            panelLeft_MVV = new Panel();
            groupBoxLoad_MVV = new GroupBox();
            textBoxLoadFromFile_MVV = new TextBox();
            panelFill_MVV = new Panel();
            groupBoxResult_MVV = new GroupBox();
            textBoxResult_MVV = new TextBox();
            splitter1 = new Splitter();
            openFileDialogTask_MVV = new OpenFileDialog();
            toolTipButtons_MVV = new ToolTip(components);
            panelTop_MVV.SuspendLayout();
            panel2Top_MVV.SuspendLayout();
            groupBoxTask_MVV.SuspendLayout();
            panelLeft_MVV.SuspendLayout();
            groupBoxLoad_MVV.SuspendLayout();
            panelFill_MVV.SuspendLayout();
            groupBoxResult_MVV.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_MVV
            // 
            panelTop_MVV.Controls.Add(buttonAbout_MVV);
            panelTop_MVV.Controls.Add(buttonDone_MVV);
            panelTop_MVV.Controls.Add(buttonOpenFile_MVV);
            panelTop_MVV.Dock = DockStyle.Top;
            panelTop_MVV.Location = new Point(0, 0);
            panelTop_MVV.Name = "panelTop_MVV";
            panelTop_MVV.Size = new Size(974, 89);
            panelTop_MVV.TabIndex = 0;
            // 
            // buttonAbout_MVV
            // 
            buttonAbout_MVV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_MVV.BackgroundImage = (Image)resources.GetObject("buttonAbout_MVV.BackgroundImage");
            buttonAbout_MVV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAbout_MVV.Location = new Point(875, 12);
            buttonAbout_MVV.Name = "buttonAbout_MVV";
            buttonAbout_MVV.Size = new Size(76, 71);
            buttonAbout_MVV.TabIndex = 0;
            toolTipButtons_MVV.SetToolTip(buttonAbout_MVV, "Сведения о программе");
            buttonAbout_MVV.UseVisualStyleBackColor = true;
            buttonAbout_MVV.Click += buttonAbout_MVV_Click;
            // 
            // buttonDone_MVV
            // 
            buttonDone_MVV.BackgroundImage = (Image)resources.GetObject("buttonDone_MVV.BackgroundImage");
            buttonDone_MVV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDone_MVV.Enabled = false;
            buttonDone_MVV.Location = new Point(171, 12);
            buttonDone_MVV.Name = "buttonDone_MVV";
            buttonDone_MVV.Size = new Size(123, 71);
            buttonDone_MVV.TabIndex = 0;
            toolTipButtons_MVV.SetToolTip(buttonDone_MVV, "Производит поиск в файле");
            buttonDone_MVV.UseVisualStyleBackColor = true;
            buttonDone_MVV.Click += buttonDone_MVV_Click;
            // 
            // buttonOpenFile_MVV
            // 
            buttonOpenFile_MVV.BackgroundImage = (Image)resources.GetObject("buttonOpenFile_MVV.BackgroundImage");
            buttonOpenFile_MVV.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOpenFile_MVV.Location = new Point(22, 12);
            buttonOpenFile_MVV.Name = "buttonOpenFile_MVV";
            buttonOpenFile_MVV.Size = new Size(123, 71);
            buttonOpenFile_MVV.TabIndex = 0;
            toolTipButtons_MVV.SetToolTip(buttonOpenFile_MVV, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile_MVV.UseVisualStyleBackColor = true;
            buttonOpenFile_MVV.Click += buttonOpenFile_MVV_Click;
            // 
            // panel2Top_MVV
            // 
            panel2Top_MVV.Controls.Add(groupBoxTask_MVV);
            panel2Top_MVV.Dock = DockStyle.Top;
            panel2Top_MVV.Location = new Point(0, 89);
            panel2Top_MVV.Name = "panel2Top_MVV";
            panel2Top_MVV.Size = new Size(974, 91);
            panel2Top_MVV.TabIndex = 0;
            // 
            // groupBoxTask_MVV
            // 
            groupBoxTask_MVV.Controls.Add(textBoxTask_MVV);
            groupBoxTask_MVV.Dock = DockStyle.Fill;
            groupBoxTask_MVV.Location = new Point(0, 0);
            groupBoxTask_MVV.Name = "groupBoxTask_MVV";
            groupBoxTask_MVV.Padding = new Padding(5);
            groupBoxTask_MVV.Size = new Size(974, 91);
            groupBoxTask_MVV.TabIndex = 0;
            groupBoxTask_MVV.TabStop = false;
            groupBoxTask_MVV.Text = "Условие";
            // 
            // textBoxTask_MVV
            // 
            textBoxTask_MVV.Dock = DockStyle.Fill;
            textBoxTask_MVV.Location = new Point(5, 25);
            textBoxTask_MVV.Multiline = true;
            textBoxTask_MVV.Name = "textBoxTask_MVV";
            textBoxTask_MVV.ReadOnly = true;
            textBoxTask_MVV.Size = new Size(964, 61);
            textBoxTask_MVV.TabIndex = 0;
            textBoxTask_MVV.Text = resources.GetString("textBoxTask_MVV.Text");
            // 
            // panelLeft_MVV
            // 
            panelLeft_MVV.Controls.Add(groupBoxLoad_MVV);
            panelLeft_MVV.Dock = DockStyle.Left;
            panelLeft_MVV.Location = new Point(0, 180);
            panelLeft_MVV.Name = "panelLeft_MVV";
            panelLeft_MVV.Size = new Size(307, 391);
            panelLeft_MVV.TabIndex = 0;
            // 
            // groupBoxLoad_MVV
            // 
            groupBoxLoad_MVV.Controls.Add(textBoxLoadFromFile_MVV);
            groupBoxLoad_MVV.Dock = DockStyle.Fill;
            groupBoxLoad_MVV.Location = new Point(0, 0);
            groupBoxLoad_MVV.Name = "groupBoxLoad_MVV";
            groupBoxLoad_MVV.Padding = new Padding(5);
            groupBoxLoad_MVV.Size = new Size(307, 391);
            groupBoxLoad_MVV.TabIndex = 0;
            groupBoxLoad_MVV.TabStop = false;
            groupBoxLoad_MVV.Text = "Ввод:";
            // 
            // textBoxLoadFromFile_MVV
            // 
            textBoxLoadFromFile_MVV.Dock = DockStyle.Fill;
            textBoxLoadFromFile_MVV.Location = new Point(5, 25);
            textBoxLoadFromFile_MVV.Multiline = true;
            textBoxLoadFromFile_MVV.Name = "textBoxLoadFromFile_MVV";
            textBoxLoadFromFile_MVV.ScrollBars = ScrollBars.Vertical;
            textBoxLoadFromFile_MVV.Size = new Size(297, 361);
            textBoxLoadFromFile_MVV.TabIndex = 0;
            // 
            // panelFill_MVV
            // 
            panelFill_MVV.Controls.Add(groupBoxResult_MVV);
            panelFill_MVV.Dock = DockStyle.Fill;
            panelFill_MVV.Location = new Point(307, 180);
            panelFill_MVV.Name = "panelFill_MVV";
            panelFill_MVV.Size = new Size(667, 391);
            panelFill_MVV.TabIndex = 0;
            // 
            // groupBoxResult_MVV
            // 
            groupBoxResult_MVV.Controls.Add(textBoxResult_MVV);
            groupBoxResult_MVV.Dock = DockStyle.Fill;
            groupBoxResult_MVV.Location = new Point(0, 0);
            groupBoxResult_MVV.Name = "groupBoxResult_MVV";
            groupBoxResult_MVV.Padding = new Padding(5);
            groupBoxResult_MVV.Size = new Size(667, 391);
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
            textBoxResult_MVV.Size = new Size(657, 361);
            textBoxResult_MVV.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(307, 180);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 391);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // openFileDialogTask_MVV
            // 
            openFileDialogTask_MVV.FileName = "openFileDialog1";
            // 
            // toolTipButtons_MVV
            // 
            toolTipButtons_MVV.ToolTipIcon = ToolTipIcon.Info;
            toolTipButtons_MVV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 571);
            Controls.Add(splitter1);
            Controls.Add(panelFill_MVV);
            Controls.Add(panelLeft_MVV);
            Controls.Add(panel2Top_MVV);
            Controls.Add(panelTop_MVV);
            MinimumSize = new Size(992, 618);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sprint 6 | Task6";
            Load += Form1_Load;
            panelTop_MVV.ResumeLayout(false);
            panel2Top_MVV.ResumeLayout(false);
            groupBoxTask_MVV.ResumeLayout(false);
            groupBoxTask_MVV.PerformLayout();
            panelLeft_MVV.ResumeLayout(false);
            groupBoxLoad_MVV.ResumeLayout(false);
            groupBoxLoad_MVV.PerformLayout();
            panelFill_MVV.ResumeLayout(false);
            groupBoxResult_MVV.ResumeLayout(false);
            groupBoxResult_MVV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_MVV;
        private Panel panel2Top_MVV;
        private Panel panelLeft_MVV;
        private Panel panelFill_MVV;
        private Splitter splitter1;
        private GroupBox groupBoxTask_MVV;
        private TextBox textBoxTask_MVV;
        private GroupBox groupBoxLoad_MVV;
        private GroupBox groupBoxResult_MVV;
        private TextBox textBoxLoadFromFile_MVV;
        private TextBox textBoxResult_MVV;
        private OpenFileDialog openFileDialogTask_MVV;
        private ToolTip toolTipButtons_MVV;
        private Button buttonAbout_MVV;
        private Button buttonDone_MVV;
        private Button buttonOpenFile_MVV;
    }
}
