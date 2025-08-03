using FlexiTrade.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexiTrade.Core.RepositoryContracts
{
    public interface IUserRepository :IDisposable
    {
        Task<bool> IsUserExists(string email);
        Task<bool> IsUserNameExists(string userName);
        Task<bool> IsPhoneNumberExists(string phoneNumber);
        Task<bool> IsEmailVerified(string email);
        Task<bool> IsPhoneNumberVerified(string phoneNumber);
        Task<bool> IsUserActive(string email);
        Task<bool> IsUserOTPExpired(string email);
        Task<bool> IsUserPasswordExpired(string email);
        Task<string> GetUserPassword(string email);
        Task<AuthenticationResponse> GetUserById(string email);
        Task<AuthenticationResponse> GetUserByEmail(string email);
        Task<AuthenticationResponse> GetUserByPhoneNumber(string phoneNumber);
        Task<AuthenticationResponse> GetUserByEmailPassword(string email,string password);
        Task<RegistationResponse> RegisterUser(RegistrationRequest request);
        Task<AuthenticationResponse> LoginUser(LoginRequest request);
    }
}
