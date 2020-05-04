using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Waresoft;

namespace Waresoft.Controllers
{
    public class SoftwareController : Controller
    {
        private readonly WaresoftContext _context;

        public SoftwareController(WaresoftContext context)
        {
            _context = context;
        }

        // GET: Software
        public async Task<IActionResult> Index(int devId)
        {
            var waresoftContext = _context.Software.Include(s => s.Developer);
            return View(await waresoftContext.ToListAsync());
        }

        // GET: Software/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var software = await _context.Software
                .Include(s => s.Developer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (software == null)
            {
                return NotFound();
            }

            return View(software);
        }

        // GET: Software/Create
        public IActionResult Create()
        {
            ViewBag.DeveloperList = new SelectList(_context.Developers, "Id", "Name");
            return View();
        }

        // POST: Software/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Software software)
        {
            if (ModelState.IsValid)
            {
                _context.Add(software);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.DeveloperList = new SelectList(_context.Developers, "Id", "Name", software.DeveloperId);
            return View(software);
        }

        // GET: Software/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var software = await _context.Software.FindAsync(id);
            ViewBag.DeveloperList = new SelectList(_context.Developers, "Id", "Name", software.DeveloperId);
            return View(software);
        }

        // POST: Software/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Software software)
        {
            if (ModelState.IsValid)
            {
                _context.Update(software);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.DeveloperList = new SelectList(_context.Developers, "Id", "Name", software.DeveloperId);
            return View(software);
        }

        // POST: Software/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var software = await _context.Software.FindAsync(id);
            _context.Software.Remove(software);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
