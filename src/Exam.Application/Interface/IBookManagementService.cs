using Exam.Domain;
using System.Collections.Generic;

namespace Exam.Application.Interface
{
    public interface IBookManagementService
    {       
        void AddBook(Book book);
        IEnumerable<Author> GetAuthors();
        bool IsAuthorExists(string name);
        bool IsBookExists(string title);
        void AddAuthor(string name);
    }
}