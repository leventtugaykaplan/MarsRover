using System.ComponentModel;

namespace MarsRover.Enums
{
    public enum Command
    {
        [Description("Left")]
        L = 1,
        [Description("Right")]
        R = 2,
        [Description("Move")]
        M = 3
    }
}
