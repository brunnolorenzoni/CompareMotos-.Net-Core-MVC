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
    public class TypeTransmissionsController : Controller
    {
        private readonly CompareMotosContext _context;

        public TypeTransmissionsController(CompareMotosContext context)
        {
            _context = context;
        }

        // GET: TypeTransmissions
        public async Task<IActionResult> Index()
        {
            return View(await _context.TypeTransmission.ToListAsync());
        }

        // GET: TypeTransmissions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeTransmission = await _context.TypeTransmission
                .FirstOrDefaultAsync(m => m.TypeTransmissionId == id);
            if (typeTransmission == null)
            {
                return NotFound();
            }

            return View(typeTransmission);
        }

        // GET: TypeTransmissions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TypeTransmissions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TypeTransmissionId,Name")] TypeTransmission typeTransmission)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typeTransmission);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeTransmission);
        }

        // GET: TypeTransmissions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeTransmission = await _context.TypeTransmission.FindAsync(id);
            if (typeTransmission == null)
            {
                return NotFound();
            }
            return View(typeTransmission);
        }

        // POST: TypeTransmissions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TypeTransmissionId,Name")] TypeTransmission typeTransmission)
        {
            if (id != typeTransmission.TypeTransmissionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeTransmission);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeTransmissionExists(typeTransmission.TypeTransmissionId))
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
            return View(typeTransmission);
        }

        // GET: TypeTransmissions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeTransmission = await _context.TypeTransmission
                .FirstOrDefaultAsync(m => m.TypeTransmissionId == id);
            if (typeTransmission == null)
            {
                return NotFound();
            }

            return View(typeTransmission);
        }

        // POST: TypeTransmissions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typeTransmission = await _context.TypeTransmission.FindAsync(id);
            _context.TypeTransmission.Remove(typeTransmission);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypeTransmissionExists(int id)
        {
            return _context.TypeTransmission.Any(e => e.TypeTransmissionId == id);
        }
    }
}
