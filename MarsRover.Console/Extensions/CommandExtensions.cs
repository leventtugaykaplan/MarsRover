using MarsRover.Enums;
using MarsRover.Exceptions;

namespace MarsRover.Extensions
{
    public static class CommandExtensions
    {
        public static List<Command> ConvertToCommandEnum(this string commands)
        {
            List<Command> commandEnumList = new List<Command>();
            foreach (var command in commands)
            {
                if (!Enum.TryParse(command.ToString(), out Command commandEnum))
                {
                    throw new InvalidCommandException($"Invalid command: {(Command)command}");
                }

                commandEnumList.Add(commandEnum);
            }

            return commandEnumList;
        }
    }
}
