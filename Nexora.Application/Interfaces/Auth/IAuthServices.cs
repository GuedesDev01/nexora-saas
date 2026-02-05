using Nexora.Application.DTOs.Auth;

namespace Nexora.Application.Interfaces.Auth;

public interface IAuthService
{
    void Register(RegisterRequest request);
    bool Login(LoginRequest request);
}