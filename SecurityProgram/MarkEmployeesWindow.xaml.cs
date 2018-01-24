using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace SecurityProgram
{
    /// <summary>
    /// Логика взаимодействия для MarkEmployeesWindow.xaml
    /// </summary>
    public partial class MarkEmployeesWindow : Window
    {
        private ObservableCollection<Employee> employees;
        private string date;
        private string pathToFile;
        public MarkEmployeesWindow(ObservableCollection<Employee> employees)
        {
            InitializeComponent();
            const string FILE_NAME = "Employees.txt";
            this.employees = employees;
            datePicker.DisplayDateEnd = DateTime.Now;
            datePicker.SelectedDate = DateTime.Now.Date;
            pathToFile = Directory.GetCurrentDirectory() + @"\" + FILE_NAME;
            dataGrid.ItemsSource = this.employees;
        }
        private void SaveEmployees()
        {
            using (FileStream fileStream = new FileStream(pathToFile, FileMode.Create))
            {
                using (StreamWriter stream = new StreamWriter(fileStream))
                {
                    using (JsonTextWriter writer = new JsonTextWriter(stream))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(writer, employees);
                    }
                }
            }
        }
        private void DataGridSelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            SaveEmployees();
        }
        private void DatePickerSelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            date = datePicker.SelectedDate.Value.ToShortDateString();
            for(int i = 0; i < employees.Count; i++)
            {
                if (!employees[i].IsWorked.ContainsKey(date))
                {
                    employees[i].IsWorked.Add(date, false);
                }
            }
            Binding binding = new Binding();
            binding.Path = new PropertyPath("IsWorked[" + date + "]");
            checkBoxColumn.Binding = binding;
        }
    }
}
