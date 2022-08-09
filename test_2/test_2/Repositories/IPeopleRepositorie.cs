using test_2.Models;

namespace test_2.Repositories
{
    public interface IPeopleRepositorie
    {
        List<Person> AllPeoplePets();
        List<Person> GetPeopleSons();
        List<Person> GetPets();
    }
}
