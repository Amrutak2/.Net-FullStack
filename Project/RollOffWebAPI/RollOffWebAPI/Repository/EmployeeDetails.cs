
using RollOffWebAPI.Data;
using RollOffWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace RollOffWebAPI.Repository
{
    public class EmployeeDetails: IEmployee
    {
        
        private readonly APIProjectContext _employeeDb;
        public EmployeeDetails(APIProjectContext employeeDb)
        {
            _employeeDb = employeeDb;

        }
        public List<EmployeeDatum> GetAllDetails()
        {
            try
            {
                List<EmployeeDatum> user = _employeeDb.EmployeeData.ToList();
                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public EmployeeDatum GetID(double id)
        {
            var value = _employeeDb.EmployeeData.FirstOrDefault(x => x.GlobalGroupId == id);
            return value;
        }
        public EmployeeDatum GetEmail(string email)
        {
            var value = _employeeDb.EmployeeData.FirstOrDefault(x => x.Email == email);
            return value;
        }
        public EmployeeDatum GetName(string name)
        {
            var value = _employeeDb.EmployeeData.FirstOrDefault(x => x.Name == name);
            return value;
        }
    }
}
