using BooksAPI.Models;

namespace BooksAPI.Repository
{
    public interface ILibraryRepo
    {
        public ICollection<Book> getAllBooks();
    }
}
