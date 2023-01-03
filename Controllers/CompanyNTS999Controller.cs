using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Test6_FinalTest.Data;
using Test6_FinalTest.Models;

namespace Test6_FinalTest.Controllers
{
    public class CompanyNTS999Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public CompanyNTS999Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CompanyNTS999
        public async Task<IActionResult> Index()
        {
              return _context.CompanyNTS999 != null ? 
                          View(await _context.CompanyNTS999.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.CompanyNTS999'  is null.");
        }

        // GET: CompanyNTS999/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.CompanyNTS999 == null)
            {
                return NotFound();
            }

            var companyNTS999 = await _context.CompanyNTS999
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyNTS999 == null)
            {
                return NotFound();
            }

            return View(companyNTS999);
        }

        // GET: CompanyNTS999/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyNTS999/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName")] CompanyNTS999 companyNTS999)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyNTS999);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyNTS999);
        }

        // GET: CompanyNTS999/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.CompanyNTS999 == null)
            {
                return NotFound();
            }

            var companyNTS999 = await _context.CompanyNTS999.FindAsync(id);
            if (companyNTS999 == null)
            {
                return NotFound();
            }
            return View(companyNTS999);
        }

        // POST: CompanyNTS999/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyId,CompanyName")] CompanyNTS999 companyNTS999)
        {
            if (id != companyNTS999.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyNTS999);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyNTS999Exists(companyNTS999.CompanyId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(companyNTS999);
        }

        // GET: CompanyNTS999/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.CompanyNTS999 == null)
            {
                return NotFound();
            }

            var companyNTS999 = await _context.CompanyNTS999
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyNTS999 == null)
            {
                return NotFound();
            }

            return View(companyNTS999);
        }

        // POST: CompanyNTS999/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.CompanyNTS999 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CompanyNTS999'  is null.");
            }
            var companyNTS999 = await _context.CompanyNTS999.FindAsync(id);
            if (companyNTS999 != null)
            {
                _context.CompanyNTS999.Remove(companyNTS999);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyNTS999Exists(string id)
        {
          return (_context.CompanyNTS999?.Any(e => e.CompanyId == id)).GetValueOrDefault();
        }
    }
}
