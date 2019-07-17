using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DrDanDongusBot.Modules
{
    public class YouTube : ModuleBase<SocketCommandContext>
    {
        [Command("yt")]
        public async Task PlayYouTubeAsync()
        {
            var author = Context.Message.Author;
            //var voiceChannel = author.Voice_Chan
            await ReplyAsync("YouTube rocks!");
        }
//        @client.command(pass_context=True)
//          async def yt(ctx, url):

//          author = ctx.message.author
//          voice_channel = author.voice_channel
//          vc = await client.join_voice_channel(voice_channel)

//           player = await vc.create_ytdl_player(url)
//          player.start()
    }
}
