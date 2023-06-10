using RestSharp;
using System;

namespace DoughMgmt
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calling Rest API meow ...");

            var client = new RestClient("https://swapi.dev/api/");
            var request = new RestRequest("people/1", Method.Get);
            request.AddHeader("Content-Type", "application/json");
            RestResponse response = client.Execute(request);

            Console.WriteLine("Response Status from API: " + response.StatusCode);
            Console.WriteLine("Response from API: " + response.Content);
        }
    }
}