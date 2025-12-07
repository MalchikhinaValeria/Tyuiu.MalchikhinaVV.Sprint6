using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.MalchikhinaVV.Sprint6.Task3.V29.Lib;
namespace Tyuiu.MalchikhinaVV.Sprint6.Task3.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5]
        {
            { -2, -13, -15, -9, -17 },
                { 13, -20, -15, 27, 18 },
                { -12, -1, -20, 13, 0 },
                { 15, 32, 18, -12, -18 },
                { 16, 5, 3, -5, -8 }
        };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_MVV.ColumnCount = columns;
            dataGridViewMatrix_MVV.RowCount = rows;


            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_MVV.Columns[i].Width = 25;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_MVV.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i,j]);
                }
            }
        }
        private void buttonDone_MVV_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_MVV.ColumnCount = columns;
            dataGridViewMatrix_MVV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_MVV.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_MVV.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void buttonHelp_MVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИИПб-25-1 Мальчихина Валерия Викторовна", "Сообщение");
        }
    }
}
