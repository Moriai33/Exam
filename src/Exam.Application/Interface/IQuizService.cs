using Exam.Domain;

namespace Exam.Application.Interface
{
    public interface IQuizService
    {
        void GenerateQuiz(int numberOfQuestions);
        Question GetNextQuestion();
        bool CheckAnswer(string answer);
        bool IsLastQuestion();
        int GetProgression();
        int NumberOfCorrectlyAnsweredQuestions();
        int GetMaxNumberOfQuestions();
    }
}