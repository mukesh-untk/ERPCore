using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCore.Models
{
    public class Employee
    {
        /// <summary>
        /// New Employee with today as DateOfJoining
        /// </summary>
        public Employee()
        {
            this.DateOfJoining = DateTime.Now;
            this.Departments = new HashSet<Department>();
        }

        /// <summary>
        /// Employee Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// First Name of Employee
        /// </summary>
        [MaxLength(50)]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of Employee
        /// </summary>
        [MaxLength(50)]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// Email of Employee
        /// </summary>
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        [Remote("IsEmailUsed", "Employee", AdditionalFields = "Id", ErrorMessage = "Email is already in use.", HttpMethod = "POST")]
        public string Email { get; set; }

        /// <summary>
        /// Age of Employee
        /// </summary>
        [Range(20, 90, ErrorMessage = @"{0} must be between {1} and {2}.")]
        [Required]
        public int Age { get; set; }

        /// <summary>
        /// Address of Employee
        /// </summary>
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Address Address { get; set; }

        /// <summary>
        /// Employee's Gender
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Departments assigned
        /// </summary>
        public virtual ICollection<Department> Departments { get; set; }

        /// <summary>
        /// Joining date of empoyee
        /// </summary>
        [Display(Name = "Date Of Joining")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime DateOfJoining { get; set; }

        public static Employee CopyFrom(Employee Obj)
        {
            Employee employee = new Employee();
            employee.FirstName = Obj.FirstName;
            employee.LastName = Obj.LastName;
            employee.Age = Obj.Age;
            employee.Email = Obj.Email;
            employee.Gender = Obj.Gender;
            
            if (Obj.Address != null)
            {
                employee.Address = new Address();
                employee.Address.Id = Obj.Address.Id;
                employee.Address.Address1 = Obj.Address.Address1;
                employee.Address.Address2 = Obj.Address.Address2;
                employee.Address.State = Obj.Address.State;
                employee.Address.City = Obj.Address.City;
                employee.Address.Zip = Obj.Address.Zip;
            }
            return employee;
        }
    }
}