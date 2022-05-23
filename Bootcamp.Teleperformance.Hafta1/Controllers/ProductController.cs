using Bootcamp.Teleperformance.Hafta1.DataManager;
using Bootcamp.Teleperformance.Hafta1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp.Teleperformance.Hafta1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static ProductManager productManager { get; set; }

        public ProductController()
        {
            if (productManager == null)
                productManager = new ProductManager();
        }

        [HttpGet("getAllProducts")]
        public List<IModel> GetAll()
        {
            List<IModel> result = new List<IModel>();
            result = productManager.GetAll();
            return result;
        }

        [HttpGet("getProduct/{id}")]
        public Product GetById(int id)
        {
            Product result = new Product();
            result = (Product)productManager.GetById(id);
            return result;
        }

        [HttpPost("addProduct")]
        public IActionResult Add([FromForm] Product product)
        {
            bool result = false;
            result = productManager.Add(product);
            return result == true ? Ok("İşlem Başarılı") : BadRequest("İşlem Başarısız Oldu.");
        }

        [HttpPut("updateProduct")]
        public IActionResult Update([FromQuery] int id, [FromForm] Product newProduct)
        {
            bool result = false;
            result = productManager.Update(id, newProduct);
            return result == true ? Ok("İşlem Başarılı") : BadRequest("İşlem Başarısız Oldu.");
        }

        [HttpDelete("deleteProduct")]
        public IActionResult Delete([FromRoute] int id)
        {
            bool result = false;
            result = productManager.Delete(id);
            return result == true ? Ok("İşlem Başarılı") : BadRequest("İşlem Başarısız Oldu.");
        }
    }
}
