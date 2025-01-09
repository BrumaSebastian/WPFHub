using System.Windows.Input;

namespace HubApp.Models
{
    class ButtonModel
    {
        public string Name { get; set; }
        public ICommand Command { get; set; }
    }
}
