using ERPCore.AppDb;
using ERPCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPCore.Services
{
    public abstract class SqlEmployeeRepository : IEmployeeRepository
    {
        public readonly AppDbContext _DbContext;
        public SqlEmployeeRepository(AppDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public bool Add(Employee employee)
        {
            _DbContext.Employees.Add(employee);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(int employeeId)
        {
            var emp = _DbContext.Employees.Where(e => e.Id == employeeId).FirstOrDefault();
            if (emp != null)
            {
                _DbContext.Employees.Remove(emp);
                _DbContext.SaveChanges();
                return true;
            }

            return false;
        }

        public Employee Get(int id)
        {
            return _DbContext.Employees.Include(e=>e.Address).Include(e=>e.Departments).Where(e => e.Id == id).FirstOrDefault();
        }

        public PagedEmployee Get(string searchText, DateTime? dateFrom, DateTime? dateTo, int max, int page, string orderBy, string order)
        {
            int skip = (page - 1) * max;
            IQueryable<Employee> employee = _DbContext.Employees;

            if (searchText != null)
            {
                employee = employee.Where(u =>
                    EF.Functions.Like(u.FirstName.ToLower(), "%" + searchText.ToLower() + "%") ||
                    EF.Functions.Like(u.LastName.ToLower(), "%" + searchText.ToLower() + "%"));
            }

            if (dateFrom != null)
            {
                employee = employee.Where(e => e.DateOfJoining >= dateFrom);
            }
            if (dateTo != null)
            {
                employee = employee.Where(e => e.DateOfJoining <= dateTo);
            }

            employee = Orderby(employee, orderBy, order);

            int count = employee.Count();

            employee = employee.Skip(skip).Take(5);
            var empList = employee.ToList();

            return new PagedEmployee()
            {
                employees = empList,
                Total = count
            };
        }

        public IEnumerable<Employee> GetAll()
        {
            return _DbContext.Employees.ToList();
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _DbContext.Departments;
        }

        public bool IsEmailUsed(int id, string email)
        {
            if(_DbContext.Employees.Where(e => e.Email.ToLower().Equals(email.ToLower()) && e.Id == id).Count() > 0)
            {
                return false;
            }

            return _DbContext.Employees.Where(e=>e.Email.ToLower().Equals(email.ToLower())).Count() > 0;
        }

        public bool Update(Employee employee)
        {
            if (employee != null)
            {
                _DbContext.Update(employee);
                _DbContext.SaveChanges();
                return true;
            }

            return false;
        }

        private IQueryable<Employee> Orderby(IQueryable<Employee> queryable, string orderBy, string order) => orderBy switch
        {
            "firstName" when order.Equals("asc") => queryable.OrderBy(e => e.FirstName),
            "firstName" => queryable.OrderByDescending(e => e.FirstName),
            "lastName" when order.Equals("asc") => queryable.OrderBy(e => e.LastName),
            "lastName" => queryable.OrderByDescending(e => e.LastName),
            "age" when order.Equals("asc") => queryable.OrderBy(e => e.Age),
            "age" => queryable.OrderByDescending(e => e.Age),
            "email" when order.Equals("asc") => queryable.OrderBy(e => e.Email),
            "email" => queryable.OrderByDescending(e => e.Email),
            "gender" when order.Equals("asc") => queryable.OrderBy(e => e.Gender),
            "gender" => queryable.OrderByDescending(e => e.Gender),
            _ when order.Equals("asc") => queryable.OrderBy(e => e.DateOfJoining),
            _ => queryable.OrderByDescending(e => e.DateOfJoining)
        };
    }
}
