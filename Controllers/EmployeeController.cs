using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ERPCore.Models;
using ERPCore.ViewModels;
using ERPCore.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ERPCore.Controllers
{
    public class EmployeeController : Controller
    {
        private const string Deleted = "User Deleted Successfully.";
        private const string NotAvailable = "Requested page is not available.";
        private const string UpdateSuccessful = "User Updated Successfully.";
        private const string AddSuccessful = "New User Added Successfully.";
        private const int ROWS_PER_PAGE = 5;

        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(ILogger<HomeController> logger, IEmployeeRepository employeeRepository)
        {
            _logger = logger;
            _employeeRepository = employeeRepository;
        }

        // GET: Employees
        public ActionResult Index()
        {
            var data = _employeeRepository.Get(null, null, null, ROWS_PER_PAGE, 1, "doj", "desc");
            EmployeeListViewModel model = new EmployeeListViewModel(data.employees);
            model.Offset = 1;
            model.RowPerPage = ROWS_PER_PAGE;
            model.Total = data.Total;
            return View(model);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Employee employee = _employeeRepository.Get(id);
            if (employee == null)
            {
                TempData["error"] = NotAvailable;
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            EmployeeViewModel employeeVM = new EmployeeViewModel();
            employeeVM.Employee = _employeeRepository.Get(id);
            if(employeeVM.Employee == null)
            {
                TempData["error"] = NotAvailable;
                return RedirectToAction("Index");
            }

            employeeVM.AllDepartments = _employeeRepository.GetAllDepartments().Select(item => 
                new SelectListItem { Value = $"{item.Id}",
                                     Text = item.Name,
                                     Selected = employeeVM.Employee.Departments.Where(d => d.Id == item.Id).Count() == 1,
                });

            return View("Create", employeeVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //[AccessAuthorize(Roles = "admin, superadmin")]
        public ActionResult Edit(EmployeeViewModel employeeVM)
        {

            if (ModelState.IsValid)
            {
                var employee = employeeVM.Employee;
                if (employeeVM.SelectedDepartments != null)
                {
                    employee.Departments = _employeeRepository.GetAllDepartments().Where(d => employeeVM.SelectedDepartments.Contains(d.Id)).ToList();
                }
                _employeeRepository.Update(employee);
                

                TempData["msg"] = UpdateSuccessful;
                return RedirectToAction("Index");
            }

            employeeVM.AllDepartments = _employeeRepository.GetAllDepartments().Select(item =>
               new SelectListItem
               {
                   Value = $"{item.Id}",
                   Text = item.Name,
                   Selected = employeeVM.Employee.Departments.Where(d => d.Id == item.Id).Count() == 1,
               });

            return View("Create", employeeVM);
        }

        [HttpGet]
        public ActionResult Create()
        {
            EmployeeViewModel employeeVM = new EmployeeViewModel();
            employeeVM.AllDepartments = _employeeRepository.GetAllDepartments().Select(d => new SelectListItem { Value = $"{d.Id}", Text = d.Name });
            return View(employeeVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //[AccessAuthorize(Roles = "admin, superadmin")]
        public ActionResult Create(EmployeeViewModel employeeVM)
        {
            if (ModelState.IsValid)
            {
                var employee = employeeVM.Employee;
                _employeeRepository.Add(employee);
                if (employeeVM.SelectedDepartments != null)
                {
                    employee.Departments = _employeeRepository.GetAllDepartments().Where(d => employeeVM.SelectedDepartments.Contains(d.Id)).ToList();
                }
                _employeeRepository.Update(employee);

                TempData["msg"] = AddSuccessful;
                return RedirectToAction("Index");
            }

            employeeVM.AllDepartments = _employeeRepository.GetAllDepartments().Select(item =>
               new SelectListItem
               {
                   Value = $"{item.Id}",
                   Text = item.Name,
                   Selected = employeeVM.Employee.Departments.Where(d => d.Id == item.Id).Count() == 1,
               });

            return View(employeeVM);
        }

        [HttpPost, ActionName("Delete")]
        // [AccessAuthorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var emp = _employeeRepository.Get(id);
            if (emp != null)
            {
                if (_employeeRepository.Delete(id))
                {
                    TempData["msg"] = Deleted;
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult IsEmailUsed([Bind(Prefix = "Employee.Id")]int id, [Bind(Prefix = "Employee.Email")] String email)
        {
            return Json(! _employeeRepository.IsEmailUsed(id, email));
        }

        [HttpPost]
        public ActionResult EmployeePage(string searchText, DateTime? dateFrom, DateTime? dateTo, int page = 1, string orderBy = "doj", string order = "desc")
        {
            var empList = _employeeRepository.Get(searchText, dateFrom, dateTo, ROWS_PER_PAGE, page, orderBy, order);
            EmployeeListViewModel model = new EmployeeListViewModel(empList.employees);
            model.Offset = page;
            model.RowPerPage = ROWS_PER_PAGE;
            model.Total = empList.Total;
            return View("EmployeeList", model);
        }
    }
}
