using ERPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPCore.Services
{
    public interface IEmployeeRepository
    {
        public bool Add(Employee employee);
        public Employee Get(int id);
        public IEnumerable<Employee> GetAll();
        public PagedEmployee Get(string searchText, DateTime? dateFrom, DateTime? dateTo, int max, int page, string orderBy, string order);
        public bool Update(Employee employee);
        public bool Delete(int employeeId);
        public bool IsEmailUsed(int id, string email);
        public IEnumerable<Department> GetAllDepartments();
    }

    public class PagedEmployee
    {
        public IEnumerable<Employee> employees { get; set; }
        public int Total { get; set; }
    }
}
