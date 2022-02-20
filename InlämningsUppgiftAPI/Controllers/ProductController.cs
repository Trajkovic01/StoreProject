using InlämningsUppgiftAPI.Data;
using InlämningsUppgiftAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InlämningsUppgiftAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly SqlContext _context;

        public ProductController(SqlContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var items = new List<Product>();
            foreach (var item in await _context.Products.Include(x => x.Category).ToListAsync())
                items.Add(new Product(item.Id, item.Name, item.Description, item.Price, item.Category.Name));

            return items;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryEntities>> GetDetaila(int id)
        {
            var item = await _context.Categories.Include(x => x.Products).FirstOrDefaultAsync(i => i.Id == id);
            


            if (item == null)
            {
                return NotFound();
            }

            return new CategoryEntities(item.Id, item.Name, item.Products);
        }

        

    }
    
}
