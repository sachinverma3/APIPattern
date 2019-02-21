using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static WebAPIPattern.BO.Common;

namespace WebAPIPattern.DA
{
    public class CommonDA
    {
        public APiResponse ReturnMethod(string responseCode, string message, object result = null)
        {
            return new APiResponse
            {
                ResponseCode = responseCode,
                Message = message,
                Result = result
            };
        }
    }
}