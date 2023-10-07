using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Executor
{
    private Stack<ICommand> _commands;

    public Executor()
    {
        _commands = new Stack<ICommand>();
    }

    public void AddCommand(ICommand command)
    {
        _commands.Push(command);
        Debug.Log(_commands.Count);
    }

    public void AddAndExecuteCommand(ICommand command)
    {
        _commands.Push(command);
        command.Execute();
    }

    public void ExecuteOneCommand(ICommand command)
    {
        command.Execute();
    }

    public void UndoCommand()
    {
        if(_commands.Count <= 0)
            return;
        ICommand command = _commands.Pop();
        Debug.Log(_commands.Count);
        command.Undo();
    }

    public async void ExecuteAll()
    { 
        foreach (var command in _commands)
        {
            command.Execute();
            await Task.Delay(1000);
        }
    }

}
