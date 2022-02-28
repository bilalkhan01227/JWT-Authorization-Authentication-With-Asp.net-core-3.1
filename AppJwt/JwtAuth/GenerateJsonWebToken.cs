using AppJwt.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace authTesting.Models
{
    public class GenerateJsonWebToken
    {
        private readonly IConfiguration config;

        public GenerateJsonWebToken(IConfiguration config)
        {
            this.config = config;
        }

        public string JsonToken(login userinfo)
        {


            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["jwt:Key"]));

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[] {
        new Claim(JwtRegisteredClaimNames.Sub, userinfo.Username),
        new Claim(JwtRegisteredClaimNames.Email, userinfo.Email),
        //new Claim("Role" , userinfo.role),
        new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())

        };
            var token = new JwtSecurityToken(
                issuer: null, audience: null, claims,
                expires: DateTime.Now.AddMinutes(120), signingCredentials: credentials
                );
            var encodeToken = new JwtSecurityTokenHandler().WriteToken(token);
            return encodeToken;
            

        }
    }
}
