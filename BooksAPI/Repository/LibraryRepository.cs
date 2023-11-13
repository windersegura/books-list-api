using BooksAPI.Context;
using BooksAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksAPI.Repository
{
    public class LibraryRepository : ILibraryRepo
    {
        private readonly LibraryContext _db;
        public LibraryRepository(LibraryContext db)
        {
            _db = db;
        }
        public ICollection<Book> getAllBooks()
        {
            var books = _db.Books.Include( a => a.Author.Name ).AsNoTracking().ToList();

            return books;
        }
    }
}
