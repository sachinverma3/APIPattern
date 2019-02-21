using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIPattern.BO
{
    public class Common
    {
        public class APiResponse
        {
            public string ResponseCode { get; set; }
            public string Message { get; set; }
            public object Result { get; set; }
        }
        public static class ErrorCodes
        {
            public static string Success = "200";
            public static string Error = "500";
            public static string NoData = "201";
            public static string NotFound = "404";
            public static string Unauthorized = "401";
            public static string AlreadyExists = "202";
        }
    }
}