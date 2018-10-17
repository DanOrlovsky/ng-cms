using ngCmsBase.Core.Data;
using ngCmsBase.Core.Domain.Authorization;
using System;
using System.Collections.Generic;
using System.Text;

namespace ngCmsBase.Service.Authorization
{
    public class UserService
    {
        private readonly IRepository<User, long> _userRepository;


        public UserService(IRepository<User, long> userRepository)
        {
            _userRepository = userRepository;
        }

        public void GetUsers()
        {
            _userRepository.GetAll();
        }
    }
}
