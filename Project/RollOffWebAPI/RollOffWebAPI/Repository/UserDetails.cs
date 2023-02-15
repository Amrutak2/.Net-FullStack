using RollOffWebAPI.Data;
using RollOffWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RollOffWebAPI.Repository
{
    public class UserDetails: IUser
    {
        private APIProjectContext _userManagementDb;
        public UserDetails(APIProjectContext userManagementDb)
        {
            _userManagementDb = userManagementDb;

        }
        #region GetAllUserDetails
        public List<UserDetail> GetAllUserDetails()
        {
            try
            {
                List<UserDetail> user = _userManagementDb.UserDetail.ToList();
                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        public UserDetail AddUsers(UserDetail user)
        {
            _userManagementDb.Add(user);
            _userManagementDb.SaveChanges();
            return (user);
        }
        public UserDetail DeleteUsers(double id, UserDetail user)
        {
            _userManagementDb.Remove(user);
            _userManagementDb.SaveChanges();
            return (user);
        }
        public UserDetail UpdateUsers(double id, UserDetail user)
        {
            _userManagementDb.Update(user);
            _userManagementDb.SaveChanges();
            return (user);
        }
    }
}
