using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Web.Entities
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int Status { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public int StatusId { get; set; }
        public int UserTypeId { get; set; }
    }
}
