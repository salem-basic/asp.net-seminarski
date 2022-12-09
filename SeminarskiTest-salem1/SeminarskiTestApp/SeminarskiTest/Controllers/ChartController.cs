using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SeminarskiTest.Helper;
using SeminarskiTest.SearchObject;
using SeminarskiTest.Services.Interfaces;

namespace SeminarskiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartController : ControllerBase
    {
        private readonly IHubContext<ChartHub> _hub;
        private readonly TimeManager _timer;
        private readonly IProizvodService _proizvodi;
        private readonly IKorisnikService _korisnik;


        public ChartController(IHubContext<ChartHub> hub, TimeManager timer, IProizvodService proizvodi, IKorisnikService korisnik)
        {
            _hub = hub;
            _timer = timer;
            _korisnik = korisnik;
            _proizvodi = proizvodi;
        }
        [HttpGet]
        public IActionResult Get()
        {

            var list = new List<ChartModel>{
                new ChartModel { Data = new List<int> { _proizvodi.Get(new ProizvodiSearchObject()).Count() }, Label = "Proizvod", BackgroundColor = "#E74C3C" },
                new ChartModel { Data = new List<int> { _korisnik.Get(null).Count() }, Label = "Korisnik", BackgroundColor = "#E5E7E9" },
            };

            _hub.Clients.All.SendAsync("TransferChartData", list);
            return Ok(new { Message = "Request Completed" });
        }
    }
}
