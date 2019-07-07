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
    public class ModelMotorcyclesController : Controller
    {
        private readonly CompareMotosContext _context;

        public ModelMotorcyclesController(CompareMotosContext context)
        {
            _context = context;
        }

        // GET: ModelMotorcycles
        public async Task<IActionResult> Index()
        {
            return View(await _context.ModelMotorcycle.ToListAsync());
        }

        // GET: ModelMotorcycles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modelMotorcycle = await _context.ModelMotorcycle
                .FirstOrDefaultAsync(m => m.ModelMotorcycleId == id);
            if (modelMotorcycle == null)
            {
                return NotFound();
            }

            return View(modelMotorcycle);
        }

        // GET: ModelMotorcycles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ModelMotorcycles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ModelMotorcycleId,Name")] ModelMotorcycle modelMotorcycle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(modelMotorcycle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(modelMotorcycle);
        }

        // GET: ModelMotorcycles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modelMotorcycle = await _context.ModelMotorcycle.FindAsync(id);
            if (modelMotorcycle == null)
            {
                return NotFound();
            }
            return View(modelMotorcycle);
        }

        // POST: ModelMotorcycles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ModelMotorcycleId,Name")] ModelMotorcycle modelMotorcycle)
        {
            if (id != modelMotorcycle.ModelMotorcycleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(modelMotorcycle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModelMotorcycleExists(modelMotorcycle.ModelMotorcycleId))
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
            return View(modelMotorcycle);
        }

        // GET: ModelMotorcycles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modelMotorcycle = await _context.ModelMotorcycle
                .FirstOrDefaultAsync(m => m.ModelMotorcycleId == id);
            if (modelMotorcycle == null)
            {
                return NotFound();
            }

            return View(modelMotorcycle);
        }

        // POST: ModelMotorcycles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var modelMotorcycle = await _context.ModelMotorcycle.FindAsync(id);
            _context.ModelMotorcycle.Remove(modelMotorcycle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModelMotorcycleExists(int id)
        {
            return _context.ModelMotorcycle.Any(e => e.ModelMotorcycleId == id);
        }
    }
}
