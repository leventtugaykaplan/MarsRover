using MarsRover.Enums;
using MarsRover.Exceptions;

namespace MarsRover.Extensions
{
    public static class CardinalPointExtensions
    {
        public static CompassCardinalPoint ConvertToCardinalPointEnum(this string orientation)
        {
            CompassCardinalPoint cardinals;
            if (Enum.TryParse(orientation, out cardinals))
            {
                return cardinals;
            }
            else
            {
                throw new InvalidCardinalPointException("Invalid cardinal point entered");
            }
        }
    }
}
