using System;
using System.Collections.Generic;
using UnityEngine;
using CardMiniGame.Utils.Commands;

namespace CardMiniGame.Core.Dealers.Commands
{
    public class DealerCommandHandler : MonoBehaviour, ICommandHandler<DealerCommand>
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
                if (commands.TryDequeue(out var command))
                {
                    currentCommand = command;
                    command.Execute();
                    OnExecuteCommand?.Invoke(command);
                }
            }
        }

        public void AddCommand(DealerCommand command)
        {
            commands.Enqueue(command);
        }
    }
}