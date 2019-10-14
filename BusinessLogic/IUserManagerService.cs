using DTO;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IUserManagerService
    {
        IIdentityMessageService SmsService { get; set; }

        Task<IdentityResult> CreateAsync(ApplicationUser user, string password);
        Task<ClaimsIdentity> SignInAsync(ApplicationUser user);
        Task<IdentityResult> ConfirmEmailAsync(string userId, string code);
        Task<ApplicationUser> FindByNameAsync(string email);
        Task<bool> IsEmailConfirmedAsync(string id);
        Task<IdentityResult> ResetPasswordAsync(string id, string code, string password);
        Task<IList<string>> GetValidTwoFactorProvidersAsync(string userId);
        Task<IdentityResult> CreateAsync(ApplicationUser user);
        Task<IdentityResult> AddLoginAsync(string id, UserLoginInfo login);
        UserManager<ApplicationUser> GetApplicationUserService();
        Task<ApplicationUser> FindByIdAsync(string id);
        Task<string> GetPhoneNumberAsync(string userId);
        Task<bool> GetTwoFactorEnabledAsync(string userId);
        Task<IList<UserLoginInfo>> GetLoginsAsync(string userId);
        Task<IdentityResult> RemoveLoginAsync(string userId, UserLoginInfo userLoginInfo);
        Task<string> GenerateChangePhoneNumberTokenAsync(string userId, string number);
        Task<IdentityResult> SetTwoFactorEnabledAsync(string userId, bool enabled);
        Task<IdentityResult> ChangePhoneNumberAsync(string userId, string phoneNumber, string code);
        Task<IdentityResult> SetPhoneNumberAsync(string userId, string phoneNumber);
        Task<IdentityResult> ChangePasswordAsync(string userId, string oldPassword, string newPassword);
        Task<IdentityResult> AddPasswordAsync(string userId, string newPassword);
        ApplicationUser FindById(string userId);
    }
}
