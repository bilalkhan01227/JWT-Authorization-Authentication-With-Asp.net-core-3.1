using AppJwt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace authTesting.Models
{
    public interface ILogin
    {
        public login LoginUser(login user);

        public int RegisterUser(login user);

        public List<User> GetUsers();

    }
}
