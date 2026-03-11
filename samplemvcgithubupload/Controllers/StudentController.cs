using Microsoft.AspNetCore.Mvc;

namespace samplemvcgithubupload.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
