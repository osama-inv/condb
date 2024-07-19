using condb.Data;
using condb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace condb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TheDbContext _context;
        public HomeController(TheDbContext theDbContext)
        {
            _context = theDbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_context.people.ToList());
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Person model)
        {
            if (ModelState.IsValid)
            {
                _context.people.Add(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
