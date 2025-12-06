using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.MalchikhinaVV.Sprint6.Task1.V26.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint6.Task1.V26
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
                int startValue = -5;
                int stopValue = 5;

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxResult_MVV.Text = "";
                textBoxResult_MVV.AppendText("*----------*----------*" + Environment.NewLine);
                textBoxResult_MVV.AppendText("|     X        f(x)  |" + Environment.NewLine);
                textBoxResult_MVV.AppendText("*----------*----------*" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                   strLine = string.Format("|{0,5:d}    |  {1, 6:f2}   |", startValue, valueArray[i]);
                    textBoxResult_MVV.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }

                textBoxResult_MVV.AppendText("*--------*----------*" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИИПб-25-1 Мальчихина Валерия Викторовна", "Сообщение");
        }



    }
}
