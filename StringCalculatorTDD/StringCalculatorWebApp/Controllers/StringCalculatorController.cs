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
        
        [HttpGet]
        public IHttpActionResult GetCalculatedString(string inputString)
        {
            return Ok(stringCalculator.Calculate(inputString));
        }

    }
}
