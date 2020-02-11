namespace Exam.Domain
{
    public class Book
    {
        public int AuthorId { get; }
        public string Title { get; }       

        public Book(int authorId, string title)
        {
            AuthorId = authorId;
            Title = title;          
        }
    }
}