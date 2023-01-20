using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demoHRMS.Models;

namespace demoHRMS.Data
{
    public class HRService
    {
        public HRService()
        {

        }
        demoDBHRContext context = new demoDBHRContext();
        public bool LoginPerson(Hr employee)
        {
            Hr check = context.Hr.Where(a => a.Hrusername == employee.Hrusername && a.Hrpassword == employee.Hrpassword).FirstOrDefault();
            if (check != null)
            {
                return true;
            }

            return false;
        }
        public int CreateEmployee(Employee employee)
        {
            context.Employee.Add(employee);
            return context.SaveChanges();
        }
        public int DeleteEmployee(Employee employee)
        {
            context.Employee.Remove(employee);
            return context.SaveChanges();
        }

        public List<Employee> GetAllEmployees()
        {
            return context.Employee.ToList();
        }
        public int EditEmployee(Employee em)
        {
            context.Employee.Update(em);
            return context.SaveChanges();
        }

    }
}

