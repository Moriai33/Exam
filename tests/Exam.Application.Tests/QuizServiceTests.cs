using System;
using System.Linq;
using AutoFixture;
using Exam.Application.Interface;
using Exam.Domain;
using FluentAssertions;
using Moq;
using Xunit;

namespace Exam.Application.Tests
{
    public class QuizServiceTests
    {
        private readonly Mock<IBookRepository> _bookRepositoryMock;
        private readonly Mock<IQuestionFactory> _questionFactoryMock;
        private readonly Fixture _fixture;

        public QuizServiceTests()
        {
            _bookRepositoryMock = new Mock<IBookRepository>();
            _questionFactoryMock = new Mock<IQuestionFactory>();
            _fixture = new Fixture();
        }

        [Fact]
        public void GenerateQuizNegativeQuestionNumber()
        {
            //Arrange
            var quizService = new QuizService(_questionFactoryMock.Object, _bookRepositoryMock.Object);

            //Act
            Action action = () => quizService.GenerateQuiz(-4);

            //Assert
            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("A kérdések számának minimum 10-nek kell lennie!");
        }


        [Fact]
        public void GenerateQuizZeroQuestionNumber()
        {
            //Arrange
            var quizService = new QuizService(_questionFactoryMock.Object, _bookRepositoryMock.Object);

            //Act
            Action action = () => quizService.GenerateQuiz(0);

            //Assert
            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("A kérdések számának minimum 10-nek kell lennie!");
        }

        [Fact]
        public void GenerateQuizTooLittleQuestionNumber()
        {
            //Arrange
            var quizService = new QuizService(_questionFactoryMock.Object, _bookRepositoryMock.Object);

            //Act
            Action action = () => quizService.GenerateQuiz(4);

            //Assert
            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage("A kérdések számának minimum 10-nek kell lennie!");
        }

        [Fact]
        public void GenerateQuizValidQuestionNumber()
        {
            //Arrange
            const int maxNumberOfBooksInDatabase = 12;
            const int numberOfQuestionsWanted = 10;
            _bookRepositoryMock
                .Setup(bookRepository => bookRepository.GetAllBookIds())
                .Returns(new int[maxNumberOfBooksInDatabase]);
            var quizService = new QuizService(_questionFactoryMock.Object, _bookRepositoryMock.Object);

            //Act
            quizService.GenerateQuiz(numberOfQuestionsWanted);

            //Assert
            quizService.GetMaxNumberOfQuestions().Should().Be(numberOfQuestionsWanted);
            quizService.IsLastQuestion().Should().BeFalse();
            quizService.GetProgression().Should().Be(0);
            quizService.NumberOfCorrectlyAnsweredQuestions().Should().Be(0);
        }

        [Fact]
        public void GenerateQuizTooMuchQuestionNumber()
        {
            //Arrange
            const int maxNumberOfBooksInDatabase = 12;
            _bookRepositoryMock
                .Setup(bookRepository => bookRepository.GetAllBookIds())
                .Returns(new int[maxNumberOfBooksInDatabase]);
            var quizService = new QuizService(_questionFactoryMock.Object, _bookRepositoryMock.Object);

            //Act
            Action action = () => quizService.GenerateQuiz(15);

            //Assert
            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithMessage($"A kérdések száma nem lehet több, mint {maxNumberOfBooksInDatabase}!");
        }

        [Fact]
        public void GetNextQuestion()
        {
            //Arrange
            const int maxNumberOfBooksInDatabase = 12;
            const int numberOfQuestionsWanted = 10;
            var question = _fixture.Create<Question>();
            var quizService = new QuizService(_questionFactoryMock.Object, _bookRepositoryMock.Object);

            _bookRepositoryMock
                .Setup(bookRepository => bookRepository.GetAllBookIds())
                .Returns(new int[maxNumberOfBooksInDatabase]);
            _questionFactoryMock.
                Setup(questionRepository => questionRepository.GetQuestion(It.IsAny<int>()))
                .Returns(question);

            //Act
            quizService.GenerateQuiz(numberOfQuestionsWanted);
            var nextQuestion = quizService.GetNextQuestion();

            //Assert
            quizService.GetProgression().Should().Be(1);
            nextQuestion.Should().BeEquivalentTo(question);
        }

        [Fact]
        public void UserChoseTheCorrectAnswer()
        {
            //Arrange
            const int maxNumberOfBooksInDatabase = 12;
            const int numberOfQuestionsWanted = 10;
            var question = _fixture.Create<Question>();
            var quizService = new QuizService(_questionFactoryMock.Object, _bookRepositoryMock.Object);
            _bookRepositoryMock
                .Setup(bookRepository => bookRepository.GetAllBookIds())
                .Returns(new int[maxNumberOfBooksInDatabase]);
            _questionFactoryMock.
                Setup(questionRepository => questionRepository.GetQuestion(It.IsAny<int>()))
                .Returns(question);

            //Act
            quizService.GenerateQuiz(numberOfQuestionsWanted);
            quizService.GetNextQuestion();
            var answer = quizService.CheckAnswer(question.Answers.Single(a => a.Value == true).Key);

            //Assert
            answer.Should().BeTrue();
            quizService.NumberOfCorrectlyAnsweredQuestions().Should().Be(1);
        }

        [Fact]
        public void UserChoseTheWrongAnswer()
        {
            //Arrange
            const int maxNumberOfBooksInDatabase = 12;
            const int numberOfQuestionsWanted = 10;
            var question = _fixture.Create<Question>();
            var quizService = new QuizService(_questionFactoryMock.Object, _bookRepositoryMock.Object);
            _bookRepositoryMock
                .Setup(bookRepository => bookRepository.GetAllBookIds())
                .Returns(new int[maxNumberOfBooksInDatabase]);
            _questionFactoryMock.
                Setup(questionRepository => questionRepository.GetQuestion(It.IsAny<int>()))
                .Returns(question);

            //Act
            quizService.GenerateQuiz(numberOfQuestionsWanted);
            quizService.GetNextQuestion();
            var answer = quizService.CheckAnswer(It.IsAny<string>());

            //Assert
            answer.Should().BeFalse();
            quizService.NumberOfCorrectlyAnsweredQuestions().Should().Be(0);
        }
    }
}