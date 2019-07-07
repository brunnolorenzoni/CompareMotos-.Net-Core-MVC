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
    public class TypeMotorcyclesController : Controller
    {
        private readonly CompareMotosContext _context;

        public TypeMotorcyclesController(CompareMotosContext context)
        {
            _context = context;
        }

        // GET: TypeMotorcycles
        public async Task<IActionResult> Index()
        {
            return View(await _context.TypeMotorcycle.ToListAsync());
        }

        // GET: TypeMotorcycles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeMotorcycle = await _context.TypeMotorcycle
                .FirstOrDefaultAsync(m => m.TypeMotorcycleId == id);
            if (typeMotorcycle == null)
            {
                return NotFound();
            }

            return View(typeMotorcycle);
        }

        // GET: TypeMotorcycles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TypeMotorcycles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TypeMotorcycleId,Name")] TypeMotorcycle typeMotorcycle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typeMotorcycle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeMotorcycle);
        }

        // GET: TypeMotorcycles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeMotorcycle = await _context.TypeMotorcycle.FindAsync(id);
            if (typeMotorcycle == null)
            {
                return NotFound();
            }
            return View(typeMotorcycle);
        }

        // POST: TypeMotorcycles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TypeMotorcycleId,Name")] TypeMotorcycle typeMotorcycle)
        {
            if (id != typeMotorcycle.TypeMotorcycleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeMotorcycle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeMotorcycleExists(typeMotorcycle.TypeMotorcycleId))
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
            return View(typeMotorcycle);
        }

        // GET: TypeMotorcycles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeMotorcycle = await _context.TypeMotorcycle
                .FirstOrDefaultAsync(m => m.TypeMotorcycleId == id);
            if (typeMotorcycle == null)
            {
                return NotFound();
            }

            return View(typeMotorcycle);
        }

        // POST: TypeMotorcycles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typeMotorcycle = await _context.TypeMotorcycle.FindAsync(id);
            _context.TypeMotorcycle.Remove(typeMotorcycle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypeMotorcycleExists(int id)
        {
            return _context.TypeMotorcycle.Any(e => e.TypeMotorcycleId == id);
        }
    }
}
