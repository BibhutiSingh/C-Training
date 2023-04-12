namespace SimpleCalculator
{
    //2+2=4
    public partial class Form1 : Form
    {
        int operand1=0;
        int operand2=0;

        string currentOperator=string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void assignValue(int value)
        {
            if (string.IsNullOrEmpty(currentOperator))
            {
                operand1 = (operand1 * 10) + value;

                lblResult.Text = operand1.ToString();
            }
            else
            {
                operand2 = (operand2 * 10) + value;

                lblResult.Text = $"{operand1} {currentOperator} {operand2}";
            }

           
        }
        private void assignOperation(string operation)
        {
            if (operand2 != 0)
            {
                executeOperation();
            }
           

            if (operation == "plus")
            {
                currentOperator = "+";
            }
            else if (operation == "minus")
            {
                currentOperator = "-";
            }
            lblResult.Text = $"{operand1} {currentOperator}";

        }
        private void executeOperation()
        {
            if (currentOperator == "+")
            {
                lblResult.Text= $"{operand1} {currentOperator} {operand2} = {operand1 + operand2}";
                operand1 = (operand1 + operand2);
                
            }
            else if(currentOperator == "-")
            {
                lblResult.Text = $"{operand1} {currentOperator} {operand2} = {operand1 - operand2}";
                operand1 = (operand1 - operand2);
            }
            operand2 = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            assignValue(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            assignValue(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            assignValue(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            assignValue(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            assignValue(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            assignValue(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            assignValue(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            assignValue(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            assignValue(9);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            assignValue(0);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            assignOperation("plus");
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            executeOperation();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            assignOperation("minus");
        }
    }
}