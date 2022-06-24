using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using MyApp.Model;
using System.ComponentModel.DataAnnotations;

namespace MyApp.DbOperation
{
    public class EmployeeRepository
    {
        public int AddEmployee(EmployeeModel model)
        {
            using(var context= new EmployeeDbEntities())
            {
                Employee emp = new Employee()
                {
                    Name = model.Name,
                    Email = model.Email,
                    Code = model.Code
                };
                context.Employee.Add(emp);
                context.SaveChanges();
                return emp.Id;
            }
        }

    }
}
