using RollOffWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RollOffWebAPI.Repository
{
   public interface IUser
    {
        List<UserDetail> GetAllUserDetails();
        UserDetail AddUsers(UserDetail user);
        UserDetail UpdateUsers(double id, UserDetail user);
        UserDetail DeleteUsers(double id, UserDetail user);
    }
}
