using MarsRover.Entities;

namespace MarsRover.Interfaces
{
    public interface ILocator
    {
        void LocateRover(Rover rover, Plateau plateau, string commands);
    }
}
