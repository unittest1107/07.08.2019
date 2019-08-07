using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace WebClientHTTP
{
    class Program
    {

        static void Main()
        {
            Task t = new Task(DownloadPageAsync);
            t.Start();
            Console.WriteLine("Downloading page...");
            Console.ReadLine();
        }
        public class OnePost
        {
            public int userId { get; set; }
            public int id { get; set; }
            public string title { get; set; }
            public string body { get; set; }
        }
        static async void DownloadPageAsync()
        {
            // ... Target page.
            //string page = "https://jsonplaceholder.typicode.com/posts";
            //string page = "http://www.mocky.io/v2/5d447b6b2f000080291796ce";
            string page = "http://localhost:3000/api/todo";


            // ... Use HttpClient.

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                using (HttpResponseMessage response = await client.GetAsync(page))
                using (HttpContent content = response.Content)
                {
                    // ... Read the string.
                    string result = await content.ReadAsStringAsync();

                    // ... Display the result.
                    if (result != null &&
                        result.Length >= 50)
                    {
                        Console.WriteLine(result);
                        dynamic json = JsonConvert.DeserializeObject(result);
                        Newtonsoft.Json.Linq.JArray jarr = json;
                        OnePost v = jarr[0].ToObject<OnePost>();
                        var va = jarr.ToObject<OnePost[]>();
                    }
                }
            }
        }
    }
}