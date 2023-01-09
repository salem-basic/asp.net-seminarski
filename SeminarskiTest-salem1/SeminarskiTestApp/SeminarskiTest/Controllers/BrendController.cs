using Microsoft.AspNetCore.Mvc;
using SeminarskiTest.Data;
using SeminarskiTest.Models;
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

        [HttpPost]

        public void Add([FromBody] BrendVModel x)
        {
            _service.Add(x);
        }


    }
}
