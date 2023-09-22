using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Apptower.Models;

namespace Apptower.Controllers
{
    public class VisitantesPorEspaciosController : Controller
    {
        private readonly ApptowerProvicionalContext _context;

        public VisitantesPorEspaciosController(ApptowerProvicionalContext context)
        {
            _context = context;
        }

        // GET: VisitantesPorEspacios
        public async Task<IActionResult> Index()
        {
            var apptowerProvicionalContext = _context.VisitantesPorEspacios.Include(v => v.IdEspacioNavigation).Include(v => v.IdVisitanteNavigation);
            return View(await apptowerProvicionalContext.ToListAsync());
        }

        // GET: VisitantesPorEspacios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.VisitantesPorEspacios == null)
            {
                return NotFound();
            }

            var visitantesPorEspacio = await _context.VisitantesPorEspacios
                .Include(v => v.IdEspacioNavigation)
                .Include(v => v.IdVisitanteNavigation)
                .FirstOrDefaultAsync(m => m.IdVisitantePorEspacio == id);
            if (visitantesPorEspacio == null)
            {
                return NotFound();
            }

            return View(visitantesPorEspacio);
        }

        // GET: VisitantesPorEspacios/Create
        public IActionResult Create()
        {
            ViewData["IdEspacio"] = new SelectList(_context.Espacios, "IdEspacio", "NombreEspacio");
            ViewData["IdVisitante"] = new SelectList(_context.Visitantes, "IdVisitante", "NombreVisitante");
            return View();
        }

        // POST: VisitantesPorEspacios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVisitantePorEspacio,IdEspacio,IdVisitante")] VisitantesPorEspacio visitantesPorEspacio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(visitantesPorEspacio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Espacios"); // Redirigir a la acción Index del controlador Espacios
            }
            ViewData["IdEspacio"] = new SelectList(_context.Espacios, "IdEspacio", "NombreEspacio", visitantesPorEspacio.IdEspacio);
            ViewData["IdVisitante"] = new SelectList(_context.Visitantes, "IdVisitante", "NombreVisitante", visitantesPorEspacio.IdVisitante);
            return View(visitantesPorEspacio);
        }

        // GET: VisitantesPorEspacios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.VisitantesPorEspacios == null)
            {
                return NotFound();
            }

            var visitantesPorEspacio = await _context.VisitantesPorEspacios.FindAsync(id);
            if (visitantesPorEspacio == null)
            {
                return NotFound();
            }
            ViewData["IdEspacio"] = new SelectList(_context.Espacios, "IdEspacio", "NombreEspacio", visitantesPorEspacio.IdEspacio);
            ViewData["IdVisitante"] = new SelectList(_context.Visitantes, "IdVisitante", "NombreVisitante", visitantesPorEspacio.IdVisitante);
            return View(visitantesPorEspacio);
        }

        // POST: VisitantesPorEspacios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdVisitantePorEspacio,IdEspacio,IdVisitante")] VisitantesPorEspacio visitantesPorEspacio)
        {
            if (id != visitantesPorEspacio.IdVisitantePorEspacio)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(visitantesPorEspacio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VisitantesPorEspacioExists(visitantesPorEspacio.IdVisitantePorEspacio))
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
            ViewData["IdEspacio"] = new SelectList(_context.Espacios, "IdEspacio", "NombreEspacio", visitantesPorEspacio.IdEspacio);
            ViewData["IdVisitante"] = new SelectList(_context.Visitantes, "IdVisitante", "NombreVisitante", visitantesPorEspacio.IdVisitante);
            return View(visitantesPorEspacio);
        }

        // GET: VisitantesPorEspacios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.VisitantesPorEspacios == null)
            {
                return NotFound();
            }

            var visitantesPorEspacio = await _context.VisitantesPorEspacios
                .Include(v => v.IdEspacioNavigation)
                .Include(v => v.IdVisitanteNavigation)
                .FirstOrDefaultAsync(m => m.IdVisitantePorEspacio == id);
            if (visitantesPorEspacio == null)
            {
                return NotFound();
            }

            return View(visitantesPorEspacio);
        }

        // POST: VisitantesPorEspacios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.VisitantesPorEspacios == null)
            {
                return Problem("Entity set 'ApptowerProvicionalContext.VisitantesPorEspacios'  is null.");
            }
            var visitantesPorEspacio = await _context.VisitantesPorEspacios.FindAsync(id);
            if (visitantesPorEspacio != null)
            {
                _context.VisitantesPorEspacios.Remove(visitantesPorEspacio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VisitantesPorEspacioExists(int id)
        {
          return (_context.VisitantesPorEspacios?.Any(e => e.IdVisitantePorEspacio == id)).GetValueOrDefault();
        }
    }
}
