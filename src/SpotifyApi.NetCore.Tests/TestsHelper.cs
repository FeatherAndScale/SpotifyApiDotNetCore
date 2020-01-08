using System.IO;
using Microsoft.Extensions.Configuration;

namespace SpotifyApi.NetCore.Tests 
{
    public static class TestsHelper
    {
        public static IConfiguration GetLocalConfig()
        {
            return new ConfigurationBuilder()
                // Using "..", "..", ".." vs. "..\\..\\.." for system-agnostic path resolution
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..", "..", ".."))
                .AddJsonFile("appsettings.local.json", false)
                .Build();
        }
    }
}