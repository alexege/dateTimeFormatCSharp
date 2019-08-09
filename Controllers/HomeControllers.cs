using Microsoft.AspNetCore.Mvc;
namespace webIntro.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index(){
            ViewBag.Example = "Hello Worlds";
            return View("Index");
        }

        [HttpGet("projects")]

        public ViewResult Projects(){
            return View("Projects");
        }

        [HttpGet("contact")]
        public ViewResult Contact(){
            return View("Contact");
        }

        [HttpGet("hello")]
        public RedirectToActionResult Hello(){
            System.Console.WriteLine("Hello There, redirecting...");
            var param = new {
                username = "Alexander",
                location = "Miami"
            };
            return RedirectToAction("HelloUser", param);
        }

        // localhost:5000/users/...
        [HttpGet("users/{username}/{location}")]

        public string HelloUser(string username, string location)
        {
            if(location == "Miami"){
                return $"Hello {username} from {location}";
            }
            return $"Hello {username}";
        }
    }
}