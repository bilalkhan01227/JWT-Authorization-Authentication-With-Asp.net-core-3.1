using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppJwt.Models
{
    public class login
    {
        [Key]
        public int ID { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }

    
    


    public class loginDTO : login
    {
        public string token { get; set; }
    }
}
