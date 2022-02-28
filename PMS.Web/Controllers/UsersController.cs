using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PMS.Web.Data;
using PMS.Web.Entities;
using PMS.Web.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PMS.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IEnumerable<AppUser>> Get()
        {
            var list = await _context.AppUsers.ToListAsync();
            return list;
        }
    }
}
