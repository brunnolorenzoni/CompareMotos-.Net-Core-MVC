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
    public class EnginesController : Controller
    {
        private readonly CompareMotosContext _context;

        public EnginesController(CompareMotosContext context)
        {
            _context = context;
        }

        // GET: Engines
        public async Task<IActionResult> Index()
        {
            var compareMotosContext = _context.Engine.Include(e => e.Cooling).Include(e => e.Cylinder).Include(e => e.Displacement).Include(e => e.TimeCycle);
            return View(await compareMotosContext.ToListAsync());
        }

        // GET: Engines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var engine = await _context.Engine
                .Include(e => e.Cooling)
                .Include(e => e.Cylinder)
                .Include(e => e.Displacement)
                .Include(e => e.TimeCycle)
                .FirstOrDefaultAsync(m => m.EngineId == id);
            if (engine == null)
            {
                return NotFound();
            }

            return View(engine);
        }

        // GET: Engines/Create
        public IActionResult Create()
        {
            ViewData["CoolingId"] = new SelectList(_context.Cooling, "CoolingId", "Name");
            ViewData["CylinderId"] = new SelectList(_context.Cylinder, "CylinderId", "Name");
            ViewData["DisplacementId"] = new SelectList(_context.Displacement, "DisplacementId", "Name");
            ViewData["TimeCycleId"] = new SelectList(_context.TimeCycle, "TimeCycleId", "Name");
            return View();
        }

        // POST: Engines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EngineId,TimeCycleId,CylinderId,DisplacementId,CoolingId")] Engine engine)
        {
            if (ModelState.IsValid)
            {
                _context.Add(engine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CoolingId"] = new SelectList(_context.Cooling, "CoolingId", "Name", engine.CoolingId);
            ViewData["CylinderId"] = new SelectList(_context.Cylinder, "CylinderId", "CylinderId", engine.CylinderId);
            ViewData["DisplacementId"] = new SelectList(_context.Displacement, "DisplacementId", "DisplacementId", engine.DisplacementId);
            ViewData["TimeCycleId"] = new SelectList(_context.TimeCycle, "TimeCycleId", "TimeCycleId", engine.TimeCycleId);
            return View(engine);
        }

        // GET: Engines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var engine = await _context.Engine.FindAsync(id);
            if (engine == null)
            {
                return NotFound();
            }
            ViewData["CoolingId"] = new SelectList(_context.Cooling, "CoolingId", "Name", engine.CoolingId);
            ViewData["CylinderId"] = new SelectList(_context.Cylinder, "CylinderId", "CylinderId", engine.CylinderId);
            ViewData["DisplacementId"] = new SelectList(_context.Displacement, "DisplacementId", "DisplacementId", engine.DisplacementId);
            ViewData["TimeCycleId"] = new SelectList(_context.TimeCycle, "TimeCycleId", "TimeCycleId", engine.TimeCycleId);
            return View(engine);
        }

        // POST: Engines/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EngineId,TimeCycleId,CylinderId,DisplacementId,CoolingId")] Engine engine)
        {
            if (id != engine.EngineId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(engine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EngineExists(engine.EngineId))
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
            ViewData["CoolingId"] = new SelectList(_context.Cooling, "CoolingId", "Name", engine.CoolingId);
            ViewData["CylinderId"] = new SelectList(_context.Cylinder, "CylinderId", "CylinderId", engine.CylinderId);
            ViewData["DisplacementId"] = new SelectList(_context.Displacement, "DisplacementId", "DisplacementId", engine.DisplacementId);
            ViewData["TimeCycleId"] = new SelectList(_context.TimeCycle, "TimeCycleId", "TimeCycleId", engine.TimeCycleId);
            return View(engine);
        }

        // GET: Engines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var engine = await _context.Engine
                .Include(e => e.Cooling)
                .Include(e => e.Cylinder)
                .Include(e => e.Displacement)
                .Include(e => e.TimeCycle)
                .FirstOrDefaultAsync(m => m.EngineId == id);
            if (engine == null)
            {
                return NotFound();
            }

            return View(engine);
        }

        // POST: Engines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var engine = await _context.Engine.FindAsync(id);
            _context.Engine.Remove(engine);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EngineExists(int id)
        {
            return _context.Engine.Any(e => e.EngineId == id);
        }
    }
}
