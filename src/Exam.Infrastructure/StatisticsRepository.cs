using Dapper;
using Exam.Application.Interface;
using Exam.Domain;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;

namespace Exam.Infrastructure
{
    internal class StatisticsRepository : IStatisticsRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["QuestionDb"].ConnectionString;

        public void AddStatistics(Statistics statistics)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                const string query = "INSERT INTO Statistics (Name, CorrectAnswers, WrongAnswers, GoodPercent) VALUES (@name, @correctAnswers, @wrongAnswers, @goodPercent) ";
                connection.Execute(
                    query,
                    param: new
                    {
                        name = statistics.Name,
                        correctAnswers = statistics.CorrectAnswers,
                        wrongAnswers = statistics.WrongAnswers,
                        goodPercent = statistics.GoodPercent
                    });
            }
        }

        public IEnumerable<Statistics> GetTopTenStatistics()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                const string query = "SELECT Name, CorrectAnswers, WrongAnswers FROM Statistics ORDER BY GoodPercent DESC LIMIT 10";
                var statistics = connection.Query<(string Name, int CorrectAnswers, int WrongAnswers)>(query);

                return statistics.Select(s => new Statistics(s.Name, s.CorrectAnswers, s.WrongAnswers));
            }
        }
    }
}