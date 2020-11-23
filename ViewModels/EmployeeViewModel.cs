using ERPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ERPCore.ViewModels
{
    public class EmployeeViewModel
    {
        public IEnumerable<int> SelectedDepartments { get; set; }
        public IEnumerable<SelectListItem> AllDepartments { get; set; }
        public Employee Employee { get; set; }
    }
}