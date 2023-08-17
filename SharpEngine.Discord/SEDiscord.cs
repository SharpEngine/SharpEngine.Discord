using SharpEngine.Core.Manager;

namespace SharpEngine.Discord;

/// <summary>
/// Static class with extensions and add version functions
/// </summary>
public static class SEDiscord
{
    /// <summary>
    /// Add versions to DebugManager
    /// </summary>
    public static void AddVersions()
    {
        DebugManager.Versions.Add("DiscordRichPresence", "1.2.1.24");
        DebugManager.Versions.Add("SharpEngine.Discord", "1.0.0");
    }
}