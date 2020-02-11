using Exam.Domain;
using System.Collections.Generic;

namespace Exam.Application.Interface
{
    public interface IBookRepository
    {
        void AddBook(Book data);
        IEnumerable<Author> GetAuthors();
        IEnumerable<int> GetAllBookIds();
        (string Author, string BookName) GetAuthorWithBook(int titleId);
        bool IsAuthorExists(string name);
        bool IsBookExists(string title);
        void AddAuthor(string name);
    }
}