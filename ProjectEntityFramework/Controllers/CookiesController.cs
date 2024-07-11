using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace ProjectEntityFramework.Cookies
{
    public class CookiesController : Controller
    {
        public IActionResult Cookies()
        {
            return View();
        }
        public IActionResult Create()
        {
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddMinutes(10);
            Response.Cookies.Append("id", "101", option);
            Response.Cookies.Append("name", "Prajwal Siwakoti", option);
            return Content("Cookie Created Successfully!");

        }
        public IActionResult Get()
        {
            string id = Request.Cookies["id"];
            string name = Request.Cookies["name"];
            return Content(id + " " + name);
        }

    }



}
