using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Zadatko2.Models;

namespace Zadatko2.ViewModels
{
    public class PersonsViewModel
    {
        public List<Person> Persons { get; set; } 

        public ICommand NewPersonCommand { get; set; }

        public ICommand PersonSelectedCommand { get; set; }

        public PersonsViewModel()
        {
            Persons = App.DataService.Persons;

            NewPersonCommand=new Command(AddNewPerson);
            PersonSelectedCommand=new Command(PersonSelected);
        }

        public void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            //DisplayAlert("Item Selected", e.SelectedItem.ToString(), "Ok");
            //((ListView)sender).SelectedItem = null; //uncomment line if you want to disable the visual selection state.
        }

        private void PersonSelected(object obj)
        {
            throw new NotImplementedException();
        }

        private void AddNewPerson()
        {
            throw new NotImplementedException();
        }
    }
}
