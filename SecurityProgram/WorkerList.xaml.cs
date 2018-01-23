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
    /// Логика взаимодействия для WorkerList.xaml
    /// </summary>
    public partial class WorkerList : Window
    {
        private List<Worker> workers;

        public WorkerList()
        {
            InitializeComponent();
            workers = new List<Worker>();
            ReadFiles();
            //Worker worker = new Worker();
            //worker.FIO = "Алексей Епта Иванович";
            //worker.Post = "Отреченный";
            //workers.Add(worker);
            foreach (Worker c in workers)
            {
                ListWorkers.Items.Add(c.FIO + " - " + c.Post);
            }



        }

        private void WorkersWindowClosed(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + "/workers.txt";
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                // записываем в файл значение каждого поля структуры
                foreach (Worker s in workers)
                {
                    writer.Write(s.FIO);
                    writer.Write(s.Post);
                }
            }
        }

        private void AddPostGotMouseCapture(object sender, MouseEventArgs e)
        {
            AddPost.Text = null;
        }

        private void AddFioGotMouseCapture(object sender, MouseEventArgs e)
        {
            AddFio.Text = null;
        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            if (AddPost.Text != null && AddPost.Text != "Должность" && AddFio.Text != null && AddFio.Text != "ФИО")
            {
                Worker worker = new Worker();
                worker.FIO = AddFio.Text;
                worker.Post = AddPost.Text;
                workers.Add(worker);
                ListWorkers.Items.Add(worker.FIO + " - " + worker.Post);
            }
            else
            {
                MessageBox.Show("Вы неправильно ввели данные работника");
            }
        }

        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            int index = ListWorkers.SelectedIndex;
            if (index != -1)
            {
                workers.RemoveAt(index);
                ListWorkers.Items.RemoveAt(index);
            }
        }

        private void ReadFiles()
        {
            string path = Directory.GetCurrentDirectory() + "/workers.txt";
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {

                while (reader.PeekChar() > -1)
                {
                    Worker temp = new Worker();
                    temp.FIO = reader.ReadString();
                    temp.Post = reader.ReadString();
                    workers.Add(temp);
                }
            }
        }

        private void attendanceButtonClick(object sender, RoutedEventArgs e)
        {
            new AttendanceWindow(workers).Show();
            workersWindow.Close();
            
        }
    }
}
