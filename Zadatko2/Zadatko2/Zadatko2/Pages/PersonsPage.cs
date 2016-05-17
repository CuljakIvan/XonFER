using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Zadatko2.Models;
using Zadatko2.ViewModels;

namespace Zadatko2.Pages
{
    public class PersonsPage:ContentPage
    {
        public PersonsPage()
        {
            BindingContext=new PersonsViewModel();

            var dataTemplate = new DataTemplate(typeof (TextCell));
            dataTemplate.SetBinding(TextCell.TextProperty, nameof(Person.Name));
            dataTemplate.SetBinding(TextCell.DetailProperty, nameof(Person.Surname));

            var listView=new ListView() {ItemTemplate = dataTemplate, VerticalOptions = LayoutOptions.FillAndExpand};
            listView.SetBinding(ListView.ItemsSourceProperty, nameof(PersonsViewModel.Persons));
            listView.SetBinding(ListView.SelectedItemProperty, nameof(PersonsViewModel.OnSelection));

            var button = new Button()
            {Text = "Click me"};
            button.SetBinding(Button.CommandProperty, nameof(PersonsViewModel.NewPersonCommand));

            Content = new StackLayout()
            {Children = {listView, button}};
        }
    }
}
