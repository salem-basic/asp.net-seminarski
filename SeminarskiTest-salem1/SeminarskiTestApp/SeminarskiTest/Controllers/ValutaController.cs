using Microsoft.AspNetCore.Mvc;
using SeminarskiTest.Data;
using SeminarskiTest.Models;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.Services.Repository;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValutaController 
    {
        private  IValutaService _service;

        public ValutaController( IValutaService service)
        {
            _service = service;
        }

        [HttpGet]

        public IEnumerable<Valuta> Get()
        {
            return _service.Get(null);
        }

        [HttpPost]

        public void Add([FromBody] ValutaVModel x)
        {
            _service.Add(x);
        }

    }
}

