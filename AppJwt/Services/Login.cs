using AppJwt.Context;
using AppJwt.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace authTesting.Models
{
    public class Login : ILogin
    {
        private readonly IConfiguration config;
        private readonly EntityContext _context;


        public Login(IConfiguration config , EntityContext context)
        {
            this.config = config;
            _context = context;
        }
        

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public login LoginUser(login user)
        {
            try
            {
               return _context.LSUser.Where(x => x.Username == user.Username && x.Password == user.Password).First();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        
        public int RegisterUser(login user)
        {
            login model = new login();
            var result = 0;
            try
            {
                
                if (model != null)
                {

                    model.Username = user.Username;
                    model.Password = user.Password;
                    model.Email = user.Email;
                    _context.Add<login>(model);
                }
                result = _context.SaveChanges();
                
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        
    }



}
