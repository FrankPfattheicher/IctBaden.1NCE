using System;
using System.Linq;
using IctBaden.Api1NCE;

namespace IctBaden._1NCE.Dashboard
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("1NCE API Dashboard");

            var usr = Environment.GetEnvironmentVariable("API_1NCE_USER");
            var pwd = Environment.GetEnvironmentVariable("API_1NCE_PASSWORD");
            var token = ApiAuthentication.GetToken(DefaultUrls.Authentication, usr, pwd);
        
            var sims = new SimsV1(DefaultUrls.Api, token);
            var list = sims.GetSimCards();
            
            foreach (var simCard in list.OrderBy(sc => sc.IMSI))
            {
                Console.WriteLine($"{simCard.IMSI} : {simCard.Label}");
            }
        }
    }
}