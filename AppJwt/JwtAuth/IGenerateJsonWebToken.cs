using AppJwt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace authTesting.Models
{
    public interface IGenerateJsonWebToken
    {
        public string JsonToken(login userinfo);
    }
}
