using MarsRover.Entities;
using MarsRover.Interfaces;
using static System.Console;

namespace MarsRover
{
    public class Startup
    {
        private readonly ILocator _locator;

        public Startup(ILocator locator)
        {
            _locator = locator ?? throw new ArgumentNullException();
        }

        public void Run()
        {
            try
            {
                string plateauEdges = ReadLine();

                var edges = plateauEdges?.Split(" ").Cast<object>().ToArray();

                Plateau plateau = new(Convert.ToInt32(edges[0]), Convert.ToInt32(edges[1]));

                while (true)
                {
                    string roverLocation = ReadLine();

                    var roverInfo = roverLocation.Split(" ").Cast<object>().ToArray();

                    Rover rover = new Rover(Convert.ToInt32(roverInfo[0]), Convert.ToInt32(roverInfo[1]), Convert.ToString(roverInfo[2]));

                    string commands = ReadLine();

                    _locator.LocateRover(rover, plateau, commands);

                    WriteLine(rover);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
