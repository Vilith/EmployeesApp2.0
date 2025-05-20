using EmployeesApp.Web.Models;
using EmployeesApp.Web.Services;
using Microsoft.AspNetCore.Mvc;
using EmployeesApp.Web.Views.Employees;

namespace EmployeesApp.Web.Controllers
{
    public class EmployeesController : Controller
    {
        static EmployeeService service = new EmployeeService();

        [HttpGet("")]
        public IActionResult Index()
        {
            var model = service.GetAll();
            var viewModel = new IndexVM {

                Employees = model.Select(b=> new IndexVM.EmployeeItemVM
                {
                    Name = b.Name,
                    Id = b.Id,
                    Email = b.Email
                })
                .ToArray()
            };
            return View(model);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(CreateVM vm)
        {
            if (!ModelState.IsValid)
                return View();

            var employee = new Employee {

                Name = vm.Name,
                Email = vm.Email
            };
            service.Add(employee);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            var model = service.GetById(id);
            return View(model);
        }
    }
}
