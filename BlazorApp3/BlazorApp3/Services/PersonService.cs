using BlazorApp3.Data;
using System.Net.Http.Json;

namespace BlazorApp3.Services
{
    public class PersonService : IPersonService
    {
        private readonly HttpClient _http;
        public PersonService(HttpClient http)
        {
            _http = http;
        }
        public List<Person> people { get; set; } = new List<Person>();
        private const string uri = "https://localhost:7238/api/Person";
        public async Task GetPerson()
        {
            var result = await _http.GetFromJsonAsync<List<Person>>(uri);
            if (result != null)
                people = result;
        }

        public async Task AddPerson(Person person)
        {
            var result = await _http.PostAsJsonAsync<Person>(uri, person);
        }
        public async Task EditPerson(Person person)
        {
            var result = await _http.PutAsJsonAsync<Person>(uri, person);
        }

        public async Task DeletePerson(int id)
        {
            //UriBuilder builder = new UriBuilder(uri);
            //var query = HttpUtility.ParseQueryString(builder.Query);
            //query["id"] = id.ToString();
            //builder.Query = query.ToString();
            //var result = await _http.DeleteAsync(builder.Uri);
            var result = await _http.DeleteAsync(uri + "/" + id.ToString());
        }
    }
}
