﻿using SeminarskiTest.Helper;
using SeminarskiTest.Models;
using SeminarskiTest.SearchObject;
using SeminarskiTest.Services.Repository;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Services.Interfaces
{
    public interface IProizvodService : IGenericRepository<Proizvod, ProizvodVModel, ProizvodiSearchObject>
    {
        PagedList<Proizvod> GetPaged(ProizvodiSearchObject search);
    }
}
