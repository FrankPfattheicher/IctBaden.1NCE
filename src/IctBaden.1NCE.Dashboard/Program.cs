using System;
using System.Linq;
using Chromely.CefGlue;
using Chromely.Core;
using Chromely.Core.Host;
using IctBaden.Api1NCE;
using IctBaden.Stonehenge3.Hosting;
using IctBaden.Stonehenge3.Kestrel;
using IctBaden.Stonehenge3.Resources;
using IctBaden.Stonehenge3.Vue;

namespace IctBaden._1NCE.Dashboard
{
    internal static class Program
    {
        internal static string ApiToken;

        private static void Main(string[] args)
        {
            Console.WriteLine("1NCE API Dashboard");

            var usr = Environment.GetEnvironmentVariable("API_1NCE_USER");
            var pwd = Environment.GetEnvironmentVariable("API_1NCE_PASSWORD");
            ApiToken = ApiAuthentication.GetToken(DefaultUrls.Authentication, usr, pwd);
        
            var provider = StonehengeResourceLoader
                .CreateDefaultLoader(new VueResourceProvider());
            var options = new StonehengeHostOptions
            {
                Title = "1NCE Dashboard",
                StartPage = "products",
                ServerPushMode = ServerPushModes.LongPolling,
                PollIntervalMs = 5000
            };
            var host = new KestrelHost(provider, options);
            if (!host.Start("localhost", 32000))
            {
                Console.WriteLine("Failed to start stonehenge server");
            }

            var startUrl = host.BaseUrl;

            var config = ChromelyConfiguration
                .Create()
                .WithLoadingCefBinariesIfNotFound(true)
                .WithSilentCefBinariesLoading(true)
                .WithHostMode(WindowState.Normal)
                .WithHostTitle(options.Title)
                .WithHostIconFile("1NCE.ico")
                .WithAppArgs(args)
                .WithHostBounds(1000, 600)
                .WithDefaultSubprocess()
                .RegisterCustomerUrlScheme("http", "localhost")
                .WithDebuggingMode(true)
                .WithStartUrl(startUrl);

            using var window = ChromelyWindow.Create(config);
            var exitCode = window.Run(args);
            if (exitCode != 0)
            {
                Console.WriteLine("Failed to start chromely frontend: code " + exitCode);
            }
        }
    }
}