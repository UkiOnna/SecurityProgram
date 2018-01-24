using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace SecurityProgram
{
    /// <summary>
    /// Логика взаимодействия для WorkerList.xaml
    /// </summary>
    public partial class WorkerList : Window
    {
        private ObservableCollection<Employee> employees;
        private string pathToFile;
        public WorkerList()
        {
            InitializeComponent();
            const string FILE_NAME = "Employees.txt";
            pathToFile = Directory.GetCurrentDirectory() + @"\" + FILE_NAME;
            using(FileStream fileStream = new FileStream(pathToFile,FileMode.OpenOrCreate))
            {
                using(StreamReader stream = new StreamReader(fileStream))
                {
                    using(JsonTextReader reader = new JsonTextReader(stream))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        employees = serializer.Deserialize<ObservableCollection<Employee>>(reader);
                        if (employees == null) employees = new ObservableCollection<Employee>();
                    }
                }
            }
            workersList.ItemsSource = employees;
        }
        private bool AllFieldsAreFull()
        {
            return nameTextBox.Text != "" && lastNameTextBox.Text != "" && midleNameTextBox.Text != "" && positionTextBox.Text != "";
        }
        private void WorkersListSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (workersList.SelectedItem != null)
            {
                nameTextBox.Text = (workersList.SelectedItem as Employee).Name;
                lastNameTextBox.Text = (workersList.SelectedItem as Employee).LastName;
                midleNameTextBox.Text = (workersList.SelectedItem as Employee).MidleName;
                positionTextBox.Text = (workersList.SelectedItem as Employee).Position;
            }
        }
        private void SaveEmployees()
        {
            using(FileStream fileStream = new FileStream(pathToFile,FileMode.Create))
            {
                using(StreamWriter stream = new StreamWriter(fileStream))
                {
                    using(JsonTextWriter writer = new JsonTextWriter(stream))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(writer, employees);
                    }
                }
            }
        }
        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            if (AllFieldsAreFull())
            {
                employees.Add(new Employee()
                {
                    Name = nameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    MidleName = midleNameTextBox.Text,
                    Position = positionTextBox.Text
                });
                SaveEmployees();
            }
            else
            {
                MessageBox.Show("Необходимо заполнить все поля.");
            }
        }
        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            if (workersList.SelectedItem != null)
            {
                employees.Remove(workersList.SelectedItem as Employee);
                SaveEmployees();
            }
        }
        private void UpdateButtonClick(object sender, RoutedEventArgs e)
        {
            if (workersList.SelectedItem != null)
            {
                (workersList.SelectedItem as Employee).Name = nameTextBox.Text;
                (workersList.SelectedItem as Employee).LastName = lastNameTextBox.Text;
                (workersList.SelectedItem as Employee).MidleName = midleNameTextBox.Text;
                (workersList.SelectedItem as Employee).Position = positionTextBox.Text;

                workersList.ItemsSource = null;
                workersList.ItemsSource = employees;

                SaveEmployees();
            }
        }
        private void MarkEmployeesButtonClick(object sender, RoutedEventArgs e)
        {
            new MarkEmployeesWindow(employees).Show();
            Close();
        }
    }
}
