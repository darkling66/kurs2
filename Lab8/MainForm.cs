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
        private BindingList<Lake> lakes;

        public MainForm()
        {
            InitializeComponent();

            lakes = new BindingList<Lake>();
            lbLakeInfo.DataSource = lakes;
            lbLakeInfo.DisplayMember = "Name";

            lbLakeInfo.SelectedIndexChanged += new EventHandler(LbLakeInfo_SelectedIndexChanged);
        }

        private void BtnAddLake_Click(object sender, EventArgs e)
        {
            Lake lake = new Lake();
            LakeForm lf = new LakeForm(lake);

            if(lf.ShowDialog() == DialogResult.OK)
            {
                lakes.Add(lake);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Прекратить роботу?", "Завершение работы", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        void LbLakeInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lake lake = (Lake)lbLakeInfo.SelectedItem;
            MessageBox.Show("Имя: " + lake.Name + "\nВид: " + lake.Type +
                "\nГлубина: " + lake.Depth + "\nШирина: " + lake.Weidth +
                "\nВозраст: " + lake.Age + "\nЗагрязненность: " + lake.Pollution + "%",
                "Информация про озеро");
        }
    }
}
