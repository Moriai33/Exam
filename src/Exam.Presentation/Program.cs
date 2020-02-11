using Exam.Application;
using Exam.Application.Interface;
using Exam.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Exam
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.RegisterApplication();
            serviceCollection.RegisterInfrastructure();
            var serviceProvider = serviceCollection.BuildServiceProvider();

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new MainForm(serviceProvider.GetRequiredService<IQuizService>(), serviceProvider.GetRequiredService<IStatisticsService>(), serviceProvider.GetRequiredService<IBookManagementService>()));
        }
    }
}