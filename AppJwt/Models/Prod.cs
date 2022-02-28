using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppJwt.Models
{
    public class Prod
    {

        [Key]
        public int P_ID { get; set; }

        public string P_Name { get; set; }

        public int P_Price { get; set; }

        public int P_Quantity { get; set; }
    }
}
