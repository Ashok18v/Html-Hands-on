using Microsoft.AspNetCore.Mvc;

namespace Assignment_razor.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
