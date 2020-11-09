using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging; 

using BookBinderBE.Services;
using BookBinderBE.Models.BookInfo;

namespace BookBinderBE.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private readonly IDatabaseService<Book> _dbService;

        public BookController(ILogger<BookController> logger, IDatabaseService<Book> dbService)
        {
            _logger = logger;
            _dbService = dbService;
        }

        [HttpPost]
        public ActionResult<Book> Create(Book inBook)
        {

            var Book = _dbService.Create(inBook);
            if(Book == null) {
                return Conflict();
            }
            return Book;
            
        }

        [HttpGet]
        public ActionResult<List<Book>> Get()
        {
            return _dbService.Get();
        }

        [HttpGet("{id}", Name = "GetBook")]
        public ActionResult<Book> Get(string id) 
        {
            var Book = _dbService.Get(id);

            if (Book == null)
            {
                return NotFound();
            }

            return Book;
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, Book bookIn)
        {
            var book = _dbService.Get(id);
            if (book == null)
            {
                return NotFound();
            }

            _dbService.Update(id, bookIn);

            return NoContent();
        }

    }
}