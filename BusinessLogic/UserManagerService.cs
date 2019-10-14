using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Database;
using DTO;
using Microsoft.AspNet.Identity;

namespace BusinessLogic
{
    class UserManagerService : IUserManagerService
    {
        private readonly IApplicationUserManager _applicationManager;
        public UserManagerService()
        {
            _applicationManager = DatabaseFactory.GetUserManager();
        }

        public IIdentityMessageService SmsService { get => _applicationManager.SMSService; set => _applicationManager.SMSService = value; }

        public async Task<IdentityResult> AddLoginAsync(string id, UserLoginInfo login)
        {
            return await _applicationManager.AddUserLoginAsync(id, login);

        }

        public async Task<IdentityResult> AddPasswordAsync(string userId, string newPassword)
        {
            return await _applicationManager.AddUserPasswordAsync(userId, newPassword);
        }

        public async Task<IdentityResult> ChangePasswordAsync(string userId, string oldPassword, string newPassword)
        {
            return await _applicationManager.ChangeUserPasswordAsync(userId, oldPassword, newPassword);
        }

        public async Task<IdentityResult> ChangePhoneNumberAsync(string userId, string phoneNumber, string code)
        {
            return await _applicationManager.ChangeUserPhoneNumberAsync(userId, phoneNumber, code);
        }

        public async Task<IdentityResult> ConfirmEmailAsync(string userId, string code)
        {
            return await _applicationManager.ConfirmUserEmailAsync(userId, code);
        }

        public async Task<IdentityResult> CreateAsync(ApplicationUser user, string password)
        {
            return await _applicationManager.CreateUserAsync(user, password);
        }

        public async Task<IdentityResult> CreateAsync(ApplicationUser user)
        {
            return await _applicationManager.CreateUserAsync(user);
        }

        public ApplicationUser FindById(string userId)
        {
            return _applicationManager.FindByUserID(userId);
        }

        public async Task<ApplicationUser> FindByIdAsync(string id)
        {
            return await _applicationManager.FindByUserIdAsync(id);
        }

        public async Task<ApplicationUser> FindByNameAsync(string email)
        {
            return await _applicationManager.FindByUserNameAsync(email);
        }

        public async Task<string> GenerateChangePhoneNumberTokenAsync(string userId, string number)
        {
            return await _applicationManager.GenerateChangeUserPhoneNumberTokenAsync(userId, number);
        }

        public UserManager<ApplicationUser> GetApplicationUserService()
        {
            return _applicationManager as UserManager<ApplicationUser>;
        }

        public async Task<IList<UserLoginInfo>> GetLoginsAsync(string userId)
        {
            return await _applicationManager.GetUserLoginsAsync(userId);
        }

        public async Task<string> GetPhoneNumberAsync(string userId)
        {
            return await _applicationManager.GetUsePhoneNumberAsync(userId);
        }

        public async Task<bool> GetTwoFactorEnabledAsync(string userId)
        {
            return await _applicationManager.GetManagerTwoFactorEnabledAsync(userId);
        }

        public async Task<IList<string>> GetValidTwoFactorProvidersAsync(string userId)
        {
            return await _applicationManager.GetManagerValidTwoFactorProvidersAsync(userId);
        }

        public async Task<bool> IsEmailConfirmedAsync(string id)
        {
            return await _applicationManager.IsUserEmailConfirmedAsync(id);
        }

        public async Task<IdentityResult> RemoveLoginAsync(string userId, UserLoginInfo userLoginInfo)
        {
            return await _applicationManager.RemoveUserLoginAsync(userId, userLoginInfo);
        }

        public async Task<IdentityResult> ResetPasswordAsync(string id, string code, string password)
        {
            return await _applicationManager.ResetUserPasswordAsync(id, code, password);
        }

        public async Task<IdentityResult> SetPhoneNumberAsync(string userId, string phoneNumber)
        {
            return await _applicationManager.SetUserPhoneNumberAsync(userId, phoneNumber);
        }

        public async Task<IdentityResult> SetTwoFactorEnabledAsync(string userId, bool enabled)
        {
            return await _applicationManager.SetUserTwoFactorEnabledAsync(userId, enabled);
        }

        public async Task<ClaimsIdentity> SignInAsync(ApplicationUser user)
        {
            return await _applicationManager.GenerateApplicationUserIdentityAsync(user);
        }
    }
}
