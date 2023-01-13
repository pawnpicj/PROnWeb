using BarCodeAPIService.Service.MasterData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Barcodesystem.Contract.RouteApi;

namespace BarCodeAPIService.Controllers.Master
{
    [ApiController]
    [Route(APIRoute.Root)]
    public class EmployeeController : ControllerBase
    {

        private IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet("GetEmployee/{username}/{passw0rd}")]
        public async Task<IActionResult> GetEmployeeBinAsync(string username, string passw0rd)
        {
            var a = await employeeService.responseGetEmployee(username, passw0rd);
            if (a.ErrorCode == 0)
            {
                return Ok(a);
            }
            else
            {
                return BadRequest(a);
            }
        }
    }
}
