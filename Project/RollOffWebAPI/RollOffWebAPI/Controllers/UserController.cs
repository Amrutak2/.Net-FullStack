using Microsoft.AspNetCore.Mvc;
using RollOffWebAPI.Models;
using RollOffWebAPI.Repository;
using RollOffWebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RollOffWebAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private UserService _userDetailsService;
        public UserController(UserService userDetailsService)
        {
            _userDetailsService = userDetailsService;
        }
        [HttpGet("GetAllUserDetails")]
        public List<UserDetail> GetAllUserDetails()
        {
            return _userDetailsService.GetAllUserDetails();
        }
        //[HttpGet]
        //public List<string> Arr()
        //{
        //    List<string> arr = new List<string>();
        //    arr.Add("Amruta");

        //    return arr;
        //}
        [HttpPost]
        public IActionResult AddUser(UserDetail users)
        {
            var usr = _userDetailsService.AddUsers(users);
            return Ok(usr);
        }
        [HttpPut]
        public IActionResult UpdateUser(double id, UserDetail users)
        {
            var usr = _userDetailsService.UpdateUsers(id, users);
            if (usr == null)
            {
                return NoContent();
            }
            return Ok(usr);
        }
        [HttpDelete]
        public IActionResult DeleteUsers(double id, UserDetail users)
        {
            var usr = _userDetailsService.DeleteUsers(id, users);
            if (usr == null)
            {
                return NoContent();
            }
            return Ok(usr);
        }
        
    }
}
