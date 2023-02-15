using System;
using System.Collections.Generic;

#nullable disable

namespace RollOffWebAPI.Models
{
    public partial class UserDetail
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
