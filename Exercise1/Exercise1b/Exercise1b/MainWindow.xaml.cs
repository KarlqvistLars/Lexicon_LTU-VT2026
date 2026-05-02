using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Exercise1b
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
#pragma warning disable IDE0044 // Add readonly modifier
        private List<Employee> employees = new List<Employee>();
#pragma warning restore IDE0044 // Add readonly modifier
        readonly string installationPath = Environment.GetCommandLineArgs()[0].Replace("Exercise1b.exe", "dbfile.txt");
        
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            if (File.Exists(installationPath))
            {
                employees = FileHandler.LoadPeople(installationPath);            
            }
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            Employee newPerson = new Employee(TextBoxNamn.Text, TextBoxFData.Text, TextBoxHourlyRate.Text);
            if (TextBoxNamn.Text != "" && TextBoxFData.Text != "" && TextBoxHourlyRate.Text != "")
            {
                FileHandler.AddPerson(employees, newPerson);
                TextBoxNamn.Text = "";
                TextBoxFData.Text = "";
                TextBoxHourlyRate.Text = "";
                FileHandler.ShowPeople(employees, EmployeeListBox);
            }
            else
            {
                MessageBox.Show(this,"Alla fält ej ifyllda!", "Felaktig inmatning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Show_Button_Click(object sender, RoutedEventArgs e)
        {
            FileHandler.ShowPeople(employees, EmployeeListBox);
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Remove_Button_Click(object sender, RoutedEventArgs e)
        {
            FileHandler.ShowPeople(employees, EmployeeListBox);
        }

        private void EmployeeListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EmployeeListBox.SelectedItem != null)
            {
                var selectedEmployee = EmployeeListBox.SelectedItem.ToString()?.Split(null as char[], StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();
                TextBoxNamn.Text = selectedEmployee[0];
                TextBoxFData.Text = selectedEmployee[1];
                TextBoxHourlyRate.Text = selectedEmployee[2];
            }
        }
    }
}
