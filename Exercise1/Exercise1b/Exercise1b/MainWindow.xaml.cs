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
            FileHandler.ShowPeople(employees, EmployeeListBox);
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            if (FileHandler.AddPerson(employees, EmployeeListBox, TextBoxNamn, TextBoxFData, TextBoxHourlyRate))
            {
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
            FileHandler.RemovePerson(employees, EmployeeListBox);
        }

        private void EmployeeListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FileHandler.SelectPerson(EmployeeListBox, TextBoxNamn, TextBoxFData, TextBoxHourlyRate);
        }
    }
}
