using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SeminarskiTest.Data;
using SeminarskiTest.Helper;
using SeminarskiTest.Models;
using SeminarskiTest.SearchObject;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrendController : ControllerBase
    {
   
        private  IBrendService _service;

        public BrendController(IBrendService service)
        {
            _service = service;
        }

        [HttpGet]

        public IEnumerable<Brend> Get()
        {
            return _service.Get(null);
        }

        [Route("GetPaged")]
        [HttpGet]
        public PagedList<Brend> Get([FromQuery] BaseSearchObject search)
        {
            var entity = this._service.GetPaged(search);

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

        public void Add([FromBody] BrendVModel x)
        {
            _service.Add(x);
        }

        [HttpPatch("{id}")]
        public void Update(int id, BrendVModel x)
        {
            this._service.Update(id, x);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this._service.Delete(id);
        }
    }
}
