using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SeminarskiTest.Helper;
using SeminarskiTest.SearchObject;
using SeminarskiTest.Services.Interfaces;

namespace SeminarskiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Chart2Controller : ControllerBase
    {
        private readonly IHubContext<ChartHub2> _hub;
        private readonly TimerManager2 _timer;
        private readonly IProizvodService _proizvodi;
        private readonly IDostavljacService _dostavljac;


        public Chart2Controller(IHubContext<ChartHub2> hub, TimerManager2 timer, IProizvodService proizvodi,  IDostavljacService dostavljac)
        {
            _hub = hub;
            _timer = timer;
            _proizvodi = proizvodi;
            _dostavljac = dostavljac;
        }
        [HttpGet]
        public IActionResult Get()
        {

            var list = new List<ChartModel2>{
                new ChartModel2 { Data = new List<int> { _proizvodi.Get(new ProizvodiSearchObject()).Count() }, Label = "Proizvod", BackgroundColor = "#E74C3C" },
                new ChartModel2 { Data = new List<int> { _dostavljac.Get(null).Count() }, Label = "Dostavljac", BackgroundColor = "#E5E7E9" },
            };

            _hub.Clients.All.SendAsync("TransferChartData", list);
            return Ok(new { Message = "Request Completed" });
        }
    }
}
