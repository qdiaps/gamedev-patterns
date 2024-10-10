using System.Collections.Generic;
using Patterns.Command.Scripts.Command;

namespace Patterns.Command.Scripts
{
    public class UnitCommandHandler
    {
        private readonly List<ICommand> _commands = new List<ICommand>();
        
        public void AddCommand(ICommand command) => 
            _commands.Add(command);

        public void ExecuteAllCommands()
        {
            var commands = _commands.ToArray();
            _commands.Clear();
            foreach (var command in commands)
                command.Execute();
        }
    }
}