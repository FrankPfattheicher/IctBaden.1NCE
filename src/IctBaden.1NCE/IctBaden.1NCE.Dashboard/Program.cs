using System;
using IctBaden.Api1NCE;

namespace IctBaden._1NCE.Dashboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var usr = Environment.GetEnvironmentVariable("API_1NCE_USER");
            var pwd = Environment.GetEnvironmentVariable("API_1NCE_PASSWORD");
            var token = ApiAuthentication.GetToken(DefaultUrls.Authentication, usr, pwd);
            
        }
    }
}