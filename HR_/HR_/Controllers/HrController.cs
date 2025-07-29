using HR_.Data;
using HR_.Models;
using Microsoft.AspNetCore.Mvc;

namespace HR_.Controllers
{
    public class HrController : Controller
    {
        ApplicationDbContext _context;
        public HrController(ApplicationDbContext context) { 
            _context = context; 
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST: Processes the form
        [HttpPost]
        public IActionResult Index(Hr hr)
        {
            _context.Hr.Add(hr);
            _context.SaveChanges();

            ViewBag.Message = "HR added successfully!";
            return View(); 
        }
    }
}
