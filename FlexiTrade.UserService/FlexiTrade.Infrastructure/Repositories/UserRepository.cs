

using FlexiTrade.Core.DTOs;
using FlexiTrade.Core.RepositoryContracts;

namespace FlexiTrade.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<AuthenticationResponse> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<AuthenticationResponse> GetUserByEmailPassword(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<AuthenticationResponse> GetUserById(string email)
        {
            throw new NotImplementedException();
        }

        public Task<AuthenticationResponse> GetUserByPhoneNumber(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserPassword(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsEmailVerified(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsPhoneNumberExists(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsPhoneNumberVerified(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsUserActive(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsUserExists(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsUserNameExists(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsUserOTPExpired(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsUserPasswordExpired(string email)
        {
            throw new NotImplementedException();
        }

        public Task<AuthenticationResponse> LoginUser(LoginRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<RegistationResponse> RegisterUser(RegistrationRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
