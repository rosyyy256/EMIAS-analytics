using System;
using System.Linq;
using System.Windows;
using Microsoft.Win32;

namespace EMIAS_analytics
{
    public partial class MainWindow
    {
        private Tree _tree;
        
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
            if (string.IsNullOrEmpty(FilePath.Text)) return;
            SemdList.Items.Clear();
            _tree = DataHandler.GetAssociativeTreeFromCsv(FilePath.Text);
            PrintDepartmentsList(DataHandler.GetAssociativeTreeFromCsv(FilePath.Text).Dates.First().Key);
        }

        private void PrintDepartmentsList(DateTime date)
        {
            SemdList.Items.Clear();
            NextDateButton.IsEnabled = _tree.Dates.ContainsKey(date.AddDays(1));
            PreviousDateButton.IsEnabled = _tree.Dates.ContainsKey(date.AddDays(-1));
            Date.Content = $"{date.Day}.{date.Month}.{date.Year}";
            foreach (var department in _tree.Dates[date])
            {
                SemdList.Items.Add($"{department.Name} - {department.SemdCount}");
            }
        }

        private void PrintDoctorsList(object sender, RoutedEventArgs e)
        {
            var department = _tree.Dates[DateTime.Parse(Date.Content.ToString())][SemdList.SelectedIndex];
            SemdList.Items.Clear(); 
            foreach (var doctor in department.DoctorsList)
            {
                SemdList.Items.Add($"{doctor.Name} - {doctor.SemdCount}");
            }
        }

        private void SwitchToNextDate(object sender, RoutedEventArgs e) => PrintDepartmentsList(DateTime.Parse(Date.Content.ToString()).AddDays(1));

        private void SwitchToPreviousDate(object sender, RoutedEventArgs e) => PrintDepartmentsList(DateTime.Parse(Date.Content.ToString()).AddDays(-1));

        private void Back(object s, RoutedEventArgs e)
        {
            PrintDepartmentsList(DateTime.Parse(Date.Content.ToString()));
        }
    }
}