using Demoo.Examples;
using Demoo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;

namespace Demoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly DbContext _context;
        
        public PersonController(DbContext context)
        {
            _context = context;
        }


        [HttpGet]
        [SwaggerResponseExample(200, typeof(PersonExamples))]
        public List<Person> Get()
        {
            return _context.Persons.ToList();
        }

        [HttpPost]
        [SwaggerRequestExample(typeof(Person), typeof(PersonExamples))]
        public Person Post([FromBody] Person person)
        {
            _context.Add(person);
            return person;
        }
    }
}
