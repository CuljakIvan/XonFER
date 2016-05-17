using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Zadatko2.Annotations;
using Zadatko2.Models;

namespace Zadatko2.Services
{
    public class DataService:INotifyPropertyChanged
    {
        private List<Person> _persons;

        public List<Person> Persons
        {
            get { return _persons;}
            set
            {
                if (_persons != value)
                {
                    _persons = value;
                    OnPropertyChanged();
                }
            }
        }

        public DataService()
        {
            _persons = new List<Person>()
            {
                new Person() {Name = "1", Surname = "jedan"},
                new Person() {Name = "2", Surname = "dva"},
                new Person() {Name = "3", Surname = "tri"},
                new Person() {Name = "4", Surname = "četiri"},
                new Person() {Name = "5", Surname = "pet"},
                new Person() {Name = "6", Surname = "šest"}
            };
        }

        public void AddPerson(Person person)
        {
            Persons.Add(person);
            OnPropertyChanged(nameof(Persons));
        }



        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
