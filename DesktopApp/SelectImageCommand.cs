using Microsoft.Win32;
using System.Windows.Input;
using System;

public class SelectImageCommand : ICommand
{
    private readonly Action<object> _execute;
    private readonly OpenFileDialog _openFileDialog;

    public SelectImageCommand(Action<object> execute, OpenFileDialog openFileDialog)
    {
        _execute = execute;
        _openFileDialog = openFileDialog;
    }

    public event EventHandler CanExecuteChanged;

    public bool CanExecute(object parameter)
    {
        return true;
    }

    public void Execute(object parameter)
    {
        
        Nullable<bool> result = _openFileDialog.ShowDialog();
        if (result == true)
        {
            string filename = _openFileDialog.FileName;
            _execute(filename);
        }
    }
}
