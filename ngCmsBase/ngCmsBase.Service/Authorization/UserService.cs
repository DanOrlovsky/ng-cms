using ngCmsBase.Core.Data;
using ngCmsBase.Core.Domain.Authorization;
using ngCmsBase.Domain.Authorization;
using ngCmsBase.Shared.Authorization.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ngCmsBase.Service.Authorization
{
    public class UserService : IngServiceBase
    {
        private readonly UserManager _userManager;


        public UserService(UserManager userManager)
        {
            _userManager = userManager;
        }


        public async Task<User> LoginUser(UserLoginInput input)
        {
            return await _userManager.LogInUser(input);
        }
    }
}
