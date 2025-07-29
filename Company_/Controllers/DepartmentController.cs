using HR_.Data;
using HR_.Models;
using Microsoft.AspNetCore.Mvc;

namespace Company_.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DepartmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("department/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("department/add")]
        public IActionResult Add(Department department)
        {
            if (ModelState.IsValid)
            {
                _context.Departments.Add(department);
                _context.SaveChanges();
                return Redirect("/home");
            }
            return View(department);
        }
    }
}
