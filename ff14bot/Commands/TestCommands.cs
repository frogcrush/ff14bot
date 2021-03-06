using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;

namespace FF14Bot.Commands
{
    public class TestCommands : BaseCommandModule
    {
        [Command("getemojiid")]
        public async Task GetEmojiId(CommandContext ctx, DiscordEmoji emoji)
        {
            await ctx.RespondAsync(emoji.Name);
        }
    }
}
