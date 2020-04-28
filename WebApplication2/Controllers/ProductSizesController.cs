using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductSizesController : Controller
    {
        private readonly WebApplication2Context _context;

        public ProductSizesController(WebApplication2Context context)
        {
            _context = context;
        }

        // GET: ProductSizes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductSize.ToListAsync());
        }

        // GET: ProductSizes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productSize = await _context.ProductSize
                .FirstOrDefaultAsync(m => m.id == id);
            if (productSize == null)
            {
                return NotFound();
            }

            return View(productSize);
        }

        // GET: ProductSizes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductSizes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,product,size,quantity")] ProductSize productSize)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productSize);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productSize);
        }

        // GET: ProductSizes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productSize = await _context.ProductSize.FindAsync(id);
            if (productSize == null)
            {
                return NotFound();
            }
            return View(productSize);
        }

        // POST: ProductSizes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("id,product,size,quantity")] ProductSize productSize)
        {
            if (id != productSize.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productSize);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductSizeExists(productSize.id))
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
            return View(productSize);
        }

        // GET: ProductSizes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productSize = await _context.ProductSize
                .FirstOrDefaultAsync(m => m.id == id);
            if (productSize == null)
            {
                return NotFound();
            }

            return View(productSize);
        }

        // POST: ProductSizes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var productSize = await _context.ProductSize.FindAsync(id);
            _context.ProductSize.Remove(productSize);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductSizeExists(string id)
        {
            return _context.ProductSize.Any(e => e.id == id);
        }
    }
}
