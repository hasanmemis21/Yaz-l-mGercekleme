using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YazılımGercekleme.Models;

namespace YazılımGercekleme.Controllers
{
    public class BookDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public BookDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: BookDetails
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.BooksDetails.Include(b => b.Book);
            return View(await appDbContext.ToListAsync());
        }

        // GET: BookDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookDetail = await _context.BooksDetails
                .Include(b => b.Book)
                .FirstOrDefaultAsync(m => m.BookDetailId == id);
            if (bookDetail == null)
            {
                return NotFound();
            }

            return View(bookDetail);
        }

        // GET: BookDetails/Create
        public IActionResult Create()
        {
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Title");
            return View();
        }

        // POST: BookDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookDetailId,Description,ISSN,Language,Country,Year,NumberOfPage,Link,BookId")] BookDetail bookDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Title", bookDetail.BookId);
            return View(bookDetail);
        }

        // GET: BookDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookDetail = await _context.BooksDetails.FindAsync(id);
            if (bookDetail == null)
            {
                return NotFound();
            }
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Title", bookDetail.BookId);
            return View(bookDetail);
        }

        // POST: BookDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookDetailId,Description,ISSN,Language,Country,Year,NumberOfPage,Link,BookId")] BookDetail bookDetail)
        {
            if (id != bookDetail.BookDetailId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookDetailExists(bookDetail.BookDetailId))
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
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Title", bookDetail.BookId);
            return View(bookDetail);
        }

        // GET: BookDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookDetail = await _context.BooksDetails
                .Include(b => b.Book)
                .FirstOrDefaultAsync(m => m.BookDetailId == id);
            if (bookDetail == null)
            {
                return NotFound();
            }

            return View(bookDetail);
        }

        // POST: BookDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookDetail = await _context.BooksDetails.FindAsync(id);
            _context.BooksDetails.Remove(bookDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookDetailExists(int id)
        {
            return _context.BooksDetails.Any(e => e.BookDetailId == id);
        }
    }
}
