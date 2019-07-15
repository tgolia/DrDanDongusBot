using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DrDanDongusBot.Modules
{
    public class Ping : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task PingAsync()
        {
            await ReplyAsync("Hello World!");
        }

        [Command("Who's a good boy?")]
        public async Task DockAsync()
        {
            await ReplyAsync("Dockadoodle!");
        }
    }
}
