using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.MalchikhinaVV.Sprint6.Task7.V28.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Tyuiu.MalchikhinaVV.Sprint6.Task7.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_MVV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_MVV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            this.WindowState = FormWindowState.Maximized;
        }
        DataService ds = new DataService();
        static string openFilePath;

        private void buttonLoadFile_MVV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MVV.ShowDialog();
            openFilePath = openFileDialogTask_MVV.FileName;
            string path = openFilePath;

            string[] lines = File.ReadAllLines(path);

            int rowCount = lines.Length;
            int colCount = lines[0].Split(';').Length;

            int[,] matrix = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] values = lines[i].Split(';');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(values[j], out int value))
                    {
                        matrix[i, j] = value;
                    }
                }
            }

            dataGridViewIn_MVV.ColumnCount = colCount;
            dataGridViewIn_MVV.RowCount = rowCount;
            dataGridViewOut_MVV.ColumnCount = colCount;
            dataGridViewOut_MVV.RowCount = rowCount;

            for (int i = 0; i < colCount; i++)
            {
                dataGridViewIn_MVV.Columns[i].Width = 50;
                dataGridViewOut_MVV.Columns[i].Width = 50;
            }

            for (int r = 0; r < rowCount; r++)
            {
                for (int c = 0; c < colCount; c++)
                {
                    dataGridViewIn_MVV.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }

            matrix = ds.GetMatrix(path);
            buttonDone_MVV.Enabled = true;
        }

        private void buttonDone_MVV_Click(object sender, EventArgs e)
        {
            int[,] matrix = ds.GetMatrix(openFilePath);
            string[] lines = File.ReadAllLines(openFilePath);

            int rowCount = lines.Length;
            int colCount = lines[0].Split(';').Length;

            for (int r = 0; r < rowCount; r++)
            {
                for (int c = 0; c < colCount; c++)
                {
                    dataGridViewOut_MVV.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }
            buttonSave_MVV.Enabled = true;
        }

        private void buttonSave_MVV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_MVV.FileName = "OutPutDataFileTask7V28.csv";
            saveFileDialogMatrix_MVV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_MVV.ShowDialog();

            string path = saveFileDialogMatrix_MVV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut_MVV.RowCount;
            int columns = dataGridViewOut_MVV.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_MVV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_MVV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonAbout_MVV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
