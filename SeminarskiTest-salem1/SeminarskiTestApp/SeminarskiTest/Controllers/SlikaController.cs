using Microsoft.AspNetCore.Mvc;
using SeminarskiTest.Models;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class SlikaController : ControllerBase
    {
        private ISlikaService repository;

        public SlikaController(ISlikaService _repository)
        {
            repository = _repository;
        }

        [HttpGet]
        public IEnumerable<Slika> Get()
        {
            return this.repository.Get(null);
        }

        [HttpPost]
        public void Add(SlikaVModel x)
        {
            this.repository.Add(x);
        }
    }
}
