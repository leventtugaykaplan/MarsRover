using MarsRover.Entities;

namespace MarsRover.Interfaces
{
    public interface ICommandStrategy
    {
        void RunCommand(Rover rover);
    }
}
