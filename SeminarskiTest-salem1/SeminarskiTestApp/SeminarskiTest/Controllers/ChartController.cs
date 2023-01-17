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
        private readonly IKorisnikService _korisnik;
        private readonly IProdavnicaService _prodavnica;
        private readonly INarudzbaService _narudzba;


        public ChartController(IHubContext<ChartHub> hub, TimeManager timer, IKorisnikService korisnik, IProdavnicaService prodavnica, INarudzbaService narudzba)
        {
            _hub = hub;
            _timer = timer;
            _korisnik = korisnik;
            _prodavnica = prodavnica;
            _narudzba = narudzba;
        }
        [HttpGet]
        public IActionResult Get()
        {

            var list = new List<ChartModel>{
                new ChartModel { Data = new List<int> { _korisnik.Get(null).Count() }, Label = "Korisnik", BackgroundColor = "#E74C3C" },
                new ChartModel { Data = new List<int> { _prodavnica.Get(new ProdavnicaSearchObject()).Count() }, Label = "Prodavnica", BackgroundColor = "#E5E7E9" },
                new ChartModel { Data = new List<int> { _narudzba.GetNarudzba().Count() }, Label = "Prodavnica", BackgroundColor = "#E5E7E9" },
            };

            _hub.Clients.All.SendAsync("TransferChartData", list);
            return Ok(new { Message = "Request Completed" });
        }
    }
}
