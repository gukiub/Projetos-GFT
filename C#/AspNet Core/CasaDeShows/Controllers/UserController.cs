using Microsoft.AspNetCore.Mvc;

namespace CasaDeShows.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}