using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherCalcForm
{
    class CipherCalcModel
    {
        private bool firstStored; //a boolean to determine if firstTerm has been set
        private double firstTerm; //holds the first term in the expression
        private double secondTerm; //holds the second term in the expression
        private double answer; //holds the current answer for the expression
        private string operationFlag; //holds the value of the operation to find the answer

        public CipherCalcModel()
        {
            ClearModel();
        }

        public CipherCalcModel(double fT, 
            double sT, double s, string oF)
        {
            firstStored = true;
            firstTerm = fT;
            secondTerm = sT;
            answer = s;
            OperationFlag = oF;
        }

        #region ACCESSING AND CHANGING VARIABLES
        public void ClearModel()
        {
            firstStored = false;
            firstTerm = 0;
            secondTerm = 0;
            answer = 0;
            operationFlag = "";
        }

        public void ClearTerms()
        {
            firstStored = false;
            firstTerm = 0;
            secondTerm = 0;

            //MessageBox.Show("clear terms");
        }

        public bool GetFirstStored()
        {
            return firstStored;
        }

        public double FirstTerm
        {
            get { return firstTerm; }
            set 
            { 
                firstTerm = value;
                firstStored = true;
            }
        }

        public double SecondTerm
        {
            get { return secondTerm; }
            set { secondTerm = value; }
        }

        public double Answer
        {
            get { return answer; }
            set { answer = value; }
        }

        public void SetAddition()
        {
            operationFlag = "+";
        }

        public void SetSubtraction()
        {
            operationFlag = "-";
        }

        public void SetMultiplication()
        {
            operationFlag = "x";
        }

        public void SetDivision()
        {
            operationFlag = "/";
        }

        public void ClearOperator()
        {
            operationFlag = "";
        }

        
        public string OperationFlag
        {
            get { return operationFlag; }
            set
            {
                switch (value) //tests if value is one of the valid operators 
                {
                    case "+":
                        SetAddition();
                        break;
                    case "-":
                        SetSubtraction();
                        break;
                    case "x":
                        SetMultiplication();
                        break;
                    case "/":
                        SetDivision();
                        break;
                    case "":
                        ClearOperator();
                        break;
                    default: //value doesn't match one of the valid operators
                        throw new ArgumentException("Invalid operator");
                }
            }
        }

        public double GetAnswer()
        {
            return answer;
        }
        #endregion
        //Solves expression with CalcAnswer and uses GetAnswer 
        //  to return the solution
        public double GetCalcAnswer()
        {
            //MessageBox.Show("get calc answer");
            CalcAnswer();
            return GetAnswer();
        }

        //takes the two stored terms and the operationFlag to create
        //  an expression and stores the solution in the answer
        //  variable; does not return a value
        public void CalcAnswer()
        {
            //MessageBox.Show("calc answer");
            
            //each case solves the answer based on the operationFlag
            switch (operationFlag)
            {
                case "+":
                    //MessageBox.Show("addition");
                    answer = firstTerm + secondTerm;
                    ClearTerms();
                    operationFlag = "";
                    break;
                case "-":
                    answer = firstTerm - secondTerm;
                    ClearTerms();
                    operationFlag = "";
                    break;
                case "x":
                    answer = firstTerm * secondTerm;
                    ClearTerms();
                    operationFlag = "";
                    break;
                case "/":
                    answer = firstTerm / secondTerm;
                    ClearTerms();
                    operationFlag = "";
                    break;
                default:
                    throw new Exception("Error in calculation");
            }
        }


    }
}
