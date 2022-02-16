using MarsRover.Entities;
using MarsRover.Enums;
using MarsRover.Interfaces;

namespace MarsRover.Implementations.Strategy
{
    public class LeftCommandStrategy : ICommandStrategy
    {
        private readonly int CardinalPointLength = Enum.GetValues(typeof(CompassCardinalPoint)).Length;
        public void RunCommand(Rover rover)
        {
             rover.Orientation = (CompassCardinalPoint)(((int)rover.Orientation + (CardinalPointLength - 1)) % CardinalPointLength);
        }
    }
}
