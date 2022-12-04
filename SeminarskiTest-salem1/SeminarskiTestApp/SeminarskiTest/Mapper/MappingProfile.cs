using AutoMapper;
using SeminarskiTest.Models;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DrzavaVModel, Drzava>();
            CreateMap<KarticaVModel, Kartica>();
            CreateMap<KategorijaVModel, Kategorija>();
            CreateMap<KorisnikVModel, Korisnik>();
            CreateMap<LoginKorisnikVModel, Korisnik>();
            CreateMap<NarudzbaVModel, Narudzba>();
            CreateMap<ProizvodVModel, Proizvod>();
            CreateMap<SpolVModel, Spol>();
            CreateMap<DobavljacVModel, Dobavljac>();
            CreateMap<ValutaVModel, Valuta>();
            CreateMap<BrendVModel, Brend>();
        }
    }
}
