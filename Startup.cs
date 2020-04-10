using System;
using System.Threading.Tasks;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;

namespace Merek
{
    public static class Startup
    {
        public static async Task Main(string[] args)
        {
            var serviceProvider = BuildServiceProvider();
            
            //serviceProvider.GetService<Servicerino>().Yes();

            var merek = serviceProvider.GetService<Merek>();
            await merek.Start("Njk4MDU2ODE0ODg5MDA5MjAy.XpAVLA.WSRPQ70Bxuf7KyiTSi5hPNPdg54");
        }
        
        private static IServiceProvider BuildServiceProvider() => new ServiceCollection()
            .AddSingleton(new DiscordSocketClient())
            .AddSingleton(new CommandService())
            // Add services here
            .AddSingleton<Servicerino>()
            .AddSingleton<Merek>()
            .BuildServiceProvider();
    }
}