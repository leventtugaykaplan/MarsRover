using MarsRover.Entities;
using MarsRover.Enums;
using MarsRover.Exceptions;
using MarsRover.Extensions;
using MarsRover.Interfaces;

namespace MarsRover.Implementations
{
    public class Locator : ILocator
    {
        private readonly IDictionary<Command, ICommandStrategy> _commandStrategy;

        public Locator(IDictionary<Command, ICommandStrategy> commandStrategy)
        {
            _commandStrategy = commandStrategy ?? throw new ArgumentNullException(nameof(commandStrategy));
        }

        public void LocateRover(Rover rover, Plateau plateau, string commands)
        {
            try
            {
                var commandEnumList = commands.ConvertToCommandEnum();

                foreach (var commandEnum in commandEnumList)
                {
                    if (!_commandStrategy.TryGetValue(commandEnum, out ICommandStrategy strategy))
                    {
                        throw new InvalidCommandException($"Invalid command: {commandEnum}");
                    }

                    strategy.RunCommand(rover);

                    if (rover.IsOutOfPlateau(plateau))
                    {
                        throw new OutOfPlateauException($"The rover, has id {rover.Id}, is out of plateau. Current Coordination : {rover.Coordination.X} {rover.Coordination.Y} {rover.Orientation}");
                    }
                }
            }
            catch (OutOfPlateauException ex)
            {
                throw;
            }
            catch (InvalidCommandException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
