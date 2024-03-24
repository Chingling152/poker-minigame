using System;
using System.Collections.Generic;
using UnityEngine;

public class DealerCommandHandler : MonoBehaviour
{
    [SerializeField]
    private Queue<DealerCommand> commands;

    public event Action<DealerCommand> OnExecuteCommand;

    private DealerCommand currentCommand;

    private void Awake()
    {
        commands = new Queue<DealerCommand>();
        currentCommand = null;
    }

    private void Update()
    {
        if (currentCommand == null || currentCommand.IsFinished)
        {
            if (this.commands.TryDequeue(out var command))
            {
                this.currentCommand = command;
                command.Execute();
                this.OnExecuteCommand?.Invoke(command);
            }
        }
    }

    public void AddCommand(DealerCommand command)
    {
        this.commands.Enqueue(command);
    }
}
