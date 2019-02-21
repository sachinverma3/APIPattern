using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIPattern.DA;
using static WebAPIPattern.BO.Common;

namespace WebAPIPattern.Controllers
{
    public class TestController : ApiController
    {
        public readonly CommonDA _response = new CommonDA();
        // GET: api/Test
        public APiResponse Get()
        { 
            try
            {
                var data = "get list of data";
                if (data!=null)
                {
                    return _response.ReturnMethod(ErrorCodes.Success, "success", data);
                }
                else
                { 
                    return _response.ReturnMethod(ErrorCodes.NoData, "No Records found");
                }
            }
            catch (Exception ex)
            { 
                return _response.ReturnMethod(ErrorCodes.Error, ex.Message);
            }
        }

        // GET: api/Test/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Test
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }

        private class commonDa
        {
        }
    }
}
