using Microsoft.AspNetCore.Mvc;
namespace ProjectEntityFramework.Controllers
{
public class QueryController:Controller{
public IActionResult GetString(int id, string name){
return Content(id+" "+name);
}
}
}