using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KatmanliMimari.Ui.Controllers
{
    [Authorize(Policy = "RequireAdministratorRole")]
    public class AdminController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult User()
        {
            return RedirectToAction("List", "User");

        }
        public IActionResult Role()
        {
            return RedirectToAction("List","Role");
        }
      
    }
}
