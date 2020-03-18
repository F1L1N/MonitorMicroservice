using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MonitorMicroservice.Models;
using MonitorMicroservice.Models.Analyzes;

namespace MonitorMicroservice.Controllers
{
    public class AnalyseController : Controller
    {
        private ApplicationContext db;
        public AnalyseController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            var model = new Analyse
            {
                AnalyseBloodBio = await db.AnalyzesBloodBio.ToListAsync(),
                AnalyseBloodClynic = await db.AnalyzesBloodClynic.ToListAsync(),
                AnalyseBloodGroup = await db.AnalyzesBloodGroup.ToListAsync(),
                AnalyseCoprogram = await db.AnalyzesCoprogram.ToListAsync(),
                AnalyseIFA = await db.AnalyzesIFA.ToListAsync(),
                AnalyseUrine = await db.AnalyzesUrine.ToListAsync()
            };

            return View(model);
        }

        public async Task<IActionResult> ShowBloodBio()
        {
            return View(await db.AnalyzesBloodBio.ToListAsync());
        }

        public async Task<IActionResult> ShowBloodClynic()
        {
            return View(await db.AnalyzesBloodClynic.ToListAsync());
        }

        public async Task<IActionResult> ShowBloodGroup()
        {
            return View(await db.AnalyzesBloodGroup.ToListAsync());
        }

        public async Task<IActionResult> ShowCoprogram()
        {
            return View(await db.AnalyzesCoprogram.ToListAsync());
        }

        public async Task<IActionResult> ShowIfa()
        {
            return View(await db.AnalyzesIFA.ToListAsync());
        }

        public async Task<IActionResult> ShowUrine()
        {
            return View(await db.AnalyzesUrine.ToListAsync());
        }

        /*public IActionResult Create()
        {
            return View();
        }*/

        public IActionResult CreateBloodBio()
        {
            return View();
        }

        public IActionResult CreateBloodClynic()
        {
            return View();
        }
        public IActionResult CreateBloodGroup()
        {
            return View();
        }
        public IActionResult CreateCoprogram()
        {
            return View();
        }
        public IActionResult CreateIFA()
        {
            return View();
        }
        public IActionResult CreateUrine()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBloodBio(AnalyseBloodBio analyse)
        {
            db.AnalyzesBloodBio.Add(analyse);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateBloodClynic(AnalyseBloodClynic analyse)
        {
            db.AnalyzesBloodClynic.Add(analyse);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateBloodGroup(AnalyseBloodGroup analyse)
        {
            db.AnalyzesBloodGroup.Add(analyse);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateCoprogram(AnalyseCoprogram analyse)
        {
            db.AnalyzesCoprogram.Add(analyse);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateIFA(AnalyseIFA analyse)
        {
            db.AnalyzesIFA.Add(analyse);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateUrine(AnalyseUrine analyse)
        {
            db.AnalyzesUrine.Add(analyse);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(string type, int? id)
        {
            if (id != null)
            {
                switch (type)
                {
                    case "blood-bio":
                        AnalyseBloodBio bloodBio = await db.AnalyzesBloodBio.FirstOrDefaultAsync(p => p.Id == id);
                        if (bloodBio != null)
                            return View(bloodBio);
                        break;
                    case "blood-clynic":
                        AnalyseBloodClynic bloodClynic = await db.AnalyzesBloodClynic.FirstOrDefaultAsync(p => p.Id == id);
                        if (bloodClynic != null)
                            return View(bloodClynic);
                        break;
                    case "blood-group":
                        AnalyseBloodGroup bloodGroup = await db.AnalyzesBloodGroup.FirstOrDefaultAsync(p => p.Id == id);
                        if (bloodGroup != null)
                            return View(bloodGroup);
                        break;
                    case "coprogram":
                        AnalyseCoprogram coprogram = await db.AnalyzesCoprogram.FirstOrDefaultAsync(p => p.Id == id);
                        if (coprogram != null)
                            return View(coprogram);
                        break;
                    case "ifa":
                        AnalyseIFA ifa = await db.AnalyzesIFA.FirstOrDefaultAsync(p => p.Id == id);
                        if (ifa != null)
                            return View(ifa);
                        break;
                    case "urine":
                        AnalyseUrine urine = await db.AnalyzesUrine.FirstOrDefaultAsync(p => p.Id == id);
                        if (urine != null)
                            return View(urine);
                        break;
                }
            }
            return NotFound();
        }

        public async Task<IActionResult> Edit(string type, int? id)
        {
            if (id != null)
            {
                switch (type)
                {
                    case "blood-bio":
                        AnalyseBloodBio bloodBio = await db.AnalyzesBloodBio.FirstOrDefaultAsync(p => p.Id == id);
                        if (bloodBio != null)
                            return View(bloodBio);
                        break;
                    case "blood-clynic":
                        AnalyseBloodClynic bloodClynic = await db.AnalyzesBloodClynic.FirstOrDefaultAsync(p => p.Id == id);
                        if (bloodClynic != null)
                            return View(bloodClynic);
                        break;
                    case "blood-group":
                        AnalyseBloodGroup bloodGroup = await db.AnalyzesBloodGroup.FirstOrDefaultAsync(p => p.Id == id);
                        if (bloodGroup != null)
                            return View(bloodGroup);
                        break;
                    case "coprogram":
                        AnalyseCoprogram coprogram = await db.AnalyzesCoprogram.FirstOrDefaultAsync(p => p.Id == id);
                        if (coprogram != null)
                            return View(coprogram);
                        break;
                    case "ifa":
                        AnalyseIFA ifa = await db.AnalyzesIFA.FirstOrDefaultAsync(p => p.Id == id);
                        if (ifa != null)
                            return View(ifa);
                        break;
                    case "urine":
                        AnalyseUrine urine = await db.AnalyzesUrine.FirstOrDefaultAsync(p => p.Id == id);
                        if (urine != null)
                            return View(urine);
                        break;
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AnalyseBloodBio analyseBloodBio)
        {
            db.AnalyzesBloodBio.Update(analyseBloodBio);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AnalyseBloodClynic analyseBloodClynic)
        {
            db.AnalyzesBloodClynic.Update(analyseBloodClynic);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(AnalyseBloodGroup analyseBloodGroup)
        {
            db.AnalyzesBloodGroup.Update(analyseBloodGroup);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(AnalyseCoprogram analyseCoprogram)
        {
            db.AnalyzesCoprogram.Update(analyseCoprogram);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(AnalyseIFA analyseIfa)
        {
            db.AnalyzesIFA.Update(analyseIfa);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(AnalyseUrine analyseUrine)
        {
            db.AnalyzesUrine.Update(analyseUrine);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(string type, int? id)
        {
            if (id != null)
            {
                switch (type)
                {
                    case "blood-bio":
                        AnalyseBloodBio bloodBio = new AnalyseBloodBio { Id = id.Value };
                        db.Entry(bloodBio).State = EntityState.Deleted;
                        break;
                    case "blood-clynic":
                        AnalyseBloodClynic bloodClynic = new AnalyseBloodClynic { Id = id.Value };
                        db.Entry(bloodClynic).State = EntityState.Deleted;
                        break;
                    case "blood-group":
                        AnalyseBloodGroup bloodGroup = new AnalyseBloodGroup { Id = id.Value };
                        db.Entry(bloodGroup).State = EntityState.Deleted;
                        break;
                    case "coprogram":
                        AnalyseCoprogram coprogram = new AnalyseCoprogram { Id = id.Value };
                        db.Entry(coprogram).State = EntityState.Deleted;
                        break;
                    case "ifa":
                        AnalyseIFA ifa = new AnalyseIFA { Id = id.Value };
                        db.Entry(ifa).State = EntityState.Deleted;
                        break;
                    case "urine":
                        AnalyseUrine urine = new AnalyseUrine { Id = id.Value };
                        db.Entry(urine).State = EntityState.Deleted;
                        break;
                }
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string type, int? id)
        {
            if (id != null)
            {

                switch (type)
                {
                    case "blood-bio":
                        AnalyseBloodBio bloodBio = await db.AnalyzesBloodBio.FirstOrDefaultAsync(p => p.Id == id);
                        if (bloodBio != null)
                            return View(bloodBio);
                        break;
                    case "blood-clynic":
                        AnalyseBloodClynic bloodClynic = await db.AnalyzesBloodClynic.FirstOrDefaultAsync(p => p.Id == id);
                        if (bloodClynic != null)
                            return View(bloodClynic);
                        break;
                    case "blood-group":
                        AnalyseBloodGroup bloodGroup = await db.AnalyzesBloodGroup.FirstOrDefaultAsync(p => p.Id == id);
                        if (bloodGroup != null)
                            return View(bloodGroup);
                        break;
                    case "coprogram":
                        AnalyseCoprogram coprogram = await db.AnalyzesCoprogram.FirstOrDefaultAsync(p => p.Id == id);
                        if (coprogram != null)
                            return View(coprogram);
                        break;
                    case "ifa":
                        AnalyseIFA ifa = await db.AnalyzesIFA.FirstOrDefaultAsync(p => p.Id == id);
                        if (ifa != null)
                            return View(ifa);
                        break;
                    case "urine":
                        AnalyseUrine urine = await db.AnalyzesUrine.FirstOrDefaultAsync(p => p.Id == id);
                        if (urine != null)
                            return View(urine);
                        break;
                }
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
