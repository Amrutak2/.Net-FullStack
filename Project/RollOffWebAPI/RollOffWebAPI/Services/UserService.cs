using RollOffWebAPI.Models;
using RollOffWebAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RollOffWebAPI.Services
{
    public class UserService
    {
        private IUser _userDetailsRepository;
        public UserService(IUser userDetailsRepository)
        {
            _userDetailsRepository = userDetailsRepository;

        }
        public List<UserDetail> GetAllUserDetails()
        {
            return _userDetailsRepository.GetAllUserDetails();
        }
        public UserDetail AddUsers(UserDetail user)
        {
            return _userDetailsRepository.AddUsers(user);
        }
        public UserDetail UpdateUsers(double id, UserDetail user)
        {
            return _userDetailsRepository.UpdateUsers(id, user);
        }
        public UserDetail DeleteUsers(double id, UserDetail user)
        {
            return _userDetailsRepository.DeleteUsers(id, user);
        }
    }
}
