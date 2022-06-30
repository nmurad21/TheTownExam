using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using THETOWN.DAL;
using THETOWN.ViewModels;

namespace THETOWN.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
