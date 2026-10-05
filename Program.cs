using Telegram.Bot;
using Telegram.Bot.Types;

var bot = new TelegramBotClient(Environment.GetEnvironmentVariable("BOT_TOKEN"));

bot.StartReceiving(
    async (client, update, ct) =>
    {
        if (update.Message != null)
        {
            await client.SendTextMessageAsync(
                update.Message.Chat.Id,
                "سلام Qw عزیز! ربات C# فعاله."
            );
        }
    },
    (client, exception, ct) =>
    {
        Console.WriteLine(exception);
        return Task.CompletedTask;
    }
);

Console.WriteLine("Bot is running...");
await Task.Delay(-1);
