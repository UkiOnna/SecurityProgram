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

namespace SecurityProgram
{
    /// <summary>
    /// Логика взаимодействия для AttendanceWindow.xaml
    /// </summary>
    public partial class AttendanceWindow : Window
    {
        private List<Worker> workers;
        private string date;

        public AttendanceWindow()
        {
            InitializeComponent();
        }

        public AttendanceWindow(List<Worker>work)
        {
            InitializeComponent();
            workers = work;
            DataContainer.ItemsSource = workers;
            
        }

        //private void AttendanceWindowClosed(object sender, EventArgs e)
        //{
        //    string path = Directory.GetCurrentDirectory() + "/workersComing.txt";
        //    using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
        //    {
        //        // записываем в файл значение каждого поля структуры
        //        foreach (Worker s in workers)
        //        {
        //            writer.Write(s.FIO);
        //            writer.Write(s.Post);
        //            writer.Write(currentDate.SelectedDate.ToString());
        //            int selectedColumn = DataContainer.CurrentCell.Column.DisplayIndex;
        //            //writer.Write()
        //        }
        //    }
        //}

        

        private void DataContainerCurrentCellChanged(object sender, EventArgs e)
        {
           
        }

        private void SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (currentDate.SelectedDate != null)
            {
                date = currentDate.SelectedDate.Value.ToShortDateString();
                for (int i = 0; i < workers.Count; i++)
                {
                    if (!workers[i].isWorked.ContainsKey(date))
                    {
                        workers[i].isWorked.Add(date, false);
                    }
                }
                Binding binding = new Binding();
                binding.Path = new PropertyPath("isWorked[" + date + "]");
                checkBox.Binding = binding;
            }
        }
    }
}
