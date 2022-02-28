using Microsoft.EntityFrameworkCore;
using PMS.Web.Data;
using PMS.Web.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Web.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<AppUser> GetUser(string Id)
        {
            var result = await _context.AppUsers.FirstOrDefaultAsync();
            return result;
        }
    }

    public interface IUserService {
        Task<AppUser> GetUser(string Id);
    }
}
