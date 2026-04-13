using System.Media;
using System.Runtime.InteropServices;

namespace CyberSecurityAwarenessBot.Services
{
    public static class AudioPlayer
    {
        public static void PlayGreeting(string filePath)
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.WriteLine("[Audio greeting only supported on Windows]");
                return;
            }

            try
            {
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filePath);

                if (File.Exists(fullPath))
                {
                    SoundPlayer player = new SoundPlayer(fullPath);
                    player.PlaySync();
                }
                else
                {
                    Console.WriteLine("[Audio file not found. Continuing without voice greeting.]");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Could not play audio: {ex.Message}]");
            }
        }
    }
}