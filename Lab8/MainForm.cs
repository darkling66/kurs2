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
            Lake lake = new Lake();
            List<Lake> lakes = new List<Lake>();
            lbLakeInfo.DisplayMember = "Name";
            lbLakeInfo.ValueMember = "Value";
            lbLakeInfo.SelectedIndexChanged += lbLakeInfo_SelectedIndexChanged;
        }

        private void btnAddLake_Click(object sender, EventArgs e)
        {
            Lake lake = new Lake();
            LakeForm lf = new LakeForm(lake);
            if(lf.ShowDialog() == DialogResult.OK)
            {
                lbLakeInfo.Items.Add(lake);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Прекратить роботу?", "Завершение работы", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        void lbLakeInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lake lake = (Lake)lbLakeInfo.SelectedItem;
            MessageBox.Show("Имя: " + lake.Name + "\n" +
                "Вид: " + lake.Type + "\n" +
                "Глубина: " + lake.Depth + "\n" +
                "Ширина: " + lake.Weidth + "\n" +
                "Возраст: " + lake.Age + "\n" +
                "Загрязненность: " + lake.Pollution + "%",
                "Информация про озеро", MessageBoxButtons.OK);
        }
    }
}
