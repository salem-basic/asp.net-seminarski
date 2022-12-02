using AutoMapper;
using SeminarskiTest.Data;
using SeminarskiTest.Models;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.Services.Repository;
using SeminarskiTest.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace SeminarskiTest.Services
{
    public class DrzavaService : GenericRepository<Drzava, DrzavaVModel, object>, IDrzavaService
    {
        private readonly AppDbContext db;

        public DrzavaService(AppDbContext _db, IMapper mapper) : base(mapper, _db)
        {
            db = _db;
        }

    }
}
