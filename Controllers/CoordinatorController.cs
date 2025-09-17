using Microsoft.AspNetCore.Mvc;

namespace PROG6212_POE_ST10439052.Controllers
{
    // Prototype controller for Programme Coordinator (no backend logic yet)
    public class CoordinatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VerifyClaims()
        {
            return View();
        }

        public IActionResult PendingClaims()
        {
            return View();
        }
    }
}


