using RollOffWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RollOffWebAPI.Repository
{
    public interface IEmployee
    {
        List<EmployeeDatum> GetAllDetails();
        EmployeeDatum GetID(double id);
        EmployeeDatum GetEmail(string email);
        EmployeeDatum GetName(string name);
    }
}
