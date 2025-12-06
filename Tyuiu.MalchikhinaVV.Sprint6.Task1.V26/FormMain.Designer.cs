
namespace Tyuiu.MalchikhinaVV.Sprint6.Task1.V26
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
            groupBoxTask_MVV = new GroupBox();
            textBoxTask_MVV = new TextBox();
            groupBoxResult_MVV = new GroupBox();
            labelResult_MVV = new Label();
            textBoxResult_MVV = new TextBox();
            groupBoxInput_MVV = new GroupBox();
            textBoxStopStep_MVV = new TextBox();
            textBoxStartStep_MVV = new TextBox();
            labelStop_MVV = new Label();
            labelStart_MVV = new Label();
            buttonDone_MVV = new Button();
            buttonHelp_MVV = new Button();
            groupBoxTask_MVV.SuspendLayout();
            groupBoxResult_MVV.SuspendLayout();
            groupBoxInput_MVV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_MVV
            // 
            groupBoxTask_MVV.Controls.Add(textBoxTask_MVV);
            groupBoxTask_MVV.Location = new Point(12, 12);
            groupBoxTask_MVV.Name = "groupBoxTask_MVV";
            groupBoxTask_MVV.Size = new Size(512, 322);
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
            textBoxTask_MVV.Size = new Size(383, 52);
            textBoxTask_MVV.TabIndex = 0;
            textBoxTask_MVV.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxResult_MVV
            // 
            groupBoxResult_MVV.Controls.Add(labelResult_MVV);
            groupBoxResult_MVV.Controls.Add(textBoxResult_MVV);
            groupBoxResult_MVV.Location = new Point(530, 12);
            groupBoxResult_MVV.Name = "groupBoxResult_MVV";
            groupBoxResult_MVV.Size = new Size(258, 412);
            groupBoxResult_MVV.TabIndex = 1;
            groupBoxResult_MVV.TabStop = false;
            groupBoxResult_MVV.Text = "Вывод данных";
            // 
            // labelResult_MVV
            // 
            labelResult_MVV.AutoSize = true;
            labelResult_MVV.Location = new Point(14, 23);
            labelResult_MVV.Name = "labelResult_MVV";
            labelResult_MVV.Size = new Size(78, 20);
            labelResult_MVV.TabIndex = 1;
            labelResult_MVV.Text = "Результат:";
            // 
            // textBoxResult_MVV
            // 
            textBoxResult_MVV.BackColor = SystemColors.Menu;
            textBoxResult_MVV.BorderStyle = BorderStyle.None;
            textBoxResult_MVV.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_MVV.Location = new Point(6, 46);
            textBoxResult_MVV.Multiline = true;
            textBoxResult_MVV.Name = "textBoxResult_MVV";
            textBoxResult_MVV.ReadOnly = true;
            textBoxResult_MVV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_MVV.Size = new Size(252, 366);
            textBoxResult_MVV.TabIndex = 0;
            // 
            // groupBoxInput_MVV
            // 
            groupBoxInput_MVV.Controls.Add(textBoxStopStep_MVV);
            groupBoxInput_MVV.Controls.Add(textBoxStartStep_MVV);
            groupBoxInput_MVV.Controls.Add(labelStop_MVV);
            groupBoxInput_MVV.Controls.Add(labelStart_MVV);
            groupBoxInput_MVV.Location = new Point(12, 340);
            groupBoxInput_MVV.Name = "groupBoxInput_MVV";
            groupBoxInput_MVV.Size = new Size(285, 84);
            groupBoxInput_MVV.TabIndex = 2;
            groupBoxInput_MVV.TabStop = false;
            groupBoxInput_MVV.Text = "Ввод данных";
            // 
            // textBoxStopStep_MVV
            // 
            textBoxStopStep_MVV.Location = new Point(143, 46);
            textBoxStopStep_MVV.Name = "textBoxStopStep_MVV";
            textBoxStopStep_MVV.Size = new Size(125, 27);
            textBoxStopStep_MVV.TabIndex = 3;
            // 
            // textBoxStartStep_MVV
            // 
            textBoxStartStep_MVV.Location = new Point(6, 46);
            textBoxStartStep_MVV.Name = "textBoxStartStep_MVV";
            textBoxStartStep_MVV.Size = new Size(125, 27);
            textBoxStartStep_MVV.TabIndex = 2;
            // 
            // labelStop_MVV
            // 
            labelStop_MVV.AutoSize = true;
            labelStop_MVV.Location = new Point(143, 23);
            labelStop_MVV.Name = "labelStop_MVV";
            labelStop_MVV.Size = new Size(94, 20);
            labelStop_MVV.TabIndex = 1;
            labelStop_MVV.Text = "Конец шага:";
            // 
            // labelStart_MVV
            // 
            labelStart_MVV.AutoSize = true;
            labelStart_MVV.Location = new Point(6, 23);
            labelStart_MVV.Name = "labelStart_MVV";
            labelStart_MVV.Size = new Size(88, 20);
            labelStart_MVV.TabIndex = 0;
            labelStart_MVV.Text = "Старт шага:";
            // 
            // buttonDone_MVV
            // 
            buttonDone_MVV.BackColor = SystemColors.GradientInactiveCaption;
            buttonDone_MVV.Location = new Point(417, 351);
            buttonDone_MVV.Name = "buttonDone_MVV";
            buttonDone_MVV.Size = new Size(107, 73);
            buttonDone_MVV.TabIndex = 3;
            buttonDone_MVV.Text = "Выполнить";
            buttonDone_MVV.UseVisualStyleBackColor = false;
            buttonDone_MVV.Click += buttonDone_MVV_Click;
            // 
            // buttonHelp_MVV
            // 
            buttonHelp_MVV.BackColor = SystemColors.ActiveCaption;
            buttonHelp_MVV.Location = new Point(303, 351);
            buttonHelp_MVV.Name = "buttonHelp_MVV";
            buttonHelp_MVV.Size = new Size(108, 73);
            buttonHelp_MVV.TabIndex = 4;
            buttonHelp_MVV.Text = "Справка";
            buttonHelp_MVV.UseVisualStyleBackColor = false;
            buttonHelp_MVV.Click += buttonHelp_MVV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_MVV);
            Controls.Add(buttonDone_MVV);
            Controls.Add(groupBoxInput_MVV);
            Controls.Add(groupBoxResult_MVV);
            Controls.Add(groupBoxTask_MVV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 26 | Мальчихина В.В";
            groupBoxTask_MVV.ResumeLayout(false);
            groupBoxTask_MVV.PerformLayout();
            groupBoxResult_MVV.ResumeLayout(false);
            groupBoxResult_MVV.PerformLayout();
            groupBoxInput_MVV.ResumeLayout(false);
            groupBoxInput_MVV.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private GroupBox groupBoxTask_MVV;
        private GroupBox groupBoxResult_MVV;
        private GroupBox groupBoxInput_MVV;
        private Button buttonDone_MVV;
        private Button buttonHelp_MVV;
        private TextBox textBoxTask_MVV;
        private Label labelResult_MVV;
        private TextBox textBoxResult_MVV;
        private Label labelStop_MVV;
        private Label labelStart_MVV;
        private TextBox textBoxStopStep_MVV;
        private TextBox textBoxStartStep_MVV;
    }
}
