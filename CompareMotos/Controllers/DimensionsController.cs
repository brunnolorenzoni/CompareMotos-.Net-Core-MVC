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
    public class DimensionsController : Controller
    {
        private readonly CompareMotosContext _context;

        public DimensionsController(CompareMotosContext context)
        {
            _context = context;
        }

        // GET: Dimensions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dimensions.ToListAsync());
        }

        // GET: Dimensions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimensions = await _context.Dimensions
                .FirstOrDefaultAsync(m => m.DimensionsId == id);
            if (dimensions == null)
            {
                return NotFound();
            }

            return View(dimensions);
        }

        // GET: Dimensions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dimensions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DimensionsId,Length,Width,Height,Weight")] Dimensions dimensions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dimensions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dimensions);
        }

        // GET: Dimensions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimensions = await _context.Dimensions.FindAsync(id);
            if (dimensions == null)
            {
                return NotFound();
            }
            return View(dimensions);
        }

        // POST: Dimensions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DimensionsId,Length,Width,Height,Weight")] Dimensions dimensions)
        {
            if (id != dimensions.DimensionsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dimensions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DimensionsExists(dimensions.DimensionsId))
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
            return View(dimensions);
        }

        // GET: Dimensions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimensions = await _context.Dimensions
                .FirstOrDefaultAsync(m => m.DimensionsId == id);
            if (dimensions == null)
            {
                return NotFound();
            }

            return View(dimensions);
        }

        // POST: Dimensions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dimensions = await _context.Dimensions.FindAsync(id);
            _context.Dimensions.Remove(dimensions);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DimensionsExists(int id)
        {
            return _context.Dimensions.Any(e => e.DimensionsId == id);
        }
    }
}
