using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DataContext;
using WebApplication1.Entities;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private readonly DataAccessContext _context;

        public StudentController(DataAccessContext context)
        {
            _context = context;
        }

        // GET: student
        //    public async Task<IActionResult> Students()
        //    {
        //        return View(await _context.Users.ToListAsync());
        //    }

        //    // GET: student/Details/5
        //    public async Task<IActionResult> Details(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var users = await _context.Users
        //            .FirstOrDefaultAsync(m => m.Id == id);
        //        if (users == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(users);
        //    }

        //    // GET: student/Create
        //    public IActionResult Create()
        //    {
        //        return View();
        //    }

        //    // POST: student/Create
        //    // To protect from overposting attacks, enable the specific properties you want to bind to.
        //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Create([Bind("Id,First_Name,Last_Name,Number")] Users users)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            _context.Add(users);
        //            await _context.SaveChangesAsync();
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View(users);
        //    }

        //    // GET: student/Edit/5
        //    public async Task<IActionResult> Edit(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var users = await _context.Users.FindAsync(id);
        //        if (users == null)
        //        {
        //            return NotFound();
        //        }
        //        return View(users);
        //    }

        //    // POST: student/Edit/5
        //    // To protect from overposting attacks, enable the specific properties you want to bind to.
        //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Edit(int id, [Bind("Id,First_Name,Last_Name,Number")] Users users)
        //    {
        //        if (id != users.Id)
        //        {
        //            return NotFound();
        //        }

        //        if (ModelState.IsValid)
        //        {
        //            try
        //            {
        //                _context.Update(users);
        //                await _context.SaveChangesAsync();
        //            }
        //            catch (DbUpdateConcurrencyException)
        //            {
        //                if (!UsersExists(users.Id))
        //                {
        //                    return NotFound();
        //                }
        //                else
        //                {
        //                    throw;
        //                }
        //            }
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View(users);
        //    }

        //    // GET: student/Delete/5
        //    public async Task<IActionResult> Delete(int? id)
        //    {
        //        if (id == null)
        //        {
        //            return NotFound();
        //        }

        //        var users = await _context.Users
        //            .FirstOrDefaultAsync(m => m.Id == id);
        //        if (users == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(users);
        //    }

        //    // POST: student/Delete/5
        //    [HttpPost, ActionName("Delete")]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> DeleteConfirmed(int id)
        //    {
        //        var users = await _context.Users.FindAsync(id);
        //        if (users != null)
        //        {
        //            _context.Users.Remove(users);
        //        }

        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }

        //    private bool UsersExists(int id)
        //    {
        //        return _context.Users.Any(e => e.Id == id);
        //    }
    }
}
