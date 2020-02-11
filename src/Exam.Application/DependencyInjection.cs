using Exam.Application.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Exam.Application
{
    public static class DependencyInjection
    {
        public static void RegisterApplication(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IQuizService, QuizService>();
            serviceCollection.AddTransient<IStatisticsService, StatisticsService>();
            serviceCollection.AddTransient<IBookManagementService, BookManagementService>();
        }
    }
}