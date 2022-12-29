using System.Text;

namespace MahProgram.Utilities.Logging;

public static class ExceptionLogger
{
    public readonly static string logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Log", "LogFile.txt");

    public static async Task LogAsync(Exception exception)
    {
        IsLogFileExists();
        StringBuilder logText = new StringBuilder();
        logText.AppendLine("\n*********************");
        logText.AppendLine($"Message : {exception.Message}");
        logText.AppendLine($"TypeMember : {exception.TargetSite}");
        logText.AppendLine($"Assembly : {exception.Source}");
        logText.AppendLine($"Stack Trace : {exception.StackTrace}");
        logText.AppendLine($"Time : {DateTime.Now}");
        logText.AppendLine("*********************");
        await File.AppendAllTextAsync(logFilePath, logText.ToString());
    }

    public static void IsLogFileExists()
    {
        if (!File.Exists(logFilePath))
        {
            File.Create(logFilePath);
        }
    }
}
