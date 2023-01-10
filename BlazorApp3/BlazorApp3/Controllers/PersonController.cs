using BlazorApp3.Data;
using Microsoft.AspNetCore.Mvc;
//using System.Web.Mvc;

namespace BlazorApp3.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        public static List<Person> persons = new List<Person>();
        public PersonController() { }

        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetPerson()
        {
            //var res = await Http.GetJsonAsync<List<Person>>("/data");

            //(HttpMethod.Post, "/api/Customer",< List<Person>>("data.json");
            persons = await Database.ReadTextAsync();
            return Ok(persons);
        }

    }
}
