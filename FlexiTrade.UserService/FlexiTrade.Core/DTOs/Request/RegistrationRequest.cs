namespace FlexiTrade.Core.DTOs
{
    public record RegistrationRequest(
        string UserName,
        string Name,
        string Email,
        string PhoneNumber,
        string Password,
        string ConfrimPassword,
        string ProfilePicture
    );
}
// This code defines a record type `RegistrationRequest` in the `FlexiTrade.Core.DTOs` namespace.