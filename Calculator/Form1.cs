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

        private void button_click(object sender, EventArgs e)
        {
            if((Result.Text == "0") || (operation_pressed)) 
            {
                Result.Clear();
            }
            operation_pressed = false;
            Button b =(Button)sender;
            if (b.Text == ",") 
            {
                if (!Result.Text.Contains(","))
                    Result.Text += b.Text;
            }
            else
                Result.Text += b.Text;
        }

        private void ButtonCE_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
        }
        Double value = 0.0;
        String operation = "";
        bool operation_pressed = false;
        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value != 0) 
            {
                if(b.Text=="sqrt")
                    Result.Text = Operators.Sqrt(Double.Parse(Result.Text)).ToString();
                ButtonResult.PerformClick();
                operation = b.Text;
                operation_pressed = true;
                equation.Text = value + " " + operation;
            }
            else if (b.Text == "sqrt") 
            {
                Result.Text = Operators.Sqrt(Double.Parse(Result.Text)).ToString();
                value = Math.Sqrt(Double.Parse(Result.Text));
            }

            else
            {
                operation = b.Text;
                value = Double.Parse(Result.Text);
                operation_pressed = true;
                equation.Text = value + " " + operation;
            }
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            operation_pressed = false;
            equation.Text = "";
            switch (operation) 
            {
                case "+":
                    //Result.Text = (value + Double.Parse(Result.Text)).ToString();
                    Result.Text = Operators.Plus(value, Double.Parse(Result.Text)).ToString();
                    break;
                case "-":
                    Result.Text = Operators.Minus(value, Double.Parse(Result.Text)).ToString();
                    //Result.Text = (value - Double.Parse(Result.Text)).ToString();
                    break;
                case "/":
                    Result.Text = Operators.Del(value, Double.Parse(Result.Text)).ToString();
                    //Result.Text = (value / Double.Parse(Result.Text)).ToString();
                    break;
                case "*":
                    Result.Text = Operators.Mult(value, Double.Parse(Result.Text)).ToString();
                    //Result.Text = (value * Double.Parse(Result.Text)).ToString();
                    break;
                case "%":
                    Result.Text = Operators.Percent(value, Double.Parse(Result.Text)).ToString();
                    //Result.Text = (value % Double.Parse(Result.Text)).ToString();
                    break;

                default:
                    break;
            }
            value=Double.Parse(Result.Text);
            operation = "";
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            Result.Text="0";
            value = 0;
            equation.Text="";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            switch(e.KeyChar.ToString()) 
            {
                case "0":
                    ButtonNull.PerformClick();
                    break;

                case "1":
                    ButtonOne.PerformClick();
                    break;
                case "2":
                    ButtonTwo.PerformClick();
                    break;
                case "3":
                    ButtonThree.PerformClick();
                    break;
                case "4":
                    ButtonFour.PerformClick();
                    break;
                case "5":
                    ButtonFive.PerformClick();
                    break;
                case "6":
                    ButtonSix.PerformClick();
                    break;
                case "7":
                    ButtonSeven.PerformClick();
                    break;
                case "8":
                    ButtonEight.PerformClick();
                    break;
                case "9":
                    ButtonNine.PerformClick();
                    break;
                case "+":
                    ButtonPlus.PerformClick();
                    break;
                case "-":
                    ButtonMinus.PerformClick();
                    break;
                case "*":
                    ButtonMult.PerformClick();
                    break;
                case "/":
                    ButtonDelenie.PerformClick();
                    break;
                case "%":
                    ButtonPercent.PerformClick();
                    break;
                case "sqrt":
                    ButtonSqrt.PerformClick();
                    break;
                case "=":
                    ButtonResult.PerformClick();
                    break;
                default : 
                    break;
                
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (Result.Text.Length > 0)
            {
                Result.Text = Result.Text.Substring(0, Result.Text.Length - 1);
            }
        }
    }
}
