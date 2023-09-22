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
    public class EspaciosController : Controller
    {
        private readonly ApptowerProvicionalContext _context;

        public EspaciosController(ApptowerProvicionalContext context)
        {
            _context = context;
        }
        [Authorize]
        public async Task<IActionResult> Index(string buscar)
        {
            // Obtener espacios que no son de tipo "APARTAMENTO"
            var espaciosSinApartamento = _context.Espacios
                .Where(e => e.TipoEspacio != "APARTAMENTO");

            // Obtener espacios que son de tipo "APARTAMENTO"
            var espaciosApartamento = _context.Espacios
                .Where(e => e.TipoEspacio == "APARTAMENTO");

            // Filtrar por nombre si se proporciona un término de búsqueda
            if (!String.IsNullOrEmpty(buscar))
            {
                espaciosSinApartamento = espaciosSinApartamento
                    .Where(e => e.NombreEspacio.Contains(buscar));

                espaciosApartamento = espaciosApartamento
                    .Where(e => e.NombreEspacio.Contains(buscar));
            }

            // Ordenar los espacios sin apartamento por IdEspacio
            espaciosSinApartamento = espaciosSinApartamento.OrderBy(e => e.IdEspacio);

            // Ordenar los espacios de tipo apartamento por NombreEspacio
            espaciosApartamento = espaciosApartamento.OrderBy(e => e.NombreEspacio);

            // Cargar los parqueaderos asociados a cada espacio
            await espaciosSinApartamento.Include(e => e.ParqueaderosDeEspacios).LoadAsync();
            await espaciosApartamento.Include(e => e.ParqueaderosDeEspacios).LoadAsync();
            await espaciosApartamento.Include(e => e.PropietariosPorEspacios).LoadAsync();
            await espaciosApartamento.Include(e => e.Residentes).LoadAsync();
            await espaciosApartamento.Include(e => e.VisitantesPorEspacios).LoadAsync();


            // Combinar ambos conjuntos de espacios
            var todosLosEspacios = await espaciosSinApartamento.ToListAsync();
            todosLosEspacios.AddRange(await espaciosApartamento.ToListAsync());

            return View(todosLosEspacios);
        }







        // GET: Espacios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Consulta la base de datos y asegúrate de incluir los parqueaderos relacionados
            var espacio = await _context.Espacios
                .Include(e => e.ParqueaderosDeEspacios)
                .Include(e => e.PropietariosPorEspacios)
                                .Include(e => e.Residentes)
                                .Include(e => e.VisitantesPorEspacios)

                .FirstOrDefaultAsync(m => m.IdEspacio == id);

            if (espacio == null)
            {
                return NotFound();
            }

            return View(espacio);
        }


        // GET: Espacios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Espacios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEspacio,TipoEspacio,NombreEspacio,Area,Capacidad,EstadoEspacio")] Espacio espacio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(espacio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(espacio);
        }

        // GET: Espacios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Espacios == null)
            {
                return NotFound();
            }

            var espacio = await _context.Espacios.FindAsync(id);
            if (espacio == null)
            {
                return NotFound();
            }
            return View(espacio);
        }

        // POST: Espacios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEspacio,TipoEspacio,NombreEspacio,Area,Capacidad,EstadoEspacio")] Espacio espacio)
        {
            if (id != espacio.IdEspacio)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(espacio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EspacioExists(espacio.IdEspacio))
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
            return View(espacio);
        }

        // GET: Espacios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Espacios == null)
            {
                return NotFound();
            }

            var espacio = await _context.Espacios
                .FirstOrDefaultAsync(m => m.IdEspacio == id);
            if (espacio == null)
            {
                return NotFound();
            }

            return View(espacio);
        }

        // POST: Espacios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Espacios == null)
            {
                return Problem("Entity set 'ApptowerProvicionalContext.Espacios'  is null.");
            }
            var espacio = await _context.Espacios.FindAsync(id);
            if (espacio != null)
            {
                _context.Espacios.Remove(espacio);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EspacioExists(int id)
        {
            return (_context.Espacios?.Any(e => e.IdEspacio == id)).GetValueOrDefault();
        }
    }
}
