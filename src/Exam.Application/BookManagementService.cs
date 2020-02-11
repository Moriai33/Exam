using Exam.Application.Interface;
using Exam.Domain;
using System.Collections.Generic;

namespace Exam.Application
{
    internal class BookManagementService : IBookManagementService
    {
        private readonly IBookRepository _bookRepository;
        public BookManagementService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void AddAuthor(string name)
        {
            _bookRepository.AddAuthor(name);
        }

        public void AddBook(Book book)
        {
            _bookRepository.AddBook(book);
        }

        public IEnumerable<Author> GetAuthors()
        {
            return _bookRepository.GetAuthors();
        }

        public bool IsAuthorExists(string name)
        {
            return _bookRepository.IsAuthorExists(name);
        }

        public bool IsBookExists(string title)
        {
            return _bookRepository.IsBookExists(title);
        }
    }
}