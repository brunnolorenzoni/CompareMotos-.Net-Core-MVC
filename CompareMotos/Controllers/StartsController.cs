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
    public class StartsController : Controller
    {
        private readonly CompareMotosContext _context;

        public StartsController(CompareMotosContext context)
        {
            _context = context;
        }

        // GET: Starts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Start.ToListAsync());
        }

        // GET: Starts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var start = await _context.Start
                .FirstOrDefaultAsync(m => m.StartId == id);
            if (start == null)
            {
                return NotFound();
            }

            return View(start);
        }

        // GET: Starts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Starts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StartId,Name")] Start start)
        {
            if (ModelState.IsValid)
            {
                _context.Add(start);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(start);
        }

        // GET: Starts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var start = await _context.Start.FindAsync(id);
            if (start == null)
            {
                return NotFound();
            }
            return View(start);
        }

        // POST: Starts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StartId,Name")] Start start)
        {
            if (id != start.StartId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(start);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StartExists(start.StartId))
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
            return View(start);
        }

        // GET: Starts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var start = await _context.Start
                .FirstOrDefaultAsync(m => m.StartId == id);
            if (start == null)
            {
                return NotFound();
            }

            return View(start);
        }

        // POST: Starts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var start = await _context.Start.FindAsync(id);
            _context.Start.Remove(start);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StartExists(int id)
        {
            return _context.Start.Any(e => e.StartId == id);
        }
    }
}
