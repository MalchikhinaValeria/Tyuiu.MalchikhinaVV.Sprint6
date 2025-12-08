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
using Tyuiu.MalchikhinaVV.Sprint6.Task6.V20.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Tyuiu.MalchikhinaVV.Sprint6.Task6.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_MVV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MVV.ShowDialog();
            openFilePath = openFileDialogTask_MVV.FileName;
            textBoxLoadFromFile_MVV.Text = File.ReadAllText(openFilePath);
            groupBoxLoad_MVV.Text = textBoxResult_MVV.Text + " " + openFileDialogTask_MVV.FileName;
            buttonDone_MVV.Enabled = true;
        }

        private void buttonDone_MVV_Click(object sender, EventArgs e)
        {
            textBoxResult_MVV.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonAbout_MVV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
