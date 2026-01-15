using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeTwoToFourRefactored.Services
{
    public class TwoInputsQuestionsServices
    {
        public string Greeting(string name, string time)
        {
            return $"To repeat back, you said your name was {name} and you woke up today at {time}.";
        }
    }
}