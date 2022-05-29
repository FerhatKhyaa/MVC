using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdonetCoreMVC1.Entities;
using AdonetCoreMVC1.Models;

namespace AdonetCoreMVC1.Controllers
{
    public class MusteriController : Controller
    {
        private readonly MusteriVtContext _context;

        public MusteriController(MusteriVtContext context)
        {
            _context = context;
        }

        // GET: Musteri
        public async Task<IActionResult> Index()
        {
              return _context.Musteris != null ? 
                          View(await _context.Musteris.ToListAsync()) :
                          Problem("Entity set 'MusteriVtContext.Musteris'  is null.");
        }

        // GET: Musteri/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Musteris == null)
            {
                return NotFound();
            }

            var musteri = await _context.Musteris
                .FirstOrDefaultAsync(m => m.Id == id);
            if (musteri == null)
            {
                return NotFound();
            }

            return View(musteri);
        }

        // GET: Musteri/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Musteri/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Adi,Soyadi,Tel,SirketAdi")] Musteri musteri)
        {
            if (ModelState.IsValid)
            {
                _context.Add(musteri);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(musteri);
        }

        // GET: Musteri/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Musteris == null)
            {
                return NotFound();
            }

            var musteri = await _context.Musteris.FindAsync(id);
            if (musteri == null)
            {
                return NotFound();
            }
            return View(musteri);
        }

        // POST: Musteri/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Adi,Soyadi,Tel,SirketAdi")] Musteri musteri)
        {
            if (id != musteri.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(musteri);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MusteriExists(musteri.Id))
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
            return View(musteri);
        }

        // GET: Musteri/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Musteris == null)
            {
                return NotFound();
            }

            var musteri = await _context.Musteris
                .FirstOrDefaultAsync(m => m.Id == id);
            if (musteri == null)
            {
                return NotFound();
            }

            return View(musteri);
        }

        // POST: Musteri/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Musteris == null)
            {
                return Problem("Entity set 'MusteriVtContext.Musteris'  is null.");
            }
            var musteri = await _context.Musteris.FindAsync(id);
            if (musteri != null)
            {
                _context.Musteris.Remove(musteri);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MusteriExists(int id)
        {
          return (_context.Musteris?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
