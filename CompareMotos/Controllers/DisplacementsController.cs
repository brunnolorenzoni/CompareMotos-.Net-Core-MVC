using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CompareMotos.Models;

namespace CompareMotos.Controllers
{
    public class DisplacementsController : Controller
    {
        private readonly CompareMotosContext _context;

        public DisplacementsController(CompareMotosContext context)
        {
            _context = context;
        }

        // GET: Displacements
        public async Task<IActionResult> Index()
        {
            return View(await _context.Displacement.ToListAsync());
        }

        // GET: Displacements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var displacement = await _context.Displacement
                .FirstOrDefaultAsync(m => m.DisplacementId == id);
            if (displacement == null)
            {
                return NotFound();
            }

            return View(displacement);
        }

        // GET: Displacements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Displacements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DisplacementId,Name")] Displacement displacement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(displacement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(displacement);
        }

        // GET: Displacements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var displacement = await _context.Displacement.FindAsync(id);
            if (displacement == null)
            {
                return NotFound();
            }
            return View(displacement);
        }

        // POST: Displacements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DisplacementId,Name")] Displacement displacement)
        {
            if (id != displacement.DisplacementId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(displacement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DisplacementExists(displacement.DisplacementId))
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
            return View(displacement);
        }

        // GET: Displacements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var displacement = await _context.Displacement
                .FirstOrDefaultAsync(m => m.DisplacementId == id);
            if (displacement == null)
            {
                return NotFound();
            }

            return View(displacement);
        }

        // POST: Displacements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var displacement = await _context.Displacement.FindAsync(id);
            _context.Displacement.Remove(displacement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DisplacementExists(int id)
        {
            return _context.Displacement.Any(e => e.DisplacementId == id);
        }
    }
}
