using Microsoft.AspNetCore.Mvc;

namespace PROG6212_POE_ST10439052.Controllers
{
    // Prototype controller for Academic Manager (no backend logic yet)
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ApproveClaims()
        {
            return View();
        }

        public IActionResult ClaimHistory()
        {
            return View();
        }
    }
}


