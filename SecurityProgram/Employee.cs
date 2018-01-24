using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SecurityProgram
{
   public class Employee : INotifyPropertyChanged
    {
        private string name;
        private string lastName;
        private string midleName;
        private string position;
        private Dictionary<string, bool> isWorked;
        public string Name {
            get
            {
                return name;
            }
            set
            {
                if (value != name)
                {
                    name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value != lastName)
                {
                    lastName = value;
                    NotifyPropertyChanged("LastName");
                }
            }
        }
        public string MidleName
        {
            get
            {
                return midleName;
            }
            set
            {
                if (value != midleName)
                {
                    midleName = value;
                    NotifyPropertyChanged("MidleName");
                }
            }
        }
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                if (value != position)
                {
                    position = value;
                    NotifyPropertyChanged("Position");
                }
            }
        }
        public Dictionary<string, bool> IsWorked
        {
            get
            {
                return isWorked;
            }
            set
            {
                if (value != isWorked)
                {
                    isWorked = value;
                    NotifyPropertyChanged("IsWorked");
                }
            }
        }
        public Employee()
        {
            IsWorked = new Dictionary<string, bool>();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName]string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} - {3}", LastName, Name, MidleName, Position);
        }
    }
}
