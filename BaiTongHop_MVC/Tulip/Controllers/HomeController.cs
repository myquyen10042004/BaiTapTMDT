using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tulip.Data;

namespace Tulip.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /
        public async Task<IActionResult> Index(string? search)
        {
            var products = from p in _context.Products select p;

            if (!string.IsNullOrEmpty(search))
            {
                products = products.Where(p => p.ProductName.Contains(search));
            }

            return View(await products.ToListAsync());
        }
    }
}
