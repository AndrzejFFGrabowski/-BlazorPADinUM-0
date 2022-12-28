using BlazorApp3.Data;

namespace BlazorApp3.Interfaces
{
    public interface IPersonService
    {
        List<Person> people { get; set; }
        Task GetPerson();

        Task DeletePerson(int id);
        Task AddPerson(Person person);

        Task EditPerson(Person person);
    }
}
