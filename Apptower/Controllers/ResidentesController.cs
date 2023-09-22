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
    public class ResidentesController : Controller
    {
        private readonly ApptowerProvicionalContext _context;

        public ResidentesController(ApptowerProvicionalContext context)
        {
            _context = context;
        }
        //Graficas
        public IActionResult MiGrafica()
        {
            List<Residente> residente = _context.Residentes.ToList();
            return View(residente);
        }


        // GET: Residentes
        [Authorize]
        public async Task<IActionResult> Index(String buscar)
        {
            var residente = from Residente in _context.Residentes select Residente;

            if (!String.IsNullOrEmpty(buscar))
            {

                residente = residente.Where(r => r.NombreResidente!.Contains(buscar));

            }
            return View(await residente.ToListAsync());
        }

        // GET: Residentes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Residentes == null)
            {
                return NotFound();
            }

            var residente = await _context.Residentes
                .Include(r => r.IdEspacioNavigation)
                .FirstOrDefaultAsync(m => m.IdResidente == id);
            if (residente == null)
            {
                return NotFound();
            }

            return View(residente);
        }

        // GET: Residentes/Create
        public IActionResult Create()
        {
            // Filtrar los espacios por tipo "APARTAMENTO"
            var espaciosApartamento = _context.Espacios
                                               .Where(e => e.TipoEspacio == "APARTAMENTO")
                                               .ToList();

            ViewData["IdEspacio"] = new SelectList(espaciosApartamento, "IdEspacio", "NombreEspacio");
            return View();
        }

        // POST: Residentes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdResidente,TipoDocumentoResidente,NumeroDocumentoResidente,NombreResidente,ApellidoResidente,FechaNacimientoResidente,CorreoResidente,TelefonoResidente,TipoResidente,ResidenciaActual,IdEspacio,FechaInicioResidencia,FechaFinResidencia,EstadoResidente")] Residente residente)
        {

            if (!ModelState.IsValid)
            {
                Console.WriteLine(residente.ToString());
                _context.Add(residente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEspacio"] = new SelectList(_context.Espacios, "IdEspacio", "NombreEspacio", residente.IdEspacio);
            return View(residente);
        }

        // GET: Residentes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Residentes == null)
            {
                return NotFound();
            }

            var residente = await _context.Residentes.FindAsync(id);
            if (residente == null)
            {
                return NotFound();
            }
            ViewData["IdEspacio"] = new SelectList(_context.Espacios, "IdEspacio", "NombreEspacio", residente.IdEspacio);
            return View(residente);
        }

        // POST: Residentes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdResidente,TipoDocumentoResidente,NumeroDocumentoResidente,NombreResidente,ApellidoResidente,FechaNacimientoResidente,CorreoResidente,TelefonoResidente,TipoResidente,ResidenciaActual,IdEspacio,FechaInicioResidencia,FechaFinResidencia,EstadoResidente")] Residente residente)
        {
            if (id != residente.IdResidente)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(residente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResidenteExists(residente.IdResidente))
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
            ViewData["IdEspacio"] = new SelectList(_context.Espacios, "IdEspacio", "NombreEspacio", residente.IdEspacio);
            return View(residente);
        }

        // GET: Residentes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Residentes == null)
            {
                return NotFound();
            }

            var residente = await _context.Residentes
                //.Include(r => r.IdEspacioNavigation)
                .FirstOrDefaultAsync(m => m.IdResidente == id);
            if (residente == null)
            {
                return NotFound();
            }

            return View(residente);
        }

        // POST: Residentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Residentes != null)
            {
                return Problem("Entity set 'ApptowerProvicionalContext.Residentes'  is null.");
            }
            var residente = await _context.Residentes.FindAsync(id);
            if (residente != null)
            {
                _context.Residentes.Remove(residente);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResidenteExists(int id)
        {
          return (_context.Residentes?.Any(e => e.IdResidente == id)).GetValueOrDefault();
        }
    }
}
