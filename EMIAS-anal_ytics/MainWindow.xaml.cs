using System.Linq;
using System.Windows;
using Microsoft.Win32;

namespace EMIAS_anal_ytics
{
    public partial class MainWindow
    {
        private Node _node;
        
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void OverviewButtonClick(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                FilePath.Text = openFileDialog.FileName;
            }
        }

        private void StartButtonClick(object sender, RoutedEventArgs e)
        {
            SemdList.Items.Clear();
            _node = DataHandler.GetAssociativeTreeFromCsv(FilePath.Text);
            PrintDepartmentsList(DataHandler.GetAssociativeTreeFromCsv(FilePath.Text).Dates.First().Key);
        }

        private void PrintDepartmentsList(string date)
        {
            Date.Content = date;
            foreach (var department in _node.Dates[date])
            {
                SemdList.Items.Add($"{department.Name} - {department.SemdCount}");
            }
        }
    }
}