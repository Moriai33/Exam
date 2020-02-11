using Exam.Application.Interface;
using System;
using System.Windows.Forms;

namespace Exam
{
    public partial class MainForm : Form
    {
        private readonly IQuizService _quizService;
        private readonly IStatisticsService _statisticsService;
        private readonly IBookManagementService _bookManagementService;        
        private const int numberOfBeginnerQuestions = 10;
        private const int numberOfAdvancedQuestions = 25;

        public MainForm(IQuizService quizService, IStatisticsService statisticsService, IBookManagementService bookManagementService)
        {
            InitializeComponent();
            _quizService = quizService;
            _statisticsService = statisticsService;
            _bookManagementService = bookManagementService;            
        }

        private void BeginnerToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            mainPanel.Controls.Clear();
            _quizService.GenerateQuiz(numberOfBeginnerQuestions);
            NewForm(new GameForm(_quizService, _statisticsService));           
        }

        private void AdvancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            _quizService.GenerateQuiz(numberOfAdvancedQuestions);
            NewForm(new GameForm(_quizService, _statisticsService));
        }

        private void CustomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            var numberOfQuestionsText = "";
            var inputBox = new InputBox();
            var inputNotANumber = true;
            
            while (inputNotANumber)
            {
                var dialogResult = inputBox.Show(PresentationResource.MainForm_Menu_NewGame_Custom_Questions, ref numberOfQuestionsText);

                if (dialogResult == DialogResult.Cancel)
                {
                    break;
                }

                if (int.TryParse(numberOfQuestionsText, out var numberOfQuestions))
                {
                    try
                    {
                        _quizService.GenerateQuiz(numberOfQuestions);
                        inputNotANumber = false;
                        NewForm(new GameForm(_quizService, _statisticsService));
                    }
                    catch (ArgumentOutOfRangeException exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
                else
                {
                    MessageBox.Show(PresentationResource.MainForm_Menu_NewGame_Custom_Error);
                    numberOfQuestionsText = "";
                }
            }
        }

        public void NewForm(Form form)
        {
            var newForm = form;
            newForm.TopLevel = false;
            mainPanel.Controls.Add(newForm);
            newForm.Show();
        }

        private void AddDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            NewForm(new DataManagementForm(_bookManagementService));
        }

        private void StatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            NewForm(new StatisticsForm(_statisticsService));
        }
    }
}