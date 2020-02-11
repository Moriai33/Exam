using Exam.Application.Interface;
using Exam.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Exam
{
    public partial class GameForm : Form
    {
        private readonly IQuizService _quizService;
        private readonly IStatisticsService _statisticsService;
        private readonly List<RadioButton> _radioButtonList = new List<RadioButton>();
        private string _name;

        public GameForm(IQuizService quizService, IStatisticsService statisticsService)
        {
            InitializeComponent();
            _quizService = quizService;
            _statisticsService = statisticsService;
            _radioButtonList.Add(answerOneRadioButton);
            _radioButtonList.Add(answerTwoRadioButton);
            _radioButtonList.Add(answerThreeRadioButton);
            _radioButtonList.Add(answerFourRadioButton);
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            var selectedAnswer = _radioButtonList.SingleOrDefault(radioButton => radioButton.Checked);
            if (selectedAnswer != null)
            {
                _quizService.CheckAnswer(selectedAnswer.Text);
            }
            if (_quizService.IsLastQuestion())
            {
                var correctAnswers = _quizService.NumberOfCorrectlyAnsweredQuestions();
                var wrongAnswers = _quizService.GetMaxNumberOfQuestions() - correctAnswers;
                var statistics = new Statistics(_name, correctAnswers, wrongAnswers);
                _statisticsService.AddStatistics(statistics);
                MessageBox.Show(
                    string.Format(
                        PresentationResource.GameForm_CheckButton_Evaluation_1 + "\n" + PresentationResource.GameForm_CheckButton_Evaluation_2,
                        _name,
                        correctAnswers,
                        statistics.GoodPercent));

                Close();
            }
            GetNextQuestion();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            var inputBox = new InputBox();
            inputBox.Show(PresentationResource.GameForm_InputBox_Text, ref _name);
            RadioButtonListVisible(true);
            questionLabel.Visible = true;
            GetNextQuestion();
            maxQuestionNumberLabel.Text = _quizService.GetMaxNumberOfQuestions().ToString();
        }

        private void RadioButtonListVisible(bool visible)
        {
            foreach (var radioButton in _radioButtonList)
            {
                radioButton.Visible = visible;
            }
        }

        private void GetNextQuestion()
        {
            RadioButtonUnChecked();
            var question = _quizService.GetNextQuestion();
            WriteDataToScreen(question);
        }

        private void RadioButtonUnChecked()
        {
            var checkedRadioButton = _radioButtonList.SingleOrDefault(radioButton => radioButton.Checked);
            if (checkedRadioButton != null)
            {
                checkedRadioButton.Checked = false;
            }
        }

        private void WriteDataToScreen(Question question)
        {
            questionLabel.Text = string.Format(PresentationResource.GameForm_QuestionLabel, question.QuestionData);
            progressLabel.Text = _quizService.GetProgression().ToString();
            var rnd = new Random();
            var k = rnd.Next(0, 4);

            foreach (var answer in question.Answers)
            {
                _radioButtonList[k].Text = answer.Key;
                k = k == 3 ? 0 : k + 1;
            }
        }

        private void gameFormCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}