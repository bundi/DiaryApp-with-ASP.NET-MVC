using Microsoft.AspNetCore.Mvc;

namespace DairyApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
