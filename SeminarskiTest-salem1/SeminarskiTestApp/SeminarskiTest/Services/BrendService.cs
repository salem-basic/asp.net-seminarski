using AutoMapper;
using SeminarskiTest.Data;
using SeminarskiTest.Models;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.Services.Repository;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Services
{
    public class BrendService : GenericRepository<Brend, BrendVModel, object>, IBrendService
    {
        private readonly AppDbContext _db;
        public BrendService(AppDbContext db, IMapper mapper) : base(mapper, db)
        {
            _db = db;
        }
    }
}
