using Microsoft.AspNetCore.Mvc;
using ProjectEntityFramework.Data;
using ProjectEntityFramework.Models.EfTestModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Linq;
namespace ProjectEntityFramework.Controllers
{
    public class StudentController : Controller
    {
       
         private readonly DataContext _context;

    public StudentController(DataContext context)
    {
        _context = context;
    }
       

        [HttpPost]
        public IActionResult Student(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                ViewBag.Message="Data Inserted Successfully!";
                var data=_context.Students.ToList();
                ViewBag.data=data;
               
            }
            return View("Student");
            
        }
      
    }
}
