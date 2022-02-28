using AppJwt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppJwt.Services
{
    public interface IProductService
    {
        IQueryable<Prod> GetProducts();
    }
}
