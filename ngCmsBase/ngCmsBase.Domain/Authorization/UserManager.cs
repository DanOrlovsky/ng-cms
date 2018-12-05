using ngCmsBase.Core.Data;
using ngCmsBase.Core.Domain.Authorization;
using ngCmsBase.Shared.Authorization.Dto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ngCmsBase.Domain.Authorization
{
    public class UserManager : IngManagerBase
    {
        private readonly IRepository<User, long> _userRepository;

        public UserManager(IRepository<User, long> userRepository)
        {
            _userRepository = userRepository;
        }

        private bool CheckPassword(User user, string newPassword)
        {
            byte[] hashBytes = System.Text.Encoding.ASCII.GetBytes(user.Password);
            PasswordHash passwordHash = new PasswordHash(hashBytes);
            return passwordHash.Verify(newPassword);
        }

        private async Task<User> UserNameLogin(UserLoginInput userLoginInfo)
        {
            var user = await _userRepository.GetAll().Where(x => x.UserName == userLoginInfo.UserNameOrEmailAddress).FirstOrDefaultAsync();
            if (CheckPassword(user, userLoginInfo.Password))
            {
                return user;
            }

            throw new InvalidOperationException("Invalid User Credentials");
        }

        private async Task<User> EmailLogin(UserLoginInput userLoginInfo)
        {

            var user = await _userRepository.GetAll().Where(x => x.Email == userLoginInfo.UserNameOrEmailAddress).FirstOrDefaultAsync();
            if (CheckPassword(user, userLoginInfo.Password))
            {
                return user;
            }

            throw new InvalidOperationException("Invalid User Credentials");
        }

        public async Task<User> LogInUser(UserLoginInput userLoginInfo)
        {
            if (userLoginInfo.UserNameOrEmailAddress.Contains("@"))
                return await EmailLogin(userLoginInfo);
            else
                return await UserNameLogin(userLoginInfo);
        }
    }
}
