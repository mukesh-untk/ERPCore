using ERPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPCore.Services
{
    public class InMemoryEmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public InMemoryEmployeeRepository()
        {
            if (_employees.Count == 0)
                DummyData();
        }

        public bool Delete(int employeeId)
        {
            var emp = _employees.Where(e => e.Id == employeeId).FirstOrDefault();
            if(emp!=null)
                return _employees.Remove(emp);
            return false;
        }

        public Employee Get(int id)
        {
            return _employees.Where(e => e.Id == id).FirstOrDefault();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }

        public bool Update(Employee employee)
        {
            Employee emp = Employee.CopyFrom(employee);
            emp.Id = employee.Id;
            _employees.Remove(_employees.Where(e => e.Id == employee.Id).First());
            _employees.Add(emp);
            return true;
        }

        public bool Add(Employee employee)
        {
            employee.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(employee);
            return true;
        }

        private IQueryable<Employee> Orderby(IQueryable<Employee> queryable, string orderBy, string order) => orderBy switch
        {
            "firstName" when order.Equals("asc")    => queryable.OrderBy(e => e.FirstName),
            "firstName"                             => queryable.OrderByDescending(e => e.FirstName),
            "lastName" when order.Equals("asc")     => queryable.OrderBy(e => e.LastName),
            "lastName"                              => queryable.OrderByDescending(e => e.LastName),
            "age" when order.Equals("asc")          => queryable.OrderBy(e => e.Age),
            "age"                                   => queryable.OrderByDescending(e => e.Age),
            "email" when order.Equals("asc")        => queryable.OrderBy(e => e.Email),
            "email"                                 => queryable.OrderByDescending(e => e.Email),
            "gender" when order.Equals("asc")       => queryable.OrderBy(e => e.Gender),
            "gender"                                => queryable.OrderByDescending(e => e.Gender),
            _ when order.Equals("asc")              => queryable.OrderBy(e => e.DateOfJoining),
            _                                       => queryable.OrderByDescending(e => e.DateOfJoining)
        };

        public PagedEmployee Get(string searchText, DateTime? dateFrom, DateTime? dateTo, int max, int page, string orderBy, string order)
        {
            int skip = (page - 1) * max;
            IQueryable<Employee> employee = _employees.AsQueryable();

            if (searchText != null)
            {
                employee = employee.Where(e => e.FirstName.Contains(searchText, StringComparison.OrdinalIgnoreCase) || e.LastName.Contains(searchText, StringComparison.OrdinalIgnoreCase));
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
        
        private void DummyData()
        {
            _employees.Add(new Employee()
            {
                FirstName = "Airi",
                LastName = "Satou",
                Email = "Airi.Satou@site.com",
                Address = new Address() { Address1 = "Tokyo", State = "unkown", City = "unknown", Zip = "123456" },
                Age = 33,
                Gender = Gender.Female,
                DateOfJoining = new DateTime(2008, 11, 28),
                Id = 1

            }) ;
            _employees.Add(new Employee()
            {
                FirstName = "Angelica",
                LastName = "Ramos",
                Email = "Angelica.Ramos@site.com",
                Address = new Address() { Address1 = "London", State = "unkown", City = "unknown", Zip = "123456" },
                Age = 42,
                Gender = Gender.Female,
                DateOfJoining = new DateTime(2009, 10, 09),
                Id = 2
            });
            _employees.Add(new Employee()
            {
                FirstName = "Ashton",
                LastName = "Cox",
                Email = "Ashton.Cox@site.com",
                Address = new Address() { Address1 = "San Francisco", State = "unkown", City = "unknown", Zip = "123456" },
                Age = 66,
                DateOfJoining = new DateTime(2009, 01, 12),
                Id = 3
            });
            _employees.Add(new Employee()
            {
                FirstName = "Bradley",
                LastName = "Greer",
                Email = "Bradley.Greer@site.com",
                Address = new Address() { Address1 = "London", State = "unkown", City = "unknown", Zip = "123456" },
                Age = 41,
                DateOfJoining = new DateTime(2012, 10, 13),
                Id = 4
            });
            _employees.Add(new Employee()
            {
                FirstName = "Brenden",
                LastName = "Wagner",
                Email = "Brenden.Wagner@site.com",
                Address = new Address() { Address1 = "San Francisco", State = "unkown", City = "unknown", Zip = "123456" },
                Age = 28,
                DateOfJoining = new DateTime(2011, 06, 07),
                Id = 5
            });
            _employees.Add(new Employee()
            {
                FirstName = "Brielle",
                LastName = "Williamson",
                Email = "Brielle.Williamson@site.com",
                Address = new Address() { Address1 = "New York", State = "unkown", City = "unknown", Zip = "123456" },
                Age = 61,
                Gender = Gender.Female,
                DateOfJoining = new DateTime(2012, 12, 02),
                Id = 6
            });
            _employees.Add(new Employee()
            {
                FirstName = "Bruno",
                LastName = "Nash",
                Email = "Bruno.Nash@site.com",
                Address = new Address() { Address1 = "London", State = "unkown", City = "unknown", Zip = "123456" },
                Age = 38,
                DateOfJoining = new DateTime(2011, 05, 03),
                Id = 7
            });
            _employees.Add(new Employee()
            {
                FirstName = "Caesar",
                LastName = "Vance",
                Email = "Caesar.Vance@site.com",
                Address = new Address() { Address1 = "New York", State = "unkown", City = "unknown", Zip = "123456" },
                Age = 21,
                DateOfJoining = new DateTime(2011, 12, 12),
                Id = 8
            });
            _employees.Add(new Employee()
            {
                FirstName = "Cara",
                LastName = "Stevens",
                Email = "Cara.Stevens@site.com",
                Address = new Address() { Address1 = "New York", State = "unkown", City = "unknown", Zip = "123456" },
                Age = 46,
                Gender = Gender.Female,
                DateOfJoining = new DateTime(2011, 12, 06),
                Id = 9
            });
            _employees.Add(new Employee()
            {
                FirstName = "Cedric",
                LastName = "Kelly",
                Email = "Cedric.Kelly@site.com",
                Address = new Address() { Address1 = "Edinburgh", State = "unkown", City = "unknown", Zip = "123456" },
                Age = 22,
                Gender = Gender.Female,
                DateOfJoining = new DateTime(2012, 03, 29),
                Id = 10
            });

        }

        public bool IsEmailUsed(int id, string email)
        {
            return (_employees.Where(e => e.Email.Equals(email, StringComparison.OrdinalIgnoreCase)).Count() > 0);
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return new int[] { 1, 2, 3, 5 }.Select(d => new Department { Id = d, Name = $"Item {d}" });
        }
    }
}
