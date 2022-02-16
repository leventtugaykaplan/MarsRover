using MarsRover.Entities;

namespace MarsRover.Extensions
{
    public static class RoverExtensions
    {
        public static bool IsOutOfPlateau(this Rover rover, Plateau plateau)
        {
            return
                rover.Coordination.X < plateau.OriginCoordinationPoint.X ||
                rover.Coordination.X > plateau.EdgeCoordinationPoint.X ||
                rover.Coordination.Y < plateau.OriginCoordinationPoint.Y ||
                rover.Coordination.Y > plateau.EdgeCoordinationPoint.Y;
        }
    }
}
