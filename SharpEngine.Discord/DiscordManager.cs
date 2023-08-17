using System.Text.Json;
using DiscordRPC;
using DiscordRPC.Logging;
using DiscordRPC.Message;
using SharpEngine.Core.Manager;
using LogLevel = SharpEngine.Core.Utils.LogLevel;

namespace SharpEngine.Discord;

public static class DiscordManager
{
    private static DiscordRpcClient DiscordRpcClient { get; set; } = null!;

    public static void Init(string clientId, RichPresence presence)
    {
        DiscordRpcClient = new DiscordRpcClient(clientId);
        
        DiscordRpcClient.OnReady += OnReady;
        DiscordRpcClient.OnPresenceUpdate += OnPresenceUpdate;

        DiscordRpcClient.Initialize();
        
        DiscordRpcClient.SetPresence(presence);
    }

    private static void OnPresenceUpdate(object sender, PresenceMessage args)
    {
        DebugManager.Log(LogLevel.LogInfo, $"DISCORD: Update Presence : {JsonSerializer.Serialize(args.Presence)}");
    }

    private static void OnReady(object sender, ReadyMessage args)
    {
        DebugManager.Log(LogLevel.LogInfo, $"DISCORD: Ready from user : {args.User.Username}");
    }
    
}