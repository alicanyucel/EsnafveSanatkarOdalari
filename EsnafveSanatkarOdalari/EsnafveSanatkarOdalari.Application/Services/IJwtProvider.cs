using EsnafveSanatkarOdalari.Application.Features.Auth.Login;
using EsnafveSanatkarOdalari.Domain.Entities;

namespace EsnafveSanatkarOdalari.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
