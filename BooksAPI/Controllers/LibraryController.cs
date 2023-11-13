using BooksAPI.Models;
using BooksAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryRepo _libraryRepo;
        public LibraryController(ILibraryRepo repo) 
        { 
            _libraryRepo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Book>>> Get(){
            var library = _libraryRepo.getAllBooks();

            return Ok(library);
        }



    }
}
