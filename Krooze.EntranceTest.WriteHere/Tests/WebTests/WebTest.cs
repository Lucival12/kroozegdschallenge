using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Net.Http;

namespace Krooze.EntranceTest.WriteHere.Tests.WebTests
{
    public class WebTest
    {
        static HttpClient client = new HttpClient();

        public JObject GetAllMovies()
        {
            var response =  client.GetAsync("https://swapi.co/api/films/").Result;
            var movies = JsonConvert.DeserializeObject<JObject>(response.Content.ReadAsStringAsync().Result);

            return movies;
        }

        public string GetDirector()
        {
            var response = client.GetAsync("https://swapi.co/api/films/").Result;
            var movies = JsonConvert.DeserializeObject<JObject>(response.Content.ReadAsStringAsync().Result);
            var aNewHope = movies["results"].Value<JArray>().Select(x => x["director"].Value<string>()).ToArray();

            return aNewHope.GroupBy(s => s).OrderByDescending(s => s.Count()).First().Key;
        }
    }
}
