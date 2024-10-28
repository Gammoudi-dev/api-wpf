using Microsoft.AspNetCore.Mvc;
using projectapitest.Models;

namespace projectapitest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonneController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<PersonneController> _logger;

        public PersonneController(ILogger<PersonneController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPersonne")]
        public IEnumerable<Personne> Get()
        {
            Personne p1 = new Personne("najem", "gammoudi");
            Personne p2 = new Personne("zied", "gammoudi");
            Personne p3 = new Personne("safa", "gammoudi");

            List<Personne> listpers = new List<Personne> { p1, p2, p3 };

            return listpers;
        }

        [HttpGet("{name}")]
        public IEnumerable<Personne> Get(string name)
        {
            Personne p1 = new Personne("najem", "gammoudi");
            Personne p2 = new Personne("zied", "gammoudi");
            Personne p3 = new Personne("safa", "gammoudi");
            Personne p4 = new Personne(name, name);
            List<Personne> listpers = new List<Personne> { p1, p2, p3, p4 };

            return listpers;
        }

    }
}
