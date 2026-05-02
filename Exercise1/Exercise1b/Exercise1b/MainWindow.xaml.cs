using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Exercise1b
{
    /// <summary>
    /// Utökning av Exercise1. Tillagt ett UI för att hantera anställda. Användaren kan lägga till, ta bort och spara anställda i en fil. Anställda visas i en ListView och detaljerna visas i TextBoxar när en anställd väljs. Data sparas automatiskt när programmet stängs.
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Employee> Employees { get; set; } = new ObservableCollection<Employee>();
        readonly string installationPath = Environment.GetCommandLineArgs()[0].Replace("Exercise1b.exe", "dbfile.txt");
        
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            if (File.Exists(installationPath))
            {
                Employees = FileHandler.LoadPeople(installationPath);            
            }
            DataContext = this;
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            if (FileHandler.AddPerson(Employees, EmployeeListView, TextBoxNamn, TextBoxFData, TextBoxHourlyRate))
            {
                FileHandler.SavePeople(Employees, installationPath);
            }
            else
            {
                MessageBox.Show(this,"Alla fält ej ifyllda!", "Felaktig inmatning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            FileHandler.SavePeople(Employees, installationPath);
            this.Close();
        }

        private void Remove_Button_Click(object sender, RoutedEventArgs e)
        {
            FileHandler.RemovePerson(Employees, EmployeeListView, TextBoxNamn, TextBoxFData, TextBoxHourlyRate);
        }

        private void EmployeeListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FileHandler.SelectPerson(EmployeeListView, TextBoxNamn, TextBoxFData, TextBoxHourlyRate);
        }

        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            TextBoxNamn.Clear();
            TextBoxFData.Clear();
            TextBoxHourlyRate.Clear();
        }
    }
}
