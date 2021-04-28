using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OldCalc
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }
        private void Calc_Load(object sender, EventArgs e)
        {

        }
        private void Numbers_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text != "0")
                textBox1.Text += button.Text;
            else
                textBox1.Text = button.Text;
        }
        private void AddPoint_Click(object sender, EventArgs e)
        {
            AddPoint();
        }
        private void Result_Click(object sender, EventArgs e)
        {
            switch (label2.Text)
            {
                case "+":
                    Sum();
                    break;
                case "-":
                    Diff();
                    break;
                case "x":
                    Multiply();
                    break;
                case "/":
                    Divide();
                    break;
            }
        }
        private void OperationChoose_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text != "0")
            {
                label1.Text = textBox1.Text;
            }
            if (label1.Text != "")
            {
                label2.Text = button.Text;
            }
            textBox1.Text = "0";
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void EraseSymb_Click(object sender, EventArgs e)
        {
            EraseOneSymb();
        }
        private void PlusMinus_Click(object sender, EventArgs e)
        {
            PlusMinus();
        }
        private void Factorial_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.LastIndexOf(",") != -1)
                MessageBox.Show("Insert Integer");
            else
            textBox1.Text = Factorial(Convert.ToDouble(textBox1.Text)).ToString();
        }
        //functions implement
        double Factorial(double n)
        {
            if (n == 0 || n == 1)
                return 1;
            return n * Factorial(n - 1);
        }
        void Sum()
        {
            label1.Text = (Convert.ToDouble(label1.Text) + Convert.ToDouble(textBox1.Text)).ToString();
            textBox1.Text = "0";
        }
        void Diff()
        {
            label1.Text = (Convert.ToDouble(label1.Text) - Convert.ToDouble(textBox1.Text)).ToString();
            textBox1.Text = "0";
        }
        void Multiply()
        {
            label1.Text = (Convert.ToDouble(label1.Text) * Convert.ToDouble(textBox1.Text)).ToString();
            textBox1.Text = "0";
        }
        void Divide()
        {
            label1.Text = (Convert.ToDouble(label1.Text) / Convert.ToDouble(textBox1.Text)).ToString();
            textBox1.Text = "0";
        }
        void PlusMinus()
        {
            textBox1.Text = (Convert.ToDouble(textBox1.Text) * -1).ToString();
        }
        void AddPoint()
        {
            if (textBox1.Text.LastIndexOf(",") == -1 && textBox1.Text.LastIndexOf("!") == -1)
            {
                textBox1.Text += ",";
            }
        }
        void Clear()
        {
            textBox1.Text = "0";
            label1.Text = "";
            label2.Text = "";
        }
        void EraseOneSymb()
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }
    }
}
