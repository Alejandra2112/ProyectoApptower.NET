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
    public class ParqueaderosController : Controller
    {
        private readonly ApptowerProvicionalContext _context;

        public ParqueaderosController(ApptowerProvicionalContext context)
        {
            _context = context;
        }

        // GET: Parqueaderos
        [Authorize]
        public async Task<IActionResult> Index(string buscar)
        {
            var parqueaderos = _context.Parqueaderos
                .Include(p => p.ParqueaderosDeEspacios)
                .AsQueryable();

            if (!string.IsNullOrEmpty(buscar))
            {
                parqueaderos = parqueaderos.Where(p => p.NombreParqueadero.Contains(buscar));
            }

            // Resto de tu código...

            return View(await parqueaderos.ToListAsync());
        }




        // GET: Parqueaderos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Parqueaderos == null)
            {
                return NotFound();
            }

            var parqueadero = await _context.Parqueaderos
                .FirstOrDefaultAsync(m => m.IdParqueadero == id);
            if (parqueadero == null)
            {
                return NotFound();
            }

            return View(parqueadero);
        }

        // GET: Parqueaderos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Parqueaderos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdParqueadero,NombreParqueadero,TipoParqueadero,EstadoParqueadero")] Parqueadero parqueadero)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parqueadero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parqueadero);
        }

        // GET: Parqueaderos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Parqueaderos == null)
            {
                return NotFound();
            }

            var parqueadero = await _context.Parqueaderos.FindAsync(id);

            if (parqueadero == null)
            {
                return NotFound();
            }
            return View(parqueadero);
        }

        // POST: Parqueaderos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdParqueadero,NombreParqueadero,TipoParqueadero,EstadoParqueadero")] Parqueadero parqueadero)
        {
            if (id != parqueadero.IdParqueadero)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parqueadero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParqueaderoExists(parqueadero.IdParqueadero))
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
            return View(parqueadero);
        }

        // GET: Parqueaderos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Parqueaderos == null)
            {
                return NotFound();
            }

            var parqueadero = await _context.Parqueaderos
                .FirstOrDefaultAsync(m => m.IdParqueadero == id);
            if (parqueadero == null)
            {
                return NotFound();
            }

            return View(parqueadero);
        }

        // POST: Parqueaderos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Parqueaderos == null)
            {
                return Problem("Entity set 'ApptowerProvicionalContext.Parqueaderos'  is null.");
            }
            var parqueadero = await _context.Parqueaderos.FindAsync(id);
            if (parqueadero != null)
            {
                _context.Parqueaderos.Remove(parqueadero);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParqueaderoExists(int id)
        {
          return (_context.Parqueaderos?.Any(e => e.IdParqueadero == id)).GetValueOrDefault();
        }
    }
}
