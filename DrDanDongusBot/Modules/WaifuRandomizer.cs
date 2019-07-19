using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DrDanDongusBot.Modules
{
    public class WaifuRandomizer : ModuleBase<SocketCommandContext>
    {
        [Command("waifu")]
        public async Task RandomWaifuAsync()
        {
            Random rand = new Random();
            int n = rand.Next(waifuList.Count);
            Waifu randomWaifu = waifuList[n];
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle(randomWaifu.Name)
                .WithThumbnailUrl(randomWaifu.Image)
                .WithDescription(randomWaifu.WittyRemark)
                .WithColor(Color.Blue);

            await ReplyAsync("", false, builder.Build());
        }


        public static Waifu makotoNiijima = new Waifu
        {
            Name = "Makoto Niijima",
            Image = "https://images-na.ssl-images-amazon.com/images/I/61TBFQyVpiL._SY679_.jpg",
            Anime = "Persona5",
            WittyRemark = "Finsh your homework first!"
        };

        public static Waifu annTakamaki = new Waifu
        {
            Name = "Ann Takamaki",
            Image = "https://images.goodsmile.info/cgm/images/product/20190531/8384/60597/large/232c4d727f681b76397bab55d3632efd.jpg",
            Anime = "Persona4",
            WittyRemark = "Like, omg"
        };

        public static Waifu futabaSakura = new Waifu
        {
            Name = "FutabaSakura",
            Image = "https://images-na.ssl-images-amazon.com/images/I/61ZXoWQ0AXL._SY606_.jpg",
            Anime = "Persona3",
            WittyRemark = "Nerf this!"
        };

        public static List<Waifu> waifuList = new List<Waifu>
        {
            makotoNiijima, annTakamaki, futabaSakura

        };
    }
}
