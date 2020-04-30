using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherCalcForm
{
    class CipherCalcModel
    {
        //takes two terms entered in the parameters and performs the operation
        //specified by the sign sent via "op", i.e. +, -, *, /
        private double calcAnswer(double term1, double term2, string op)
        {
            double answer;

            switch (op)
            {
                case "+":
                    answer = term1 + term2;
                    break;
                default:
                    answer = 0;
                    break;
            }

            return answer;
        }
    }
}
