using Microsoft.AspNetCore.Mvc;
using ngCmsBase.Service.Authorization;
using ngCmsBase.Shared.Authorization.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngCmsBase.Web.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {

        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<UserDto> Login(UserLoginInput input)
        {
            var user = await _userService.LoginUser(input);
            var userDto = new UserDto
            {
                UserName = user.UserName,
                Email = user.Email
            };

            return userDto;
        }
    }
}
