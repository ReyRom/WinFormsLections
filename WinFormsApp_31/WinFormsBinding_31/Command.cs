using System.Windows.Input;

namespace WinFormsBinding_31
{
    public class Command : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        Action<object?> action;

        public Command(Action<object?> action)
        {
            this.action = action;
        }

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter) => action?.Invoke(parameter);
    }
}
