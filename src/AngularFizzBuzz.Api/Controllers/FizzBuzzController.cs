using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AngularFizzBuzz.Api.Models;

namespace AngularFizzBuzz.Api.Controllers
{
    [Route("api/[controller]")]
    public class FizzBuzzController : Controller
    {
        // GET api/fizzbuzz/rules
        [Route("rules")]
        [HttpGet]
        public IEnumerable<FizzBuzzRule> Get()
        {
            var fizzBuzzRules = new List<FizzBuzzRule>()
            {
                new FizzBuzzRule() { DisplayResult = "Fizz", Operator = "%", Value = 3, OperationResult = 0},
                new FizzBuzzRule() { DisplayResult = "Buzz", Operator = "%", Value = 5, OperationResult = 0},
                new FizzBuzzRule() { DisplayResult = "Boom", Operator = ">", Value = 50}
            };

            return fizzBuzzRules;
        }
    }
}
