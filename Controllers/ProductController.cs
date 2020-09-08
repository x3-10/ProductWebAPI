using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductWebAPI.Interfaces;
using ProductWebAPI.Models;
using ProductWebAPI.Repositories;

namespace ProductWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepo _productRepo;

        public ProductController(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Product> products = null;
            products = _productRepo.GetAllProducts();
            return Ok(products);
        }
        //get:api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {

                Product product = null;

                product = _productRepo.GetProduct(id);

                if (product != null)
                {
                    return Ok(product);
                }
                else
                {
                    return NotFound("Product with Id = " + id.ToString() + " not found to display.");


                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
