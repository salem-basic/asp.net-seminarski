using Microsoft.AspNetCore.Mvc;
using SeminarskiTest.Data;
using SeminarskiTest.Models;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DobavljacController : ControllerBase
    {
        
        private  IDobavljacService _service;

        public DobavljacController(IDobavljacService service)
        {
            
            _service = service;
        }

        [HttpGet]

        public IEnumerable<Dobavljac> Get()
        {
            return this._service.Get(null);
        }

        [HttpPost]

        public void Add(DobavljacVModel x)
        {
            this._service.Add(x);
        }


    }
}
