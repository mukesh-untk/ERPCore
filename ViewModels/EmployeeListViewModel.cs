using ERPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERPCore.ViewModels
{
    public class EmployeeListViewModel
    {
        public EmployeeListViewModel(IEnumerable<Employee> empList)
        {
            Employees = empList;
        }
        public IEnumerable<Employee> Employees { get; set; }

        public int Offset { get; set; }

        public int Total { get; set; }

        public int RowPerPage { get; set; }

        public string OrderBy { get; set; }

        public string SearchText { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }
    }
}