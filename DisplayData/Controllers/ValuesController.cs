using DisplayWordFromCurrencyAndName.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DisplayData.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [AllowAnonymous]
        public IHttpActionResult Get(double number)
        {
            try
            {
                //convert number in to word.
                var result = Helper.NumberToWords(number);

                return Ok(result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return InternalServerError();
            }
        }
    }
}
