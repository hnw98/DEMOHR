using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demoHRMS.Data;
using demoHRMS.Models;

namespace demoHRMS.Business
{
    public class ServicesVM
    {
        
        public Task<List<Employee>> GetEmployeeList()
        {
            HRService service = new HRService();
            return Task.FromResult(service.GetAllEmployees());
        }

        public Task<int> SavePerson(Employee person)
        {
            HRService service = new HRService();
            return Task.FromResult(service.CreateEmployee(person));
        }

        public Task<int> DeletePerson(Employee person)
        {
            HRService service = new HRService();
            return Task.FromResult(service.DeleteEmployee(person));
        }
        public Task<int> UpdatePerson(Employee person)
        {
            HRService service = new HRService();
            return Task.FromResult(service.EditEmployee(person));
        }

        public bool Login(Hr person)
        {
            HRService service = new HRService();
            return service.LoginPerson(person);
        }
    }
}
