using System;
using System.Windows.Input;

namespace Record_Book_MVVM.Commands
{
  public class RelayCommand : ICommand
  {
    public event EventHandler? CanExecuteChanged;

    private Action<object> _Excute { get; set; }

    private Predicate<object> _CanExcute { get; set; }

    public RelayCommand(Action<object> ExcuteMethod, Predicate<object> CanExcuteMethod)
    {
      _Excute = ExcuteMethod;
      _CanExcute = CanExcuteMethod;
    }

    public bool CanExecute(object? parameter)
    {
      return _CanExcute(parameter);
    }

    public void Execute(object? parameter)
    {
      _Excute(parameter);
    }
  }
}
