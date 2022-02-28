using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PMS.Web.Models;
using PMS.Web.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PMS.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ILogger<EmployeesController> _logger;

        private readonly IEmployeeService _employeeService;

        private readonly IMapper _mapper;

        public EmployeesController(IMapper mapper,ILogger<EmployeesController> logger, IEmployeeService employeeService)
        {
            _mapper = mapper;
            _logger = logger;
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeModel>> Get()
        {
            var list = await _employeeService.GetEmployees();
            //Using automapper to map Models to/from entities.
            var employees = _mapper.Map<IEnumerable<EmployeeModel>>(list);
            return employees;
        }
    }
}
