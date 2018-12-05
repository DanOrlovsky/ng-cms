using System;
using System.Collections.Generic;
using System.Text;

namespace ngCmsBase.Shared.Authorization.Dto
{
    public class UserLoginInput
    {
        public string UserNameOrEmailAddress { get; set; }

        public string Password { get; set; }
    }
}
