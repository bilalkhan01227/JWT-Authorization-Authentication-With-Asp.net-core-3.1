using AppJwt.Context;
using AppJwt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppJwt.Services
{
    public class ProductService : IProductService
    {
        private readonly EntityContext _context;

        public ProductService(EntityContext context)
        {
            _context = context;
        }

        public IQueryable<Prod> GetProducts()
        {
           return _context.Products;
        }
    }
}
