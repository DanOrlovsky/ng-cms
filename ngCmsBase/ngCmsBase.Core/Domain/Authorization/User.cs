using System;
using System.Collections.Generic;
using System.Text;

namespace ngCmsBase.Core.Domain.Authorization
{
    public class User : BaseEntity<long>
    {
        public string UserName { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
    }
}
