﻿using AutoMapper;
using SeminarskiTest.Data;
using SeminarskiTest.Helper;
using SeminarskiTest.Models;
using SeminarskiTest.SearchObject;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.Services.Repository;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Services
{
    public class KategorijaService : GenericRepository<Kategorija, KategorijaVModel, BaseSearchObject>, IKategorijaService
    {
        private readonly AppDbContext db;

        public KategorijaService(AppDbContext _db, IMapper mapper) : base(mapper, _db)
        {
            db = _db;
        }

        public override PagedList<Kategorija> GetPaged(IQueryable<Kategorija> entity, BaseSearchObject search)
        {
            return PagedList<Kategorija>.ToPagedList(entity, search.PageNumber, search.PageSize);
        }
    }
}
