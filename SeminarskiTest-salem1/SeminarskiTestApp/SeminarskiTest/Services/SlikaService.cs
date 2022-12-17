using AutoMapper;
using SeminarskiTest.Data;
using SeminarskiTest.Models;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.Services.Repository;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Services
{
    public class SlikaService : GenericRepository<Slika, SlikaVModel, object> , ISlikaService
    {
        private readonly AppDbContext _db;

        public SlikaService(AppDbContext db, IMapper mapper ) : base(mapper,db)
        {
            _db = db;   
        }
    }
}
