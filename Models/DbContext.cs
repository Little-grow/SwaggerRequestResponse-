namespace Demoo.Models
{
    public class DbContext
    {
        public List<Person> Persons = new List<Person>();

        

        public void Add(Person person)
        {
            Persons.Add(person);
        }
    }
}
