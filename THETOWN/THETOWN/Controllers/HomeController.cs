using Microsoft.AspNetCore.Mvc;
using System.Linq;
using THETOWN.DAL;
using THETOWN.ViewModels;

namespace THETOWN.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.TheTownBackground = _context.theTownBackground.FirstOrDefault();
            homeVM.Introduction= _context.introductions.FirstOrDefault();
            homeVM.transportation = _context.transportations.ToList();
            homeVM.WorkTitle = _context.workTitles.FirstOrDefault();
            homeVM.workSliders = _context.workSliders.ToList();
            homeVM.Contact = _context.contacts.FirstOrDefault();
            return View(homeVM);
        }
    }
}
