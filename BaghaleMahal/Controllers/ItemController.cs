using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BaghaleMahal.Models;
using BaghaleMahal.Data;
namespace BaghaleMahal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ApiContext _context;
        public ItemController(ApiContext context)
        {
            _context = context;
        }
        [HttpPost]
        public JsonResult AddEdit(Items item)
        {
            var itemInDb = _context.Items.Find(item.Id);
            if (itemInDb == null) {
                _context.Items.Add(item);
                _context.SaveChanges();
                return new JsonResult(Ok(item));
            }else
            {
                return new JsonResult(NotFound());
            }
        }
        [HttpGet]
        public JsonResult Get(int id)
        {
            var item = _context.Items.Find(id);
            if (item == null)
            {
                return new JsonResult(NotFound());
            }
            return new JsonResult(Ok(item));
        }
    }
}
