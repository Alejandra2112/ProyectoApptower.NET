﻿using System;
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
    public class VisitantesController : Controller
    {
        private readonly ApptowerProvicionalContext _context;

        public VisitantesController(ApptowerProvicionalContext context)
        {
            _context = context;
        }

        // GET: Visitantes
        [Authorize]
        public async Task<IActionResult> Index(String buscar)
        {
            var visitante = from Visitante in _context.Visitantes select Visitante;

            if (!String.IsNullOrEmpty(buscar))
            {

                visitante = visitante.Where(v => v.NombreVisitante!.Contains(buscar));

            }
            return View(await visitante.ToListAsync());
        }

        // GET: Visitantes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Visitantes == null)
            {
                return NotFound();
            }

            var visitante = await _context.Visitantes
                .FirstOrDefaultAsync(m => m.IdVisitante == id);
            if (visitante == null)
            {
                return NotFound();
            }

            return View(visitante);
        }

        // GET: Visitantes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Visitantes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVisitante,TipoDocumentoVisitante,NumeroDocumentoVisitante,NombreVisitante,ApellidoVisitante,GeneroVisitante,PermisoVisitante")] Visitante visitante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(visitante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(visitante);
        }

        // GET: Visitantes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Visitantes == null)
            {
                return NotFound();
            }

            var visitante = await _context.Visitantes.FindAsync(id);
            if (visitante == null)
            {
                return NotFound();
            }
            return View(visitante);
        }

        // POST: Visitantes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdVisitante,TipoDocumentoVisitante,NumeroDocumentoVisitante,NombreVisitante,ApellidoVisitante,GeneroVisitante,PermisoVisitante")] Visitante visitante)
        {
            if (id != visitante.IdVisitante)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(visitante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VisitanteExists(visitante.IdVisitante))
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
            return View(visitante);
        }

        // GET: Visitantes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Visitantes == null)
            {
                return NotFound();
            }

            var visitante = await _context.Visitantes
                .FirstOrDefaultAsync(m => m.IdVisitante == id);
            if (visitante == null)
            {
                return NotFound();
            }

            return View(visitante);
        }

        // POST: Visitantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Visitantes == null)
            {
                return Problem("Entity set 'ApptowerProvicionalContext.Visitantes'  is null.");
            }
            var visitante = await _context.Visitantes.FindAsync(id);
            if (visitante != null)
            {
                _context.Visitantes.Remove(visitante);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VisitanteExists(int id)
        {
          return (_context.Visitantes?.Any(e => e.IdVisitante == id)).GetValueOrDefault();
        }
    }
}
