using FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Services
{
    public interface IService
    {
        Task<IEnumerable<SupplyData>> Find();
    }
}
