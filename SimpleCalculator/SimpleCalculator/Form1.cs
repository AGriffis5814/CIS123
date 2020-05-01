using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmSimpleCalculator : Form
    {
        public frmSimpleCalculator()
        {
            InitializeComponent();
        }
        
        // private method
        private decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            switch (operator1)
            {
                case "+":
                    txtResult.Text = (operand1 + operand2).ToString("f4");
                    break;
                case "-":
                    txtResult.Text = (operand1 - operand2).ToString("f4");
                    break;
                case "*":
                    txtResult.Text = (operand1 * operand2).ToString("f4");
                    break;
                case "/":
                    txtResult.Text = (operand1 / operand2).ToString("f4");
                    break;
                default:
                    MessageBox.Show("Only use +, -, *, or /");
                    break;
            }
            return txtResult.Text;

        }
        //calculate button click method
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
            string operator1 = Convert.ToString(txtOperator.Text);
            decimal operand2 = Convert.ToDecimal(txtOperand2.Text);


            decimal txtresult = Calculate(operand1, operator1, operand2);

            txtResult.Text = txtresult.ToString();

            txtOperand1.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearResults(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
    }
}
