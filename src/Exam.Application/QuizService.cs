using Exam.Application.Interface;
using Exam.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam.Application
{
    internal class QuizService : IQuizService
    {
        private readonly IQuestionFactory _questionFactory;
        private readonly IBookRepository _bookRepository;
        private int _maxNumberOfQuestions;
        private HashSet<int> _alreadyAskedBookIds;
        private IEnumerable<int> _bookIds;
        private int _currentNumberOfQuestions;
        private string _currentCorrectAnswer;
        private int _numberOfCorrectAnswers;

        public QuizService(IQuestionFactory questionFactory, IBookRepository bookRepository)
        {
            _questionFactory = questionFactory;
            _bookRepository = bookRepository;
        }

        public bool CheckAnswer(string answer)
        {
            if (_currentCorrectAnswer != answer)
            {
                return false;
            }

            _numberOfCorrectAnswers++;
            return true;
        }

        public void GenerateQuiz(int numberOfQuestions)
        {
            if (numberOfQuestions < 10)
            {               
               throw new ArgumentOutOfRangeException(message: "A kérdések számának minimum 10-nek kell lennie!", null);
            }

            _bookIds = _bookRepository.GetAllBookIds();

            if (numberOfQuestions > _bookIds.Count())
            {
                throw new ArgumentOutOfRangeException(message: $"A kérdések száma nem lehet több, mint {_bookIds.Count()}!", null);
            }

            _maxNumberOfQuestions = numberOfQuestions;
            _currentNumberOfQuestions = 0;
            _alreadyAskedBookIds = new HashSet<int>();
        }

        public Question GetNextQuestion()
        {
            var nextBookId = GetNewBookId();
            var question = _questionFactory.GetQuestion(nextBookId);
            _currentCorrectAnswer = question.Answers.Single(answer => answer.Value == true).Key;
            _currentNumberOfQuestions++;

            return question;
        }

        private int GetNewBookId()
        {
            var rnd = new Random();
            var nextBookId = rnd.Next(1, _bookIds.Count() + 1);
            while (!_alreadyAskedBookIds.Add(nextBookId))
            {
                nextBookId = rnd.Next(1, _bookIds.Count() + 1);
            }

            return nextBookId;
        }

        public int GetProgression()
        {
            return _currentNumberOfQuestions;
        }

        public bool IsLastQuestion()
        {
            return _currentNumberOfQuestions == _maxNumberOfQuestions;
        }

        public int NumberOfCorrectlyAnsweredQuestions()
        {
            return _numberOfCorrectAnswers;
        }

        public int GetMaxNumberOfQuestions()
        {
            return _maxNumberOfQuestions;
        }
    }
}