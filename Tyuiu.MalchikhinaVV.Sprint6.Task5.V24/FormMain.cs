using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.MalchikhinaVV.Sprint6.Task5.V24.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint6.Task5.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        public int len = 0;

        string path = @"C:\Users\Home\source\repos\Tyuiu.MalchikhinaVV.Sprint6\InPutFileTask5V24.txt";
        private void buttonDone_MVV_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewResult_MVV.ColumnCount = 2;
                dataGridViewResult_MVV.Columns[0].Width = 20;
                dataGridViewResult_MVV.Columns[1].Width = 50;

                this.chartFunction_MVV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_MVV.ChartAreas[0].AxisY.Title = "Ось Y";

                chartFunction_MVV.Series[0].Points.Clear();
                dataGridViewResult_MVV.Rows.Clear();
                double[] numsMass = new double[len];

                numsMass = ds.LoadFromDataFile(path);

                for (int i = 0; i < numsMass.Length; i++)
                {
                    dataGridViewResult_MVV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                    chartFunction_MVV.Series[0].Points.AddXY(i, numsMass[i]);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpen_MVV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_MVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИИПб-25-2 Мальчихина Валерия Викторовна", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
