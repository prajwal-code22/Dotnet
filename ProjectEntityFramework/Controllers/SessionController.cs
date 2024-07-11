using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace ProjectEntityFramework.Session{
    public class SessionController:Controller{
        public IActionResult CreateSession(){
            HttpContext.Session.SetInt32("Id",101);
            HttpContext.Session.SetString("Name","Anish Siwakoti");
            return Content("Session has been created successfully!");
        }
        public IActionResult GetSession(){
            int id=HttpContext.Session.GetInt32("Id").Value;
            string name=HttpContext.Session.GetString("Name");
            return Content(id+" "+name);
        }
    }
}