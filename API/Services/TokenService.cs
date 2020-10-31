using API.Entities;
using API.Interfaces;

namespace API.Services
{
    public class TokenService : ITokenService
    {
        private readonly ITokenService _tokenService;
        public TokenService(ITokenService tokenService)
        {
            _tokenService = tokenService;

        }
        public string CreateToken(AppUser user)
        {
            throw new System.NotImplementedException();
        }
    }
}