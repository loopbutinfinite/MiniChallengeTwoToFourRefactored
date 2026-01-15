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
    public class TwoInputsQuestionsController : ControllerBase
    {
        private readonly TwoInputsQuestionsServices _TwoInputsQuestionsServices;

        public TwoInputsQuestionsController(TwoInputsQuestionsServices twoInputsQuestionsServices)
        {
            _TwoInputsQuestionsServices = twoInputsQuestionsServices;
        }

        [HttpPost]
        [Route("Response/{name}/{time}")]
        
        public string ReturnGreeting(string name, string time)
        {
            return _TwoInputsQuestionsServices.Greeting(name, time);
        }
    }
}