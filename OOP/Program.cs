
//var logic = new CustomerBusinessLogic();
//logic.GetCustomerName(3);
//public interface ICustomerDataAccess
//{
//    string GetCustomerName(int id);
//}

//public class CustomerDataAccess : ICustomerDataAccess
//{
//    public CustomerDataAccess()
//    {
//    }

//    public string GetCustomerName(int id)
//    {
//        return "Dummy Customer Name";
//    }
//}

//public class DataAccessFactory
//{
//    public static ICustomerDataAccess GetCustomerDataAccessObj()
//    {
//        return new CustomerDataAccess();
//    }
//}

//public class CustomerBusinessLogic
//{
//    ICustomerDataAccess _custDataAccess;

//    public CustomerBusinessLogic()
//    {
//        _custDataAccess = DataAccessFactory.GetCustomerDataAccessObj();
//    }

//    public string GetCustomerName(int id)
//    {
//        return _custDataAccess.GetCustomerName(id);
//    }
//}

using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

var botClient = new TelegramBotClient("6903851883:AAHrfft0De0mLAb-K-ghCnJ6dB1WF9e02ow");

using CancellationTokenSource cts = new();

// StartReceiving does not block the caller thread. Receiving is done on the ThreadPool.
ReceiverOptions receiverOptions = new()
{
    AllowedUpdates = Array.Empty<UpdateType>() // receive all update types except ChatMember related updates
};

botClient.StartReceiving(
    updateHandler: HandleUpdateAsync,
    pollingErrorHandler: HandlePollingErrorAsync,
    receiverOptions: receiverOptions,
    cancellationToken: cts.Token
);
Update update = new Update();
var mes = update.Message;
var id = mes.Chat.Id;
var me = await botClient.GetMeAsync();

Console.WriteLine($"Start listening for @{me.Username}");
Console.ReadLine();

// Send cancellation request to stop bot
cts.Cancel();

async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
{
    // Only process Message updates: https://core.telegram.org/bots/api#message
    if (update.Message is not { } message)
        return;
    // Only process text messages
    if (message.Text is not { } messageText)
        return;

    var chatId = message.Chat.Id;

    Console.WriteLine($"Received a '{messageText}' message in chat {chatId}.");

    // Echo received message text
    Message sentMessage = await botClient.SendTextMessageAsync(
        chatId: chatId,
        text: "You said:\n" + messageText,
        cancellationToken: cancellationToken);
}

Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
{
    var ErrorMessage = exception switch
    {
        ApiRequestException apiRequestException
            => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
        _ => exception.ToString()
    };

    Console.WriteLine(ErrorMessage);
    return Task.CompletedTask;
}
