using MarsRover.Entities;
using MarsRover.Enums;
using MarsRover.Exceptions;
using MarsRover.Interfaces;

namespace MarsRover.Implementations.Strategy
{
    public class MoveCommandStrategy : ICommandStrategy
    {
        public void RunCommand(Rover rover)
        {
            switch (rover.Orientation)
            {
                case CompassCardinalPoint.N:
                        rover.Coordination.Y++;
                    break;
                case CompassCardinalPoint.E:
                        rover.Coordination.X++;
                    break;
                case CompassCardinalPoint.S:
                        rover.Coordination.Y--;
                    break;
                case CompassCardinalPoint.W:
                        rover.Coordination.X--;
                    break;
                default:
                    throw new InvalidDirectionException("Invalid move direction");
            }
        }
    }
}
