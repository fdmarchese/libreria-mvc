using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LibreriaMVC.Database;
using LibreriaMVC.Models;
using Microsoft.AspNetCore.Authorization;

namespace LibreriaMVC.Controllers
{
    [Authorize]
    public class EditorialesController : Controller
    {
        private readonly LibreriaDbContext _context;

        public EditorialesController(LibreriaDbContext context)
        {
            _context = context;
        }

        // GET: Editoriales
        public async Task<IActionResult> Index()
        {
            return View(await _context.Editoriales.ToListAsync());
        }

        // GET: Editoriales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editorial = await _context.Editoriales
                .FirstOrDefaultAsync(m => m.Id == id);
            if (editorial == null)
            {
                return NotFound();
            }

            return View(editorial);
        }

        // GET: Editoriales/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Editoriales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] Editorial editorial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(editorial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(editorial);
        }

        // GET: Editoriales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editorial = await _context.Editoriales.FindAsync(id);
            if (editorial == null)
            {
                return NotFound();
            }
            return View(editorial);
        }

        // POST: Editoriales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] Editorial editorial)
        {
            if (id != editorial.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(editorial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EditorialExists(editorial.Id))
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
            return View(editorial);
        }

        // GET: Editoriales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editorial = await _context.Editoriales
                .FirstOrDefaultAsync(m => m.Id == id);
            if (editorial == null)
            {
                return NotFound();
            }

            return View(editorial);
        }

        // POST: Editoriales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var editorial = await _context.Editoriales.FindAsync(id);
            _context.Editoriales.Remove(editorial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EditorialExists(int id)
        {
            return _context.Editoriales.Any(e => e.Id == id);
        }
    }
}
