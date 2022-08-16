using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CalorieAppTrack.Data;
using CalorieAppTrack.Models;
using static CalorieAppTrack.Data.ApplicationDbContext;

namespace CalorieAppTrack.Controllers
{
    public class CalorieCalculatorModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CalorieCalculatorModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CalorieCalculatorModels

        public async Task<IActionResult> Index()
        {
            return View(await _context.CalorieCalculatorModel.ToListAsync());
        }

        // GET: CalorieCalculatorModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calorieCalculatorModel = await _context.CalorieCalculatorModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calorieCalculatorModel == null)
            {
                return NotFound();
            }

            return View(calorieCalculatorModel);
        }

        // GET: CalorieCalculatorModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CalorieCalculatorModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Height,Age,ActualWeight,CalorieIntake")] CalorieCalculatorModel calorieCalculatorModel)
        {
        calorieCalculatorModel.CalorieIntake = 66 + (13.7 * calorieCalculatorModel.ActualWeight) + (5 * calorieCalculatorModel.Height) - (6.75 * calorieCalculatorModel.Age);
         if (ModelState.IsValid)
         {
          _context.Add(calorieCalculatorModel);
          await _context.SaveChangesAsync();
          return RedirectToAction(nameof(Index));
          }
            
            return View(calorieCalculatorModel);
        }

        // GET: CalorieCalculatorModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calorieCalculatorModel = await _context.CalorieCalculatorModel.FindAsync(id);
            if (calorieCalculatorModel == null)
            {
                return NotFound();
            }
            return View(calorieCalculatorModel);
        }

        // POST: CalorieCalculatorModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Height,Age,ActualWeight,CalorieIntake")] CalorieCalculatorModel calorieCalculatorModel)
        {
            if (id != calorieCalculatorModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(calorieCalculatorModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CalorieCalculatorModelExists(calorieCalculatorModel.Id))
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
            return View(calorieCalculatorModel);
        }

        // GET: CalorieCalculatorModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calorieCalculatorModel = await _context.CalorieCalculatorModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (calorieCalculatorModel == null)
            {
                return NotFound();
            }

            return View(calorieCalculatorModel);
        }

        // POST: CalorieCalculatorModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var calorieCalculatorModel = await _context.CalorieCalculatorModel.FindAsync(id);
            _context.CalorieCalculatorModel.Remove(calorieCalculatorModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CalorieCalculatorModelExists(int id)
        {
            return _context.CalorieCalculatorModel.Any(e => e.Id == id);
        }
    }
}
