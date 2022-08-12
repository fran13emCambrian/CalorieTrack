using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CalorieAppTracker.Data;
using CalorieAppTracker.Models;

namespace CalorieAppTracker.Controllers
{
    public class WeightCalculatorsController : Controller
    {
        private readonly CalorieAppTrackerContext _context;

        public WeightCalculatorsController(CalorieAppTrackerContext context)
        {
            _context = context;
        }

        // GET: WeightCalculators
        public async Task<IActionResult> Index()
        {
            return View(await _context.WeightCalculator.ToListAsync());
        }

        // GET: WeightCalculators/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weightCalculator = await _context.WeightCalculator
                .FirstOrDefaultAsync(m => m.Id == id);
             if (weightCalculator == null)
            {
                 return NotFound();
             }
            weightCalculator.IdealWeight = 0.75 * weightCalculator.Height - 62.5;
            return View(weightCalculator);
        }

        // GET: WeightCalculators/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WeightCalculators/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Height")] WeightCalculator weightCalculator)
        {
            if (ModelState.IsValid)
            {
                _context.Add(weightCalculator);
             await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(weightCalculator);
        }

        // GET: WeightCalculators/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weightCalculator = await _context.WeightCalculator.FindAsync(id);
            if (weightCalculator == null)
            {
                return NotFound();
            }
            return View(weightCalculator);
        }

        // POST: WeightCalculators/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Height")] WeightCalculator weightCalculator)
        {
            if (id != weightCalculator.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(weightCalculator);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WeightCalculatorExists(weightCalculator.Id))
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
            return View(weightCalculator);
        }

        // GET: WeightCalculators/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weightCalculator = await _context.WeightCalculator
                .FirstOrDefaultAsync(m => m.Id == id);
            if (weightCalculator == null)
            {
                return NotFound();
            }

            return View(weightCalculator);
        }

        // POST: WeightCalculators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var weightCalculator = await _context.WeightCalculator.FindAsync(id);
            _context.WeightCalculator.Remove(weightCalculator);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WeightCalculatorExists(int id)
        {
            return _context.WeightCalculator.Any(e => e.Id == id);
        }
    }
}
