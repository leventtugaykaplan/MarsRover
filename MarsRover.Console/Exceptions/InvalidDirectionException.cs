namespace MarsRover.Exceptions
{
    internal class InvalidDirectionException : Exception
    {
        public InvalidDirectionException(string message) : base(message) { }
        public InvalidDirectionException(string message, Exception inner) : base(message, inner) { }
    }
}
