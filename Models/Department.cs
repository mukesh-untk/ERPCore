using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ERPCore.Models
{
    public class Department
    {
        public Department()
        {
            this.Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public String Name { get; set; }

        [NotMapped]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}