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
    public class BackBrakesController : Controller
    {
        private readonly CompareMotosContext _context;

        public BackBrakesController(CompareMotosContext context)
        {
            _context = context;
        }

        // GET: BackBrakes
        public async Task<IActionResult> Index()
        {
            return View(await _context.BackBrake.ToListAsync());
        }

        // GET: BackBrakes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var backBrake = await _context.BackBrake
                .FirstOrDefaultAsync(m => m.BackBrakeeId == id);
            if (backBrake == null)
            {
                return NotFound();
            }

            return View(backBrake);
        }

        // GET: BackBrakes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BackBrakes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BackBrakeeId,Name")] BackBrake backBrake)
        {
            if (ModelState.IsValid)
            {
                _context.Add(backBrake);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(backBrake);
        }

        // GET: BackBrakes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var backBrake = await _context.BackBrake.FindAsync(id);
            if (backBrake == null)
            {
                return NotFound();
            }
            return View(backBrake);
        }

        // POST: BackBrakes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BackBrakeeId,Name")] BackBrake backBrake)
        {
            if (id != backBrake.BackBrakeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(backBrake);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BackBrakeExists(backBrake.BackBrakeeId))
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
            return View(backBrake);
        }

        // GET: BackBrakes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var backBrake = await _context.BackBrake
                .FirstOrDefaultAsync(m => m.BackBrakeeId == id);
            if (backBrake == null)
            {
                return NotFound();
            }

            return View(backBrake);
        }

        // POST: BackBrakes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var backBrake = await _context.BackBrake.FindAsync(id);
            _context.BackBrake.Remove(backBrake);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BackBrakeExists(int id)
        {
            return _context.BackBrake.Any(e => e.BackBrakeeId == id);
        }
    }
}
