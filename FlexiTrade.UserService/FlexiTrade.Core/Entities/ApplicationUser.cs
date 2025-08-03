

using System.ComponentModel.DataAnnotations;

namespace FlexiTrade.Core.Entities
{
    public class ApplicationUser
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string LastPassword { get; set; }
        public DateTime LastPasswordCngDate { get; set; }
        public string ProfilePicture { get; set; }
        public DateTime PassExpireDate { get; set; }
        public string OTP { get; set; } 
        public DateTime OTPExpireDate { get; set; }
        public bool IsActive { get; set; }
    }
}
