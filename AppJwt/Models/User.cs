using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace authTesting.Models
{
    public class User
    {   [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
    }

}
