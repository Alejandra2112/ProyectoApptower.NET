using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Apptower.Models;
using Microsoft.AspNetCore.Authorization;

namespace Apptower.Controllers
{
    public class ParqueaderosDeEspaciosController : Controller
    {
        private readonly ApptowerProvicionalContext _context;

        public ParqueaderosDeEspaciosController(ApptowerProvicionalContext context)
        {
            _context = context;
        }

        // GET: ParqueaderosDeEspacios
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var apptowerProvicionalContext = _context.ParqueaderosDeEspacios.Include(p => p.IdEspacioNavigation).Include(p => p.IdParqueaderoNavigation);
            return View(await apptowerProvicionalContext.ToListAsync());
        }

        // GET: ParqueaderosDeEspacios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ParqueaderosDeEspacios == null)
            {
                return NotFound();
            }

            var parqueaderosDeEspacio = await _context.ParqueaderosDeEspacios
                .Include(p => p.IdEspacioNavigation)
                .Include(p => p.IdParqueaderoNavigation)
                .FirstOrDefaultAsync(m => m.IdParqueaderosDeEspacios == id);
            if (parqueaderosDeEspacio == null)
            {
                return NotFound();
            }

            return View(parqueaderosDeEspacio);
        }

        // GET: ParqueaderosDeEspacios/Create
        public IActionResult Create(int? id)
        {

            ViewData["id"] = id ;

            Console.WriteLine(id);

            // Filtrar los espacios por tipo "APARTAMENTO" y ordenarlos por NombreEspacio de manera ascendente
            var espaciosApartamento = _context.Espacios
                                              .Where(e => e.TipoEspacio == "APARTAMENTO")
                                              .OrderBy(e => e.NombreEspacio);

            // Crear una SelectList solo con los espacios de tipo "APARTAMENTO" y ordenados por nombre
            ViewData["IdEspacio"] = new SelectList(espaciosApartamento, "IdEspacio", "NombreEspacio");

            // Filtrar los parqueaderos por tipo "RESIDENTES" y ordenarlos por NombreParqueadero de manera ascendente
            var parqueaderosResidentes = _context.Parqueaderos
                                                    .Where(p => p.TipoParqueadero == "RESIDENTES")
                                                    .OrderBy(p => p.NombreParqueadero);

            // Crear una SelectList solo con los parqueaderos de tipo "RESIDENTES" y ordenados por nombre
            ViewData["IdParqueadero"] = new SelectList(parqueaderosResidentes, "IdParqueadero", "NombreParqueadero");

            return View();
        }



        // POST: ParqueaderosDeEspacios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdParqueaderosDeEspacios,IdEspacio,IdParqueadero")] ParqueaderosDeEspacio parqueaderosDeEspacio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parqueaderosDeEspacio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Espacios"); // Redirigir a la acción Index del controlador Espacios
            }
            ViewData["IdEspacio"] = new SelectList(_context.Espacios, "IdEspacio", "NombreEspacio", parqueaderosDeEspacio.IdEspacio);
            ViewData["IdParqueadero"] = new SelectList(_context.Parqueaderos, "IdParqueadero", "NombreParqueadero", parqueaderosDeEspacio.IdParqueadero);
            return View(parqueaderosDeEspacio);
        }


        // GET: ParqueaderosDeEspacios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ParqueaderosDeEspacios == null)
            {
                return NotFound();
            }

            var parqueaderosDeEspacio = await _context.ParqueaderosDeEspacios.FindAsync(id);
            if (parqueaderosDeEspacio == null)
            {
                return NotFound();
            }
            ViewData["IdEspacio"] = new SelectList(_context.Espacios, "IdEspacio", "NombreEspacio", parqueaderosDeEspacio.IdEspacio);
            ViewData["IdParqueadero"] = new SelectList(_context.Parqueaderos, "IdParqueadero", "NombreParqueadero", parqueaderosDeEspacio.IdParqueadero);
            return View(parqueaderosDeEspacio);
        }

        // POST: ParqueaderosDeEspacios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdParqueaderosDeEspacios,IdEspacio,IdParqueadero")] ParqueaderosDeEspacio parqueaderosDeEspacio)
        {
            if (id != parqueaderosDeEspacio.IdParqueaderosDeEspacios)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parqueaderosDeEspacio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParqueaderosDeEspacioExists(parqueaderosDeEspacio.IdParqueaderosDeEspacios))
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
            ViewData["IdEspacio"] = new SelectList(_context.Espacios, "IdEspacio", "NombreEspacio", parqueaderosDeEspacio.IdEspacio);
            ViewData["IdParqueadero"] = new SelectList(_context.Parqueaderos, "IdParqueadero", "NombreParqueadero", parqueaderosDeEspacio.IdParqueadero);
            return View(parqueaderosDeEspacio);
        }

        // GET: ParqueaderosDeEspacios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ParqueaderosDeEspacios == null)
            {
                return NotFound();
            }

            var parqueaderosDeEspacio = await _context.ParqueaderosDeEspacios
                .Include(p => p.IdEspacioNavigation)
                .Include(p => p.IdParqueaderoNavigation)
                .FirstOrDefaultAsync(m => m.IdParqueaderosDeEspacios == id);
            if (parqueaderosDeEspacio == null)
            {
                return NotFound();
            }

            return View(parqueaderosDeEspacio);
        }

        // POST: ParqueaderosDeEspacios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ParqueaderosDeEspacios == null)
            {
                return Problem("Entity set 'ApptowerProvicionalContext.ParqueaderosDeEspacios'  is null.");
            }
            var parqueaderosDeEspacio = await _context.ParqueaderosDeEspacios.FindAsync(id);
            if (parqueaderosDeEspacio != null)
            {
                _context.ParqueaderosDeEspacios.Remove(parqueaderosDeEspacio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Espacios"); // Redirigir a la acción Index del controlador Espacios
        }

        private bool ParqueaderosDeEspacioExists(int id)
        {
          return (_context.ParqueaderosDeEspacios?.Any(e => e.IdParqueaderosDeEspacios == id)).GetValueOrDefault();
        }
    }
}
