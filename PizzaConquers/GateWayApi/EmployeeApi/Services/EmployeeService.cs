using EmployeeApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Services
{
    public class EmployeeService
    {
        private readonly EmployeeContext _employeeContext;

        public EmployeeService(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public Employee Add(Employee emp)
        {
            try {
                _employeeContext.Add(emp);
                _employeeContext.SaveChanges();
                return emp;
            }
            catch(DbUpdateConcurrencyException dbx)
            {
                Console.WriteLine(dbx.Message);
            }
            catch(DbUpdateException dbex)
            {
                Console.WriteLine(dbex.Message);
            }
            return null;
        }
        public ICollection<Employee> GetAll()
        {
            if (_employeeContext.Employees.ToList().Count > 0)
                return _employeeContext.Employees.ToList();
            return null;
        }
    }
}
