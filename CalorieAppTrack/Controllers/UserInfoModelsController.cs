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
    public class UserInfoModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserInfoModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UserInfoModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserInfoModel.ToListAsync());
        }

        // GET: UserInfoModels/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userInfoModel = await _context.UserInfoModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userInfoModel == null)
            {
                return NotFound();
            }

            return View(userInfoModel);
        }

        // GET: UserInfoModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserInfoModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName")] UserInfoModel userInfoModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userInfoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userInfoModel);
        }

        // GET: UserInfoModels/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userInfoModel = await _context.UserInfoModel.FindAsync(id);
            if (userInfoModel == null)
            {
                return NotFound();
            }
            return View(userInfoModel);
        }

        // POST: UserInfoModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,FirstName,LastName")] UserInfoModel userInfoModel)
        {
            if (id != userInfoModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userInfoModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserInfoModelExists(userInfoModel.Id))
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
            return View(userInfoModel);
        }

        // GET: UserInfoModels/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userInfoModel = await _context.UserInfoModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userInfoModel == null)
            {
                return NotFound();
            }

            return View(userInfoModel);
        }

        // POST: UserInfoModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var userInfoModel = await _context.UserInfoModel.FindAsync(id);
            _context.UserInfoModel.Remove(userInfoModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserInfoModelExists(string id)
        {
            return _context.UserInfoModel.Any(e => e.Id == id);
        }
    }
}
