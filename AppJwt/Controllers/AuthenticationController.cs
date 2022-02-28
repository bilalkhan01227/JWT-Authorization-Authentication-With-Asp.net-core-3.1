using AppJwt.Models;
using authTesting.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration config;
        private readonly ILogin _ilogin;

        public AuthenticationController(IConfiguration config, ILogin ilogin)
        {
            this.config = config;
            _ilogin = ilogin;
        }

        [HttpPost("login")]
        public Response Login(login user)
        {
            try
            {
                login loginUser = new login();
                loginUser.Username = user.Username;
                loginUser.Password = user.Password;
                //IActionResult response = Unauthorized();
                var result = _ilogin.LoginUser(loginUser);
                if (result == null)
                {
                    return new Response()
                    {

                        Data = result,
                        Message = "Logged Fail",
                        StatusCode = 104


                    };


                }
                else
                {
                    GenerateJsonWebToken jsonWebToken = new GenerateJsonWebToken(config);
                    string token = jsonWebToken.JsonToken(result);
                    //string Token = token.JsonToken(result)
                    //return RedirectToAction("Index","Home");
                    if (token != null)
                    {
                        //  HttpContext.Response.Cookies.Append("token", token);
                        return new Response()
                        {

                            Data = result,
                            Message = "Logged In success",
                            StatusCode = 200,
                            Token = token


                        };

                    }


                }
            }
            catch (Exception ex)
            {
                return new Response()
                {
                    Data = null,
                    /*Message = ex.Message,*/
                    Message = ex.Message,
                    StatusCode = 500,
                    Token = null
                };

            }
            return new Response() { };
        }


        [HttpPost("register")]
        public Response Register( login user)
        {
            var result = _ilogin.RegisterUser(user);
            return new Response
            {
                Data = result,
                Message = "Success, You have been registered",
                StatusCode = 200
            };
        }
       
    }
}

