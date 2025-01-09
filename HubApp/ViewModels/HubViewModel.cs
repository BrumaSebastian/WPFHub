using System.Collections.ObjectModel;
using System.Windows;
using HubApp.Helpers;
using HubApp.Models;

namespace HubApp.ViewModels
{
    class HubViewModel
    {
        public ObservableCollection<ButtonModel> Buttons { get; set; }

        public HubViewModel()
        {
            Buttons = new ObservableCollection<ButtonModel>
            {
                new ButtonModel { Name = "Load plugin", Command = new RelayCommand(() => Buttons.Add(new ButtonModel { Name = "ihau", Command = new RelayCommand(() => ShowMessage("Pressed btn"))})) },
            };
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
