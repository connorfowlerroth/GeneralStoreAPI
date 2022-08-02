using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeneralStoreAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GeneralStoreAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private GeneralStoreDBContext _db;
        public ProductController(GeneralStoreContext db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductEdit newProduct)
        {
            ProductController product = new ProductController()
            {
                Name = newProduct.Name,
                Price = newProduct.price,
                QuantityInStock = newProduct.Quantity,
            };

            _db.Products.Add(products);
            await _db.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts() {
            var products = await _db.Products.ToListAsync();
            return Ok(products);
        }
    }
}