using Exam.Application.Interface;
using Exam.Domain;
using System.Collections.Generic;

namespace Exam.Application
{
    internal class StatisticsService : IStatisticsService
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public StatisticsService(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }

        public void AddStatistics(Statistics statistics)
        {
            _statisticsRepository.AddStatistics(statistics);
        }

        public IEnumerable<Statistics> GetTopTenStatistics()
        {
            return _statisticsRepository.GetTopTenStatistics();
        }
    }
}