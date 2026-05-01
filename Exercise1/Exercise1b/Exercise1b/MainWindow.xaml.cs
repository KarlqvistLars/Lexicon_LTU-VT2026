using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Exercise1b
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Employee> employees = new List<Employee>();
        string installationPath = Environment.GetCommandLineArgs()[0].Replace("Exercise1b.exe", "dbfile.txt");
        
        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists(installationPath))
            {
                employees = FileHandler.LoadPeople(installationPath);            
            }
        }

        private void OK_Button_Click(object sender, RoutedEventArgs e)
        {
            Employee newPerson = new Employee(TextBoxNamn.Text, TextBoxFData.Text, TextBoxHourlyRate.Text);
            FileHandler.AddPerson(employees, newPerson);
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            FileHandler.ShowPeople(employees);
        }
    }
}
