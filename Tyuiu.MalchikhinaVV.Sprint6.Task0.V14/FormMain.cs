using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.MalchikhinaVV.Sprint6.Task0.V14.Lib;

namespace Tyuiu.MalchikhinaVV.Sprint6.Task0.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_MVV_Click(object sender, EventArgs e)
        {
             DataService ds = new DataService();
            try
            {
                textBoxOutput_MVV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInput_MVV.Text)));

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxInput_MVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_MVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИИПб-25-1 Мальчихина Валерия Викторовна", "Сообщение");
        }
    }
}
