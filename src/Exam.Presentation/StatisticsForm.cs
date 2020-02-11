using Exam.Application.Interface;
using System.Windows.Forms;

namespace Exam
{
    public partial class StatisticsForm : Form
    {
        private readonly IStatisticsService _statisticsService;
        public StatisticsForm(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;
            InitializeComponent();
        }

        private void Statistic_Load(object sender, System.EventArgs e)
        {
            var bindingSource = new BindingSource
            {
                DataSource = _statisticsService.GetTopTenStatistics()
            };
            statisticsGridView.DataSource = bindingSource;
        }

        private void statisticsFormCloseButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}