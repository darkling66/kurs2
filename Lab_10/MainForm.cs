using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            gvLakes.AutoGenerateColumns = false;
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Type";
            column.Name = "Вид";
            gvLakes.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Depth";
            column.Name = "Глубина";
            gvLakes.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Weidth";
            column.Name = "Ширина";
            gvLakes.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Имя";
            gvLakes.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Age";
            column.Name = "Возраст";
            gvLakes.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Pollution";
            column.Name = "Загрязненность";
            gvLakes.Columns.Add(column);

            EventArgs args = new EventArgs();
            OnResize(args);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Lake lake = new Lake();
            LakeForm lf = new LakeForm(lake);
            if (lf.ShowDialog() == DialogResult.OK)
            {
                bindSrcLakes.Add(lake);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Lake lake = (Lake)bindSrcLakes.List[bindSrcLakes.Position];
            LakeForm lf = new LakeForm(lake);
            if (lf.ShowDialog() == DialogResult.OK)
            {
                bindSrcLakes.List[bindSrcLakes.Position] = lake;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?",
                "Видалення запису", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcLakes.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені",
                "Очищення даних", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcLakes.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
