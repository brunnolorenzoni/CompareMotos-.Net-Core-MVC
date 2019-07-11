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
    public class BrakesController : Controller
    {
        private readonly CompareMotosContext _context;

        public BrakesController(CompareMotosContext context)
        {
            _context = context;
        }

        // GET: Brakes
        public async Task<IActionResult> Index()
        {
            var compareMotosContext = _context.Brake.Include(b => b.BackBrake).Include(b => b.FrontBrake);
            return View(await compareMotosContext.ToListAsync());
        }

        // GET: Brakes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brake = await _context.Brake
                .Include(b => b.BackBrake)
                .Include(b => b.FrontBrake)
                .FirstOrDefaultAsync(m => m.BrakeId == id);
            if (brake == null)
            {
                return NotFound();
            }

            return View(brake);
        }

        // GET: Brakes/Create
        public IActionResult Create()
        {
            ViewData["BackBrakeId"] = new SelectList(_context.BackBrake, "BackBrakeeId", "Name");
            ViewData["FrontBrakeId"] = new SelectList(_context.FrontBrake, "FrontBrakeId", "Name");
            return View();
        }

        // POST: Brakes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BrakeId,FrontBrakeId,BackBrakeId")] Brake brake)
        {
            if (ModelState.IsValid)
            {
                _context.Add(brake);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BackBrakeId"] = new SelectList(_context.BackBrake, "BackBrakeeId", "Name", brake.BackBrakeId);
            ViewData["FrontBrakeId"] = new SelectList(_context.FrontBrake, "FrontBrakeId", "Name", brake.FrontBrakeId);
            return View(brake);
        }

        // GET: Brakes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brake = await _context.Brake.FindAsync(id);
            if (brake == null)
            {
                return NotFound();
            }
            ViewData["BackBrakeId"] = new SelectList(_context.BackBrake, "BackBrakeeId", "Name", brake.BackBrakeId);
            ViewData["FrontBrakeId"] = new SelectList(_context.FrontBrake, "FrontBrakeId", "Name", brake.FrontBrakeId);
            return View(brake);
        }

        // POST: Brakes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BrakeId,FrontBrakeId,BackBrakeId")] Brake brake)
        {
            if (id != brake.BrakeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(brake);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BrakeExists(brake.BrakeId))
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
            ViewData["BackBrakeId"] = new SelectList(_context.BackBrake, "BackBrakeeId", "Name", brake.BackBrakeId);
            ViewData["FrontBrakeId"] = new SelectList(_context.FrontBrake, "FrontBrakeId", "Name", brake.FrontBrakeId);
            return View(brake);
        }

        // GET: Brakes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brake = await _context.Brake
                .Include(b => b.BackBrake)
                .Include(b => b.FrontBrake)
                .FirstOrDefaultAsync(m => m.BrakeId == id);
            if (brake == null)
            {
                return NotFound();
            }

            return View(brake);
        }

        // POST: Brakes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var brake = await _context.Brake.FindAsync(id);
            _context.Brake.Remove(brake);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BrakeExists(int id)
        {
            return _context.Brake.Any(e => e.BrakeId == id);
        }
    }
}
