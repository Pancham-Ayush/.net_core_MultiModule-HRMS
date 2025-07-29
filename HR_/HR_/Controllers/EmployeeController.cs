using HR_.Data;
using HR_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
namespace HR_.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> create()
        {
            ViewBag.Departments = await _context.Departments.ToListAsync();
            ViewBag.Hrs = await _context.Hr.ToListAsync();
            ViewBag.Seniors = await _context.Employees.ToListAsync();

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> create_emp(Employee e, String skillset)
        {

            var allSkills = _context.Skills.ToList();
            ViewBag.Message = "Employee added successfully!";
            var skillset_ = skillset.Trim().Split(',');
            List<Skill> matchedSkills = new List<Skill>();

            foreach (var s in skillset_)
            {
                var sname = s.Trim().ToLower();
                var find = allSkills.Find(s => s.Name.ToLower() == sname);
                if (find != null)
                {
                    matchedSkills.Add(find);
                    // Initialize if null
                    if (find.Employees == null)
                        find.Employees = new List<Employee>();
                    find.Employees.Add(e);
                }
                else
                {
                    var sk = new Skill();
                    sk.Name = sname;
                    sk.Employees = new List<Employee> { e };
                    await _context.Skills.AddAsync(sk);
                    allSkills.Add(sk);
                    matchedSkills.Add(sk);
                }

            }
            e.Skills = matchedSkills;
            _context.Employees.Add(e);

            await _context.SaveChangesAsync();

            return View("Index", "Home");
        }

    }
}
