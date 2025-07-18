using System.Windows;

namespace LibScholarAssist
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnAnalyzeClick(object sender, RoutedEventArgs e)
        {
            string question = ResearchInput.Text;
            ResearchAnalyzer analyzer = new ResearchAnalyzer();
            string results = analyzer.AnalyzeFromUI(question);
            ResultOutput.Text = results;
        }
    }
}