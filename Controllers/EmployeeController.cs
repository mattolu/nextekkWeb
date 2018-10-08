using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWeb.Controllers
{
    public class EmployeeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (var context = new EmployeeContext())
            {
                var model = await context.Employees.AsNoTracking().ToListAsync();
                return View(model);
            }
            
        }  

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FirstName, LastName, DateOfBirth, Sex, MaritalStatus, Password, ConfirmPassword, NumberOfChildren")] Employee employee)
        {
            using (var context = new EmployeeContext())
            {
                context.Add(employee);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
    }
}