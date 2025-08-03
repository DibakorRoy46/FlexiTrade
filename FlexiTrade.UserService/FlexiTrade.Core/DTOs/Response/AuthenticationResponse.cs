
namespace FlexiTrade.Core.DTOs
{
    public record AuthenticationResponse
    (
       string UserName,
       string Token,
       string Name,
       string Email,
       string PhoneNumber,
       string OTP,
       DateTime OTPExpireDate,
       bool Status,
       string ReturnMessage
    );     
}
