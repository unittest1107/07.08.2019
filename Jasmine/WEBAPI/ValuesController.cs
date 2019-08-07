using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {

        [Route("api/calculator/add/{a}/{b}")]
        public HttpResponseMessage Get(int a, int b)
        {
            return Request.CreateResponse(HttpStatusCode.BadRequest, new { SUM = a + b });

            // return Request.CreateResponse(HttpStatusCode.InternalServerError, String.Format("Server Error {0}", e.Message));
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
