﻿using Microsoft.AspNetCore.Mvc;
using SeminarskiTest.Models;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategorijaController : ControllerBase
    {
        private IKategorijaService repository;

        public KategorijaController(IKategorijaService _repository)
        {
            repository = _repository;
        }

        [HttpGet]
        public IEnumerable<Kategorija> Get()
        {
            return this.repository.Get(null);
        }

        [HttpPost]
        public void Add(KategorijaVModel x)
        {
            this.repository.Add(x);
        }

        [HttpPatch("{id}")]
        public void Update(int id, KategorijaVModel x)
        {
            this.repository.Update(id, x);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.repository.Delete(id);
        }
    }
}
