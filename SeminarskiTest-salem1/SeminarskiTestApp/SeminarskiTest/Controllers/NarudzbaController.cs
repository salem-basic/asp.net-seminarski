using Microsoft.AspNetCore.Mvc;
using SeminarskiTest.Models;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NarudzbaController : ControllerBase
    {
        private INaruzdbaService repository;

        public NarudzbaController(INaruzdbaService _repository)
        {
            repository = _repository;
        }

        [HttpGet]
        public IEnumerable<Narudzba> Get()
        {
            return this.repository.Get(null);
        }

        [HttpPost]
        public void Add(NarudzbaVModel x)
        {
            this.repository.Add(x);
        }

        [HttpPatch("{id}")]
        public void Update(int id, NarudzbaVModel x)
        {
            this.repository.Update(id, x);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.repository.Delete(id);
        }
    }
}
