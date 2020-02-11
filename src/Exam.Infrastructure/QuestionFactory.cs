using Exam.Application.Interface;
using Exam.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam.Infrastructure
{
    internal class QuestionFactory : IQuestionFactory
    {
        private readonly IBookRepository _bookRepository;

        public QuestionFactory(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Question GetQuestion(int titleId)
        {
            var goodAnswer = _bookRepository.GetAuthorWithBook(titleId);
            var authors = _bookRepository.GetAuthors();

            var possibleBadAnswerList = authors.Where(author => author.Name != goodAnswer.Author).Select(author => author.Name);
            var badAnswerList = GetRandomAuthors(possibleBadAnswerList);
            var question = new Question(goodAnswer.BookName, goodAnswer.Author, badAnswerList.ElementAt(0), badAnswerList.ElementAt(1), badAnswerList.ElementAt(2));

            return question;
        }

        private IEnumerable<string> GetRandomAuthors(IEnumerable<string> authors)
        {
            var rnd = new Random();
            var selectedAuthor = new HashSet<string>();

            while (selectedAuthor.Count < 4)
            {
                var index = rnd.Next(0, authors.Count());
                selectedAuthor.Add(authors.ElementAt(index));
            }

            return selectedAuthor;
        }
    }
}