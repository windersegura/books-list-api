namespace BooksAPI.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public string Genre { get; set; }
        public string Cover { get; set; }
        public string Synopsis { get; set; }
        public short Year { get; set; }
        public string ISBN { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
