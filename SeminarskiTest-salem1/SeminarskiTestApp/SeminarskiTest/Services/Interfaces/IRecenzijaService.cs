using SeminarskiTest.Controllers;
using SeminarskiTest.Models;
using SeminarskiTest.Services.Repository;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Services.Interfaces
{
    public interface IRecenzijaService : IGenericRepository<Recenzija, RecenzijaVModel, object>
    {

    }
}
