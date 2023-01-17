using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SeminarskiTest.Helper;
using SeminarskiTest.Services.Interfaces;

namespace SeminarskiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Chart3Controller :  ControllerBase
    {
        private readonly IHubContext<ChartHub> _hub;
        private readonly TimeManager _timer;
        private readonly INarudzbaService _narudzba;


        public Chart3Controller(IHubContext<ChartHub> hub, TimeManager timer, INarudzbaService narudzba)
        {
            _hub = hub;
            _timer = timer;
            _narudzba = narudzba;
        }
        [HttpGet]
        public IActionResult Get()
        {

            var list = new List<ChartModel3>{
                new ChartModel3 { Data = new List<int> { _narudzba.GetNarudzba().Count() }, Label = "Narudzbe", BackgroundColor = "#E5E7E9" },
            };

            _hub.Clients.All.SendAsync("TransferChartData", list);
            return Ok(new { Message = "Request Completed" });
        }
    }
}
