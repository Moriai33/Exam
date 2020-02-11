using Exam.Application.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Exam.Infrastructure
{
    public static class DependencyInjection
    {
        public static void RegisterInfrastructure(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IBookRepository, BookRepository>();
            serviceCollection.AddTransient<IQuestionFactory, QuestionFactory>();
            serviceCollection.AddTransient<IStatisticsRepository, StatisticsRepository>();
        }
    }
}