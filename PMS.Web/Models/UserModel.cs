using Microsoft.AspNetCore.Identity;
using System;

namespace PMS.Web.Models
{
    public class UserModel:IdentityUser
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
