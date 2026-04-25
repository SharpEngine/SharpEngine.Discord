using DiscordRPC.Logging;
using SharpEngine.Core.Manager;

namespace SharpEngine.Discord;

internal class DiscordLogger : ILogger
{
    public void Trace(string message, params object[] args) { }

    public void Info(string message, params object[] args) { }

    public void Warning(string message, params object[] args) =>
        DebugManager.Log(
            Core.Utils.LogLevel.Warning,
            "DISCORD: " + string.Format(message, args)
        );

    public void Error(string message, params object[] args) =>
        DebugManager.Log(Core.Utils.LogLevel.Error, "DISCORD: " + string.Format(message, args));

    public LogLevel Level { get; set; }
}
