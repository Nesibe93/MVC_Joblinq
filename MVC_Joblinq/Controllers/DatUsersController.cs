using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Joblinq.Models;

namespace MVC_Joblinq.Controllers
{
    public class DatUsersController : Controller
    {
        private readonly DBJoblinqContext _context;

        public DatUsersController(DBJoblinqContext context)
        {
            _context = context;
        }

        // GET: DatUsers
        public async Task<IActionResult> Index()
        {
              return _context.DatUsers != null ? 
                          View(await _context.DatUsers.ToListAsync()) :
                          Problem("Entity set 'DBJoblinqContext.DatUsers'  is null.");
        }

        // GET: DatUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DatUsers == null)
            {
                return NotFound();
            }

            var datUser = await _context.DatUsers
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (datUser == null)
            {
                return NotFound();
            }

            return View(datUser);
        }

        // GET: DatUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DatUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,UserEmail,UserPassword,UserAccountType")] DatUser datUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(datUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(datUser);
        }

        // GET: DatUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DatUsers == null)
            {
                return NotFound();
            }

            var datUser = await _context.DatUsers.FindAsync(id);
            if (datUser == null)
            {
                return NotFound();
            }
            return View(datUser);
        }

        // POST: DatUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,UserEmail,UserPassword,UserAccountType")] DatUser datUser)
        {
            if (id != datUser.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(datUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DatUserExists(datUser.UserId))
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
            return View(datUser);
        }

        // GET: DatUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DatUsers == null)
            {
                return NotFound();
            }

            var datUser = await _context.DatUsers
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (datUser == null)
            {
                return NotFound();
            }

            return View(datUser);
        }

        // POST: DatUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DatUsers == null)
            {
                return Problem("Entity set 'DBJoblinqContext.DatUsers'  is null.");
            }
            var datUser = await _context.DatUsers.FindAsync(id);
            if (datUser != null)
            {
                _context.DatUsers.Remove(datUser);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DatUserExists(int id)
        {
          return (_context.DatUsers?.Any(e => e.UserId == id)).GetValueOrDefault();
        }
    }
}
