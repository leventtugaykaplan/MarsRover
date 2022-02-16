namespace MarsRover.Exceptions
{
    public class InvalidCardinalPointException : Exception
    {
        public InvalidCardinalPointException(string message) : base(message) { }
        public InvalidCardinalPointException(string message, Exception inner) : base(message, inner) { }
    }
}
