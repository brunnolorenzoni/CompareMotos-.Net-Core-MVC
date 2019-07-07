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
    public class FrontBrakesController : Controller
    {
        private readonly CompareMotosContext _context;

        public FrontBrakesController(CompareMotosContext context)
        {
            _context = context;
        }

        // GET: FrontBrakes
        public async Task<IActionResult> Index()
        {
            return View(await _context.FrontBrake.ToListAsync());
        }

        // GET: FrontBrakes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frontBrake = await _context.FrontBrake
                .FirstOrDefaultAsync(m => m.FrontBrakeId == id);
            if (frontBrake == null)
            {
                return NotFound();
            }

            return View(frontBrake);
        }

        // GET: FrontBrakes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FrontBrakes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FrontBrakeId,Name")] FrontBrake frontBrake)
        {
            if (ModelState.IsValid)
            {
                _context.Add(frontBrake);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(frontBrake);
        }

        // GET: FrontBrakes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frontBrake = await _context.FrontBrake.FindAsync(id);
            if (frontBrake == null)
            {
                return NotFound();
            }
            return View(frontBrake);
        }

        // POST: FrontBrakes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FrontBrakeId,Name")] FrontBrake frontBrake)
        {
            if (id != frontBrake.FrontBrakeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(frontBrake);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FrontBrakeExists(frontBrake.FrontBrakeId))
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
            return View(frontBrake);
        }

        // GET: FrontBrakes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frontBrake = await _context.FrontBrake
                .FirstOrDefaultAsync(m => m.FrontBrakeId == id);
            if (frontBrake == null)
            {
                return NotFound();
            }

            return View(frontBrake);
        }

        // POST: FrontBrakes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var frontBrake = await _context.FrontBrake.FindAsync(id);
            _context.FrontBrake.Remove(frontBrake);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FrontBrakeExists(int id)
        {
            return _context.FrontBrake.Any(e => e.FrontBrakeId == id);
        }
    }
}
