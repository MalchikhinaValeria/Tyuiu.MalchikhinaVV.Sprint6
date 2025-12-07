namespace Tyuiu.MalchikhinaVV.Sprint6.Task3.V29
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
            dataGridViewMatrix_MVV = new DataGridView();
            textBoxTask_MVV = new TextBox();
            groupBoxResult_MVV = new GroupBox();
            labelResult_MVV = new Label();
            textBoxResult_MVV = new TextBox();
            buttonDone_MVV = new Button();
            buttonHelp_MVV = new Button();
            groupBoxTask_MVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_MVV).BeginInit();
            groupBoxResult_MVV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_MVV
            // 
            groupBoxTask_MVV.Controls.Add(dataGridViewMatrix_MVV);
            groupBoxTask_MVV.Controls.Add(textBoxTask_MVV);
            groupBoxTask_MVV.Location = new Point(12, 12);
            groupBoxTask_MVV.Name = "groupBoxTask_MVV";
            groupBoxTask_MVV.Size = new Size(523, 426);
            groupBoxTask_MVV.TabIndex = 0;
            groupBoxTask_MVV.TabStop = false;
            groupBoxTask_MVV.Text = "Условие";
            // 
            // dataGridViewMatrix_MVV
            // 
            dataGridViewMatrix_MVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_MVV.ColumnHeadersVisible = false;
            dataGridViewMatrix_MVV.Location = new Point(264, 26);
            dataGridViewMatrix_MVV.Name = "dataGridViewMatrix_MVV";
            dataGridViewMatrix_MVV.RowHeadersVisible = false;
            dataGridViewMatrix_MVV.RowHeadersWidth = 51;
            dataGridViewMatrix_MVV.Size = new Size(241, 188);
            dataGridViewMatrix_MVV.TabIndex = 1;
            // 
            // textBoxTask_MVV
            // 
            textBoxTask_MVV.BorderStyle = BorderStyle.None;
            textBoxTask_MVV.Location = new Point(6, 26);
            textBoxTask_MVV.Multiline = true;
            textBoxTask_MVV.Name = "textBoxTask_MVV";
            textBoxTask_MVV.ReadOnly = true;
            textBoxTask_MVV.Size = new Size(235, 257);
            textBoxTask_MVV.TabIndex = 0;
            textBoxTask_MVV.Text = "Дан массив 5 на 5. \r\n-2 -13 -15  -9 -17\r\n\r\n  13 -20 -15  27  18\r\n\r\n -12  -1 -20  13   0\r\n\r\n  15  32  18 -12 -18\r\n\r\n  16   5   3  -5  -8\r\nВыполнить сортировку по возрастанию в пятом столбце.\r\n";
            // 
            // groupBoxResult_MVV
            // 
            groupBoxResult_MVV.Controls.Add(labelResult_MVV);
            groupBoxResult_MVV.Controls.Add(textBoxResult_MVV);
            groupBoxResult_MVV.Location = new Point(541, 13);
            groupBoxResult_MVV.Name = "groupBoxResult_MVV";
            groupBoxResult_MVV.Size = new Size(250, 138);
            groupBoxResult_MVV.TabIndex = 1;
            groupBoxResult_MVV.TabStop = false;
            groupBoxResult_MVV.Text = "Вывод данных";
            // 
            // labelResult_MVV
            // 
            labelResult_MVV.AutoSize = true;
            labelResult_MVV.Location = new Point(12, 27);
            labelResult_MVV.Name = "labelResult_MVV";
            labelResult_MVV.Size = new Size(78, 20);
            labelResult_MVV.TabIndex = 1;
            labelResult_MVV.Text = "Результат:";
            // 
            // textBoxResult_MVV
            // 
            textBoxResult_MVV.BackColor = SystemColors.ButtonHighlight;
            textBoxResult_MVV.Location = new Point(6, 51);
            textBoxResult_MVV.Name = "textBoxResult_MVV";
            textBoxResult_MVV.ReadOnly = true;
            textBoxResult_MVV.Size = new Size(125, 27);
            textBoxResult_MVV.TabIndex = 0;
            // 
            // buttonDone_MVV
            // 
            buttonDone_MVV.FlatStyle = FlatStyle.Popup;
            buttonDone_MVV.Location = new Point(666, 387);
            buttonDone_MVV.Name = "buttonDone_MVV";
            buttonDone_MVV.Size = new Size(122, 51);
            buttonDone_MVV.TabIndex = 2;
            buttonDone_MVV.Text = "Выполнить";
            buttonDone_MVV.UseVisualStyleBackColor = true;
            buttonDone_MVV.Click += buttonDone_MVV_Click;
            // 
            // buttonHelp_MVV
            // 
            buttonHelp_MVV.FlatStyle = FlatStyle.Popup;
            buttonHelp_MVV.Location = new Point(553, 387);
            buttonHelp_MVV.Name = "buttonHelp_MVV";
            buttonHelp_MVV.Size = new Size(94, 51);
            buttonHelp_MVV.TabIndex = 3;
            buttonHelp_MVV.Text = "Справка";
            buttonHelp_MVV.UseVisualStyleBackColor = true;
            buttonHelp_MVV.Click += buttonHelp_MVV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_MVV);
            Controls.Add(buttonDone_MVV);
            Controls.Add(groupBoxResult_MVV);
            Controls.Add(groupBoxTask_MVV);
            Name = "FormMain";
            Text = "Form1";
            groupBoxTask_MVV.ResumeLayout(false);
            groupBoxTask_MVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_MVV).EndInit();
            groupBoxResult_MVV.ResumeLayout(false);
            groupBoxResult_MVV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_MVV;
        private DataGridView dataGridViewMatrix_MVV;
        private TextBox textBoxTask_MVV;
        private GroupBox groupBoxResult_MVV;
        private Label labelResult_MVV;
        private TextBox textBoxResult_MVV;
        private Button buttonDone_MVV;
        private Button buttonHelp_MVV;
    }
}
