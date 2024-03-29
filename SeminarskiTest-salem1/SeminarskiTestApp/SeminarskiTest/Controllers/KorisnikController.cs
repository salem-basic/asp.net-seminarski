﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SeminarskiTest.Helper;
using SeminarskiTest.Models;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikController : ControllerBase
    {
        private IKorisnikService repository;
        private readonly UserManager<Korisnik> _userManager;
        //private readonly SignInManager<Korisnik> signInManager;
        private readonly ILogger<KorisnikController> _logger;
        private readonly IMapper _mapper;
        private readonly IAuthManager _authManager;

        public KorisnikController(UserManager<Korisnik> userManager, ILogger<KorisnikController> logger, IMapper mapper, IKorisnikService _repository, IAuthManager authManager)
        {
            _userManager = userManager;
            _logger = logger;
            _mapper = mapper;
            repository = _repository;
            _authManager = authManager;
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
                user.NormalizedEmail = user.Email.ToUpper();
                user.NormalizedUserName = user.UserName.ToUpper();

                var result = await _userManager.CreateAsync(user, korisnik.Lozinka);

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                    return BadRequest(ModelState);
                }

                //if (!result.Succeeded)
                //{
                //    var errors = result.Errors.Select(e => e.Description);

                //    return BadRequest(new RegistrationResponseVModel { Errors = errors });
                //}
                List<string> uloga = new List<string>();
                uloga.Add("Korisnik");
                await _userManager.AddToRolesAsync(user,uloga);

                return Accepted();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(Register)}");
                return Problem($"Something went wrong in the {nameof(Register)}", statusCode: 500);
            }
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginKorisnikVModel loginKorisnik)
        {
            _logger.LogInformation($"Login Attempt for {loginKorisnik.Email} ");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                if (!await _authManager.ValidateUser(loginKorisnik))
                {
                    return Unauthorized();
                }

                return Accepted(new TokenRequest { Token = await _authManager.CreateToken(), IsAuthSuccessful = true /*RefreshToken = await _authManager.CreateRefreshToken()*/ });
                }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong in the {nameof(Login)}");
                return Problem($"Something Went Wrong in the {nameof(Login)}", statusCode: 500);
            }
        }


        [HttpGet]
        public IEnumerable<Korisnik> Get()
        {
            return this.repository.Get(null);
        }

        [HttpPost]
        public void Add(KorisnikVModel x)
        {
            this.repository.Add(x);
        }


        [HttpPatch("{id}")]
        public void Update(int id, KorisnikVModel x)
        {
            this.repository.Update(id, x);
        }

        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    this.repository.Delete(id);
        //}

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            this.repository.Delete(id);
        }
    } 
}

