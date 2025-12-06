namespace Tyuiu.MalchikhinaVV.Sprint6.Task0.V14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCondition_MVV = new GroupBox();
            pictureBoxFormula_MVV = new PictureBox();
            textBoxCondition_MVV = new TextBox();
            groupBoxInput_MVV = new GroupBox();
            labelVar_MVV = new Label();
            textBoxInput_MVV = new TextBox();
            groupBoxOutput_MVV = new GroupBox();
            labelResult_MVV = new Label();
            textBoxOutput_MVV = new TextBox();
            buttonDone_MVV = new Button();
            buttonHelp_MVV = new Button();
            groupBoxCondition_MVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_MVV).BeginInit();
            groupBoxInput_MVV.SuspendLayout();
            groupBoxOutput_MVV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_MVV
            // 
            groupBoxCondition_MVV.AccessibleName = "groupBoxCondition_MVV";
            groupBoxCondition_MVV.Controls.Add(pictureBoxFormula_MVV);
            groupBoxCondition_MVV.Controls.Add(textBoxCondition_MVV);
            groupBoxCondition_MVV.Location = new Point(12, 12);
            groupBoxCondition_MVV.Name = "groupBoxCondition_MVV";
            groupBoxCondition_MVV.Size = new Size(776, 221);
            groupBoxCondition_MVV.TabIndex = 0;
            groupBoxCondition_MVV.TabStop = false;
            groupBoxCondition_MVV.Text = "Условие";
            // 
            // pictureBoxFormula_MVV
            // 
            pictureBoxFormula_MVV.BackgroundImageLayout = ImageLayout.None;
            pictureBoxFormula_MVV.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxFormula_MVV.Image = (Image)resources.GetObject("pictureBoxFormula_MVV.Image");
            pictureBoxFormula_MVV.InitialImage = (Image)resources.GetObject("pictureBoxFormula_MVV.InitialImage");
            pictureBoxFormula_MVV.Location = new Point(593, 26);
            pictureBoxFormula_MVV.Name = "pictureBoxFormula_MVV";
            pictureBoxFormula_MVV.Size = new Size(142, 73);
            pictureBoxFormula_MVV.TabIndex = 1;
            pictureBoxFormula_MVV.TabStop = false;
            // 
            // textBoxCondition_MVV
            // 
            textBoxCondition_MVV.AccessibleName = "textBoxCondition_MVV";
            textBoxCondition_MVV.BorderStyle = BorderStyle.None;
            textBoxCondition_MVV.Location = new Point(6, 26);
            textBoxCondition_MVV.Name = "textBoxCondition_MVV";
            textBoxCondition_MVV.ReadOnly = true;
            textBoxCondition_MVV.Size = new Size(257, 20);
            textBoxCondition_MVV.TabIndex = 0;
            textBoxCondition_MVV.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInput_MVV
            // 
            groupBoxInput_MVV.AccessibleName = "groupBoxInput_MVV";
            groupBoxInput_MVV.Controls.Add(labelVar_MVV);
            groupBoxInput_MVV.Controls.Add(textBoxInput_MVV);
            groupBoxInput_MVV.Location = new Point(12, 239);
            groupBoxInput_MVV.Name = "groupBoxInput_MVV";
            groupBoxInput_MVV.Size = new Size(529, 125);
            groupBoxInput_MVV.TabIndex = 1;
            groupBoxInput_MVV.TabStop = false;
            groupBoxInput_MVV.Text = "Ввод данных";
            // 
            // labelVar_MVV
            // 
            labelVar_MVV.AutoSize = true;
            labelVar_MVV.Location = new Point(9, 33);
            labelVar_MVV.Name = "labelVar_MVV";
            labelVar_MVV.Size = new Size(114, 20);
            labelVar_MVV.TabIndex = 1;
            labelVar_MVV.Text = "Переменная Х:";
            // 
            // textBoxInput_MVV
            // 
            textBoxInput_MVV.Location = new Point(6, 60);
            textBoxInput_MVV.Name = "textBoxInput_MVV";
            textBoxInput_MVV.Size = new Size(125, 27);
            textBoxInput_MVV.TabIndex = 0;
            textBoxInput_MVV.KeyPress += textBoxInput_MVV_KeyPress;
            // 
            // groupBoxOutput_MVV
            // 
            groupBoxOutput_MVV.AccessibleName = "groupBoxOutput_MVV";
            groupBoxOutput_MVV.Controls.Add(labelResult_MVV);
            groupBoxOutput_MVV.Controls.Add(textBoxOutput_MVV);
            groupBoxOutput_MVV.Location = new Point(547, 239);
            groupBoxOutput_MVV.Name = "groupBoxOutput_MVV";
            groupBoxOutput_MVV.Size = new Size(241, 125);
            groupBoxOutput_MVV.TabIndex = 2;
            groupBoxOutput_MVV.TabStop = false;
            groupBoxOutput_MVV.Text = "Вывод данных";
            // 
            // labelResult_MVV
            // 
            labelResult_MVV.AutoSize = true;
            labelResult_MVV.Location = new Point(10, 32);
            labelResult_MVV.Name = "labelResult_MVV";
            labelResult_MVV.Size = new Size(78, 20);
            labelResult_MVV.TabIndex = 1;
            labelResult_MVV.Text = "Результат:";
            // 
            // textBoxOutput_MVV
            // 
            textBoxOutput_MVV.Location = new Point(6, 58);
            textBoxOutput_MVV.Name = "textBoxOutput_MVV";
            textBoxOutput_MVV.ReadOnly = true;
            textBoxOutput_MVV.Size = new Size(125, 27);
            textBoxOutput_MVV.TabIndex = 0;
            // 
            // buttonDone_MVV
            // 
            buttonDone_MVV.BackColor = SystemColors.ButtonFace;
            buttonDone_MVV.Location = new Point(623, 382);
            buttonDone_MVV.Name = "buttonDone_MVV";
            buttonDone_MVV.Size = new Size(165, 45);
            buttonDone_MVV.TabIndex = 3;
            buttonDone_MVV.Text = "Выполнить";
            buttonDone_MVV.UseVisualStyleBackColor = false;
            buttonDone_MVV.Click += buttonDone_MVV_Click;
            // 
            // buttonHelp_MVV
            // 
            buttonHelp_MVV.BackColor = SystemColors.ButtonFace;
            buttonHelp_MVV.FlatStyle = FlatStyle.Flat;
            buttonHelp_MVV.Location = new Point(553, 382);
            buttonHelp_MVV.Name = "buttonHelp_MVV";
            buttonHelp_MVV.Size = new Size(64, 45);
            buttonHelp_MVV.TabIndex = 4;
            buttonHelp_MVV.Text = "?";
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
            Controls.Add(groupBoxOutput_MVV);
            Controls.Add(groupBoxInput_MVV);
            Controls.Add(groupBoxCondition_MVV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 14 | Мальчихина В.В";
            groupBoxCondition_MVV.ResumeLayout(false);
            groupBoxCondition_MVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_MVV).EndInit();
            groupBoxInput_MVV.ResumeLayout(false);
            groupBoxInput_MVV.PerformLayout();
            groupBoxOutput_MVV.ResumeLayout(false);
            groupBoxOutput_MVV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_MVV;
        private TextBox textBoxCondition_MVV;
        private GroupBox groupBoxInput_MVV;
        private GroupBox groupBoxOutput_MVV;
        private PictureBox pictureBoxFormula_MVV;
        private TextBox textBoxInput_MVV;
        private Label labelVar_MVV;
        private Label labelResult_MVV;
        private TextBox textBoxOutput_MVV;
        private Button buttonDone_MVV;
        private Button buttonHelp_MVV;
    }
}
