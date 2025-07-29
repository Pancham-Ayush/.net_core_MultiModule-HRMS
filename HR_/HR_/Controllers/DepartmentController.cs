using HR_.Data;
using HR_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HR_.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DepartmentController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("AddDepartment")]
        public IActionResult AddDepartment()
        {
            return View();
        }
        [HttpPost("AddDepartment")]
        public IActionResult acceptdepartment(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
       
    }
}
