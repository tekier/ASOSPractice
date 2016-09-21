using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StringCalculatorTDD;

namespace StringCalculatorWebApp.Controllers
{
    public class StringCalculatorController : ApiController
    {
        StringCalculator stringCalculator = new StringCalculator();

        public IHttpActionResult CalculateString(string inputString)
        {
            var sum = stringCalculator.Calculate(inputString);
            return Ok(sum);
        }

    }
}
