using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using THETOWN.DAL;
using THETOWN.Models;

namespace THETOWN.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TransportationController : Controller
    {
        private readonly AppDbContext _context;
        public TransportationController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Transportation> list = _context.transportations.ToList();
            return View(list);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Transportation dbTransportation =await _context.transportations.FindAsync(id);
            if (dbTransportation == null) return NotFound();
            return View(dbTransportation);
        }

       public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Transportation transportation)
        {
            Transportation dbTransportation = new Transportation();
            dbTransportation.IconUrl = transportation.IconUrl;
            dbTransportation.Title = transportation.Title;
            dbTransportation.Desc = transportation.Desc;
            await _context.transportations.AddAsync(dbTransportation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task< IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Transportation dbTransportation = await _context.transportations.FindAsync(id);
            if (dbTransportation == null) return NotFound();
            return View(dbTransportation);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int?id,Transportation transportation)
        {
            if (id == null) return NotFound();
            Transportation dbTransportation = await _context.transportations.FindAsync(id);
            dbTransportation.IconUrl = transportation.IconUrl;
            dbTransportation.Title = transportation.Title;
            dbTransportation.Desc = transportation.Desc;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]

        public async Task< IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Transportation dbTransportation = await _context.transportations.FindAsync(id);
            if (dbTransportation == null) return NotFound();
            _context.transportations.Remove(dbTransportation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
