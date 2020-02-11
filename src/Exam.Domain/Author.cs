namespace Exam.Domain
{
    public class Author
    {
        public string Name { get; }
        public int Id { get; }

        public Author(int id, string name)
        {
            Name = name;
            Id = id;
        }
    }
}