using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.AspNet.Identity;

namespace Database
{
    public interface IApplicationUserManager
    {
        IIdentityMessageService SMSService { get; set; }

        Task<IdentityResult> CreateUserAsync(ApplicationUser user, string password);
        Task<IdentityResult> CreateUserAsync(ApplicationUser user);

        Task<ClaimsIdentity> GenerateApplicationUserIdentityAsync(ApplicationUser user);
        Task<IdentityResult> ConfirmUserEmailAsync(string userId, string code);
        Task<ApplicationUser> FindByUserNameAsync(string email);
        Task<IdentityResult> AddUserLoginAsync(string id, UserLoginInfo login);
        Task<bool> IsUserEmailConfirmedAsync(string id);
        Task<IdentityResult> ResetUserPasswordAsync(string id, string code, string password);
        Task<IList<string>> GetManagerValidTwoFactorProvidersAsync(string userId);
        Task<IdentityResult> AddUserPasswordAsync(string userId, string newPassword);
        Task<IdentityResult> ChangeUserPasswordAsync(string userId, string oldPassword, string newPassword);
        Task<IdentityResult> ChangeUserPhoneNumberAsync(string userId, string phoneNumber, string code);
        Task<ApplicationUser> FindByUserIdAsync(string id);
        Task<string> GetUsePhoneNumberAsync(string userId);
        Task<bool> GetManagerTwoFactorEnabledAsync(string userId);
        Task<IList<UserLoginInfo>> GetUserLoginsAsync(string userId);
        Task<IdentityResult> RemoveUserLoginAsync(string userId, UserLoginInfo userLoginInfo);
        Task<string> GenerateChangeUserPhoneNumberTokenAsync(string userId, string number);
        Task<IdentityResult> SetUserTwoFactorEnabledAsync(string userId, bool enabled);
        Task<IdentityResult> SetUserPhoneNumberAsync(string userId, string phoneNumber);
        ApplicationUser FindByUserID(string userId);
    }
}
