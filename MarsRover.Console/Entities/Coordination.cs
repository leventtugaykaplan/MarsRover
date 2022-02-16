namespace MarsRover.Entities
{
    public class Coordination
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordination(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Coordination c = obj as Coordination;
            if ((object)c == null)
                return false;

            return (X == c.X) && (Y == c.Y);
        }

        public bool Equals(Coordination c)
        {
            if ((object)c == null)
                return false;

            return (X == c.X) && (Y == c.Y);
        }

        public static bool operator ==(Coordination c1, Coordination c2)
        {
            if (ReferenceEquals(c1, c2))
                return true;

            if ((object)c1 == null || (object)c2 == null)
                return false;

            return c1.X == c2.X && c1.Y == c2.Y;
        }

        public static bool operator !=(Coordination c1, Coordination c2)
        {
            return !(c1 == c2);
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
    }
}
