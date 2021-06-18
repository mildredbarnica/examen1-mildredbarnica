using examenEmpleados.Data;
using examenEmpleados.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examenEmpleados.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext db;

        public EmployeesController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Index(string search)
        {
            if (search == null)
            {
                return View(await db.Employees.ToListAsync());
            }

            return View(await db.Employees.
                Where(e => e.EmployeeNombres.Contains(search))
                .ToListAsync());

        }

        public IActionResult Create()
        {
            return View();
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empl = await db.Employees.FirstOrDefaultAsync(e => e.EmployeeId == id);

            if (empl == null)
            {
                return NotFound();
            }

            return View(empl);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Add(employee);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(employee);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empl = await db.Employees.FindAsync(id);

            if (empl == null)
            {
                return NotFound();
            }

            return View(empl);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(employee);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }

            return View(employee);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empl = await db.Employees.FirstOrDefaultAsync(e => e.EmployeeId == id);

            if (empl == null)
            {
                return NotFound();
            }

            return View(empl);

        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {

            var empl = await db.Employees.FindAsync(id);
            db.Employees.Remove(empl);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        }
}
