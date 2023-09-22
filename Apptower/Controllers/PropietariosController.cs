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
    public class PropietariosController : Controller
    {
        private readonly ApptowerProvicionalContext _context;

        public PropietariosController(ApptowerProvicionalContext context)
        {
            _context = context;
        }

        // GET: Propietarios
        [Authorize]
        public async Task<IActionResult> Index(String buscar)
        {
            var propietario = from Propietario in _context.Propietarios select Propietario;

            if (!String.IsNullOrEmpty(buscar))
            {

                propietario = propietario.Where(s => s.NombrePropietario!.Contains(buscar));

            }



            return View(await propietario.ToListAsync());
        }

        // GET: Propietarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Propietarios == null)
            {
                return NotFound();
            }

            var propietario = await _context.Propietarios
                .FirstOrDefaultAsync(m => m.IdPropietario == id);
            if (propietario == null)
            {
                return NotFound();
            }

            return View(propietario);
        }

        // GET: Propietarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Propietarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPropietario,TipoDocumentoPropietario,NumeroDocumentoPropietario,NombrePropietario,ApellidoPropietario,FechaNacimientoPropietario,CorreoPropietario,TelefonoPropietario,EstadoPropietario")] Propietario propietario)
        {
            if (!ModelState.IsValid)
            {

                var existingUser = await _context.Propietarios.FirstOrDefaultAsync(u => u.NumeroDocumentoPropietario == propietario.NumeroDocumentoPropietario);

                if (existingUser != null)
                {
                    // Ya existe un usuario con el mismo documento, manejar el error
                    ModelState.AddModelError(string.Empty, "Ya existe un propietario con el mismo documento.");
                    return View(propietario);

                }
                propietario.EstadoPropietario = "Activo";

                _context.Add(propietario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(propietario);
        }

        // GET: Propietarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Propietarios == null)
            {
                return NotFound();
            }

            var propietario = await _context.Propietarios.FindAsync(id);
            if (propietario == null)
            {
                return NotFound();
            }
            return View(propietario);
        }

        // POST: Propietarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPropietario,TipoDocumentoPropietario,NumeroDocumentoPropietario,NombrePropietario,ApellidoPropietario,FechaNacimientoPropietario,CorreoPropietario,TelefonoPropietario,EstadoPropietario")] Propietario propietario)
        {
            if (id != propietario.IdPropietario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(propietario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropietarioExists(propietario.IdPropietario))
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
            return View(propietario);
        }

        // GET: Propietarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Propietarios == null)
            {
                return NotFound();
            }

            var propietario = await _context.Propietarios
                .FirstOrDefaultAsync(m => m.IdPropietario == id);
            if (propietario == null)
            {
                return NotFound();
            }

            return View(propietario);
        }

        // POST: Propietarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Propietarios == null)
            {
                return Problem("Entity set 'ApptowerProvicionalContext.Propietarios'  is null.");
            }
            var propietario = await _context.Propietarios.FindAsync(id);
            if (propietario != null)
            {
                _context.Propietarios.Remove(propietario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropietarioExists(int id)
        {
            return (_context.Propietarios?.Any(e => e.IdPropietario == id)).GetValueOrDefault();
        }
    }
}
