using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddLake_Click(object sender, EventArgs e)
        {
            Lake lake = new Lake();
            LakeForm lf = new LakeForm(lake);
            if(lf.ShowDialog() == DialogResult.OK)
            {
                tbLakeInfo.Text += string.Format(
                "Данные про Озеро:\r\n" +
                "Вид: {0}\r\n" +
                "Глубина: {1} м\r\n" +
                "Ширина: {2} км\r\n" +
                "Имя: {3}\r\n" +
                "Возраст: {4} млн\r\n" +
                "Загрязненность: {5}%\r\n" +
                " \r\n", lake.Type, lake.Depth, lake.Weidth, lake.Name, lake.Age, lake.Pollution);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Прекратить роботу?", "Завершение работы", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
