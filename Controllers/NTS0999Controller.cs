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
    public class NTS0999Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public NTS0999Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NTS0999
        public async Task<IActionResult> Index()
        {
              return _context.NTS0999 != null ? 
                          View(await _context.NTS0999.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.NTS0999'  is null.");
        }

        // GET: NTS0999/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.NTS0999 == null)
            {
                return NotFound();
            }

            var nTS0999 = await _context.NTS0999
                .FirstOrDefaultAsync(m => m.NTSId == id);
            if (nTS0999 == null)
            {
                return NotFound();
            }

            return View(nTS0999);
        }

        // GET: NTS0999/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NTS0999/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NTSId,NTSName,NTSGender")] NTS0999 nTS0999)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nTS0999);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nTS0999);
        }

        // GET: NTS0999/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NTS0999 == null)
            {
                return NotFound();
            }

            var nTS0999 = await _context.NTS0999.FindAsync(id);
            if (nTS0999 == null)
            {
                return NotFound();
            }
            return View(nTS0999);
        }

        // POST: NTS0999/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NTSId,NTSName,NTSGender")] NTS0999 nTS0999)
        {
            if (id != nTS0999.NTSId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nTS0999);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NTS0999Exists(nTS0999.NTSId))
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
            return View(nTS0999);
        }

        // GET: NTS0999/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.NTS0999 == null)
            {
                return NotFound();
            }

            var nTS0999 = await _context.NTS0999
                .FirstOrDefaultAsync(m => m.NTSId == id);
            if (nTS0999 == null)
            {
                return NotFound();
            }

            return View(nTS0999);
        }

        // POST: NTS0999/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.NTS0999 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.NTS0999'  is null.");
            }
            var nTS0999 = await _context.NTS0999.FindAsync(id);
            if (nTS0999 != null)
            {
                _context.NTS0999.Remove(nTS0999);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NTS0999Exists(string id)
        {
          return (_context.NTS0999?.Any(e => e.NTSId == id)).GetValueOrDefault();
        }
    }
}
