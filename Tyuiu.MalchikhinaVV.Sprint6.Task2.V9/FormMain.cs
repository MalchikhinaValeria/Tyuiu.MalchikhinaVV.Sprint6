using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.MalchikhinaVV.Sprint6.Task2.V9.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint6.Task2.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_MVV_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartStep_MVV.Text);
                int stopValue = Convert.ToInt32(textBoxStopStep_MVV.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction_MVV.Titles.Add("График функции");

                this.chartFunction_MVV.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_MVV.ChartAreas[0].AxisY.Title = "Ось У";

                for (int i = 0; i <= len - 1; i++)
                {
                   this.dataGridViewResult_MVV.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    this.chartFunction_MVV.Series[0].Points.AddXY(startValue, valueArray[i]);
                    startValue++;
                }
 
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИИПб-25-1 Мальчихина Валерия Викторовна", "Сообщение");
        }

        private void buttonDone_MVV_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_MVV.BackColor = Color.Red;
        }

        private void buttonDone_MVV_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_MVV.BackColor = Color.Green;
        }

        private void buttonDone_MVV_MouseDown(object sender, EventArgs e)
        {
            buttonDone_MVV.BackColor = Color.Blue;
        }
    }
}
