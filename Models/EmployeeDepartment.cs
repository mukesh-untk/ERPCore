using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPCore.Models
{
    public class EmployeeDepartment
    {
        public EmployeeDepartment()
        {
            Departments = new HashSet<Department>();
            Employees = new HashSet<Employee>();
        }
        public int DepartmentId { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public int EmployeeId { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
