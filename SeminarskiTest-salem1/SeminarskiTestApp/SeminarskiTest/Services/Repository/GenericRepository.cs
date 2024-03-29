﻿using AutoMapper;
using SeminarskiTest.Data;

namespace SeminarskiTest.Services.Repository
{
    public class GenericRepository<T, TModel, TSearch> : IGenericRepository<T, TModel, TSearch> where T : class where TModel : class where TSearch : class
    {
        IMapper _mapper;
        AppDbContext _context;

        public GenericRepository(IMapper mapper, AppDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public IEnumerable<T> Get(TSearch search = null)
        {
            var entity = _context.Set<T>().AsQueryable();

            entity = AddInclude(entity);

            return entity.ToList();

        }


        public void Add(TModel x)
        {
            var set = _context.Set<T>();

            var entity = _mapper.Map<T>(x);

            set.Add(entity);
            _context.SaveChanges();
        }



        public void Update(int id, TModel z)
        {
            var set = _context.Set<T>();

            var entity = set.Find(id);

            _mapper.Map(z, entity);

            _context.SaveChanges();
        }


        public void Delete(int id)
        {
            var set = _context.Set<T>();

            var entity = set.Find(id);

            set.Remove(entity);

            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var set = _context.Set<T>();

            var entity = set.Find(id);

            set.Remove(entity);

            _context.SaveChanges();
        }


        virtual public IQueryable<T> AddInclude(IQueryable<T> query)
        {
            return query;
        }

        virtual public IQueryable<T> AddQuery(IQueryable<T> query, TSearch search)
        {
            return query;
        }
    }
}
