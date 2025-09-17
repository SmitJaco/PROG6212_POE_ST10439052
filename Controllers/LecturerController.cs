using Microsoft.AspNetCore.Mvc;

namespace PROG6212_POE_ST10439052.Controllers
{
    // Prototype controller for Lecturer 
    public class LecturerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SubmitClaim()
        {
            return View();
        }

        public IActionResult AttachDocuments()
        {
            return View();
        }

        public IActionResult TrackStatus()
        {
            return View();
        }
    }
}


