using Microsoft.AspNetCore.Mvc;
using Students.Models;
namespace MYFIRSTWEBAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentApiController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            List<Student> list = new List<Student>();
            list.Add(new Student(101, "ram"));
            list.Add(new Student(102, "Prajwal"));
            list.Add(new Student(103, "Gita"));
            list.Add(new Student(104, "ram"));
            return list;


        }
    }

}
