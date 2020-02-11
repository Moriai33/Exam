using Dapper;
using Exam.Application.Interface;
using Exam.Domain;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;

namespace Exam.Infrastructure
{
    internal class BookRepository : IBookRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["QuestionDb"].ConnectionString;
        public void AddBook(Book book)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                const string query = "INSERT INTO Book (Title, AuthorId) VALUES (@title, @authorid) ";
                connection.Execute(query, param: new { title = book.Title, authorid = book.AuthorId });
            }
        }

        public bool IsAuthorExists(string name)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                const string query = "SELECT EXISTS (SELECT Name FROM Author WHERE Name = @name)";
                var isAuthorExists = connection.QueryFirst<bool>(query, param: new { name = name });

                return isAuthorExists;
            }
        }

        public bool IsBookExists(string title)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                const string query = "SELECT EXISTS (SELECT Title FROM Book WHERE Title = @title)";
                var isBookExists = connection.QueryFirst<bool>(query, param: new { title = title });

                return isBookExists;
            }
        }
        
        public void AddAuthor(string name)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                const string query = "INSERT INTO Author (Name) VALUES (@name) ";
                connection.Execute(query, param: new { name = name});
            }
        }

        public IEnumerable<Author> GetAuthors()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                const string query = "SELECT Id, Name FROM Author";
                var authors = connection.Query<(int Id, string Name)>(query);
                
                return authors.Select(author => new Author(author.Id, author.Name));
            }
        }

        public IEnumerable<int> GetAllBookIds()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                const string query = "SELECT Id FROM Book";
                var ids = connection.Query<int>(query);

                return ids;
            }
        }

        public (string Author, string BookName) GetAuthorWithBook(int titleId)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                const string query = "SELECT Name, Title FROM Book b INNER JOIN Author a ON b.AuthorId = a.Id WHERE b.Id = @titleId";
                var authorWithBook = connection.QueryFirst<(string, string)>(query, param: new { titleId = titleId });

                return authorWithBook;
            }           
        }
    }
}