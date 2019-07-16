using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DrDanDongusBot.Modules
{
    public class GoodBoy : ModuleBase<SocketCommandContext>
    {
        [Command("Who's a good boy?")]
        public async Task DockAsync()
        {
            await ReplyAsync("Dockadoodle!");
        }
    }
}
