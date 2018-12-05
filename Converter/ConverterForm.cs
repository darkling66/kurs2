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

namespace Converter
{
    public partial class ConverterForm : Form
    {
        public ConverterForm()
        {
            InitializeComponent();
        }

        private void ConvertValue()
        {
            string from, to;
            double converted;
            string UAH1 = @"..\..\UAH_to_USD.txt";
            string UAH2 = @"..\..\UAH_to_RUB.txt";
            string USD1 = @"..\..\USD_to_UAH.txt";
            string USD2 = @"..\..\USD_to_RUB.txt";
            string RUB1 = @"..\..\RUB_to_USD.txt";
            string RUB2 = @"..\..\RUB_to_UAH.txt";
            from = comboBox1.SelectedItem.ToString();
            to = comboBox2.SelectedItem.ToString();
            converted = Convert.ToDouble(richTextBox1.Text);
            if (from == "UAH")
            {
                switch (to)
                {
                    case "USD":
                        FileOpen(UAH1);
                        break;
                    case "RUB":
                        FileOpen(UAH2);
                        break;
                }
            }
            if (from == "USD")
            {
                switch (to)
                {
                    case "UAH":
                        FileOpen(USD1);
                        break;
                    case "RUB":
                        FileOpen(USD2);
                        break;
                }
            }
            if (from == "RUB")
            {
                switch (to)
                {
                    case "USD":
                        FileOpen(RUB1);
                        break;
                    case "UAH":
                        FileOpen(RUB2);
                        break;
                }
            }
        }

        private void FileOpen(string s)
        {
            using (FileStream fstream = File.OpenRead(s))
            {
                double converted;
                converted = Convert.ToDouble(richTextBox1.Text);
                byte[] kurs = new byte[fstream.Length];
                fstream.Read(kurs, 0, kurs.Length);
                string k = System.Text.Encoding.Default.GetString(kurs);
                richTextBox2.Text = Convert.ToString(converted * Convert.ToDouble(k));
            }
        }

        private void EqualValue()
        {
            string from, to;
            from = comboBox1.SelectedItem.ToString();
            to = comboBox2.SelectedItem.ToString();
            if (from == to)
            {
                MessageBox.Show("Это одна и та же валюта", "Внимание!");
            }
        }

        private void AddNumber(int s)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = s.ToString("0.######");
            }
            else
            {
                richTextBox1.Text += s;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            EqualValue();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EqualValue();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x1 = double.Parse(richTextBox1.Text);
            }
            catch (Exception ex)
            {
                string err = String.Format("Error number. {0}", ex.Message);
                MessageBox.Show(err, "Conversion error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (richTextBox1.Text == string.Empty)
            {
                MessageBox.Show("Введите количество валюты для перевода!", "Внимание!");
            }
            else
            {
                ConvertValue();
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AddNumber(0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddNumber(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNumber(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNumber(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddNumber(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddNumber(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddNumber(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddNumber(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddNumber(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddNumber(9);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            richTextBox2.Text = "0";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string a = "";
            int i = 0;
            if (richTextBox1.Text != "0")
            {
                while (i < richTextBox1.Text.Length - 1)
                {
                    a += richTextBox1.Text[i];
                    i++;
                }
                richTextBox1.Text = a;
                if (a == string.Empty)
                {
                    richTextBox1.Text = "0";
                }
            }

        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ",";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            About about = new About();
            if (about.ShowDialog() == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
