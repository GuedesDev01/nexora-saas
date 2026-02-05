using Nexora.Application.DTOs.Auth;
using Nexora.Application.Interfaces.Auth;

namespace Nexora.Application.Services.Auth;

public class AuthService : IAuthService
{
    public void Register(RegisterRequest request)
    {
        // lógica real vem depois
    }

    public bool Login(LoginRequest request)
    {
        return true;
    }
}
