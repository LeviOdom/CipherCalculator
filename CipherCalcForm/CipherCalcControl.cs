using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherCalcForm
{
    public partial class CipherCalcControl: UserControl
    {
        private CipherCalcModel cipherCalculator = new CipherCalcModel();

        public CipherCalcControl()
        {
            InitializeComponent();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            UserBox.AppendText(oneButton.Text);
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            UserBox.AppendText(twoButton.Text);
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            UserBox.AppendText(threeButton.Text);
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            UserBox.AppendText(fourButton.Text);
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            UserBox.AppendText(fiveButton.Text);
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            UserBox.AppendText(sixButton.Text);
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            UserBox.AppendText(sevenButton.Text);
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            UserBox.AppendText(eightButton.Text);
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            UserBox.AppendText(nineButton.Text);
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            UserBox.AppendText(zeroButton.Text);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("" + cipherCalculator.GetFirstStored());

            if(cipherCalculator.GetFirstStored() == false)
            {
                cipherCalculator.FirstTerm = Double.Parse(UserBox.Text);
                //MessageBox.Show("firstStored (T\\F)= " + firstStored 
                //    + "\nfirstTerm(int) = " + firstTerm);

                //UserBox.AppendText(" " + addButton.Text + " ");
                cipherCalculator.SetAddition();
                operatorLabel.Text = cipherCalculator.OperationFlag;
                UserBox.Text = "";

                //MessageBox.Show("First Stored is " + cipherCalculator.GetFirstStored()
                //    + "\nOperator: " + cipherCalculator.OperationFlag);
            }
            else 
            {
                MessageBox.Show("Error in input.");
            }
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            if (cipherCalculator.GetFirstStored() == false)
            {
                cipherCalculator.FirstTerm = Double.Parse(UserBox.Text);

                cipherCalculator.SetSubtraction();
                operatorLabel.Text = cipherCalculator.OperationFlag;
                UserBox.Text = "";
            }
            else
            {
                MessageBox.Show("Error in input.");
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (cipherCalculator.GetFirstStored() == false)
            {
                cipherCalculator.FirstTerm = Double.Parse(UserBox.Text);

                cipherCalculator.SetMultiplication();
                operatorLabel.Text = cipherCalculator.OperationFlag;
                UserBox.Text = "";
            }
            else
            {
                MessageBox.Show("Error in input.");
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (cipherCalculator.GetFirstStored() == false)
            {
                cipherCalculator.FirstTerm = Double.Parse(UserBox.Text);

                cipherCalculator.SetDivision();
                operatorLabel.Text = cipherCalculator.OperationFlag;
                UserBox.Text = "";
            }
            else
            {
                MessageBox.Show("Error in input.");
            }
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("First Stored is " + cipherCalculator.GetFirstStored());

            if (cipherCalculator.GetFirstStored() == true)
            {
            //MessageBox.Show("Variable firstStored is true.\n" 
            //    + "Operator is " + operatorLabel.Text + "\nEvaluate.");

                cipherCalculator.SecondTerm = Double.Parse(UserBox.Text);

                //MessageBox.Show("Variable secondTerm is " + secondTerm);

                //string solution = "" + cipherCalculator.CalcAnswer();

                //MessageBox.Show("Evalutate:\n" + firstTerm + " " + operationFlag
                //    + " " + secondTerm + "\n   = " + answer);

                UserBox.Text = "" + cipherCalculator.GetCalcAnswer();
                operatorLabel.Text = cipherCalculator.OperationFlag;
            }
            else
            {
                MessageBox.Show("Variable firstStored is false. Error.");
            }
        }

        private void ClearEquationButton_Click(object sender, EventArgs e)
        {
            cipherCalculator.ClearModel();
            operatorLabel.Text = cipherCalculator.OperationFlag;
            UserBox.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserBox.Text = "";
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            string currentText = UserBox.Text;
            int i = currentText.Length;

            if(i <= 0)
            {
                //MessageBox.Show("Current Text Empty: " + currentText);

                UserBox.Text = "";
            }
            else
            {
                //MessageBox.Show("Current Text: " + currentText);

                currentText = currentText.Substring(0, i - 1);

                UserBox.Text = currentText;
            }
            
        }
        private void CipherButton_Click(object sender, EventArgs e)
        {
            //saves current text in the TextBox
            //string currentText = UserBox.Text;

            //variable that can hold the enciphered code
            //declared here so that the try box does not include
            //  creation of the variable, just the Encipher method
            string code;
            
            try
            {
                code = cipherCalculator.Encipher(UserBox.Text);
                UserBox.Text = code;
            }
            
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Cipher Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void DecipherButton_Click(object sender, EventArgs e)
        {
            //saves current text in the TextBox
            //string currentText = UserBox.Text;

            //variable that can hold the enciphered code
            //declared here so that the try box does not include
            //  creation of the variable, just the Encipher method
            string decode;

            try
            {
                decode = cipherCalculator.Decipher(UserBox.Text);
                UserBox.Text = decode;
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Decipher Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //sets textbox to display employee pricing based on current number
        private void EmpPriceButton_Click(object sender, EventArgs e)
        {
            string empPrice = cipherCalculator.EmpCostCalc(UserBox.Text);

            UserBox.Text = empPrice;
        }
    }
}
