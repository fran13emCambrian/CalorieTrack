using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CalorieAppTrack.Data;
using CalorieAppTrack.Models;

namespace CalorieAppTrack.Controllers
{
    public class FoodEntryModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FoodEntryModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FoodEntryModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.FoodEntryModel.ToListAsync());
        }

        // GET: FoodEntryModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodEntryModel = await _context.FoodEntryModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (foodEntryModel == null)
            {
                return NotFound();
            }

            return View(foodEntryModel);
        }

        // GET: FoodEntryModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FoodEntryModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FoodName,Description,Calories,Servings,TotalCalories,TotalDayCalories")] FoodEntryModel foodEntryModel)
        {
            foodEntryModel.TotalCalories = foodEntryModel.Calories * foodEntryModel.Servings;
            foodEntryModel.TotalDayCalories += foodEntryModel.TotalCalories;
            if (ModelState.IsValid)
            {
                _context.Add(foodEntryModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(foodEntryModel);
        }

        // GET: FoodEntryModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodEntryModel = await _context.FoodEntryModel.FindAsync(id);
            if (foodEntryModel == null)
            {
                return NotFound();
            }
            return View(foodEntryModel);
        }

        // POST: FoodEntryModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FoodName,Description,Calories,Servings,TotalCalories,TotalDayCalories")] FoodEntryModel foodEntryModel)
        {
            if (id != foodEntryModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(foodEntryModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FoodEntryModelExists(foodEntryModel.Id))
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
            return View(foodEntryModel);
        }

        // GET: FoodEntryModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodEntryModel = await _context.FoodEntryModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (foodEntryModel == null)
            {
                return NotFound();
            }

            return View(foodEntryModel);
        }

        // POST: FoodEntryModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var foodEntryModel = await _context.FoodEntryModel.FindAsync(id);
            _context.FoodEntryModel.Remove(foodEntryModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FoodEntryModelExists(int id)
        {
            return _context.FoodEntryModel.Any(e => e.Id == id);
        }
    }
}
