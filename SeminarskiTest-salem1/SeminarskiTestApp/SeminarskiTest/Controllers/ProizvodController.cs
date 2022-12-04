using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SeminarskiTest.Helper;
using SeminarskiTest.Models;
using SeminarskiTest.SearchObject;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProizvodController : ControllerBase
    {
        private IProizvodService repository;

        public ProizvodController(IProizvodService _repository)
        {
            repository = _repository;
        }

        [HttpGet]

        public IEnumerable<Proizvod> Get([FromQuery] ProizvodiSearchObject search, int test)
        {
            return this.repository.Get(search);
        }

        [Route("GetPaged")]
        [HttpGet]

        public PagedList<Proizvod> Get([FromQuery] ProizvodiSearchObject search)
        {
            var entity = this.repository.GetPaged(search);

            var metaData = new
            {
                entity.TotalCount,
                entity.PageSize,
                entity.CurrentPage,
                entity.HasNext,
                entity.HasPrevious
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metaData));

            return entity;
        }

        [HttpPost]

        public void Add([FromBody] ProizvodVModel x)
        {
            this.repository.Add(x);
        }

        [HttpPatch("{id}")]

        public void Update(int id, [FromBody] ProizvodVModel x)
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
