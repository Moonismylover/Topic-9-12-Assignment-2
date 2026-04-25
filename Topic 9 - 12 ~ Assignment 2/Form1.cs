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
        bool enteredSecondNum = false;

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
            enteredSecondNum = false;
            result = 0;
            lsthistory.Items.Clear();
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "";
            if (enteredFirstNum == false)
            {
                double.TryParse(txtdisplay.Text, out firstNum);
                txtdisplay.Text += "1";
            }
            else if (enteredSecondNum == false)
            {
                double.TryParse(txtdisplay.Text, out secondNum);
                txtdisplay.Text += "1";
            }
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "";
            if (enteredFirstNum == false)
            {
                double.TryParse(txtdisplay.Text, out firstNum);
                txtdisplay.Text += "2";
            }
            else if (enteredSecondNum == false)
            {
                double.TryParse(txtdisplay.Text, out secondNum);
                txtdisplay.Text += "2";
            }
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "";
            if (enteredFirstNum == false)
            {
                double.TryParse(txtdisplay.Text, out firstNum);
                txtdisplay.Text += "3";
            }
            else if (enteredSecondNum == false)
            {
                double.TryParse(txtdisplay.Text, out secondNum);
                txtdisplay.Text += "3";
            }
        }

        private void btnfour_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "";
            if (enteredFirstNum == false)
            {
                double.TryParse(txtdisplay.Text, out firstNum);
                txtdisplay.Text += "4";
            }
            else if (enteredSecondNum == false)
            {
                double.TryParse(txtdisplay.Text, out secondNum);
                txtdisplay.Text += "4";
            }
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "";
            if (enteredFirstNum == false)
            {
                double.TryParse(txtdisplay.Text, out firstNum);
                txtdisplay.Text += "5";
            }
            else if (enteredSecondNum == false)
            {
                double.TryParse(txtdisplay.Text, out secondNum);
                txtdisplay.Text += "5";
            }
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "";
            if (enteredFirstNum == false)
            {
                double.TryParse(txtdisplay.Text, out firstNum);
                txtdisplay.Text += "6";
            }
            else if (enteredSecondNum == false)
            {
                double.TryParse(txtdisplay.Text, out secondNum);
                txtdisplay.Text += "6";
            }
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "";
            if (enteredFirstNum == false)
            {
                double.TryParse(txtdisplay.Text, out firstNum);
                txtdisplay.Text += "7";
            }
            else if (enteredSecondNum == false)
            {
                double.TryParse(txtdisplay.Text, out secondNum);
                txtdisplay.Text += "7";
            }
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "";
            if (enteredFirstNum == false)
            {
                double.TryParse(txtdisplay.Text, out firstNum);
                txtdisplay.Text += "8";
            }
            else if (enteredSecondNum == false)
            {
                double.TryParse(txtdisplay.Text, out secondNum);
                txtdisplay.Text += "8";
            }
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "";
            if (enteredFirstNum == false)
            {
                double.TryParse(txtdisplay.Text, out firstNum);
                txtdisplay.Text += "9";
            }
            else if (enteredSecondNum == false)
            {
                double.TryParse(txtdisplay.Text, out secondNum);
                txtdisplay.Text += "9";
            }
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "";
            if (enteredFirstNum == false)
            {
                double.TryParse(txtdisplay.Text, out firstNum);
                txtdisplay.Text += "0";
            }
            else if (enteredSecondNum == false)
            {
                double.TryParse(txtdisplay.Text, out secondNum);
                txtdisplay.Text += "0";
            }
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += ".";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            sign = "+";
            enteredFirstNum = true;
            enteredSecondNum = false;
            txtdisplay.Text = "+";

            if (!enteredFirstNum)
            {
                MessageBox.Show("Please enter a number first!", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            sign = "-";
            enteredFirstNum = true;
            enteredSecondNum = false;
            txtdisplay.Text = "-";

            if (!enteredFirstNum)
            {
                MessageBox.Show("Please enter a number first!", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            sign = "x";
            enteredFirstNum = true;
            enteredSecondNum = false;
            txtdisplay.Text = "x";

            if (!enteredFirstNum)
            {
                MessageBox.Show("Please enter a number first!", "Error", MessageBoxButtons.OK);
            }
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            sign = "/";
            enteredFirstNum = true;
            enteredSecondNum = false;
            txtdisplay.Text = "/";

            if (!enteredFirstNum)
            {
                MessageBox.Show("Please enter a number first!", "Error", MessageBoxButtons.OK);
            }
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

            lsthistory.Items.Add($"{firstNum} {sign} {secondNum} = {result}");

            txtdisplay.Text = $"{result}";

            firstNum = result;
            enteredFirstNum = true;
            enteredSecondNum = false;
            secondNum = 0;
        }
    }
}

//Hard Version – Only do this if you are looking for a real challenge!
//Make a calculator application that the user enters the numbers with the mouse by clicking on buttons,
//like a real calculator. Exactly what features you add is up to you. There will be lot’s to consided:
// How will your calculator know whether you are entering the first or second number?
// How will it store the operation that was chosen?
// What happens after you press equal?