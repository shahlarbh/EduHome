using Microsoft.AspNetCore.Mvc;

namespace EduHome.Areas.AdminPanel.Controllers
{
    public class DashboardController : AdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
