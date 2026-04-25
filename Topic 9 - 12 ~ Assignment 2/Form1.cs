using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_9___12___Assignment_2
{
    public partial class MainForm : Form
    {
        string sign;
        double firstNum, secondNum, result = 0;
        bool enteredFirstNum = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnquit_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Reconfirm if you want to quit", "Quit", MessageBoxButtons.YesNo))
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "";
            firstNum = 0;
            secondNum = 0;
            enteredFirstNum = false;
            result = 0;
            lsthistory.Items.Clear();
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "1";
            if (!enteredFirstNum)
            {
                double.TryParse(txtdisplay.Text, out firstNum);
            }
            else
            {
                double.TryParse(txtdisplay.Text, out secondNum);
            }
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "2";
            if (!enteredFirstNum)
            {
                double.TryParse(txtdisplay.Text, out firstNum);
            }
            else 
            {
                double.TryParse(txtdisplay.Text, out secondNum);
            }
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "3";
            if (!enteredFirstNum)
            {
                double.TryParse(txtdisplay.Text, out firstNum);
            }
            else 
            {
                double.TryParse(txtdisplay.Text, out secondNum);
            }
        }

        private void btnfour_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "4";
            if (!enteredFirstNum)
            {
                double.TryParse(txtdisplay.Text, out firstNum);
            }
            else 
            {
                double.TryParse(txtdisplay.Text, out secondNum);
            }
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "5";
            if (!enteredFirstNum)
            {
                double.TryParse(txtdisplay.Text, out firstNum);
            }
            else 
            {
                double.TryParse(txtdisplay.Text, out secondNum);
            }
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "6";
            if (!enteredFirstNum)
            {
                double.TryParse(txtdisplay.Text, out firstNum);
            }
            else 
            {
                double.TryParse(txtdisplay.Text, out secondNum);
            }
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "7";
            if (!enteredFirstNum)
            {
                double.TryParse(txtdisplay.Text, out firstNum);
            }
            else
            {
                double.TryParse(txtdisplay.Text, out secondNum);
            }
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "8";
            if (!enteredFirstNum)
            {
                double.TryParse(txtdisplay.Text, out firstNum);
            }
            else 
            {
                double.TryParse(txtdisplay.Text, out secondNum);
            }
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "9";
            if (!enteredFirstNum)
            {
                double.TryParse(txtdisplay.Text, out firstNum);
            }
            else 
            {
                double.TryParse(txtdisplay.Text, out secondNum);
            }
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "0";
            if (!enteredFirstNum)
            {
                double.TryParse(txtdisplay.Text, out firstNum);
            }
            else 
            {
                double.TryParse(txtdisplay.Text, out secondNum);
            }
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += ".";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "")
            {
                MessageBox.Show("Enter a number first", "ERROR", MessageBoxButtons.OK);
                return;
            }

            sign = "+";
            enteredFirstNum = true;
            txtdisplay.Text = "";
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "")
            {
                MessageBox.Show("Enter a number first", "ERROR", MessageBoxButtons.OK);
                return;
            }

            sign = "-";
            enteredFirstNum = true;
            txtdisplay.Text = "";
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "")
            {
                MessageBox.Show("Enter a number first", "ERROR", MessageBoxButtons.OK);
                return;
            }

            sign = "x";
            enteredFirstNum = true;
            txtdisplay.Text = "";
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text == "")
            {
                MessageBox.Show("Enter a number first", "ERROR", MessageBoxButtons.OK);
                return;
            }

            sign = "/";
            enteredFirstNum = true;
            txtdisplay.Text = "";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            switch (sign)
            {
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "x":
                    result = firstNum * secondNum;
                    break;
                case "/":
                    if (secondNum == 0)
                    {
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }
                    else
                    {
                        result = firstNum / secondNum;
                        break;
                    }
            }

            txtdisplay.Text = $"{firstNum} {sign} {secondNum} = {result}";

            firstNum = result;
            enteredFirstNum = true;
            secondNum = 0;
        }
    }
}