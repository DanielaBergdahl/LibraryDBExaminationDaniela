using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LibraryDBExaminationDaniela.Data;
using LibraryDBExaminationDaniela.Data.Entities;

namespace LibraryDBExaminationDaniela.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryBooksController : ControllerBase
    {
        private readonly Context _context;

        public LibraryBooksController(Context context)
        {
            _context = context;
        }

        // GET: api/LibraryBooks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LibraryBook>>> GetLibraryBooks()
        {
            return await _context.LibraryBooks.ToListAsync();
        }

        // GET: api/LibraryBooks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LibraryBook>> GetLibraryBook(int id)
        {
            var libraryBook = await _context.LibraryBooks.FindAsync(id);

            if (libraryBook == null)
            {
                return NotFound();
            }

            return libraryBook;
        }

        // PUT: api/LibraryBooks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLibraryBook(int id, LibraryBook libraryBook)
        {
            if (id != libraryBook.Id)
            {
                return BadRequest();
            }

            _context.Entry(libraryBook).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LibraryBookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/LibraryBooks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LibraryBook>> PostLibraryBook(LibraryBook libraryBook)
        {
            _context.LibraryBooks.Add(libraryBook);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLibraryBook", new { id = libraryBook.Id }, libraryBook);
        }

        // DELETE: api/LibraryBooks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLibraryBook(int id)
        {
            var libraryBook = await _context.LibraryBooks.FindAsync(id);
            if (libraryBook == null)
            {
                return NotFound();
            }

            _context.LibraryBooks.Remove(libraryBook);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LibraryBookExists(int id)
        {
            return _context.LibraryBooks.Any(e => e.Id == id);
        }
    }
}
