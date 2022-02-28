using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace authTesting.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public string Token { get; set; }
    }
}
