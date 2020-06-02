using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace TapGestureRecognizerBug
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand DeleteCommand => new Command<Person>(DeletePerson);
        public ObservableCollection<Person> People { get; private set; } = new ObservableCollection<Person>();
        public PersonViewModel()
        {
            People.Add(new Person("Steve", 21));
            People.Add(new Person("John", 42));
            People.Add(new Person("Tom", 29));
            People.Add(new Person("Lucas", 29));
            People.Add(new Person("Jane", 30));
            OnPropertyChanged("PersonViewModel");
        }
        private void DeletePerson(Person obj)
        {
            Xamarin.Forms.Application.Current.MainPage.DisplayAlert("DeleteCommand", obj?.Name, "Ok");
            OnPropertyChanged("DeletePerson");
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
