using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MonkeyGallery.Data;
using MonkeyGallery.Models;


namespace MonkeyGallery.ViewModels
{
    public class MonkeysPageViewModel : ViewModel
    {
        public Monkey Monkey { get; private set; }
        public ObservableCollection<Monkey> Monkeys { get; set; }

        private DataSource _dataSource;
        private Monkey selectedMonkey;
        public Monkey SelectedMonkey { get => selectedMonkey; set { selectedMonkey = value; OnPropertyChanged(); } }
        public ICommand SelectCommand { get; private set; }


        public MonkeysPageViewModel(DataSource dataSource)
        {
            _dataSource = dataSource;
            Monkeys = new ObservableCollection<Monkey>(_dataSource.GetMonkeys());
            SelectCommand = new Command(async () =>
            {
                var navigationParameter = new Dictionary<string, object>
            {
                { "Monkey", SelectedMonkey }
            };
                await Shell.Current.GoToAsync($"monkey", navigationParameter);
            });





        }
    }
}