using System;
using System.Threading.Tasks;
using Discord.Commands;

namespace Merek
{
    public class TestModule : ModuleBase<SocketCommandContext>
    {
        private readonly Servicerino _service;

        public TestModule(Servicerino service)
        {
            _service = service;
        }

        [Command("ping")]
        [Summary("Pings the bot")]
        public Task SayAsync()
        {
            Console.WriteLine("Yes");
            _service.Yes();
            return ReplyAsync("pong");
        }
    }
}
