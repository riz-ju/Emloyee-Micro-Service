using EmloyeeService.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmloyeeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        DatabaseContext _db;

        public EmployeeController(DatabaseContext db)
        {
            _db = db;
        }


        [HttpGet]
        public IEnumerable<Employee> GetEmployees() {
            return _db.Employees.ToList();
        }



    }
}
