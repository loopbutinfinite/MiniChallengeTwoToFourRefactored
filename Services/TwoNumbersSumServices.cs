using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeTwoToFourRefactored.Services
{
    public class TwoNumbersSumServices
    {
        public string SumOfTwoNumbers(string input1, string input2)
        {
            if(double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2))
            {
                return $"The sume of both {num1} and {num2} is equal to {num1 + num2}";
            }
            return "Invalid input. Please enter a valid number.";
        }
    }
}