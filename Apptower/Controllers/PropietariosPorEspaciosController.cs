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
    public class PropietariosPorEspaciosController : Controller
    {
        private readonly ApptowerProvicionalContext _context;

        public PropietariosPorEspaciosController(ApptowerProvicionalContext context)
        {
            _context = context;
        }

        // GET: PropietariosPorEspacios
        public async Task<IActionResult> Index()
        {
            var apptowerProvicionalContext = _context.PropietariosPorEspacios.Include(p => p.IdEspacioNavigation).Include(p => p.IdPropietarioNavigation);
            return View(await apptowerProvicionalContext.ToListAsync());
        }

        // GET: PropietariosPorEspacios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PropietariosPorEspacios == null)
            {
                return NotFound();
            }

            var propietariosPorEspacio = await _context.PropietariosPorEspacios
                .Include(p => p.IdEspacioNavigation)
                .Include(p => p.IdPropietarioNavigation)
                .FirstOrDefaultAsync(m => m.IdPropietariosPorEspacio == id);
            if (propietariosPorEspacio == null)
            {
                return NotFound();
            }

            return View(propietariosPorEspacio);
        }

        // GET: PropietariosPorEspacios/Create
        public IActionResult Create()
        {
            // Filtrar los espacios por tipo "APARTAMENTO" y estado "ACTIVO"
            var espaciosApartamento = _context.Espacios
                                               .Where(e => e.TipoEspacio == "APARTAMENTO" && e.EstadoEspacio == "ACTIVO")
                                               .ToList();

            ViewData["IdEspacio"] = new SelectList(espaciosApartamento, "IdEspacio", "NombreEspacio");
            ViewData["IdPropietario"] = new SelectList(_context.Propietarios, "IdPropietario", "NombrePropietario");

            return View();
        }


        // POST: PropietariosPorEspacios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPropietariosPorEspacio,IdEspacio,IdPropietario")] PropietariosPorEspacio propietariosPorEspacio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(propietariosPorEspacio);
                await _context.SaveChangesAsync();
                //TempData["mensaje"] = $"Se agrego {propietariosPorEspacio.IdPropietarioNavigation.NombrePropietario + propietariosPorEspacio.IdPropietarioNavigation.ApellidoPropietario + "al apartamento " + propietariosPorEspacio.IdEspacioNavigation.NombreEspacio}";

                return RedirectToAction("Index", "Espacios"); // Redirigir a la acción Index del controlador Espacios
            }
            ViewData["IdEspacio"] = new SelectList(_context.Espacios, "IdEspacio", "NombreEspacio", propietariosPorEspacio.IdEspacio);
            ViewData["IdPropietario"] = new SelectList(_context.Propietarios, "IdPropietario", "NombrePropietario", propietariosPorEspacio.IdPropietario);


            return View(propietariosPorEspacio);
        }

        // GET: PropietariosPorEspacios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PropietariosPorEspacios == null)
            {
                return NotFound();
            }

            var propietariosPorEspacio = await _context.PropietariosPorEspacios.FindAsync(id);
            if (propietariosPorEspacio == null)
            {
                return NotFound();
            }
            ViewData["IdEspacio"] = new SelectList(_context.Espacios, "IdEspacio", "NombreEspacio", propietariosPorEspacio.IdEspacio);
            ViewData["IdPropietario"] = new SelectList(_context.Propietarios, "IdPropietario", "NombrePropietario", propietariosPorEspacio.IdPropietario);
            return View(propietariosPorEspacio);
        }

        // POST: PropietariosPorEspacios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPropietariosPorEspacio,IdEspacio,IdPropietario")] PropietariosPorEspacio propietariosPorEspacio)
        {
            if (id != propietariosPorEspacio.IdPropietariosPorEspacio)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(propietariosPorEspacio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropietariosPorEspacioExists(propietariosPorEspacio.IdPropietariosPorEspacio))
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
            ViewData["IdEspacio"] = new SelectList(_context.Espacios, "IdEspacio", "NombreEspacio", propietariosPorEspacio.IdEspacio);
            ViewData["IdPropietario"] = new SelectList(_context.Propietarios, "IdPropietario", "NombrePropietario", propietariosPorEspacio.IdPropietario);
            return View(propietariosPorEspacio);
        }

        // GET: PropietariosPorEspacios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PropietariosPorEspacios == null)
            {
                return NotFound();
            }

            var propietariosPorEspacio = await _context.PropietariosPorEspacios
                .Include(p => p.IdEspacioNavigation)
                .Include(p => p.IdPropietarioNavigation)
                .FirstOrDefaultAsync(m => m.IdPropietariosPorEspacio == id);
            if (propietariosPorEspacio == null)
            {
                return NotFound();
            }

            return View(propietariosPorEspacio);
        }

        // POST: PropietariosPorEspacios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PropietariosPorEspacios == null)
            {
                return Problem("Entity set 'ApptowerProvicionalContext.PropietariosPorEspacios'  is null.");
            }
            var propietariosPorEspacio = await _context.PropietariosPorEspacios.FindAsync(id);
            if (propietariosPorEspacio != null)
            {
                _context.PropietariosPorEspacios.Remove(propietariosPorEspacio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Espacios"); // Redirigir a la acción Index del controlador Espacios
        }

        private bool PropietariosPorEspacioExists(int id)
        {
          return (_context.PropietariosPorEspacios?.Any(e => e.IdPropietariosPorEspacio == id)).GetValueOrDefault();
        }
    }
}
