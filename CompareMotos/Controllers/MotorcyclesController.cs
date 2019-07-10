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
    public class MotorcyclesController : Controller
    {
        private readonly CompareMotosContext _context;

        public MotorcyclesController(CompareMotosContext context)
        {
            _context = context;
        }

        // GET: Motorcycles
        public async Task<IActionResult> Index()
        {
            var compareMotosContext = _context.Motorcycle.Include(m => m.Brake).Include(m => m.Brand).Include(m => m.Electric).Include(m => m.Engine).Include(m => m.Fuel).Include(m => m.ModelMotorcycle).Include(m => m.Transmission).Include(m => m.TypeMotorcycle);
            return View(await compareMotosContext.ToListAsync());
        }

        // GET: Motorcycles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motorcycle = await _context.Motorcycle
                .Include(m => m.Brake)
                .Include(m => m.Brand)
                .Include(m => m.Electric)
                .Include(m => m.Engine)
                .Include(m => m.Fuel)
                .Include(m => m.ModelMotorcycle)
                .Include(m => m.Transmission)
                .Include(m => m.TypeMotorcycle)
                .FirstOrDefaultAsync(m => m.MotorcycleId == id);
            if (motorcycle == null)
            {
                return NotFound();
            }

            return View(motorcycle);
        }

        // GET: Motorcycles/Create
        public IActionResult Create()
        {
            ViewData["BrakeId"] = new SelectList(_context.Brake, "BrakeId", "BrakeId");
            ViewData["BrandId"] = new SelectList(_context.Brand, "BrandId", "Name");
            ViewData["ElectricId"] = new SelectList(_context.Electric, "ElectricId", "ElectricId");
            ViewData["EngineId"] = new SelectList(_context.Engine, "EngineId", "EngineId");
            ViewData["FuelId"] = new SelectList(_context.Fuel, "FuelId", "FuelId");
            ViewData["ModelMotorcycleId"] = new SelectList(_context.ModelMotorcycle, "ModelMotorcycleId", "Name");
            ViewData["TransmissionId"] = new SelectList(_context.Transmission, "TransmissionId", "TransmissionId");
            ViewData["TypeMotorcycleId"] = new SelectList(_context.TypeMotorcycle, "TypeMotorcycleId", "Name");
            return View();
        }

        // POST: Motorcycles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MotorcycleId,Year,Price,Length,Width,Height,Weight,TypeMotorcycleId,BrandId,ModelMotorcycleId,EngineId,FuelId,ElectricId,BrakeId,TransmissionId")] Motorcycle motorcycle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(motorcycle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BrakeId"] = new SelectList(_context.Brake, "BrakeId", "BrakeId", motorcycle.BrakeId);
            ViewData["BrandId"] = new SelectList(_context.Brand, "BrandId", "Name", motorcycle.BrandId);
            ViewData["ElectricId"] = new SelectList(_context.Electric, "ElectricId", "ElectricId", motorcycle.ElectricId);
            ViewData["EngineId"] = new SelectList(_context.Engine, "EngineId", "EngineId", motorcycle.EngineId);
            ViewData["FuelId"] = new SelectList(_context.Fuel, "FuelId", "FuelId", motorcycle.FuelId);
            ViewData["ModelMotorcycleId"] = new SelectList(_context.ModelMotorcycle, "ModelMotorcycleId", "Name", motorcycle.ModelMotorcycleId);
            ViewData["TransmissionId"] = new SelectList(_context.Transmission, "TransmissionId", "TransmissionId", motorcycle.TransmissionId);
            ViewData["TypeMotorcycleId"] = new SelectList(_context.TypeMotorcycle, "TypeMotorcycleId", "Name", motorcycle.TypeMotorcycleId);
            return View(motorcycle);
        }

        // GET: Motorcycles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motorcycle = await _context.Motorcycle.FindAsync(id);
            if (motorcycle == null)
            {
                return NotFound();
            }
            ViewData["BrakeId"] = new SelectList(_context.Brake, "BrakeId", "BrakeId", motorcycle.BrakeId);
            ViewData["BrandId"] = new SelectList(_context.Brand, "BrandId", "Name", motorcycle.BrandId);
            ViewData["ElectricId"] = new SelectList(_context.Electric, "ElectricId", "ElectricId", motorcycle.ElectricId);
            ViewData["EngineId"] = new SelectList(_context.Engine, "EngineId", "EngineId", motorcycle.EngineId);
            ViewData["FuelId"] = new SelectList(_context.Fuel, "FuelId", "FuelId", motorcycle.FuelId);
            ViewData["ModelMotorcycleId"] = new SelectList(_context.ModelMotorcycle, "ModelMotorcycleId", "Name", motorcycle.ModelMotorcycleId);
            ViewData["TransmissionId"] = new SelectList(_context.Transmission, "TransmissionId", "TransmissionId", motorcycle.TransmissionId);
            ViewData["TypeMotorcycleId"] = new SelectList(_context.TypeMotorcycle, "TypeMotorcycleId", "Name", motorcycle.TypeMotorcycleId);
            return View(motorcycle);
        }

        // POST: Motorcycles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MotorcycleId,Year,Price,Length,Width,Height,Weight,TypeMotorcycleId,BrandId,ModelMotorcycleId,EngineId,FuelId,ElectricId,BrakeId,TransmissionId")] Motorcycle motorcycle)
        {
            if (id != motorcycle.MotorcycleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(motorcycle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MotorcycleExists(motorcycle.MotorcycleId))
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
            ViewData["BrakeId"] = new SelectList(_context.Brake, "BrakeId", "BrakeId", motorcycle.BrakeId);
            ViewData["BrandId"] = new SelectList(_context.Brand, "BrandId", "Name", motorcycle.BrandId);
            ViewData["ElectricId"] = new SelectList(_context.Electric, "ElectricId", "ElectricId", motorcycle.ElectricId);
            ViewData["EngineId"] = new SelectList(_context.Engine, "EngineId", "EngineId", motorcycle.EngineId);
            ViewData["FuelId"] = new SelectList(_context.Fuel, "FuelId", "FuelId", motorcycle.FuelId);
            ViewData["ModelMotorcycleId"] = new SelectList(_context.ModelMotorcycle, "ModelMotorcycleId", "Name", motorcycle.ModelMotorcycleId);
            ViewData["TransmissionId"] = new SelectList(_context.Transmission, "TransmissionId", "TransmissionId", motorcycle.TransmissionId);
            ViewData["TypeMotorcycleId"] = new SelectList(_context.TypeMotorcycle, "TypeMotorcycleId", "Name", motorcycle.TypeMotorcycleId);
            return View(motorcycle);
        }

        // GET: Motorcycles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motorcycle = await _context.Motorcycle
                .Include(m => m.Brake)
                .Include(m => m.Brand)
                .Include(m => m.Electric)
                .Include(m => m.Engine)
                .Include(m => m.Fuel)
                .Include(m => m.ModelMotorcycle)
                .Include(m => m.Transmission)
                .Include(m => m.TypeMotorcycle)
                .FirstOrDefaultAsync(m => m.MotorcycleId == id);
            if (motorcycle == null)
            {
                return NotFound();
            }

            return View(motorcycle);
        }

        // POST: Motorcycles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var motorcycle = await _context.Motorcycle.FindAsync(id);
            _context.Motorcycle.Remove(motorcycle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MotorcycleExists(int id)
        {
            return _context.Motorcycle.Any(e => e.MotorcycleId == id);
        }
    }
}
