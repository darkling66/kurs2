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
    public partial class LakeForm : Form
    {
        public Lake TheLake;

        public LakeForm(Lake t)
        {
            TheLake = t;
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                TheLake.Type = tbType.Text.Trim();
                TheLake.Depth = int.Parse(tbDepth.Text.Trim());
                TheLake.Weidth = int.Parse(tbWeidth.Text.Trim());
                TheLake.Name = tbName.Text.Trim();
                TheLake.Age = int.Parse(tbAge.Text.Trim());
                TheLake.Pollution = int.Parse(tbPollution.Text.Trim());
                DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                string error = String.Format("Error number. {0}", ex.Message);
                MessageBox.Show(error, "Conversion error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void LakeForm_Load(object sender, EventArgs e)
        {
            if (TheLake != null)
            {
                tbType.Text = TheLake.Type;
                tbDepth.Text = TheLake.Depth.ToString();
                tbWeidth.Text = TheLake.Weidth.ToString();
                tbName.Text = TheLake.Name;
                tbAge.Text = TheLake.Age.ToString();
                tbPollution.Text = TheLake.Pollution.ToString();
            }
        }
    }
}
