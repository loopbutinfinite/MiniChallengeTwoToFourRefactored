using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniChallengeTwoToFourRefactored.Services;

namespace MiniChallengeTwoToFourRefactored.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TwoNumbersSumController : ControllerBase
    {
        private readonly TwoNumbersSumServices _TwoNumbersSumServices;

        public TwoNumbersSumController(TwoNumbersSumServices twoNumbersSumServices)
        {
            _TwoNumbersSumServices=twoNumbersSumServices;
        }

        [HttpPost]
        [Route("Sum/{input1}/{input2}")]
        public string ReturnSum(string input1, string input2)
        {
            return _TwoNumbersSumServices.SumOfTwoNumbers(input1, input2);
        }
    }
}