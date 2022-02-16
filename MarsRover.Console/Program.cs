using MarsRover.Enums;
using MarsRover.Implementations;
using MarsRover.Implementations.Strategy;
using MarsRover.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MarsRover
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            host.Services.GetRequiredService<Startup>().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureServices(services =>
                services
                    .AddSingleton<Startup>()
                    .AddSingleton<ILocator, Locator>()
                    .AddSingleton<IDictionary<Command, ICommandStrategy>>(_ =>
                        new Dictionary<Command, ICommandStrategy>()
                        {
                            { Command.L, new LeftCommandStrategy() },
                            { Command.R, new RightCommandStrategy() },
                            { Command.M, new MoveCommandStrategy() }
                        }));
    }
}