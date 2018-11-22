using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double x1 = 0;
            double x2 = 0;
            if (string.IsNullOrEmpty(tbX1.Text) || (String.IsNullOrEmpty(tbX2.Text)))
            {
                tbY.Text = "Не введено даних!";
                tbMin.Text = "Не введено даних!";
                return;
            }
            try
            {
                x1 = double.Parse(tbX1.Text);
                x2 = double.Parse(tbX2.Text);
            }
            catch(Exception excpetion)
            {
                string error = String.Format("Error number. {0}", excpetion.Message);
                MessageBox.Show(error, "Conversion error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            double y = Math.Pow(Math.Cos(Math.Exp((x1 + 2 * x2 + 9) / 0.666)), 3);
            tbY.Text = y.ToString("0.######");
            if (x1 < x2) {
                tbMin.Text = x1.ToString("0.######");
            }
            else
            {
                tbMin.Text = x2.ToString("0.######");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbX1.Text = string.Empty;
            tbX2.Text = string.Empty;
            tbY.Text = string.Empty;
            tbMin.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
