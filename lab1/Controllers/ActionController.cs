using System.Numerics;
using Microsoft.AspNetCore.Mvc;
using lab1.Models;
namespace LAB1.Controllers
{
    public class ActionController : Controller
    {
        //iAction result type
        //view
        public IActionResult index()
        {
            return View();
        }
        //partialView
        public PartialViewResult index1()
        {
            return PartialView("_PartialView");
        }
        //redirect result to home controller in privacy method
        public RedirectResult index2()
        {
            return Redirect("~/home/privacy");
        }
        public ActionResult index3()
        {
            return RedirectToAction("Privacy", "Home");
        }
        public ActionResult index4()
        {
            var students = new List<Student1>{
                new Student1{Id=1,Name="ram"},
                new Student1{Id=2,Name="Hari"}

            };
            return Ok(students);
        }
       public ActionResult Index5()
        {
            var filePath = "/home/prajwal/Desktop/ADO_NET/lab1/obj/lab1.csproj.nuget.g.props";
            return File(filePath, "application/xml");
        }
    }

}