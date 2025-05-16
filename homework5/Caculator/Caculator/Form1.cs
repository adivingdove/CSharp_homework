using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1: Form
    {
        private string currentExpression = ""; // 存储输入表达式
        private double result = 0; // 计算结果
        private char lastOperator; // 记录上一次的运算符
        private bool isNewNumber = true; // 是否输入新的数字


        public Form1()
        {
            InitializeComponent();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn && char.IsDigit(btn.Text[0]))
                {
                    btn.Click += NumberButton_Click;
             
                }
            }

            btnAdd.Click += OperatorButton_Click;
            btnSub.Click += OperatorButton_Click;
            btnMul.Click += OperatorButton_Click;
            btnDiv.Click += OperatorButton_Click;

            btnEqual.Click += btnEqual_Click;
            btnClear.Click += btnClear_Click;

        }


        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (isNewNumber)
            {
                txtDisplay.Text = btn.Text;
                isNewNumber = false;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
        }


        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (!isNewNumber) // 防止连续点击运算符
            {
                currentExpression += txtDisplay.Text + " " + btn.Text + " ";
                result = double.Parse(txtDisplay.Text);
                lastOperator = btn.Text[0];
                isNewNumber = true;
                txtDisplay.Text = "";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (!isNewNumber)
            {
                currentExpression += txtDisplay.Text + " = ";
                double secondOperand = double.Parse(txtDisplay.Text);

                switch (lastOperator)
                {
                    case '+': result += secondOperand; break;
                    case '-': result -= secondOperand; break;
                    case '*': result *= secondOperand; break;
                    case '/':
                        if (secondOperand == 0)
                        {
                            MessageBox.Show("除数不能为 0！");
                            return;
                        }
                        result /= secondOperand;
                        break;
                }

                txtDisplay.Text = currentExpression + result.ToString();
                isNewNumber = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            currentExpression = "";
            result = 0;
            isNewNumber = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
