using SeminarskiTest.Helper;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Services.Interfaces
{
    public interface IAuthManager
    {
        Task<bool> ValidateUser(LoginKorisnikVModel loginKorisnik);
        Task<string> CreateToken();
        Task<string> CreateRefreshToken();
        Task<TokenRequest> VerifyRefreshToken(TokenRequest request);
    }
}
