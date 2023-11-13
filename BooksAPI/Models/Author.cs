namespace BooksAPI.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public ICollection<Book> BooksList { get; set; }
    }
}
