using Exam.Domain;
using System.Collections.Generic;

namespace Exam.Application.Interface
{
    public interface IStatisticsRepository
    {
        IEnumerable<Statistics> GetTopTenStatistics();
        void AddStatistics(Statistics statistics);
    }
}