using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;



namespace Logic.RandomFact
{
    public static class RandomFactLogic
    {
        public static async Task<string> GetRandomFact()
        {
            string result = String.Empty;
            string uriRequest = String.Format("https://random-facts4.p.rapidapi.com/get");
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage
                              {
                                  Method = HttpMethod.Get,
                                  RequestUri = new Uri(uriRequest),
                                  Headers =
                                      {
                                          { "X-RapidAPI-Key", "ea6dfe63d9msh4d8c4abed3bfa8fp19064bjsna9a4dabf1e5d" },
                                          { "X-RapidAPI-Host", "random-facts4.p.rapidapi.com" },
                                      },
                              };

            using(HttpResponseMessage response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                string body = await response.Content.ReadAsStringAsync();

                Console.WriteLine(body);
                result = JsonSerilaizerFacts(body);
            }

            return result;
        }

        public static string JsonSerilaizerFacts(string i_Json)
        {
            string[] factsParams = i_Json.Split(',');
            StringBuilder finalString = new StringBuilder();

            finalString.Append("Did you know?" + Environment.NewLine);

            foreach(string curString in factsParams)
            { 
                finalString.Append(removeUnesseryChar(curString) + ' ' + Environment.NewLine);
            }

            return finalString.ToString();
        }

        private static string removeUnesseryChar(string io_StringToChange)
        {
            StringBuilder finalString = new StringBuilder();

            foreach(char c in io_StringToChange)
            {
                if(c != '"' && c != ']' && c != '}' && c != '{' && c!= '[')
                    finalString.Append(c);
            }

            return finalString.ToString();
        }
    }
}
