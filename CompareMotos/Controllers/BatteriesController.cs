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
    public class BatteriesController : Controller
    {
        private readonly CompareMotosContext _context;

        public BatteriesController(CompareMotosContext context)
        {
            _context = context;
        }

        // GET: Batteries
        public async Task<IActionResult> Index()
        {
            return View(await _context.Battery.ToListAsync());
        }

        // GET: Batteries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var battery = await _context.Battery
                .FirstOrDefaultAsync(m => m.BatteryId == id);
            if (battery == null)
            {
                return NotFound();
            }

            return View(battery);
        }

        // GET: Batteries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Batteries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BatteryId,Name")] Battery battery)
        {
            if (ModelState.IsValid)
            {
                _context.Add(battery);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(battery);
        }

        // GET: Batteries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var battery = await _context.Battery.FindAsync(id);
            if (battery == null)
            {
                return NotFound();
            }
            return View(battery);
        }

        // POST: Batteries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BatteryId,Name")] Battery battery)
        {
            if (id != battery.BatteryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(battery);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BatteryExists(battery.BatteryId))
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
            return View(battery);
        }

        // GET: Batteries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var battery = await _context.Battery
                .FirstOrDefaultAsync(m => m.BatteryId == id);
            if (battery == null)
            {
                return NotFound();
            }

            return View(battery);
        }

        // POST: Batteries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var battery = await _context.Battery.FindAsync(id);
            _context.Battery.Remove(battery);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BatteryExists(int id)
        {
            return _context.Battery.Any(e => e.BatteryId == id);
        }
    }
}
