using AutoMapper;
using SeminarskiTest.Data;
using SeminarskiTest.Models;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.Services.Repository;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Services
{
    public class DobavljacService : GenericRepository<Dobavljac, DobavljacVModel, object>, IDobavljacService
    {
        private readonly AppDbContext _db;
        public DobavljacService(AppDbContext db, IMapper mapper) : base(mapper, db)
        {
            _db = db;
        }
    }
}
