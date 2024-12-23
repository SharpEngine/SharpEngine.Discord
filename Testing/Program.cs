using DiscordRPC;
using SharpEngine.Core;
using SharpEngine.Core.Manager;
using SharpEngine.Core.Utils;
using SharpEngine.Discord;

namespace Testing;

internal static class Program
{
    private static void Main()
    {
        SEDiscord.AddVersions();

        DiscordManager.Init(
            "734562497092255774",
            new RichPresence { State = "Essaye SharpEngine.Discord" }
        );

        var window = new Window(
            1280,
            920,
            "SE Discord",
            Color.CornflowerBlue,
            null,
            true,
            true,
            true
        );

        window.AddScene(new MyScene());

        window.Run();
    }
}
