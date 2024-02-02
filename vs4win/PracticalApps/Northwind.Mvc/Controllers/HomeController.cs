using Microsoft.AspNetCore.Mvc; // Controller, IActionResult
using Northwind.Mvc.Models; // ErrorViewModel
using System.Diagnostics; // Activity
using Packt.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore; // NorthwindContext

namespace Northwind.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NorthwindContext db;
        public HomeController(ILogger<HomeController> logger, NorthwindContext injectedContext)
        {
            _logger = logger;
            db = injectedContext;
        }
        [ResponseCache(Duration = 10 /* seconds */, Location = ResponseCacheLocation.Any)]
        public async Task<IActionResult> Index()
        {
            HomeIndexViewModel model = new
            (
                VisitorCount: Random.Shared.Next(1, 1001),
                Categories: await db.Categories.ToListAsync(),
                Products: await db.Products.ToListAsync()
            );

            return View(model);
        }

        //[Route("private")]
        [Authorize(Roles = "Administrators")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> ProductDetail(int? id, string alertstyle = "success")
        {
            ViewData["alertstyle"] = alertstyle;
            if (!id.HasValue)
            {
                return BadRequest("You must pass a product ID in the route, for example, / Home / ProductDetail / 21");
            }
            Product? model = await db.Products.SingleOrDefaultAsync(p => p.ProductId == id);
            if (model is null)
            {
                return NotFound($"ProductId {id} not found.");
            }
            return View(model); // pass model to view and then return result
        }

        public IActionResult ModelBinding()
        {
            return View(); // the page with a form to submit
        }

        [HttpPost] // use this action method to process POSTs
        public IActionResult ModelBinding(Thing thing)
        {
            HomeModelBindingViewModel model = new(
                Thing: thing, HasErrors: !ModelState.IsValid,
                ValidationErrors: ModelState.Values
                .SelectMany(state => state.Errors)
                .Select(error => error.ErrorMessage)
            );
            return View(model);
        }

        public IActionResult ProductsThatCostMoreThan(decimal? price)
        {
            if (!price.HasValue)
            {
                return BadRequest("You must pass a product price in the query string, for example, / Home / ProductsThatCostMoreThan ? price = 50");
            }
            IEnumerable<Product> model = db.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .Where(p => p.UnitPrice > price);
            if (!model.Any())
            {

                return NotFound($"No products cost more than {price:C}.");
            }
            ViewData["MaxPrice"] = price.Value.ToString("C");
            return View(model); // pass model to view
        }

        [Route("category/{id}")]
        public async Task<IActionResult> CategoryDetail(int? id)
        {
            if (!id.HasValue)
            {
                return BadRequest("You must pass a category ID in the route, for example, /Home/CategoryDetail/6");
            }

            Category? model = await db.Categories.Include(p => p.Products)
              .SingleOrDefaultAsync(p => p.CategoryId == id);

            if (model is null)
            {
                return NotFound($"CategoryId {id} not found.");
            }

            return View(model); // pass model to view and then return result
        }
    }
}
