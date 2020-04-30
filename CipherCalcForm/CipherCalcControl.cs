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
        
        private bool firstStored = false;
        private double firstTerm = 0;
        private double secondTerm = 0;
        private double answer = 0;
        private string operationFlag = "";

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
            if(firstStored==false)
            {
                firstTerm = Double.Parse(UserBox.Text);
                firstStored = true;

                //MessageBox.Show("firstStored (T\\F)= " + firstStored 
                //    + "\nfirstTerm(int) = " + firstTerm);

                //UserBox.AppendText(" " + addButton.Text + " ");
                operatorLabel.Text = "+";
                UserBox.Text = "";
                operationFlag = operatorLabel.Text;
            }
            else 
            {
                MessageBox.Show("Error in input.");
            }
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            if (firstStored == false)
            {
                firstTerm = Double.Parse(UserBox.Text);
                firstStored = true;

                operatorLabel.Text = "-";
                UserBox.Text = "";
                operationFlag = operatorLabel.Text;
            }
            else
            {
                MessageBox.Show("Error in input.");
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (firstStored == false)
            {
                firstTerm = Double.Parse(UserBox.Text);
                firstStored = true;

                operatorLabel.Text = "x";
                UserBox.Text = "";
                operationFlag = operatorLabel.Text;
            }
            else
            {
                MessageBox.Show("Error in input.");
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (firstStored == false)
            {
                firstTerm = Double.Parse(UserBox.Text);
                firstStored = true;

                operatorLabel.Text = "/";
                UserBox.Text = "";
                operationFlag = operatorLabel.Text;
            }
            else
            {
                MessageBox.Show("Error in input.");
            }
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (firstStored == true)
            {
                //MessageBox.Show("Variable firstStored is true.\n" 
                //    + "Operator is " + operatorLabel.Text + "\nEvaluate.");

                secondTerm = Double.Parse(UserBox.Text);

                //MessageBox.Show("Variable secondTerm is " + secondTerm);

                answer = cipherCalculator.CalcAnswer(firstTerm, secondTerm, operationFlag);

                MessageBox.Show("Evalutate:\n" + firstTerm + " " + operationFlag
                    + " " + secondTerm + "\n   = " + answer);

                UserBox.Text = "" + answer;
                firstStored = false;
                operationFlag = "=";
                operatorLabel.Text = operationFlag;
            }
            else
            {
                MessageBox.Show("Variable firstStored is false. Error.");
            }
        }

        private void CipherButton_Click(object sender, EventArgs e)
        {

        }

        private void DecipherButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearEquationButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }
    }
}
