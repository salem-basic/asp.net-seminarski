using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeminarskiTest.Data;
using SeminarskiTest.Migrations;
using SeminarskiTest.Models;

namespace SeminarskiTest.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class RecenzijaController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public RecenzijaController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public class RecenzijaVM
        {
            public int id { get; set; }
            public string nazivProizvoda { get; set; }
            public List<Recenzija> recenzije { get; set; }
            public List<Korisnik> korisnici { get; set; }
        }

        [HttpGet("{id}")]
        public ActionResult<RecenzijaVM> GetRecenzije(int id)
        {
            var proizvod = _dbContext.Proizvod.Find(id);

            if (proizvod == null)
                return BadRequest("Proizvod ne postoji!");

            var recenzija = new RecenzijaVM()
            {
                id = proizvod.Id,
                nazivProizvoda = proizvod.NazivProizvoda,
                korisnici = _dbContext.Korisnik.Select(x => new Korisnik()
                {
                    Id = x.Id,
                    Ime = x.Ime,
                    Prezime = x.Prezime,
                    DatumRodjenja = x.DatumRodjenja,
                    Grad = x.Grad,
                    BrojTelefona = x.BrojTelefona,
                    Adresa = x.Adresa,
                    Lozinka = x.Lozinka,
                    Email = x.Email,
                    DrzavaId = x.DrzavaId,
                    SpolId = x.SpolId
                }).ToList(),
                recenzije = _dbContext.Recenzija.Include(x => x.proizvod).Where(x => x.proizvod.Id == proizvod.Id)
                                                .Include(x=> x.korisnik)
                                                .ToList()
            };

            return Ok(recenzija);
        }

        [HttpGet]
        public ActionResult GetKorisnike()
        {
            var korisnik = _dbContext.Korisnik.Select(x => new Korisnik()
            {
                Id = x.Id,
                Ime = x.Ime,
                Prezime = x.Prezime,
                DatumRodjenja = x.DatumRodjenja,
                Grad = x.Grad,
                BrojTelefona = x.BrojTelefona,
                Adresa = x.Adresa,
                Lozinka = x.Lozinka,
                Email = x.Email,
                DrzavaId = x.DrzavaId,
                SpolId = x.SpolId
            }).ToList();

            return Ok(korisnik);
        }

        public class DodajRecenzijuVM
        {
            public string opis { get; set; }
            public int ocjena { get; set; }
            public string? korisnik { get; set; }

        }

        [HttpPost("{id}")]
        public ActionResult Recenziraj(int id, DodajRecenzijuVM x)
        {
            var proizvod = _dbContext.Proizvod.Find(id);

            if (proizvod == null)
                return BadRequest("Proizvod ne postoji!");

            var nova = new Recenzija();
            _dbContext.Add(nova);

            nova.opis = x.opis;
            nova.ocjena = x.ocjena;
            nova.proizvodId = proizvod.Id;
            nova.korisnikId = x.korisnik;

            _dbContext.SaveChanges();

            return Ok(nova);
        }
    }
}
