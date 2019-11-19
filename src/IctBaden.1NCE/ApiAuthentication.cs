using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace IctBaden.Api1NCE
{
    public static class ApiAuthentication
    {
        public static string GetToken(string authUrl, string user, string password)
        {
            try
            {
                var usrPwd = $"{user}:{password}";
                var usrPwdBase64 = Convert.ToBase64String(Encoding.ASCII.GetBytes(usrPwd));

                using var client = new WebClient();
                
                client.Headers.Add(HttpRequestHeader.Accept, "application/json");
                client.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                client.Headers.Add(HttpRequestHeader.Authorization, "Basic " + usrPwdBase64);

                client.QueryString = new NameValueCollection
                {
                    { "grant_type", "client_credentials" } 
                };
                
                var json = client.UploadString(authUrl, "");

                var response = JsonConvert.DeserializeObject<JObject>(json);

                var token = response.SelectToken("access_token").Value<string>();

                return token;
            }
            catch (Exception ex)
            {
                Trace.TraceError("ApiAuthentication.GetToken: " + ex.Message);
                return null;
            }
            
            
        }
    }
}