using Microsoft.AspNetCore.Authorization;
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
    public class ProdavnicaController : ControllerBase
    {
        private IProdavnicaService repository;

        public ProdavnicaController(IProdavnicaService _repository)
        {
            repository = _repository;
        }

        [HttpGet]
        public IEnumerable<Prodavnica> Get([FromQuery] ProdavnicaSearchObject search, int test)
        {
            return this.repository.Get(search);
        }

        [Route("GetPaged")]
        [HttpGet]
        public PagedList<Prodavnica> Get([FromQuery] ProdavnicaSearchObject search)
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
        
        public void Add([FromBody] ProdavnicaVModel x)
        {
            this.repository.Add(x);
        }

        [HttpPatch("{id}")]
        public void Update(int id, [FromBody] ProdavnicaVModel x)
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
