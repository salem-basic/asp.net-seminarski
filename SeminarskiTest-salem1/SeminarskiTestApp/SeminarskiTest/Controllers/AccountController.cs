using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SeminarskiTest.Data;
using SeminarskiTest.Models;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<Korisnik> _userManager;
        //private readonly SignInManager<Korisnik> signInManager;
        private readonly ILogger<AccountController> _logger;
        private readonly IMapper _mapper;
        private readonly AppDbContext _db;

        public AccountController(AppDbContext db, UserManager<Korisnik> userManager, /*SignInManager<Korisnik> signInManager*/ ILogger<AccountController> logger, IMapper mapper)
        {
            _userManager = userManager;
            //this.signInManager = signInManager;
            _logger = logger;
            _mapper = mapper;
            _db = db;
        }

        [HttpPost]
        [Route("registration")]
        public async Task<IActionResult> Register(KorisnikVModel korisnik)
        {
            _logger.LogInformation($"Registration attempt for {korisnik.Email}) ");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var user = _mapper.Map<Korisnik>(korisnik);
                user.UserName = korisnik.Email;
                var result = await _userManager.CreateAsync(user, korisnik.Lozinka);

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                    return BadRequest(ModelState);
                }
                //await _userManager.AddToRolesAsync(user, korisnik.Roles);
           
                return Accepted();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(Register)}");
                return Problem($"Something went wrong in the {nameof(Register)}", statusCode: 500);
            }
        }
    }
}
