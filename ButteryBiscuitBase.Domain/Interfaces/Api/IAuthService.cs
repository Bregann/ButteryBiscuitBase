using ButteryBiscuitBase.Domain.DTOs.Auth.Requests;
using ButteryBiscuitBase.Domain.DTOs.Auth.Responses;

namespace ButteryBiscuitBase.Domain.Interfaces.Api
{
    public interface IAuthService
    {
        Task RegisterUser(RegisterUserRequest request);
        Task<LoginUserResponse> LoginUser(LoginUserRequest request);
        Task<LoginUserResponse> RefreshToken(string refreshToken);
    }
}
