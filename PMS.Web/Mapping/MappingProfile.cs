using AutoMapper;
using PMS.Web.Entities;
using PMS.Web.Models;

namespace PMS.Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Employee, EmployeeModel>();
            CreateMap<EmployeeModel, Employee>();

            CreateMap<AppUser, UserModel>();
            CreateMap<UserModel, AppUser>();
        }
    }
}
