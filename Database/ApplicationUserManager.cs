using DTO;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    internal class ApplicationUserManager : UserManager<ApplicationUser>, IApplicationUserManager
    {
        public ApplicationUserManager(IUserStore<ApplicationUser> store) : base(store)
        {
        }

        public IIdentityMessageService SMSService { get => SmsService; set => SmsService = value; }

        public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
        {
            var appDbContext = context.Get<DatabaseContext>();
            var appUserManager = new ApplicationUserManager(new UserStore<ApplicationUser>(appDbContext));

            return appUserManager;
        }

        public async Task<IdentityResult> AddUserLoginAsync(string id, UserLoginInfo login)
        {
            return await AddLoginAsync(id, login);
        }

        public async Task<IdentityResult> AddUserPasswordAsync(string userId, string newPassword)
        {
            return await AddUserPasswordAsync(userId, newPassword);
        }

        public async Task<IdentityResult> ChangeUserPasswordAsync(string userId, string oldPassword, string newPassword)
        {
            return await ChangePasswordAsync(userId, oldPassword, newPassword);
        }

        public async Task<IdentityResult> ChangeUserPhoneNumberAsync(string userId, string phoneNumber, string code)
        {
            return await ChangePhoneNumberAsync(userId, phoneNumber, code);
        }

        public async Task<IdentityResult> ConfirmUserEmailAsync(string userId, string code)
        {
            return await ConfirmEmailAsync(userId, code);
        }

        public async Task<IdentityResult> CreateUserAsync(ApplicationUser applicationUser, string password)
        {
           return await CreateAsync(applicationUser, password);
        }

        public async Task<IdentityResult> CreateUserAsync(ApplicationUser applicationUser)
        {
            return await CreateAsync(applicationUser);
        }

        public ApplicationUser FindByUserID(string userId)
        {
            return FindByUserID(userId);
        }

        public async Task<ApplicationUser> FindByUserIdAsync(string id)
        {
            return await FindByIdAsync(id);
        }

        public async Task<ApplicationUser> FindByUserNameAsync(string email)
        {
            return await FindByEmailAsync(email);
        }

        public async Task<ClaimsIdentity> GenerateApplicationUserIdentityAsync(ApplicationUser user)
        {
            var userIdentity = await CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;

        }

        public async Task<string> GenerateChangeUserPhoneNumberTokenAsync(string userId, string number)
        {
            return await GenerateChangePhoneNumberTokenAsync(userId, number);
        }

        public async Task<bool> GetManagerTwoFactorEnabledAsync(string userId)
        {
            return await GetTwoFactorEnabledAsync(userId);
        }

        public async Task<IList<string>> GetManagerValidTwoFactorProvidersAsync(string userId)
        {
            return await GetValidTwoFactorProvidersAsync(userId);
        }

        public async Task<string> GetUsePhoneNumberAsync(string userId)
        {
            return await GetPhoneNumberAsync(userId);
        }

        public async Task<IList<UserLoginInfo>> GetUserLoginsAsync(string userId)
        {
            return await GetLoginsAsync(userId);
        }

        public async Task<bool> IsUserEmailConfirmedAsync(string id)
        {
            return await IsEmailConfirmedAsync(id);
        }

        public async Task<IdentityResult> RemoveUserLoginAsync(string userId, UserLoginInfo userLoginInfo)
        {
            return await RemoveLoginAsync(userId, userLoginInfo);
        }

        public async Task<IdentityResult> ResetUserPasswordAsync(string id, string code, string password)
        {
            return await ResetPasswordAsync(id, code, password);
        }

        public async Task<IdentityResult> SetUserPhoneNumberAsync(string userId, string phoneNumber)
        {
            return await SetPhoneNumberAsync(userId, phoneNumber);
        }

        public async Task<IdentityResult> SetUserTwoFactorEnabledAsync(string userId, bool enabled)
        {
            return await SetUserTwoFactorEnabledAsync(userId, enabled);
        }
    }
}
