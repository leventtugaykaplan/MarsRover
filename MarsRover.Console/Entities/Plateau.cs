namespace MarsRover.Entities
{
    public class Plateau
    {
        public Coordination OriginCoordinationPoint { private set; get; }
        public Coordination EdgeCoordinationPoint { private set; get; }

        public Plateau(int edgeX, int edgeY)
        {
            OriginCoordinationPoint = new Coordination(0, 0);
            EdgeCoordinationPoint = new Coordination(edgeX, edgeY);
        }
    }
}
