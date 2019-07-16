using Discord;
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
        public async Task PingAsync([Remainder]string name = "Christian")
        {
            //EmbedBuilder builder = new EmbedBuilder();
            //builder.AddField("Field1", "test")
            //    .AddField("Field2", "test")
            //    .AddField("Field3", "test");

            //builder.WithTitle("Ping!")
            //    .WithDescription("this is a really nice ping!")
            //    .WithColor(Color.Blue);

            //await ReplyAsync("", false, builder.Build());

            //Context.User;
            //Context.Client;
            //Context.Guild;
            //Contect.Message;
            //Context.Channel;

            //await ReplyAsync($"{Context.Client.CurrentUser.Mention} || {Context.User.Mention} sent {Context.Message.Content} in {Context.Guild.Name}!");

            await ReplyAsync($"{name} is a n00b");

            //[Command("ping"), RequireBotPermission(), RequireOwner, etc]

        }
    }
}
