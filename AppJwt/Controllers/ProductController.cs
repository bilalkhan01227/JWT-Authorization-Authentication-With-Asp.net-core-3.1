using AppJwt.Models;
using AppJwt.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)

        {
            _productService = productService;
        }


        
        
        [HttpGet("GetAll")]
        
        public IActionResult GetAllProducts()
        {
            try
            {
                var products = _productService.GetProducts();
                return Ok(products);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }

            
           
        }





    }
}
