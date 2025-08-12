using Serilog;

namespace CoderSquare.Application.ErrorLogs;

public class LogException
{
    public static void LogExceptions(Exception ex)
    {
        LogToFil(ex.Message);

        LogToConsole(ex.Message);

        LogToDebugger(ex.Message);
    }

    private static void LogToDebugger(string exMessage) => Log.Debug(exMessage);

    private static void LogToConsole(string exMessage) => Log.Warning(exMessage);

    private static void LogToFil(string exMessage) => Log.Information(exMessage);
}