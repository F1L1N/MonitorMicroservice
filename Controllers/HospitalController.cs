using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MonitorMicroservice.Models;

namespace MonitorMicroservice.Controllers
{
    public class HospitalController : Controller
    {
        private ApplicationContext db;
        public HospitalController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Hospitals.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Hospital hospital)
        {
            db.Hospitals.Add(hospital);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Hospital hospital = await db.Hospitals.FirstOrDefaultAsync(p => p.Id == id);
                if (hospital != null)
                    return View(hospital);
            }
            return NotFound();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Hospital hospital = await db.Hospitals.FirstOrDefaultAsync(p => p.Id == id);
                if (hospital != null)
                    return View(hospital);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Hospital hospital)
        {
            db.Hospitals.Update(hospital);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Hospital hospital = await db.Hospitals.FirstOrDefaultAsync(p => p.Id == id);
                if (hospital != null)
                    return View(hospital);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Hospital hospital = new Hospital { Id = id.Value };
                db.Entry(hospital).State = EntityState.Deleted;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
