using MarsRover.Enums;
using MarsRover.Extensions;

namespace MarsRover.Entities
{
    public class Rover
    {
        public string Id { get; private set; }
        public Coordination Coordination { get; set; }
        public CompassCardinalPoint Orientation { get; set; }

        public Rover(int x, int y, string orientation)
        {
            Id = Guid.NewGuid().ToString()[^4..];
            Coordination = new Coordination(x, y);

            Orientation = orientation.ConvertToCardinalPointEnum();
        }

        public override string ToString()
        {
            return $"{Coordination.X} {Coordination.Y} {Orientation}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Rover r = obj as Rover;
            if (r is null)
                return false;

            return (Coordination == r.Coordination) && (Orientation == r.Orientation);
        }

        public bool Equals(Rover r)
        {
            if (r is null)
                return false;

            return (Coordination == r.Coordination) && (Orientation == r.Orientation);
        }

        public static bool operator ==(Rover r1, Rover r2)
        {
            if (ReferenceEquals(r1, r2))
                return true;

            if ((object)r1 == null || (object)r2 == null)
                return false;

            return r1.Coordination == r2.Coordination && r1.Orientation == r2.Orientation;
        }

        public static bool operator !=(Rover r1, Rover r2)
        {
            return !(r1 == r2);
        }

        public override int GetHashCode()
        {
            return Coordination.GetHashCode() ^ Orientation.GetHashCode();
        }
    }
}
