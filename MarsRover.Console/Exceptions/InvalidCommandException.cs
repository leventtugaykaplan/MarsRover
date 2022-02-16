namespace MarsRover.Exceptions
{
    public class InvalidCommandException : Exception
    {
        public InvalidCommandException(string message) : base(message) { }
        public InvalidCommandException(string message, Exception inner) : base(message, inner) { }
    }
}
