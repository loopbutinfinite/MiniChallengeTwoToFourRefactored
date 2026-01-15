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
    public class TwoNumbersStatementsController : ControllerBase
    {
        private readonly TwoNumbersStatementsServices _TwoNumbersStatementsServices;

        public TwoNumbersStatementsController(TwoNumbersStatementsServices twoNumbersStatementsServices)
        {
            _TwoNumbersStatementsServices = twoNumbersStatementsServices;
        }

        [HttpPost]
        [Route("Statements/{input1}/{input2}")]
        public string ReturnStatements(string input1, string input2)
        {
            return _TwoNumbersStatementsServices.ReturnStatements(input1, input2);
        }
    }
}