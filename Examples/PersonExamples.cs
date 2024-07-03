using Demoo.Models;
using Microsoft.VisualBasic;
using Swashbuckle.AspNetCore.Filters;
using System.Linq.Expressions;

namespace Demoo.Examples
{
    public class PersonExamples : IMultipleExamplesProvider<Person>
    {
        public IEnumerable<SwaggerExample<Person>> GetExamples()
        {
            yield return SwaggerExample.Create(
                "WithContact",
                new Person()
                {
                    Name = "Shahd",
                    Contact = "shahd@gmail.com"
                });

            yield return SwaggerExample.Create(
               "WithoutContact",
               new Person()
               {
                   Name = "Nasir",
               });
        }
    }
}
