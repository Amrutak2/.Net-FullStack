using RollOffWebAPI.Models;
using RollOffWebAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RollOffWebAPI.Services
{
    public class EmployeeService
    {
        private IEmployee _employeeDetails;
        public EmployeeService(IEmployee employeeDetails)
        {
            _employeeDetails = employeeDetails;

        }
        public List<EmployeeDatum> GetAllDetails()
        {
            return _employeeDetails.GetAllDetails();
        }

        public EmployeeDatum GetID(double id)
        {
            return _employeeDetails.GetID(id);
        }
        public EmployeeDatum GetEmail(string email)
        {
            return _employeeDetails.GetEmail(email);
        }
        public EmployeeDatum GetName(string name)
        {
            return _employeeDetails.GetName(name);
        }
    }
}
