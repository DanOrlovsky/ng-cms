using ngCmsBase.Core.Data;
using ngCmsBase.Core.Domain.Authorization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ngCmsBase.Service.Authorization
{
    public class UserService : IngServiceBase
    {
        private readonly IRepository<User, long> _userRepository;


        public UserService(IRepository<User, long> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ICollection<User>> GetUsers()
        {
            return await _userRepository.GetAllAsync();
        }
    }
}
