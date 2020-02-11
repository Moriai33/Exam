using System.Collections.Generic;

namespace Exam.Domain
{
    public class Question
    {
        public string QuestionData { get; }
        public Dictionary<string, bool> Answers { get; }

        public Question(string questionData, string goodAnswer, string wrongAnswer1, string wrongAnswer2, string wrongAnswer3)
        { 
            QuestionData = questionData;
            Answers = new Dictionary<string, bool>();           
            Answers.Add(goodAnswer, true);
            Answers.Add(wrongAnswer1, false);
            Answers.Add(wrongAnswer2, false);
            Answers.Add(wrongAnswer3, false);
        }
    }
}