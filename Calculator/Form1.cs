using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string firstOperand = boxFirstOperand.Text;
            string secondOperand = boxSecondOperand.Text;
            lblResult.Text = "";
            if (!decimal.TryParse(firstOperand, out _) && !decimal.TryParse(secondOperand, out _)
                || !decimal.TryParse(firstOperand, out _) && boxOperation.Text == "Factorial")
            {
                lblResult.Text = "Please enter a valid number";
            }
            else
            {
                switch(boxOperation.Text)
                {
                    case "Add":
                        var addOperation = new AddOperation(firstOperand, secondOperand);
                        lblResult.Text = addOperation.Calculate();
                        break;
                    case "Subtract":
                        var subtractOperation = new SubtractOperation(firstOperand, secondOperand);
                        lblResult.Text = subtractOperation.Calculate();
                        break;
                    case "Multiply":
                        var multiplyOperation = new MultiplyOperation(firstOperand, secondOperand);
                        lblResult.Text = multiplyOperation.Calculate();
                        break;
                    case "Divide":
                        var divideOperation = new DivideOperation(firstOperand, secondOperand);
                        lblResult.Text = divideOperation.Calculate();
                        break;
                    case "Factorial":
                        var factorialOperation = new FactorialOperation(firstOperand, secondOperand);
                        lblResult.Text = factorialOperation.Calculate();
                        break;
                    default:
                        lblResult.Text = "Looks like you forgot to choose an operation";
                        break;

                }
            }

            
        }

        private void boxOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(boxOperation.Text)
            {
                case"Add":
                    lblShowOperation.Text = "+";
                    break;
                case "Subtract":
                    lblShowOperation.Text = "-";
                    break;
                case "Multiply":
                    lblShowOperation.Text = "*";
                    break;
                case "Divide":
                    lblShowOperation.Text = "/";
                    break;
                case "Factorial":
                    lblShowOperation.Text = "!";
                    break;
                default:
                    lblShowOperation.Text = "";
                    break;
            }
            if (boxOperation.Text == "Factorial")
            {
                boxSecondOperand.ReadOnly = true;
                boxSecondOperand.Text = "";
                boxFirstOperand.MaxLength = 4;
                if (boxFirstOperand.Text.Length > 4) boxFirstOperand.Text = "";
            }
            else
            {
                boxSecondOperand.ReadOnly = false;
                boxFirstOperand.MaxLength = 9;
            }
        }

        private void boxSecondOperand_TextChanged(object sender, EventArgs e)
        {
            //boxSecondOperand.Text = String.Format("N", boxSecondOperand.Text);
        }
    }
}
