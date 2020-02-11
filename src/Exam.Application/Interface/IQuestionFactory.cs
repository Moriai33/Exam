using Exam.Domain;

namespace Exam.Application.Interface
{
    public interface IQuestionFactory
    {
        Question GetQuestion(int titleId);
    }
}