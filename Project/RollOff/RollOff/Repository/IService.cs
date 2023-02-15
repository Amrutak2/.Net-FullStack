using RollOff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RollOff.Repository
{
    public interface IService
    {
        Task<IEnumerable<SupplyDatum>> Find();
    }
    
}
