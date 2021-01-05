using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Aplicacao_Kolping.Data;
using Aplicacao_Kolping.Models;

namespace Aplicacao_Kolping.Controllers
{
    public class ModalidadesController : Controller
    {
        private readonly Aplicacao_KolpingContext _context;

        public ModalidadesController(Aplicacao_KolpingContext context)
        {
            _context = context;
        }

        // GET: Modalidades
        public async Task<IActionResult> Index()
        {
            return View(await _context.Modalidades.ToListAsync());
        }

        // GET: Modalidades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modalidades = await _context.Modalidades
                .FirstOrDefaultAsync(m => m.ID == id);
            if (modalidades == null)
            {
                return NotFound();
            }

            return View(modalidades);
        }

        // GET: Modalidades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Modalidades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Preco,Descricao")] Modalidades modalidades)
        {
            if (ModelState.IsValid)
            {

                _context.Add(modalidades);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(modalidades);
        }

        // GET: Modalidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modalidades = await _context.Modalidades.FindAsync(id);
            if (modalidades == null)
            {
                return NotFound();
            }
            return View(modalidades);
        }

        // POST: Modalidades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Preco,Descricao")] Modalidades modalidades)
        {
            if (id != modalidades.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(modalidades);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModalidadesExists(modalidades.ID))
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
            return View(modalidades);
        }

        // GET: Modalidades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modalidades = await _context.Modalidades
                .FirstOrDefaultAsync(m => m.ID == id);
            if (modalidades == null)
            {
                return NotFound();
            }

            return View(modalidades);
        }

        // POST: Modalidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var modalidades = await _context.Modalidades.FindAsync(id);
            _context.Modalidades.Remove(modalidades);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ModalidadesExists(int id)
        {
            return _context.Modalidades.Any(e => e.ID == id);
        }
    }
}
