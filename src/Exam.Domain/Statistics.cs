namespace Exam.Domain
{
    public class Statistics
    {
        public string Name { get; }
        public int CorrectAnswers { get; }
        public int WrongAnswers { get; }
        public double GoodPercent { get; }

        public Statistics(string name, int correctAnswers, int wrongAnswers)
        {
            Name = name;
            CorrectAnswers = correctAnswers;
            WrongAnswers = wrongAnswers;
            GoodPercent = (double)correctAnswers / (correctAnswers + wrongAnswers) * 100;
        }
    }
}