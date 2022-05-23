using Bootcamp.Teleperformance.Hafta1.DataManager;
using Bootcamp.Teleperformance.Hafta1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bootcamp.Teleperformance.Hafta1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private static IDataManager categoryManager { get; set; }

        public CategoryController()
        {
            if (categoryManager == null)
                categoryManager = new CategoryManager();
        }

        [HttpGet("getAllProducts")]
        public List<IModel> GetAll()
        {
            List<IModel> result = new List<IModel>();
            result = categoryManager.GetAll();
            return result;
        }

        [HttpGet("getProduct/{id}")]
        public IModel GetById(int id)
        {
            IModel result = new Category();
            result = categoryManager.GetById(id);
            return result;
        }

        [HttpPost("addProduct")]
        public IActionResult Add([FromForm] Category category)
        {
            bool result = false;
            result = categoryManager.Add(category);
            return result == true ? Ok("İşlem Başarılı") : BadRequest("İşlem Başarısız Oldu.");
        }

        [HttpPut("updateProduct")]
        public IActionResult Update([FromQuery] int id, [FromForm] Category newCategory)
        {
            bool result = false;
            result = categoryManager.Update(id, newCategory);
            return result == true ? Ok("İşlem Başarılı") : BadRequest("İşlem Başarısız Oldu.");
        }

        [HttpDelete("deleteProduct")]
        public IActionResult Delete([FromRoute] int id)
        {
            bool result = false;
            result = categoryManager.Delete(id);
            return result == true ? Ok("İşlem Başarılı") : BadRequest("İşlem Başarısız Oldu.");
        }
    }
}
